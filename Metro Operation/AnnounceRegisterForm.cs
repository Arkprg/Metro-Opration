using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class AnnounceRegisterForm : BaseForm
    {
        public AnnounceRegisterForm()
        {
            InitializeComponent();
        }

        private void ErrorShow(IWin32Window control, string errorText)
        {
            using (ToolTip errorTip=new ToolTip())
            {
                errorTip.IsBalloon=true;
                errorTip.ToolTipIcon=ToolTipIcon.Error;
                errorTip.ToolTipTitle="خطا";
                errorTip.Show(errorText, control, 3000);
            }
        }

        private void AnnounceRegisterForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Help.ShowHelp(this, AppState.DatabasePath + "\\Help\\help.chm", HelpNavigator.TopicId, "0202");
        }

        private void AnnounceRegisterForm_Load(object sender, EventArgs e)
        {
            try
            {
                HtmlEditControl1.DocumentHTML="<p dir=\"Rtl\" align=\"right\"><font Size=4 face=\"B Nazanin\"></font></p>";

                if (KindCombo.Enabled)
                {
                    LineCombo.Items.Clear();
                    LineCombo.Items.Add("همه موارد");

                    string query="Vis=True";
                    DataRow[] rows=MainForm.PersonTable.Select(query, "Line_Num");
                    foreach (DataRow row in rows)
                    {
                        string lineNum=row["Line_Num"].ToString();
                        if (!LineCombo.Items.Contains(lineNum))
                        {
                            LineCombo.Items.Add(lineNum);
                        }
                    }

                    if (AppState.UserLevel < 2)
                    {
                        LineCombo.SelectedIndex=0;
                    }
                    else
                    {
                        LineCombo.SelectedItem=AppState.UserLnum;
                        LineCombo.Enabled=false;
                    }
                }
                else
                {
                    Panel2.Enabled=false;
                }

                StartCalendar.Today_Click(null, null);
                EndCalendar.LastDayOfMonth_Click(null, null);
            }
            catch (Exception ex)
            {
               MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime startDate=ConvertClass.ShamsiToMiladi(StartCalendar.Text);
                DateTime endDate=ConvertClass.ShamsiToMiladi(EndCalendar.Text);

                if (string.IsNullOrWhiteSpace(TitrBox.Text))
                {
                    ErrorShow(TitrBox, "عنوان اطلاعیه را مشخص کنید");
                    return;
                }

                if (KindCombo.SelectedIndex < 0)
                {
                    ErrorShow(KindCombo, "نوع اطلاعیه را مشخص کنید");
                    return;
                }

                if (Panel2.Enabled)
                {
                    if (LevelCombo.SelectedIndex < 0)
                    {
                        ErrorShow(LevelCombo, "اولویت نمایش اطلاعیه را مشخص کنید");
                        return;
                    }
                    if (LineCombo.SelectedIndex < 0)
                    {
                        ErrorShow(LineCombo, "نام خط را مشخص کنید");
                        return;
                    }
                    if (UnitCombo.SelectedIndex < 0)
                    {
                        ErrorShow(UnitCombo, "واحد سازمانی را مشخص کنید");
                        return;
                    }
                    if (LocalCombo.SelectedIndex < 0)
                    {
                        ErrorShow(LocalCombo, "مبدا را مشخص کنید");
                        return;
                    }
                    if (PostCombo.SelectedIndex < 0)
                    {
                        ErrorShow(PostCombo, "پست سازمانی را مشخص کنید");
                        return;
                    }
                    if (TimeCombo.SelectedIndex < 0)
                    {
                        ErrorShow(TimeCombo, "نوع شیفت را مشخص کنید");
                        return;
                    }
                    if (ShiftCombo.SelectedIndex < 0 && ShiftCombo.Enabled)
                    {
                        ErrorShow(ShiftCombo, "نام شیفت را مشخص کنید");
                        return;
                    }
                    if (startDate < DateTime.Today)
                    {
                        ErrorShow(StartCalendar, "تاریخ نمایش اطلاعیه صحیح نیست");
                        return;
                    }
                    if (endDate < startDate)
                    {
                        ErrorShow(StartCalendar, "مدت نمایش اطلاعیه صحیح نیست");
                        ErrorShow(EndCalendar, "مدت نمایش اطلاعیه صحیح نیست");
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(HtmlEditControl1.DocumentHTML))
                    {
                        ErrorShow(HtmlEditControl1, "متن اطلاعیه صحیح نیست");
                        return;
                    }

                    Enabled=false;

                    using (OleDbConnection conn=new OleDbConnection(AppState.ConnectionString))
                    {
                        conn.Open();
                        string cmdText="INSERT INTO Notifi (Tarikh, EndDate, Kind, Titr, Context, L_Show, U_Reg, T_Reg, Vis, P_Line, P_Staff, P_Loc, P_Post, P_Time, P_Shift) VALUES (@Tarikh, @EndDate, @Kind, @Titr, @Context, @L_Show, @U_Reg, @T_Reg, True, @P_Line, @P_Staff, @P_Loc, @P_Post, @P_Time, @P_Shift)";

                        using (OleDbCommand cmd=new OleDbCommand(cmdText, conn))
                        {
                            cmd.Parameters.AddWithValue("@Tarikh", StartCalendar.Text);
                            cmd.Parameters.AddWithValue("@EndDate", EndCalendar.Text);
                            cmd.Parameters.AddWithValue("@Kind", KindCombo.SelectedItem);
                            cmd.Parameters.AddWithValue("@Titr", TitrBox.Text);
                            cmd.Parameters.AddWithValue("@Context", HtmlEditControl1.DocumentHTML.Replace("table", "table border='1'"));
                            cmd.Parameters.AddWithValue("@L_Show", LevelCombo.SelectedItem);
                            cmd.Parameters.AddWithValue("@U_Reg", AppState.UserName);
                            cmd.Parameters.AddWithValue("@T_Reg", MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss"));
                            cmd.Parameters.AddWithValue("@P_Line", LineCombo.SelectedIndex == 0 ? "همه موارد" : LineCombo.SelectedItem);
                            cmd.Parameters.AddWithValue("@P_Staff", UnitCombo.SelectedIndex == 0 ? "همه موارد" : UnitCombo.SelectedItem);
                            cmd.Parameters.AddWithValue("@P_Loc", LocalCombo.SelectedIndex == 0 ? "همه موارد" : LocalCombo.SelectedItem);
                            cmd.Parameters.AddWithValue("@P_Post", PostCombo.SelectedIndex == 0 ? "همه موارد" : PostCombo.SelectedItem);
                            cmd.Parameters.AddWithValue("@P_Time", TimeCombo.SelectedIndex == 0 ? "همه موارد" : TimeCombo.SelectedItem);
                            cmd.Parameters.AddWithValue("@P_Shift", ShiftCombo.SelectedIndex == 0 ? "همه موارد" : ShiftCombo.SelectedItem);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    TitrBox.Text="";
                    HtmlEditControl1.DocumentHTML="";
                    LevelCombo.SelectedIndex=-1;
                    if (LineCombo.Enabled)
                    {
                        LineCombo.SelectedIndex=-1;
                    }

                    if (UnitCombo.Enabled)
                    {
                        UnitCombo.SelectedIndex=-1;
                    }

                    LocalCombo.SelectedIndex=-1;
                    KindCombo.SelectedIndex=-1;
                    Enabled=true;

                    MessageBoxFa.Show("ثبت با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(HtmlEditControl1.DocumentHTML))
                    {
                        ErrorShow(HtmlEditControl1, "متن اطلاعیه صحیح نیست");
                        return;
                    }

                    Enabled=false;

                    using (OleDbConnection conn=new OleDbConnection(AppState.ConnectionString))
                    {
                        conn.Open();
                        string cmdText="INSERT INTO Notifi (Tarikh, Kind, Titr, Context, U_Reg, T_Reg, Vis) VALUES (@Tarikh, @Kind, @Titr, @Context, @U_Reg, @T_Reg, True)";
                        using (OleDbCommand cmd=new OleDbCommand(cmdText, conn))
                        {
                            cmd.Parameters.AddWithValue("@Tarikh", StartCalendar.Text);
                            cmd.Parameters.AddWithValue("@Kind", KindCombo.SelectedItem);
                            cmd.Parameters.AddWithValue("@Titr", TitrBox.Text);
                            cmd.Parameters.AddWithValue("@Context", HtmlEditControl1.DocumentHTML.Replace("table", "table border='1'"));
                            cmd.Parameters.AddWithValue("@U_Reg", AppState.UserName);
                            cmd.Parameters.AddWithValue("@T_Reg", MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss"));

                            cmd.ExecuteNonQuery();
                        }
                    }

                    Enabled=true;
                    MessageBoxFa.Show("ثبت با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
               MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LocalCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                PostCombo.SelectedIndex=-1;
                PostCombo.Items.Clear();
                PostCombo.Items.Add("همه موارد");

                if (LocalCombo.SelectedIndex >= 0)
                {
                    string query="Vis=True";
                    if (AppState.UserLevel > 1)
                    {
                        query += " AND Line_Num='" + AppState.UserLnum + "'";
                    }

                    if (AppState.UserLevel > 4 || AppState.UserLevel > 14)
                    {
                        query += " AND P_Staff='" + AppState.UserStaff + "'";
                    }

                    if (LocalCombo.SelectedItem.ToString() != "همه موارد")
                    {
                        query += " AND Shift_Loc='" + LocalCombo.SelectedItem + "'";
                    }

                    DataRow[] rows=MainForm.PersonTable.Select(query, "P_Post");
                    foreach (DataRow row in rows)
                    {
                        string post=row["P_Post"].ToString();
                        if (!PostCombo.Items.Contains(post))
                        {
                            PostCombo.Items.Add(post);
                        }
                    }

                    PostCombo.SelectedIndex=0;
                }
            }
            catch (Exception ex)
            {
               MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        private void PostCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TimeCombo.SelectedIndex=-1;
                TimeCombo.Items.Clear();
                TimeCombo.Items.Add("همه موارد");

                if (PostCombo.SelectedIndex >= 0)
                {
                    string query="Vis=True";
                    if (AppState.UserLevel > 1)
                    {
                        query += " AND Line_Num='" + AppState.UserLnum + "'";
                    }

                    if (AppState.UserLevel > 4 || AppState.UserLevel > 14)
                    {
                        query += " AND P_Staff='" + AppState.UserStaff + "'";
                    }

                    if (LocalCombo.SelectedItem.ToString() != "همه موارد")
                    {
                        query += " AND Shift_Loc='" + LocalCombo.SelectedItem + "'";
                    }

                    if (PostCombo.SelectedItem.ToString() != "همه موارد")
                    {
                        query += " AND P_Post='" + PostCombo.SelectedItem + "'";
                    }

                    DataRow[] rows=MainForm.PersonTable.Select(query, "Shift_Time");
                    foreach (DataRow row in rows)
                    {
                        string time=row["Shift_Time"].ToString();
                        if (!TimeCombo.Items.Contains(time))
                        {
                            TimeCombo.Items.Add(time);
                        }
                    }

                    TimeCombo.SelectedIndex=0;
                }
            }
            catch (Exception ex)
            {
               MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        private void ShiftTimeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ShiftCombo.SelectedIndex=-1;
                ShiftCombo.Items.Clear();
                ShiftCombo.Items.Add("همه موارد");

                if (TimeCombo.SelectedIndex >= 0)
                {
                    string query="Vis=True";
                    if (AppState.UserLevel > 1)
                    {
                        query += " AND Line_Num='" + AppState.UserLnum + "'";
                    }

                    if (AppState.UserLevel > 4 || AppState.UserLevel > 14)
                    {
                        query += " AND P_Staff='" + AppState.UserStaff + "'";
                    }

                    if (LocalCombo.SelectedItem.ToString() != "همه موارد")
                    {
                        query += " AND Shift_Loc='" + LocalCombo.SelectedItem + "'";
                    }

                    if (PostCombo.SelectedItem.ToString() != "همه موارد")
                    {
                        query += " AND P_Post='" + PostCombo.SelectedItem + "'";
                    }

                    if (TimeCombo.SelectedItem.ToString() != "همه موارد")
                    {
                        query += " AND Shift_Time='" + TimeCombo.SelectedItem + "'";
                    }

                    DataRow[] rows=MainForm.PersonTable.Select(query, "Shift_name");
                    foreach (DataRow row in rows)
                    {
                        string shift=row["Shift_name"].ToString();
                        if (!ShiftCombo.Items.Contains(shift))
                        {
                            ShiftCombo.Items.Add(shift);
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

        private void LineCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                UnitCombo.SelectedIndex=-1;
                UnitCombo.Items.Clear();
                UnitCombo.Items.Add("همه موارد");

                if (LineCombo.SelectedIndex >= 0)
                {
                    string query="Vis=True";
                    if (AppState.UserLevel > 1)
                    {
                        query += " AND Line_Num='" + AppState.UserLnum + "'";
                    }

                    DataRow[] rows=MainForm.PersonTable.Select(query, "P_Staff");
                    foreach (DataRow row in rows)
                    {
                        string staff=row["P_Staff"].ToString();
                        if (!UnitCombo.Items.Contains(staff))
                        {
                            UnitCombo.Items.Add(staff);
                        }
                    }

                    if (AppState.UserLevel < 3)
                    {
                        UnitCombo.SelectedIndex=0;
                    }
                    else
                    {
                        UnitCombo.SelectedItem=AppState.UserStaff;
                        UnitCombo.Enabled=false;
                    }
                }
            }
            catch (Exception ex)
            {
               MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        private void UnitCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LocalCombo.SelectedIndex=-1;
                LocalCombo.Items.Clear();
                if (AppState.UserLevel < 6)
                {
                    LocalCombo.Items.Add("همه موارد");
                }

                if (UnitCombo.SelectedIndex >= 0)
                {
                    string query="Vis=True";
                    if (AppState.UserLevel > 1)
                    {
                        query += " AND Line_Num='" + AppState.UserLnum + "'";
                    }

                    if (AppState.UserLevel > 4 || AppState.UserLevel > 14)
                    {
                        query += " AND P_Staff='" + AppState.UserStaff + "'";
                    }

                    DataRow[] rows=MainForm.PersonTable.Select(query, "Shift_Loc");
                    foreach (DataRow row in rows)
                    {
                        string loc=row["Shift_Loc"].ToString();
                        if (!LocalCombo.Items.Contains(loc))
                        {
                            LocalCombo.Items.Add(loc);
                        }
                    }

                    if (AppState.UserLevel < 6)
                    {
                        LocalCombo.SelectedIndex=0;
                    }
                    else
                    {
                        LocalCombo.SelectedItem=AppState.UserLocal;
                    }
                }
            }
            catch (Exception ex)
            {
               MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }
    }
}
