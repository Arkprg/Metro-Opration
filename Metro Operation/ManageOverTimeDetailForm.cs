using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Excel=Microsoft.Office.Interop.Excel;

namespace Metro_Operation
{
    public partial class ManageOverTimeDetailForm
    {
        public ManageOverTimeDetailForm()
        {
            InitializeComponent();
        }

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj=null;
            }
            catch (Exception)
            {
            }
            finally
            {

            }
        }

        public void ManageOverTimeDetailForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Help.ShowHelp(this, AppState.DatabasePath + "\\Help\\help.chm", HelpNavigator.TopicId, "070401");
        }

        public void ManageOverTimeDetailForm_Load(object sender, EventArgs e)
        {
            LocalCombo.Items.Clear();
            if (AppState.UserLevel < 6)
            {
                LocalCombo.Items.Add("همه موارد");
            }

            foreach (string Local in MainForm.Locals)
            {
                if (!string.IsNullOrEmpty(Local))
                {
                    LocalCombo.Items.Add(Local);
                }
            }
            if (LocalCombo.Items.Count > 0)
            {
                LocalCombo.SelectedIndex=0;
            }

            KindCombo.Enabled=false;
            KindCombo.SelectedIndex=0;
            StartCalendar.FirstDayOfMonth_Click(null, null);
            EndCalendar.LastDayOfMonth_Click(null, null);
        }

        public void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                TotalGridView.Height--;
                // تبدیل تاریخ شمسی به میلادی (فرض: این تابع رشته شمسـی را به DateTime برمی‌گرداند)
                DateTime startDate=ConvertClass.ShamsiToMiladi(StartCalendar.Text);
                DateTime endDate=ConvertClass.ShamsiToMiladi(EndCalendar.Text);

                // اعتبارسنجی سریع ComboBoxها
                Tuple<ComboBox, string>[] comboValidations=new Tuple<ComboBox, string>[]
                {
                    Tuple.Create(KindCombo, "نوع گزارش را مشخص کنید"),
                    Tuple.Create(LocalCombo, "مبدا را مشخص کنید"),
                    Tuple.Create(ShiftCombo, "شیفت را مشخص کنید"),
                    Tuple.Create(TimeCombo, "نوع شیفت را مشخص کنید")
                };

                foreach (Tuple<ComboBox, string> item in comboValidations)
                {
                    ComboBox combo=item.Item1;
                    string msg=item.Item2;

                    if (combo.SelectedIndex < 0)
                    {
                        ErrorShow(combo, msg);
                        return;
                    }
                }

                // validate dates
                if (startDate < DateTime.Now.AddYears(-5))
                {
                    ErrorShow(StartCalendar, "تاریخ شروع گزارش صحیح نیست");
                    return;
                }
                if (endDate < DateTime.Now.AddYears(-5))
                {
                    ErrorShow(EndCalendar, "تاریخ پایان گزارش صحیح نیست");
                    return;
                }
                if (startDate > endDate)
                {
                    ErrorShow(StartCalendar, "بازه زمانی گزارش صحیح نیست");
                    ErrorShow(EndCalendar, "بازه زمانی گزارش صحیح نیست");
                    return;
                }

                // آماده‌سازی UI
                using (WaitForm wait=new WaitForm())
                {
                    wait.Show();
                    wait.Refresh();
                    Enabled=false;
                    ClearAllGrids();

                    // بازکردن اتصال جدید (ایمن‌تر از استفاده از یک اتصال سراسری باز)
                    using (OleDbConnection connection=new OleDbConnection(AppState.ConnectionString))
                    {
                        connection.Open();

                        // 1) پر کردن جدول Ezafeh برای بازه انتخابی (با پارامتر)
                        DataTable ezDT=new DataTable();
                        using (OleDbCommand cmdEz=new OleDbCommand("SELECT * FROM Ezafeh WHERE Vis=True AND Tarikh BETWEEN ? AND ?", connection))
                        {
                            cmdEz.Parameters.AddWithValue("?", StartCalendar.Text);
                            cmdEz.Parameters.AddWithValue("?", EndCalendar.Text);
                            using (OleDbDataAdapter adapter=new OleDbDataAdapter(cmdEz))
                            {
                                adapter.Fill(ezDT);
                            }
                        }

                        // 2) پر کردن ردیف‌های پایه (TotalGridView و بقیه) طبق KindCombo
                        if (KindCombo.SelectedIndex == 1)
                        {
                            // از دیتابیس بخوان
                            FillGrids_FromDatabase(connection);
                        }
                        else
                        {
                            // از MainForm.PersonTable بخوان (در حافظه)
                            FillGrids_FromPersonTable();
                        }

                        // 3) پردازش و جمع‌آوری زمان‌ها برای هر Grid به کمک تابع عمومی
                        // تعریف gridConfigs به سبک سازگار
                        Tuple<DataGridView, string, bool>[] gridConfigs=new Tuple<DataGridView, string, bool>[]
                        {
                            Tuple.Create(TotalGridView, "Vis=True", false),
                            Tuple.Create(DailyLeavAutoGridView, "E_Kind='جایگزین مرخصی روزانه' AND Vis=True", false),
                            Tuple.Create(DailyLeavManuGridView, "E_Kind='جایگزین مرخصی روزانه' AND Vis=True", false),
                            Tuple.Create(TimeLeaveGridView, "E_Kind='جایگزین مرخصی ساعتی' AND Vis=True", false),
                            Tuple.Create(EzafeAutoGridView, "E_Kind='اضافه کار' AND Vis=True", false),
                            Tuple.Create(HamkariGridView, "E_Kind='همکاری با شیفت' AND Vis=True", false),
                            Tuple.Create(ClassGridView, "E_Kind='کلاس آموزشی' AND Vis=True", false),
                            Tuple.Create(KeshikGridView, "E_Kind='کشیک' AND Vis=True", false),
                            Tuple.Create(TashvighGridView, "E_Kind='تشویقی' AND Vis=True", false),
                            Tuple.Create(FridayGridView, "Vis=True", true)
                        };

                        // اجرای حلقه
                        foreach (Tuple<DataGridView, string, bool> config in gridConfigs)
                        {
                            DataGridView grid=config.Item1;
                            string ezafeFilter=config.Item2;
                            bool onlyFriday=config.Item3;

                            ProcessGridViewTimes(grid, ezDT, ezafeFilter, onlyFriday);
                            if (grid.RowCount > 0) grid.CurrentRow.Selected=false;
                        }

                    } // end using connection

                    // پایان
                    Enabled=true;
                    wait.Close();
                }
                Panel1.Enabled=true;
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید", "خطا در اجرای دستور", MessageBoxIcon.Error);
                // طبق نسخهٔ VB اصلی، فرم را می‌بندیم
                Close();
            }
        }

        /// <summary>
        /// پر کردن ردیف‌های اولیه (Total + همه GridViewها) از دیتابیس (KindCombo == 1)
        /// </summary>
        private void FillGrids_FromDatabase(OleDbConnection connection)
        {
            StringBuilder sb=new StringBuilder();
            sb.Append("SELECT Person.FName, Person.Family, Person.P_Num, Person.Line_Num, Person.Shift_Loc, Person.P_Post, Person.Shift_Time, Person.Shift_name ");
            sb.Append("FROM PUser INNER JOIN Person ON Person.P_Num=PUser.P_Num ");
            sb.Append("WHERE (PUser.Acc_Levl < 9 OR (PUser.Acc_Levl > 10 AND PUser.Acc_Levl < 19))");

            List<object> parameters=new List<object>();

            if (AppState.UserLevel > 1)
            {
                sb.Append(" AND Line_Num=?");
                parameters.Add(AppState.UserLnum);
            }
            if (AppState.UserLevel > 5 || AppState.UserLevel > 15)
            {
                sb.Append(" AND P_Staff=?");
                parameters.Add(AppState.UserStaff);
            }
            if ((string)ShiftCombo.SelectedItem != "همه موارد")
            {
                sb.Append(" AND Person.Shift_name=?");
                parameters.Add(ShiftCombo.SelectedItem);
            }
            if ((string)TimeCombo.SelectedItem != "همه موارد")
            {
                sb.Append(" AND Person.Shift_Time=?");
                parameters.Add(TimeCombo.SelectedItem);
            }
            if ((string)LocalCombo.SelectedItem != "همه موارد")
            {
                sb.Append(" AND Person.Shift_Loc=?");
                parameters.Add(LocalCombo.SelectedItem);
            }
            if ((string)PostCombo.SelectedItem != "همه موارد")
            {
                sb.Append(" AND Person.P_Post=?");
                parameters.Add(PostCombo.SelectedItem);
            }

            sb.Append(" ORDER BY Person.Family, Person.FName");

            using (OleDbCommand cmd=new OleDbCommand(sb.ToString(), connection))
            {
                foreach (object p in parameters)
                {
                    cmd.Parameters.AddWithValue("?", p);
                }

                using (OleDbDataReader reader=cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string fullName=reader["FName"].ToString() + " " + reader["Family"].ToString();
                        string pnum=reader["P_Num"].ToString();
                        string ppost=reader["P_Post"].ToString();
                        string shiftLoc=reader["Shift_Loc"].ToString();
                        string shiftTime=reader["Shift_Time"].ToString();
                        string shiftName=reader["Shift_name"].ToString();

                        AddPersonRowToAllGrids(fullName, pnum, ppost, shiftLoc, shiftTime, shiftName);
                    }
                }
            }
        }

        /// <summary>
        /// پر کردن ردیف‌های اولیه از MainForm.PersonTable (KindCombo == 0)
        /// </summary>
        private void FillGrids_FromPersonTable()
        {
            // ساخت کوئری فیلتر برای DataTable.Select (مثل نسخهٔ VB)
            StringBuilder qsb=new StringBuilder();
            qsb.Append("Vis=True");
            if (AppState.UserLevel > 1)
            {
                qsb.Append(" AND Line_Num='" + AppState.UserLnum + "'");
            }

            if (AppState.UserLevel > 5 || AppState.UserLevel > 15)
            {
                qsb.Append(" AND P_Staff='" + AppState.UserStaff + "'");
            }

            if ((string)LocalCombo.SelectedItem != "همه موارد")
            {
                qsb.Append(" AND Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'");
            }

            if ((string)PostCombo.SelectedItem != "همه موارد")
            {
                qsb.Append(" AND P_Post='" + PostCombo.SelectedItem.ToString() + "'");
            }

            if ((string)ShiftCombo.SelectedItem != "همه موارد")
            {
                qsb.Append(" AND Shift_name='" + ShiftCombo.SelectedItem.ToString() + "'");
            }

            if ((string)TimeCombo.SelectedItem != "همه موارد")
            {
                qsb.Append(" AND Shift_Time='" + TimeCombo.SelectedItem.ToString() + "'");
            }

            DataRow[] rows=MainForm.PersonTable.Select(qsb.ToString(), "Family");
            foreach (DataRow r in rows)
            {
                string fullName=r["FName"].ToString() + " " + r["Family"].ToString();
                string pnum=r["P_Num"].ToString();
                string ppost=r["P_Post"].ToString();
                string shiftLoc=r["Shift_Loc"].ToString();
                string shiftTime=r["Shift_Time"].ToString();
                string shiftName=r["Shift_name"].ToString();

                AddPersonRowToAllGrids(fullName, pnum, ppost, shiftLoc, shiftTime, shiftName);
            }
        }

        /// <summary>
        /// تابع کمکی که یک شخص را به همه‌ی GridViewهای موردنظر اضافه می‌کند
        /// </summary>
        private void AddPersonRowToAllGrids(string fullName, string pnum, string ppost, string shiftLoc, string shiftTime, string shiftName)
        {
            // TotalGridView: columns: idx, name, pnum, timeStr, doubleValue, ppost, shiftLoc, shiftTime, shiftName
            TotalGridView.Rows.Add(0, fullName, pnum, "00:00", 0.0, ppost, shiftLoc, shiftTime, shiftName);

            // دیگر GridViewها: (index, fullName, pnum, "00:00", 0.0)
            object[] baseRow=new object[] { 0, fullName, pnum, "00:00", 0.0 };
            DailyLeavAutoGridView.Rows.Add(baseRow);
            TimeLeaveGridView.Rows.Add((object[])baseRow.Clone());
            HamkariGridView.Rows.Add((object[])baseRow.Clone());
            EzafeAutoGridView.Rows.Add((object[])baseRow.Clone());
            ClassGridView.Rows.Add((object[])baseRow.Clone());
            KeshikGridView.Rows.Add((object[])baseRow.Clone());
            TashvighGridView.Rows.Add((object[])baseRow.Clone());
            FridayGridView.Rows.Add((object[])baseRow.Clone());
            DailyLeavManuGridView.Rows.Add((object[])baseRow.Clone());
        }

        /// <summary>
        /// پردازش عمومی GridViewها: جمع‌زنی زمان‌ها از ezDT و پر کردن سلول‌ها
        /// baseFilter باید فیلتر مربوط به Ezafeh مثل "E_Kind='اضافه کار' AND Vis=True" باشد
        /// </summary>
        private void ProcessGridViewTimes(DataGridView grid, DataTable ezDT, string baseFilter, bool onlyFriday=false)
        {
            double totalSum=0.0;

            // اگر grid خالی است یا فقط سطر جمع را داشت، از کار جلوگیری کن
            if (grid.Rows.Count == 0)
            {
                return;
            }

            for (int i=0; i < grid.Rows.Count;) // -1 چون در انتها ردیف "مجموع" اضافه می‌شود (یا ممکن است اضافه شده باشد)
            {
                // قابل اطمینان‌سازی مقدار سلول جمع
                if (grid.Rows[i].Cells[4].Value == null)
                {
                    grid.Rows[i].Cells[4].Value=0.0;
                }

                double.TryParse(grid.Rows[i].Cells[4].Value.ToString(), out double current);

                // ساخت فیلتر بر اساس KindCombo (P_Num یا U_Reg)
                string filter=baseFilter;
                if (KindCombo.SelectedIndex == 0)
                {
                    filter += $" AND P_Num='{grid.Rows[i].Cells[2].Value}'";
                }
                else
                {
                    filter += $" AND U_Reg='{grid.Rows[i].Cells[1].Value}'";
                }

                DataRow[] matches=ezDT.Select(filter);
                double rowSum=0.0;

                foreach (DataRow dr in matches)
                {
                    if (onlyFriday)
                    {
                        // تبدیل Tarikh (شمای پروژه: Tarikh شمسـی است) — استفاده از ShamsiToMiladi جهت گرفتن DayOfWeek
                        DateTime dtTarikh;
                        try
                        {
                            dtTarikh=ConvertClass.ShamsiToMiladi(dr["Tarikh"].ToString());
                        }
                        catch
                        {
                            continue;
                        }
                        if (dtTarikh.DayOfWeek != DayOfWeek.Friday)
                        {
                            continue;
                        }
                    }

                    // جمع زمان
                    string eTime=dr["E_Time"]?.ToString() ?? "";
                    if (!string.IsNullOrEmpty(eTime))
                    {
                        rowSum += ConvertClass.TimeToDouble(eTime);
                    }
                    else
                    {
                        // اگر خالی باشه هم تلاش کنیم تبدیل کنیم (مطابق رفتار قدیمی)
                        rowSum += ConvertClass.TimeToDouble(eTime);
                    }
                }

                current += rowSum;
                grid.Rows[i].Cells[0].Value=i + 1;
                grid.Rows[i].Cells[4].Value=current;

                if ((int)current == 0 && ZeroRowCheck.Checked)
                {
                    grid.Rows.RemoveAt(i);
                    // i بدون افزایش، چون ردیف‌ها جابجا شدند
                }
                else
                {
                    grid.Rows[i].Cells[3].Value=ConvertClass.DoubleToTime(current);
                    totalSum += current;
                    i++;
                }
            }

            // اضافه کردن ردیف مجموع مانند نسخهٔ اولیه (اگر لازم است)
            // اگر آخرین سطر اکنون مربوط به مجموع نیست، آن را اضافه کن:
            bool hasSummary=false;
            if (grid.Rows.Count > 0)
            {
                DataGridViewRow last=grid.Rows[grid.Rows.Count - 1];
                if (last.Cells[1].Value != null && last.Cells[1].Value.ToString() == "مجموع")
                {
                    hasSummary=true;
                }
            }
            if (!hasSummary)
            {
                // ساخت یک سطر مجموع سازگار با ساختار Grid
                // فرض می‌کنیم ستون‌ها همانند نسخهٔ قدیمی هستند
                object[] values=new object[grid.ColumnCount];
                if (grid.ColumnCount >= 4)
                {
                    values[1]="مجموع";
                    values[3]=ConvertClass.DoubleToTime(totalSum);
                    if (grid.ColumnCount > 4)
                    {
                        values[4]=0.0;
                    }
                }
                grid.Rows.Add(values);
            }
        }


        private void ClearAllGrids()
        {
            DataGridView[] grids=new[]
            {
                DailyLeavAutoGridView, TimeLeaveGridView, HamkariGridView, EzafeAutoGridView, ClassGridView, KeshikGridView, TashvighGridView, FridayGridView, DailyLeavManuGridView, TotalGridView
            };

            foreach (DataGridView grid in grids)
            {
                grid.Rows.Clear();
            }
        }

        public void DailyLeavAutoGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DailyLeavAutoGridView.RowCount > 0 && e.RowIndex >= 0 && ConvertClass.TimeToDouble(DailyLeavAutoGridView.CurrentRow.Cells[3].Value.ToString()) > 0)
            {
                DetailShwoForm ShowForm=new DetailShwoForm();
                ShowForm.TimeLabel.Text=StartCalendar.Text + " تا " + EndCalendar.Text;
                ShowForm.UserLabel.Text="";
                ShowForm.TitrLabel.Text="جایگزین مرخصی روزانه";
                ShowForm.FName=DailyLeavAutoGridView.CurrentRow.Cells[1].Value.ToString();
                ShowForm.Family="";
                ShowForm.Pnum=DailyLeavAutoGridView.CurrentRow.Cells[2].Value.ToString();
                ShowForm.Command="SELECT Tarikh, U_Reg, E_Time, E_Mem FROM Ezafeh WHERE E_Mem NOT LIKE '%(%' AND Vis=True AND E_Kind='جایگزین مرخصی روزانه' AND ";
                if (KindCombo.SelectedIndex == 0)
                {
                    ShowForm.Command += "P_Num='" + DailyLeavAutoGridView.CurrentRow.Cells[2].Value.ToString();
                }
                else
                {
                    ShowForm.Command += "Ezafeh.U_Reg='" + DailyLeavAutoGridView.CurrentRow.Cells[1].Value.ToString();
                }
                ShowForm.Command += "' AND Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Tarikh DESC";
                ShowForm.ShowDialog(this);
                DailyLeavAutoGridView.CurrentRow.Selected=false;
            }
        }

        public void TimeLeaveGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TimeLeaveGridView.RowCount > 0 && e.RowIndex >= 0 && ConvertClass.TimeToDouble(TimeLeaveGridView.CurrentRow.Cells[3].Value.ToString()) > 0)
            {
                DetailShwoForm ShowForm=new DetailShwoForm();
                ShowForm.TimeLabel.Text=StartCalendar.Text + " تا " + EndCalendar.Text;
                ShowForm.TitrLabel.Text="جایگزین مرخصی ساعتی";
                ShowForm.UserLabel.Text="";
                ShowForm.FName=TimeLeaveGridView.CurrentRow.Cells[1].Value.ToString();
                ShowForm.Family="";
                ShowForm.Pnum=TimeLeaveGridView.CurrentRow.Cells[2].Value.ToString();
                ShowForm.Command="SELECT Tarikh, U_Reg, E_Time, E_Mem FROM Ezafeh WHERE Vis=True AND E_Kind='جایگزین مرخصی ساعتی' AND ";
                if (KindCombo.SelectedIndex == 0)
                {
                    ShowForm.Command += "P_Num='" + TimeLeaveGridView.CurrentRow.Cells[2].Value.ToString();
                }
                else
                {
                    ShowForm.Command += "U_Reg='" + TimeLeaveGridView.CurrentRow.Cells[1].Value.ToString();
                }
                ShowForm.Command += "' AND Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Tarikh DESC";
                ShowForm.ShowDialog(this);
                TimeLeaveGridView.CurrentRow.Selected=false;
            }
        }

        public void DataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (HamkariGridView.RowCount > 0 && e.RowIndex >= 0 && ConvertClass.TimeToDouble(HamkariGridView.CurrentRow.Cells[3].Value.ToString()) > 0)
            {
                DetailShwoForm ShowForm=new DetailShwoForm();
                ShowForm.TimeLabel.Text=StartCalendar.Text + " تا " + EndCalendar.Text;
                ShowForm.TitrLabel.Text="همکاری با شیفت";
                ShowForm.UserLabel.Text="";
                ShowForm.FName=HamkariGridView.CurrentRow.Cells[1].Value.ToString();
                ShowForm.Family="";
                ShowForm.Pnum=HamkariGridView.CurrentRow.Cells[2].Value.ToString();
                ShowForm.Command="SELECT Tarikh, U_Reg, E_Time, E_Mem FROM Ezafeh WHERE Vis=True AND E_Kind='همکاری با شیفت' AND ";
                if (KindCombo.SelectedIndex == 0)
                {
                    ShowForm.Command += "P_Num='" + HamkariGridView.CurrentRow.Cells[2].Value.ToString();
                }
                else
                {
                    ShowForm.Command += "U_Reg='" + HamkariGridView.CurrentRow.Cells[1].Value.ToString();
                }
                ShowForm.Command += "' AND Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Tarikh DESC";
                ShowForm.ShowDialog(this);
                HamkariGridView.CurrentRow.Selected=false;
            }
        }

        public void EzafeAutoGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (EzafeAutoGridView.RowCount > 0 && e.RowIndex >= 0 && ConvertClass.TimeToDouble(EzafeAutoGridView.CurrentRow.Cells[3].Value.ToString()) > 0)
            {
                DetailShwoForm ShowForm=new DetailShwoForm();
                ShowForm.TimeLabel.Text=StartCalendar.Text + " تا " + EndCalendar.Text;
                ShowForm.TitrLabel.Text="اضافه کار";
                ShowForm.UserLabel.Text="";
                ShowForm.FName=EzafeAutoGridView.CurrentRow.Cells[1].Value.ToString();
                ShowForm.Family="";
                ShowForm.Pnum=EzafeAutoGridView.CurrentRow.Cells[2].Value.ToString();
                ShowForm.Command="SELECT Tarikh, U_Reg, E_Time, E_Mem FROM Ezafeh WHERE Vis=True AND E_Kind='اضافه کار' AND ";
                if (KindCombo.SelectedIndex == 0)
                {
                    ShowForm.Command += "P_Num='" + EzafeAutoGridView.CurrentRow.Cells[2].Value.ToString();
                }
                else
                {
                    ShowForm.Command += "U_Reg='" + EzafeAutoGridView.CurrentRow.Cells[1].Value.ToString();
                }
                ShowForm.Command += "' AND Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Tarikh DESC";
                ShowForm.ShowDialog(this);
                EzafeAutoGridView.CurrentRow.Selected=false;
            }
        }

        public void ClassGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ClassGridView.RowCount > 0 && e.RowIndex >= 0 && ConvertClass.TimeToDouble(ClassGridView.CurrentRow.Cells[3].Value.ToString()) > 0)
            {
                DetailShwoForm ShowForm=new DetailShwoForm();
                ShowForm.TimeLabel.Text=StartCalendar.Text + " تا " + EndCalendar.Text;
                ShowForm.TitrLabel.Text="کلاس آموزشی";
                ShowForm.UserLabel.Text="";
                ShowForm.FName=ClassGridView.CurrentRow.Cells[1].Value.ToString();
                ShowForm.Family="";
                ShowForm.Pnum=ClassGridView.CurrentRow.Cells[2].Value.ToString();
                ShowForm.Command="SELECT Tarikh, U_Reg, E_Time, E_Mem FROM Ezafeh WHERE Vis=True AND E_Kind='کلاس آموزشی' AND ";
                if (KindCombo.SelectedIndex == 0)
                {
                    ShowForm.Command += "P_Num='" + ClassGridView.CurrentRow.Cells[2].Value.ToString();
                }
                else
                {
                    ShowForm.Command += "U_Reg='" + ClassGridView.CurrentRow.Cells[1].Value.ToString();
                }
                ShowForm.Command += "' AND Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Tarikh DESC";
                ShowForm.ShowDialog(this);
                ClassGridView.CurrentRow.Selected=false;
            }
        }

        public void KeshikGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (KeshikGridView.RowCount > 0 && e.RowIndex >= 0 && ConvertClass.TimeToDouble(KeshikGridView.CurrentRow.Cells[3].Value.ToString()) > 0)
            {
                DetailShwoForm ShowForm=new DetailShwoForm();
                ShowForm.TimeLabel.Text=StartCalendar.Text + " تا " + EndCalendar.Text;
                ShowForm.TitrLabel.Text="کشیک";
                ShowForm.UserLabel.Text="";
                ShowForm.FName=KeshikGridView.CurrentRow.Cells[1].Value.ToString();
                ShowForm.Family="";
                ShowForm.Pnum=KeshikGridView.CurrentRow.Cells[2].Value.ToString();
                ShowForm.Command="SELECT Tarikh, U_Reg, E_Time, E_Mem FROM Ezafeh WHERE Vis=True AND E_Kind='کشیک' AND ";
                if (KindCombo.SelectedIndex == 0)
                {
                    ShowForm.Command += "P_Num='" + KeshikGridView.CurrentRow.Cells[2].Value.ToString();
                }
                else
                {
                    ShowForm.Command += "U_Reg='" + KeshikGridView.CurrentRow.Cells[1].Value.ToString();
                }
                ShowForm.Command += "' AND Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Tarikh DESC";
                ShowForm.ShowDialog(this);
                KeshikGridView.CurrentRow.Selected=false;
            }
        }

        public void TashvighGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TashvighGridView.RowCount > 0 && e.RowIndex >= 0 && ConvertClass.TimeToDouble(TashvighGridView.CurrentRow.Cells[3].Value.ToString()) > 0)
            {
                DetailShwoForm ShowForm=new DetailShwoForm();
                ShowForm.TimeLabel.Text=StartCalendar.Text + " تا " + EndCalendar.Text;
                ShowForm.TitrLabel.Text="تشویقی";
                ShowForm.UserLabel.Text="";
                ShowForm.FName=TashvighGridView.CurrentRow.Cells[1].Value.ToString();
                ShowForm.Family="";
                ShowForm.Pnum=TashvighGridView.CurrentRow.Cells[2].Value.ToString();
                ShowForm.Command="SELECT Tarikh, U_Reg, E_Time, E_Mem FROM Ezafeh WHERE Vis=True AND E_Kind='تشویقی' AND ";
                if (KindCombo.SelectedIndex == 0)
                {
                    ShowForm.Command += "P_Num='" + TashvighGridView.CurrentRow.Cells[2].Value.ToString();
                }
                else
                {
                    ShowForm.Command += "U_Reg='" + TashvighGridView.CurrentRow.Cells[1].Value.ToString();
                }
                ShowForm.Command += "' AND Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Tarikh DESC";
                ShowForm.ShowDialog(this);
                TashvighGridView.CurrentRow.Selected=false;
            }
        }

        public void FridayGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (FridayGridView.RowCount > 0 && e.RowIndex >= 0 && ConvertClass.TimeToDouble(FridayGridView.CurrentRow.Cells[3].Value.ToString()) > 0)
            {
                DetailShwoForm ShowForm=new DetailShwoForm();
                ShowForm.TimeLabel.Text=StartCalendar.Text + " تا " + EndCalendar.Text;
                ShowForm.TitrLabel.Text="اضافه کار جمعه";
                ShowForm.UserLabel.Text="";
                ShowForm.FName=FridayGridView.CurrentRow.Cells[1].Value.ToString();
                ShowForm.Family="";
                ShowForm.Pnum=FridayGridView.CurrentRow.Cells[2].Value.ToString();
                ShowForm.Seprat=" ";
                ShowForm.Command="SELECT Tarikh, U_Reg, E_Time, E_Kind, E_Mem FROM Ezafeh WHERE Vis=True AND ";
                if (KindCombo.SelectedIndex == 0)
                {
                    ShowForm.Command += "P_Num='" + FridayGridView.CurrentRow.Cells[2].Value.ToString();
                }
                else
                {
                    ShowForm.Command += "U_Reg='" + FridayGridView.CurrentRow.Cells[1].Value.ToString();
                }
                ShowForm.Command += "' AND Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Tarikh DESC";
                ShowForm.Week="Friday";
                ShowForm.ShowDialog(this);
                FridayGridView.CurrentRow.Selected=false;
            }
        }

        public void DailyLeavManuGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DailyLeavManuGridView.RowCount > 0 && e.RowIndex >= 0 && ConvertClass.TimeToDouble(DailyLeavManuGridView.CurrentRow.Cells[3].Value.ToString()) > 0)
            {
                DetailShwoForm ShowForm=new DetailShwoForm();
                ShowForm.TimeLabel.Text=StartCalendar.Text + " تا " + EndCalendar.Text;
                ShowForm.TitrLabel.Text="جایگزین مرخصی روزانه";
                ShowForm.UserLabel.Text="";
                ShowForm.FName=DailyLeavManuGridView.CurrentRow.Cells[1].Value.ToString();
                ShowForm.Family="";
                ShowForm.Pnum=DailyLeavManuGridView.CurrentRow.Cells[2].Value.ToString();
                ShowForm.Command="SELECT Tarikh, U_Reg, E_Time, E_Mem FROM Ezafeh WHERE E_Mem LIKE '%(%' AND Vis=True AND E_Kind='جایگزین مرخصی روزانه' AND ";
                if (KindCombo.SelectedIndex == 0)
                {
                    ShowForm.Command += "P_Num='" + DailyLeavManuGridView.CurrentRow.Cells[2].Value.ToString();
                }
                else
                {
                    ShowForm.Command += "U_Reg='" + DailyLeavManuGridView.CurrentRow.Cells[1].Value.ToString();
                }
                ShowForm.Command += "' AND Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Tarikh DESC";
                ShowForm.ShowDialog(this);
                DailyLeavManuGridView.CurrentRow.Selected=false;
            }
        }

        public void TotalGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TotalGridView.RowCount > 0 && e.RowIndex >= 0 && ConvertClass.TimeToDouble(TotalGridView.CurrentRow.Cells[3].Value.ToString()) > 0)
            {
                DetailShwoForm ShowForm=new DetailShwoForm();
                ShowForm.TimeLabel.Text=StartCalendar.Text + " تا " + EndCalendar.Text;
                ShowForm.TitrLabel.Text="مجموع اضافه کار";
                ShowForm.UserLabel.Text="";
                ShowForm.FName=TotalGridView.CurrentRow.Cells[1].Value.ToString();
                ShowForm.Family="";
                ShowForm.Pnum=TotalGridView.CurrentRow.Cells[2].Value.ToString();
                ShowForm.Seprat=" ";
                ShowForm.Command="SELECT Tarikh, U_Reg, E_Time, E_Kind, E_Mem FROM Ezafeh WHERE Vis=True AND ";
                if (KindCombo.SelectedIndex == 0)
                {
                    ShowForm.Command += "P_Num='" + TotalGridView.CurrentRow.Cells[2].Value.ToString();
                }
                else
                {
                    ShowForm.Command += "U_Reg='" + TotalGridView.CurrentRow.Cells[1].Value.ToString();
                }
                ShowForm.Command += "' AND Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Tarikh DESC";
                ShowForm.ShowDialog(this);
                TotalGridView.CurrentRow.Selected=false;
            }
        }

        public void TimeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (TimeCombo.SelectedIndex >= 0)
                {
                    ShiftCombo.Items.Clear();
                    ShiftCombo.Items.Add("همه موارد");
                    string QueStr="Vis=True";
                    if (AppState.UserLevel > 1)
                    {
                        QueStr += " AND Line_Num='" + AppState.UserLnum + "'";
                    }

                    if (AppState.UserLevel > 5 || AppState.UserLevel > 15)
                    {
                        QueStr += " AND P_Staff='" + AppState.UserStaff + "'";
                    }

                    if ((string)LocalCombo.SelectedItem != "همه موارد")
                    {
                        QueStr += " AND Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                    }

                    if ((string)PostCombo.SelectedItem != "همه موارد")
                    {
                        QueStr += " AND P_Post='" + PostCombo.SelectedItem.ToString() + "'";
                    }

                    if ((string)TimeCombo.SelectedItem != "همه موارد")
                    {
                        QueStr += " AND Shift_Time='" + TimeCombo.SelectedItem.ToString() + "'";
                    }

                    DataRow[] DRow=MainForm.PersonTable.Select(QueStr, "Shift_name");
                    foreach (DataRow DtR in DRow)
                    {
                        if (ShiftCombo.Items.IndexOf(DtR["Shift_name"].ToString()) < 0)
                        {
                            ShiftCombo.Items.Add(DtR["Shift_name"].ToString());
                        }
                    }
                    ShiftCombo.SelectedIndex=0;
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void ExportButton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog SaveFileDialog1=new SaveFileDialog()
                {
                    Filter="Excel Files|*.xlsx|Excel Files 97-2003|*.xls"
                };
                if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (WaitForm wait=new WaitForm())
                    {
                        wait.Show();
                        wait.Refresh();
                        Enabled=false;

                        Excel.Application ExcelApp=new Excel.Application();
                        Excel.Worksheet Worksheet1;
                        Excel.Worksheet Worksheet2;
                        Excel.Worksheet Worksheet3;
                        Excel.Worksheet Worksheet4;
                        Excel.Worksheet Worksheet5;
                        Excel.Worksheet Worksheet6;
                        Excel.Worksheet Worksheet7;
                        Excel.Worksheet Worksheet8;
                        Excel.Worksheet Worksheet9;
                        Excel.Worksheet Worksheet10;
                        Excel.Workbook Workbook;
                        System.Globalization.CultureInfo NewCulture;
                        System.Globalization.CultureInfo OldCulture;



                        OldCulture=System.Threading.Thread.CurrentThread.CurrentCulture;
                        NewCulture=new System.Globalization.CultureInfo(ExcelApp.LanguageSettings.get_LanguageID(Microsoft.Office.Core.MsoAppLanguageID.msoLanguageIDUI), true);
                        System.Threading.Thread.CurrentThread.CurrentCulture=NewCulture;

                        object misValue=System.Reflection.Missing.Value;
                        int i;
                        int j=0;

                        Workbook=ExcelApp.Workbooks.Add(misValue);

                        // ************* Worksheet1
                        Worksheet1=Workbook.Sheets["sheet1"];
                        Worksheet1.Name="اضافه کار کل";
                        Worksheet1.PageSetup.PaperSize=Excel.XlPaperSize.xlPaperA4;
                        Worksheet1.DisplayRightToLeft=true;
                        Worksheet1.Cells.Font.Name="Tahoma";
                        Worksheet1.Cells.Font.Size=10;
                        Worksheet1.Rows.RowHeight=18;
                        Worksheet1.Rows.HorizontalAlignment=Excel.XlHAlign.xlHAlignCenter;
                        Worksheet1.Rows.VerticalAlignment=Excel.XlVAlign.xlVAlignCenter;

                        Worksheet1.Cells.NumberFormat="@";
                        Worksheet1.Rows[1].RowHeight=22;

                        for (i=0; i <= TotalGridView.Columns.Count - 1; i++)
                        {
                            Worksheet1.Cells[1, i + 1]=TotalGridView.Columns[i].HeaderText;
                            Worksheet1.Cells[1, i + 1].Font.Bold=true;
                            Worksheet1.Cells[1, i + 1].Interior.Color=ColorTranslator.ToOle(Color.Yellow);
                        }


                        for (i=1; i <= TotalGridView.RowCount; i++)
                        {
                            for (j=0; j <= TotalGridView.ColumnCount - 1; j++)
                            {
                                Worksheet1.Cells[i + 1, j + 1]=TotalGridView[j, i - 1].Value.ToString();
                            }
                        }
                        Worksheet1.Rows[TotalGridView.RowCount + 1].Font.Bold=true;
                        Worksheet1.Rows[TotalGridView.RowCount + 1].Interior.Color=ColorTranslator.ToOle(Color.Yellow);
                        Worksheet1.Columns.EntireColumn.AutoFit();
                        Worksheet1.UsedRange.Borders.LineStyle=Excel.XlLineStyle.xlContinuous;

                        // ************* Worksheet2
                        Worksheet2=Workbook.Sheets.Add(Worksheet1);
                        Worksheet2.Name="جایگزین مرخصی روزانه (خودکار)";
                        Worksheet2.PageSetup.PaperSize=Excel.XlPaperSize.xlPaperA4;
                        Worksheet2.DisplayRightToLeft=true;
                        Worksheet2.Cells.Font.Name="Tahoma";
                        Worksheet2.Cells.Font.Size=10;
                        Worksheet2.Rows.RowHeight=18;
                        Worksheet2.Rows.HorizontalAlignment=Excel.XlHAlign.xlHAlignCenter;
                        Worksheet2.Rows.VerticalAlignment=Excel.XlVAlign.xlVAlignCenter;

                        Worksheet2.Cells.NumberFormat="@";
                        Worksheet2.Rows[1].RowHeight=22;

                        for (i=0; i <= DailyLeavAutoGridView.Columns.Count - 2; i++)
                        {
                            Worksheet2.Cells[1, i + 1]=DailyLeavAutoGridView.Columns[i].HeaderText;
                            Worksheet2.Cells[1, i + 1].Font.Bold=true;
                            Worksheet2.Cells[1, i + 1].Interior.Color=ColorTranslator.ToOle(Color.Yellow);
                        }


                        for (i=1; i <= DailyLeavAutoGridView.RowCount; i++)
                        {
                            for (j=0; j <= DailyLeavAutoGridView.ColumnCount - 2; j++)
                            {
                                Worksheet2.Cells[i + 1, j + 1]=DailyLeavAutoGridView[j, i - 1].Value.ToString();
                            }
                        }
                        Worksheet2.Rows[DailyLeavAutoGridView.RowCount + 1].Font.Bold=true;
                        Worksheet2.Rows[DailyLeavAutoGridView.RowCount + 1].Interior.Color=ColorTranslator.ToOle(Color.Yellow);
                        Worksheet2.Columns.EntireColumn.AutoFit();
                        Worksheet2.UsedRange.Borders.LineStyle=Excel.XlLineStyle.xlContinuous;

                        // ************* Worksheet3
                        Worksheet3=Workbook.Sheets.Add(Worksheet2);
                        Worksheet3.PageSetup.PaperSize=Excel.XlPaperSize.xlPaperA4;
                        Worksheet3.DisplayRightToLeft=true;

                        Worksheet3.Cells.Font.Name="Tahoma";
                        Worksheet3.Cells.Font.Size=10;
                        Worksheet3.Rows.RowHeight=18;
                        Worksheet3.Rows.HorizontalAlignment=Excel.XlHAlign.xlHAlignCenter;
                        Worksheet3.Rows.VerticalAlignment=Excel.XlVAlign.xlVAlignCenter;

                        Worksheet3.Cells.NumberFormat="@";
                        Worksheet3.Rows[1].RowHeight=22;

                        for (i=0; i <= TimeLeaveGridView.Columns.Count - 2; i++)
                        {
                            Worksheet3.Cells[1, i + 1]=TimeLeaveGridView.Columns[i].HeaderText;
                            Worksheet3.Cells[1, i + 1].Font.Bold=true;
                            Worksheet3.Cells[1, i + 1].Interior.Color=ColorTranslator.ToOle(Color.Yellow);
                        }


                        for (i=1; i <= TimeLeaveGridView.RowCount; i++)
                        {
                            for (j=0; j <= TimeLeaveGridView.ColumnCount - 2; j++)
                            {
                                Worksheet3.Cells[i + 1, j + 1]=TimeLeaveGridView[j, i - 1].Value.ToString();
                            }
                        }
                        Worksheet3.Name="جایگزین مرخصی ساعتی";
                        Worksheet3.Rows[TimeLeaveGridView.RowCount + 1].Font.Bold=true;
                        Worksheet3.Rows[TimeLeaveGridView.RowCount + 1].Interior.Color=ColorTranslator.ToOle(Color.Yellow);
                        Worksheet3.Columns.EntireColumn.AutoFit();
                        Worksheet3.UsedRange.Borders.LineStyle=Excel.XlLineStyle.xlContinuous;

                        // ************* Worksheet4
                        Worksheet4=Workbook.Sheets.Add(Worksheet3);
                        Worksheet4.PageSetup.PaperSize=Excel.XlPaperSize.xlPaperA4;
                        Worksheet4.DisplayRightToLeft=true;

                        Worksheet4.Cells.Font.Name="Tahoma";
                        Worksheet4.Cells.Font.Size=10;
                        Worksheet4.Rows.RowHeight=18;
                        Worksheet4.Rows.HorizontalAlignment=Excel.XlHAlign.xlHAlignCenter;
                        Worksheet4.Rows.VerticalAlignment=Excel.XlVAlign.xlVAlignCenter;

                        Worksheet4.Cells.NumberFormat="@";
                        Worksheet4.Rows[1].RowHeight=22;

                        for (i=0; i <= HamkariGridView.Columns.Count - 2; i++)
                        {
                            Worksheet4.Cells[1, i + 1]=HamkariGridView.Columns[i].HeaderText;
                            Worksheet4.Cells[1, i + 1].Font.Bold=true;
                            Worksheet4.Cells[1, i + 1].Interior.Color=ColorTranslator.ToOle(Color.Yellow);
                        }


                        for (i=1; i <= HamkariGridView.RowCount; i++)
                        {
                            for (j=0; j <= HamkariGridView.ColumnCount - 2; j++)
                            {
                                Worksheet4.Cells[i + 1, j + 1]=HamkariGridView[j, i - 1].Value.ToString();
                            }
                        }
                        Worksheet4.Name="همکاری با شیفت";
                        Worksheet4.Rows[HamkariGridView.RowCount + 1].Font.Bold=true;
                        Worksheet4.Rows[HamkariGridView.RowCount + 1].Interior.Color=ColorTranslator.ToOle(Color.Yellow);
                        Worksheet4.Columns.EntireColumn.AutoFit();
                        Worksheet4.UsedRange.Borders.LineStyle=Excel.XlLineStyle.xlContinuous;

                        // ************* Worksheet5
                        Worksheet5=Workbook.Sheets.Add(Worksheet4);
                        Worksheet5.PageSetup.PaperSize=Excel.XlPaperSize.xlPaperA4;
                        Worksheet5.DisplayRightToLeft=true;

                        Worksheet5.Cells.Font.Name="Tahoma";
                        Worksheet5.Cells.Font.Size=10;
                        Worksheet5.Rows.RowHeight=18;
                        Worksheet5.Rows.HorizontalAlignment=Excel.XlHAlign.xlHAlignCenter;
                        Worksheet5.Rows.VerticalAlignment=Excel.XlVAlign.xlVAlignCenter;

                        Worksheet5.Cells.NumberFormat="@";
                        Worksheet5.Rows[1].RowHeight=22;

                        for (i=0; i <= EzafeAutoGridView.Columns.Count - 2; i++)
                        {
                            Worksheet5.Cells[1, i + 1]=EzafeAutoGridView.Columns[i].HeaderText;
                            Worksheet5.Cells[1, i + 1].Font.Bold=true;
                            Worksheet5.Cells[1, i + 1].Interior.Color=ColorTranslator.ToOle(Color.Yellow);
                        }


                        for (i=1; i <= EzafeAutoGridView.RowCount; i++)
                        {
                            for (j=0; j <= EzafeAutoGridView.ColumnCount - 2; j++)
                            {
                                Worksheet5.Cells[i + 1, j + 1]=EzafeAutoGridView[j, i - 1].Value.ToString();
                            }
                        }
                        Worksheet5.Name="اضافه کار(پردازش لوحه)";
                        Worksheet5.Rows[EzafeAutoGridView.RowCount + 1].Font.Bold=true;
                        Worksheet5.Rows[EzafeAutoGridView.RowCount + 1].Interior.Color=ColorTranslator.ToOle(Color.Yellow);
                        Worksheet5.Columns.EntireColumn.AutoFit();
                        Worksheet5.UsedRange.Borders.LineStyle=Excel.XlLineStyle.xlContinuous;


                        // ************* Worksheet6
                        Worksheet6=Workbook.Sheets.Add(Worksheet5);
                        Worksheet6.PageSetup.PaperSize=Excel.XlPaperSize.xlPaperA4;
                        Worksheet6.DisplayRightToLeft=true;

                        Worksheet6.Cells.Font.Name="Tahoma";
                        Worksheet6.Cells.Font.Size=10;
                        Worksheet6.Rows.RowHeight=18;
                        Worksheet6.Rows.HorizontalAlignment=Excel.XlHAlign.xlHAlignCenter;
                        Worksheet6.Rows.VerticalAlignment=Excel.XlVAlign.xlVAlignCenter;

                        Worksheet6.Cells.NumberFormat="@";
                        Worksheet6.Rows[1].RowHeight=22;

                        for (i=0; i <= ClassGridView.Columns.Count - 2; i++)
                        {
                            Worksheet6.Cells[1, i + 1]=ClassGridView.Columns[i].HeaderText;
                            Worksheet6.Cells[1, i + 1].Font.Bold=true;
                            Worksheet6.Cells[1, i + 1].Interior.Color=ColorTranslator.ToOle(Color.Yellow);
                        }


                        for (i=1; i <= ClassGridView.RowCount; i++)
                        {
                            for (j=0; j <= ClassGridView.ColumnCount - 2; j++)
                            {
                                Worksheet6.Cells[i + 1, j + 1]=ClassGridView[j, i - 1].Value.ToString();
                            }
                        }
                        Worksheet6.Name="کلاس بازآموزی";
                        Worksheet6.Rows[ClassGridView.RowCount + 1].Font.Bold=true;
                        Worksheet6.Rows[ClassGridView.RowCount + 1].Interior.Color=ColorTranslator.ToOle(Color.Yellow);
                        Worksheet6.Columns.EntireColumn.AutoFit();
                        Worksheet6.UsedRange.Borders.LineStyle=Excel.XlLineStyle.xlContinuous;


                        // ************* Worksheet7
                        Worksheet7=Workbook.Sheets.Add(Worksheet6);
                        Worksheet7.PageSetup.PaperSize=Excel.XlPaperSize.xlPaperA4;
                        Worksheet7.DisplayRightToLeft=true;

                        Worksheet7.Cells.Font.Name="Tahoma";
                        Worksheet7.Cells.Font.Size=10;
                        Worksheet7.Rows.RowHeight=18;
                        Worksheet7.Rows.HorizontalAlignment=Excel.XlHAlign.xlHAlignCenter;
                        Worksheet7.Rows.VerticalAlignment=Excel.XlVAlign.xlVAlignCenter;

                        Worksheet7.Cells.NumberFormat="@";
                        Worksheet7.Rows[1].RowHeight=22;

                        for (i=0; i <= KeshikGridView.Columns.Count - 2; i++)
                        {
                            Worksheet7.Cells[1, i + 1]=KeshikGridView.Columns[i].HeaderText;
                            Worksheet7.Cells[1, i + 1].Font.Bold=true;
                            Worksheet7.Cells[1, i + 1].Interior.Color=ColorTranslator.ToOle(Color.Yellow);
                        }


                        for (i=1; i <= KeshikGridView.RowCount; i++)
                        {
                            for (j=0; j <= KeshikGridView.ColumnCount - 2; j++)
                            {
                                Worksheet7.Cells[i + 1, j + 1]=KeshikGridView[j, i - 1].Value.ToString();
                            }
                        }
                        Worksheet7.Name="اضافه کشیک";
                        Worksheet7.Rows[KeshikGridView.RowCount + 1].Font.Bold=true;
                        Worksheet7.Rows[KeshikGridView.RowCount + 1].Interior.Color=ColorTranslator.ToOle(Color.Yellow);
                        Worksheet7.Columns.EntireColumn.AutoFit();
                        Worksheet7.UsedRange.Borders.LineStyle=Excel.XlLineStyle.xlContinuous;


                        // ************* Worksheet8
                        Worksheet8=Workbook.Sheets.Add(Worksheet7);
                        Worksheet8.PageSetup.PaperSize=Excel.XlPaperSize.xlPaperA4;
                        Worksheet8.DisplayRightToLeft=true;

                        Worksheet8.Cells.Font.Name="Tahoma";
                        Worksheet8.Cells.Font.Size=10;
                        Worksheet8.Rows.RowHeight=18;
                        Worksheet8.Rows.HorizontalAlignment=Excel.XlHAlign.xlHAlignCenter;
                        Worksheet8.Rows.VerticalAlignment=Excel.XlVAlign.xlVAlignCenter;

                        Worksheet8.Cells.NumberFormat="@";
                        Worksheet8.Rows[1].RowHeight=22;

                        for (i=0; i <= TashvighGridView.Columns.Count - 2; i++)
                        {
                            Worksheet8.Cells[1, i + 1]=TashvighGridView.Columns[i].HeaderText;
                            Worksheet8.Cells[1, i + 1].Font.Bold=true;
                            Worksheet8.Cells[1, i + 1].Interior.Color=ColorTranslator.ToOle(Color.Yellow);
                        }


                        for (i=1; i <= TashvighGridView.RowCount; i++)
                        {
                            for (j=0; j <= TashvighGridView.ColumnCount - 2; j++)
                            {
                                Worksheet8.Cells[i + 1, j + 1]=TashvighGridView[j, i - 1].Value.ToString();
                            }
                        }
                        Worksheet8.Name="اضافه کار تشویقی";
                        Worksheet8.Rows[TashvighGridView.RowCount + 1].Font.Bold=true;
                        Worksheet8.Rows[TashvighGridView.RowCount + 1].Interior.Color=ColorTranslator.ToOle(Color.Yellow);
                        Worksheet8.Columns.EntireColumn.AutoFit();
                        Worksheet8.UsedRange.Borders.LineStyle=Excel.XlLineStyle.xlContinuous;


                        // ************* Worksheet9
                        Worksheet9=Workbook.Sheets.Add(Worksheet8);
                        Worksheet9.PageSetup.PaperSize=Excel.XlPaperSize.xlPaperA4;
                        Worksheet9.DisplayRightToLeft=true;

                        Worksheet9.Cells.Font.Name="Tahoma";
                        Worksheet9.Cells.Font.Size=10;
                        Worksheet9.Rows.RowHeight=18;
                        Worksheet9.Rows.HorizontalAlignment=Excel.XlHAlign.xlHAlignCenter;
                        Worksheet9.Rows.VerticalAlignment=Excel.XlVAlign.xlVAlignCenter;

                        Worksheet9.Cells.NumberFormat="@";
                        Worksheet9.Rows[1].RowHeight=22;

                        for (i=0; i <= FridayGridView.Columns.Count - 2; i++)
                        {
                            Worksheet9.Cells[1, i + 1]=FridayGridView.Columns[i].HeaderText;
                            Worksheet9.Cells[1, i + 1].Font.Bold=true;
                            Worksheet9.Cells[1, i + 1].Interior.Color=ColorTranslator.ToOle(Color.Yellow);
                        }


                        for (i=1; i <= FridayGridView.RowCount; i++)
                        {
                            for (j=0; j <= FridayGridView.ColumnCount - 2; j++)
                            {
                                Worksheet9.Cells[i + 1, j + 1]=FridayGridView[j, i - 1].Value.ToString();
                            }
                        }
                        Worksheet9.Name="اضافه کار جمعه";
                        Worksheet9.Rows[FridayGridView.RowCount + 1].Font.Bold=true;
                        Worksheet9.Rows[FridayGridView.RowCount + 1].Interior.Color=ColorTranslator.ToOle(Color.Yellow);
                        Worksheet9.Columns.EntireColumn.AutoFit();
                        Worksheet9.UsedRange.Borders.LineStyle=Excel.XlLineStyle.xlContinuous;


                        // ************* Worksheet10
                        Worksheet10=Workbook.Sheets.Add(Worksheet9);
                        Worksheet10.PageSetup.PaperSize=Excel.XlPaperSize.xlPaperA4;
                        Worksheet10.DisplayRightToLeft=true;

                        Worksheet10.Cells.Font.Name="Tahoma";
                        Worksheet10.Cells.Font.Size=10;
                        Worksheet10.Rows.RowHeight=18;
                        Worksheet10.Rows.HorizontalAlignment=Excel.XlHAlign.xlHAlignCenter;
                        Worksheet10.Rows.VerticalAlignment=Excel.XlVAlign.xlVAlignCenter;

                        Worksheet10.Cells.NumberFormat="@";
                        Worksheet10.Rows[1].RowHeight=22;

                        for (i=0; i <= DailyLeavManuGridView.Columns.Count - 2; i++)
                        {
                            Worksheet10.Cells[1, i + 1]=DailyLeavManuGridView.Columns[i].HeaderText;
                            Worksheet10.Cells[1, i + 1].Font.Bold=true;
                            Worksheet10.Cells[1, i + 1].Interior.Color=ColorTranslator.ToOle(Color.Yellow);
                        }


                        for (i=1; i <= DailyLeavManuGridView.RowCount; i++)
                        {
                            for (j=0; j <= DailyLeavManuGridView.ColumnCount - 2; j++)
                            {
                                Worksheet10.Cells[i + 1, j + 1]=DailyLeavManuGridView[j, i - 1].Value.ToString();
                            }
                        }
                        Worksheet10.Name="جایگزین مرخصی روزانه (دستی)";
                        Worksheet10.Rows[DailyLeavManuGridView.RowCount + 1].Font.Bold=true;
                        Worksheet10.Rows[DailyLeavManuGridView.RowCount + 1].Interior.Color=ColorTranslator.ToOle(Color.Yellow);
                        Worksheet10.Columns.EntireColumn.AutoFit();
                        Worksheet10.UsedRange.Borders.LineStyle=Excel.XlLineStyle.xlContinuous;


                        //     Workbook.Sheets("Sheet2").Delete
                        //     Workbook.Sheets("Sheet3").Delete
                        Worksheet1.SaveAs(SaveFileDialog1.FileName);
                        Worksheet2.SaveAs(SaveFileDialog1.FileName);
                        Worksheet3.SaveAs(SaveFileDialog1.FileName);
                        Worksheet4.SaveAs(SaveFileDialog1.FileName);
                        Worksheet5.SaveAs(SaveFileDialog1.FileName);
                        Worksheet6.SaveAs(SaveFileDialog1.FileName);
                        Worksheet7.SaveAs(SaveFileDialog1.FileName);
                        Worksheet8.SaveAs(SaveFileDialog1.FileName);
                        Worksheet9.SaveAs(SaveFileDialog1.FileName);
                        Worksheet10.SaveAs(SaveFileDialog1.FileName);
                        Workbook.Close();
                        ExcelApp.Quit();

                        ReleaseObject(ExcelApp);
                        ReleaseObject(Workbook);
                        ReleaseObject(Worksheet1);
                        System.Threading.Thread.CurrentThread.CurrentCulture=OldCulture;

                        Enabled=true;
                        wait.Close();
                    }
                    MessageBoxFa.Show("ذخیره با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Enabled=true;
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
            }
        }

        public void LocalCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LocalCombo.SelectedIndex >= 0)
            {
                PostCombo.Items.Clear();
                PostCombo.Items.Add("همه موارد");

                string QueStr="Vis=True";
                if (AppState.UserLevel > 1)
                {
                    QueStr += " AND Line_Num='" + AppState.UserLnum + "'";
                }

                if (AppState.UserLevel > 5 || AppState.UserLevel > 15)
                {
                    QueStr += " AND P_Staff='" + AppState.UserStaff + "'";
                }

                if ((string)LocalCombo.SelectedItem != "همه موارد")
                {
                    QueStr += " AND Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                }

                DataRow[] DRow=MainForm.PersonTable.Select(QueStr, "P_Post");
                foreach (DataRow DtR in DRow)
                {
                    if (PostCombo.Items.IndexOf(DtR["P_Post"].ToString()) < 0)
                    {
                        PostCombo.Items.Add(DtR["P_Post"].ToString());
                    }
                }
                PostCombo.SelectedIndex=0;
            }
        }

        public void PostCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LocalCombo.SelectedIndex >= 0)
            {
                TimeCombo.Items.Clear();
                TimeCombo.Items.Add("همه موارد");

                string QueStr="Vis=True";
                if (AppState.UserLevel > 1)
                {
                    QueStr += " AND Line_Num='" + AppState.UserLnum + "'";
                }

                if (AppState.UserLevel > 5 || AppState.UserLevel > 15)
                {
                    QueStr += " AND P_Staff='" + AppState.UserStaff + "'";
                }

                if ((string)LocalCombo.SelectedItem != "همه موارد")
                {
                    QueStr += " AND Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                }

                if ((string)PostCombo.SelectedItem != "همه موارد")
                {
                    QueStr += " AND P_Post='" + PostCombo.SelectedItem.ToString() + "'";
                }

                DataRow[] DRow=MainForm.PersonTable.Select(QueStr, "Shift_Time");
                foreach (DataRow DtR in DRow)
                {
                    if (TimeCombo.Items.IndexOf(DtR["Shift_Time"].ToString()) < 0)
                    {
                        TimeCombo.Items.Add(DtR["Shift_Time"].ToString());
                    }
                }
                TimeCombo.SelectedIndex=0;
            }
        }

        public void ShiftCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DailyLeavAutoGridView.Rows.Clear();
            TimeLeaveGridView.Rows.Clear();
            HamkariGridView.Rows.Clear();
            EzafeAutoGridView.Rows.Clear();
            ClassGridView.Rows.Clear();
            KeshikGridView.Rows.Clear();
            TashvighGridView.Rows.Clear();
            FridayGridView.Rows.Clear();
            DailyLeavManuGridView.Rows.Clear();
            TotalGridView.Rows.Clear();
        }

        public void StartCalendar_TextChanged(object sender, EventArgs e)
        {
            DailyLeavAutoGridView.Rows.Clear();
            TimeLeaveGridView.Rows.Clear();
            HamkariGridView.Rows.Clear();
            EzafeAutoGridView.Rows.Clear();
            ClassGridView.Rows.Clear();
            KeshikGridView.Rows.Clear();
            TashvighGridView.Rows.Clear();
            FridayGridView.Rows.Clear();
            DailyLeavManuGridView.Rows.Clear();
            TotalGridView.Rows.Clear();
        }
    }
}
