using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class MainForm : BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        public static string Path = "";
        public static int TrlTime;
        public static string ErrorLogo;
        public static int ExamNum;
        public static DataTable PersonTable = new DataTable(); //
        public static bool PrimLoh = false;
        public static string[] Locals = new string[7];
        public static readonly Taghvim PersianToday = new Taghvim();
        public static bool ShClose = false;

        // private readonly DataTable TripTable=new DataTable();
        private int PesronHis;
        private int DetalHis;
        private int SizeHis;
        private int PermHis;
        private bool Odd = true, PrimeWarned = false;
        private readonly DatabaseHelper _dbHelper = new DatabaseHelper(AppState.ConnectionString);

        // نقشهٔ دسترسی برای تمام منوها
        private readonly Dictionary<string, bool> AccessMap = new Dictionary<string, bool>();

        public static ToolTip ErrorTip = new ToolTip()
        {
            IsBalloon = true,
            ToolTipIcon = ToolTipIcon.Error,
            ToolTipTitle = "خطا"
        };
        public void Tables()
        {
            try
            {
                AppState.Exam = false;
                AppState.Test = false;
                AppState.AnsShould = false;
                AppState.Election = false;
                //KarTablePicture.Visible=false;
                //KarTableBox.Enabled=false;
                //KarTablePicture.Enabled=false;
                //MainTable.Rows.Clear();
                using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    // بررسی آزمون‌های فعال
                    DataTable activeExams = _dbHelper.GetDataTable("SELECT * FROM Exam WHERE Tarikh<=? AND EndDate>=? AND Vis=True AND (P_Line='همه موارد' OR P_Line=?) AND (P_Local='همه موارد' OR P_Local=?) AND (P_Post='همه موارد' OR P_Post=?) AND (P_Time='همه موارد' OR P_Time=?) AND (P_Shift='همه موارد' OR P_Shift=?) ORDER BY L_Show DESC, Tarikh", new[]
                    {PersianToday.Tarikh(),
                        PersianToday.Tarikh(),
                        AppState.UserLnum,
                        AppState.UserLocal,
                        AppState.UserPost,
                        AppState.UserTime,
                        AppState.UserShift
                    });

                    foreach (DataRow _exam in activeExams.Rows)
                    {
                        // بررسی نتایج آزمون برای کاربر فعلی
                        DataTable examResults = _dbHelper.GetDataTable(
                            "SELECT * FROM ExamResult WHERE P_Num=? AND ExamID=? AND Vis=True", new[]
                            {AppState.UserPnum, _exam["ID"]});

                        if (examResults.Rows.Count == 0)
                        {
                            ExamNum = Convert.ToInt32(_exam["ID"]);
                            if (_exam["L_Show"].ToString() == "اجباری")
                            {
                                AppState.AnsShould = true;
                            }

                            if (_exam["Kind"].ToString() == "نظر سنجی")
                            {
                                AppState.Exam = true;
                            }
                            else
                            {
                                AppState.Test = true;
                            }
                        }
                    }

                    //// آزمون‌ها
                    //DataTable examDt=_dbHelper.GetDataTable("SELECT * FROM Exam WHERE Tarikh=? AND E_Line=? AND E_Local=? AND E_Time=? AND E_Shift=?", new[]
                    //            {PersianToday.Tarikh(), AppState.UserLnum, AppState.UserLocal, AppState.UserTime, AppState.UserShift});

                    //if (examDt.Rows.Count > 0)
                    //    foreach (DataRow row in examDt.Rows)
                    //        MessageBoxFa.Show("امروز آزمون " + row["E_Name"].ToString() + " برگزار می‌شود", "آزمون", MessageBoxIcon.Information);


                    // انتخابات
                    //DataTable electionDt=_dbHelper.GetDataTable("SELECT * FROM Election WHERE El_Date=? AND El_Line=? AND El_Local=? AND El_Time=? AND El_Shift=?", new[]
                    //    {PersianToday.Tarikh(), AppState.UserLnum, AppState.UserLocal, AppState.UserTime, AppState.UserShift});

                    //if (electionDt.Rows.Count > 0)
                    //    foreach (DataRow row in electionDt.Rows)
                    //        MessageBoxFa.Show("امروز انتخابات " + row["El_Name"].ToString() + " برگزار می‌شود", "انتخابات", MessageBoxIcon.Information);


                    //// آمار روزانه
                    //DataTable dailyStatsDt=_dbHelper.GetDataTable("SELECT * FROM Daily WHERE D_Date=? AND D_Line=? AND D_Local=? AND D_Time=? AND D_Shift=?", new[]
                    //    {PersianToday.Tarikh(), AppState.UserLnum, AppState.UserLocal, AppState.UserTime, AppState.UserShift});

                    //if (dailyStatsDt.Rows.Count == 0)
                    //{
                    //    _dbHelper.ExecuteNonQuery("INSERT INTO Daily (D_Date, D_Line, D_Local, D_Time, D_Shift) VALUES (?, ?, ?, ?, ?)", new[]
                    //        {PersianToday.Tarikh(), AppState.UserLnum, AppState.UserLocal, AppState.UserTime, AppState.UserShift});
                    //}

                    // بررسی انتخابات فعال
                    DataTable activeElections = _dbHelper.GetDataTable(
                        "SELECT * FROM ElectionMember INNER JOIN Election ON Election.ID=ElectionMember.E_ID " +
                        "WHERE P_Num=? AND E_Start<=? AND E_End>=? AND Election.Vis=True ORDER BY L_Show", new[]
                        {AppState.UserPnum, PersianToday.Tarikh(), PersianToday.Tarikh()});

                    foreach (DataRow _election in activeElections.Rows)
                    {
                        if (string.IsNullOrEmpty(_election["E_Choice"].ToString()))
                        {
                            AppState.Election = true;
                            if (_election["L_Show"].ToString() == "اجباری")
                            {
                                AppState.AnsShould = true;
                            }
                        }
                    }

                    //if (AppState.UserLevel == 9 || AppState.UserLevel == 19)
                    //{
                    //    // تعویض کشیک
                    //    DataTable keshikHistory=_dbHelper.GetDataTable(
                    //        "SELECT KeshikHist.FromID, KeshikHist.ToID, Keshik.ID, Keshik.Tarikh, " +
                    //        "Keshik.T_Keshik, Keshik.L_Keshik, Keshik.Fad " +
                    //        "FROM KeshikHist INNER JOIN Keshik ON KeshikHist.ToID=Keshik.ID " +
                    //        "WHERE Keshik.P_Num=? AND KeshikHist.Vis=True", new[]
                    //        {AppState.UserPnum});

                    //    // AppState.Keshik=keshikHistory.Rows.Count > 0;

                    //    Taghvim PersianDate=new Taghvim();
                    //    MainTable.Columns[0].HeaderText="کشیک ماهانه";

                    //    // نمایش کشیک‌های آینده
                    //    DataTable futureKeshiks=_dbHelper.GetDataTable(
                    //        "SELECT * FROM Keshik WHERE P_Num=? AND Tarikh>=? AND Vis=True ORDER BY Tarikh", new[]
                    //        {AppState.UserPnum, PersianToday.Tarikh()});

                    //    foreach (DataRow keshik in futureKeshiks.Rows)
                    //    {
                    //        PersianDate.SetDate(keshik["Tarikh"].ToString());
                    //        MainTable.Rows.Add(
                    //            PersianDate.DayWeek() + " " + keshik["Tarikh"].ToString() + " " +
                    //            keshik["T_Keshik"].ToString(), keshik["L_Keshik"].ToString());
                    //    }

                    //    PermisPanel.Visible=true;
                    //    DataRow[] DRow=PersonTable.Select("P_Num='" + AppState.UserPnum.ToString() + "'");
                    //    if ((bool)DRow[0]["OverTime"])
                    //        OvertimeBox.Image=Properties.Resources.yes;
                    //    else
                    //        OvertimeBox.Image=Properties.Resources.no;

                    //    if ((bool)DRow[0]["Reserv"])
                    //        ReservBox.Image=Properties.Resources.yes;
                    //    else
                    //        ReservBox.Image=Properties.Resources.no;

                    //    if ((bool)DRow[0]["Trip"])
                    //        TripBox.Image=Properties.Resources.yes;
                    //    else
                    //        TripBox.Image=Properties.Resources.no;

                    //}
                    //else
                    //{

                    //    MainTable.Columns[0].HeaderText="آمار امروز " + PersianToday.Tarikh();

                    //    // مرخصی روزانه
                    //    DataTable dailyLeave=_dbHelper.GetDataTable(
                    //        "SELECT COUNT(Morakhasi.Tarikh) AS Cou FROM Morakhasi " +
                    //        "INNER JOIN Person ON Person.P_Num=Morakhasi.P_Num " +
                    //        "WHERE Morakhasi.Vis=True AND Morakhasi.Tarikh=? AND Person.Shift_Loc=?", new[]
                    //        {PersianToday.Tarikh(), AppState.UserLocal});

                    //    if (dailyLeave.Rows.Count > 0) MainTable.Rows.Add("مرخصی روزانه " + AppState.UserLocal, dailyLeave.Rows[0]["Cou"].ToString() + " نفر");

                    //    // مرخصی ساعتی
                    //    DataTable hourlyLeave=_dbHelper.GetDataTable(
                    //        "SELECT COUNT(Amal.Tarikh) AS Cou FROM Amal " +
                    //        "INNER JOIN Person ON Person.P_Num=Amal.P_Num " +
                    //        "WHERE Amal.Vis=True AND Amal.OnvAmal='ساعتی' AND Amal.Tarikh=? AND Person.Shift_Loc=?", new[]
                    //        {PersianToday.Tarikh(), AppState.UserLocal});

                    //    if (hourlyLeave.Rows.Count > 0) MainTable.Rows.Add("مرخصی ساعتی " + AppState.UserLocal, hourlyLeave.Rows[0]["Cou"].ToString() + " نفر");

                    //    // راهبران رزرو
                    //    DataTable reserveDrivers=_dbHelper.GetDataTable(
                    //        "SELECT COUNT(Rezerv.Tarikh) AS Cou FROM Rezerv " +
                    //        "INNER JOIN Person ON Person.P_Num=Rezerv.P_Num " +
                    //        "WHERE Rezerv.Vis=True AND Rezerv.Tarikh=? AND Person.Shift_Loc=? AND Rezerv.Mem<>'شانتر'", new[]
                    //        {PersianToday.Tarikh(), AppState.UserLocal});

                    //    if (reserveDrivers.Rows.Count > 0) MainTable.Rows.Add("راهبران رزرو " + AppState.UserLocal, reserveDrivers.Rows[0]["Cou"].ToString() + " نفر");

                    //    // درخواست اضافه کار
                    //    DataTable overtimeRequests=_dbHelper.GetDataTable(
                    //        "SELECT COUNT(JayGozin.Tarikh) AS Cou FROM JayGozin " +
                    //        "INNER JOIN Person ON Person.P_Num=JayGozin.P_Num " +
                    //        "WHERE JayGozin.Vis=True AND JayGozin.Tarikh=? AND Person.Shift_Loc=?", new[]
                    //        {PersianToday.Tarikh(), AppState.UserLocal});

                    //    if (overtimeRequests.Rows.Count > 0) MainTable.Rows.Add("درخواست اضافه کار " + AppState.UserLocal, overtimeRequests.Rows[0]["Cou"].ToString() + " نفر");

                    //    if (AppState.UserLevel < 6)
                    //    {
                    //        string local=(Locals[0].ToString() != AppState.UserLocal) ?
                    //            Locals[0].ToString() : Locals[1].ToString();

                    //        MainTable.Height=250;
                    //        MainTable.Rows.Add("-------------------");

                    //        // مرخصی روزانه برای محل دوم
                    //        DataTable otherLocationLeave=_dbHelper.GetDataTable(
                    //            "SELECT COUNT(Morakhasi.Tarikh) AS Cou FROM Morakhasi " +
                    //            "INNER JOIN Person ON Person.P_Num=Morakhasi.P_Num " +
                    //            "WHERE Morakhasi.Vis=True AND Morakhasi.Tarikh=? AND Person.Shift_Loc=?", new[]
                    //            {PersianToday.Tarikh(), local});

                    //        if (otherLocationLeave.Rows.Count > 0) MainTable.Rows.Add("مرخصی روزانه " + local, otherLocationLeave.Rows[0]["Cou"].ToString() + " نفر");

                    //        // مرخصی ساعتی برای محل دوم
                    //        DataTable otherLocationHourlyLeave=_dbHelper.GetDataTable(
                    //            "SELECT COUNT(Amal.Tarikh) AS Cou FROM Amal " +
                    //            "INNER JOIN Person ON Person.P_Num=Amal.P_Num " +
                    //            "WHERE Amal.Vis=True AND Amal.OnvAmal='ساعتی' AND Amal.Tarikh=? AND Person.Shift_Loc=?", new[]
                    //            {PersianToday.Tarikh(), local});

                    //        if (otherLocationHourlyLeave.Rows.Count > 0) MainTable.Rows.Add("مرخصی ساعتی " + local, otherLocationHourlyLeave.Rows[0]["Cou"].ToString() + " نفر");

                    //        // راهبران رزرو برای محل دوم
                    //        DataTable otherLocationReserveDrivers=_dbHelper.GetDataTable(
                    //            "SELECT COUNT(Rezerv.Tarikh) AS Cou FROM Rezerv " +
                    //            "INNER JOIN Person ON Person.P_Num=Rezerv.P_Num " +
                    //            "WHERE Rezerv.Vis=True AND Rezerv.Tarikh=? AND Person.Shift_Loc=? AND Rezerv.Mem<>'شانتر'", new[]
                    //            {PersianToday.Tarikh(), local});

                    //        if (otherLocationReserveDrivers.Rows.Count > 0) MainTable.Rows.Add("راهبران رزرو " + local, otherLocationReserveDrivers.Rows[0]["Cou"].ToString() + " نفر");

                    //        // درخواست اضافه کار برای محل دوم
                    //        DataTable otherLocationOvertimeRequests=_dbHelper.GetDataTable(
                    //            "SELECT COUNT(JayGozin.Tarikh) AS Cou FROM JayGozin " +
                    //            "INNER JOIN Person ON Person.P_Num=JayGozin.P_Num " +
                    //            "WHERE JayGozin.Vis=True AND JayGozin.Tarikh=? AND Person.Shift_Loc=?", new[]
                    //            {PersianToday.Tarikh(), local});

                    //        if (otherLocationOvertimeRequests.Rows.Count > 0) MainTable.Rows.Add("درخواست اضافه کار " + local, otherLocationOvertimeRequests.Rows[0]["Cou"].ToString() + " نفر");
                    //    }
                    //}
                }

                if (AppState.Exam)
                {
                    ExamShowForm Showform = new ExamShowForm();
                    DialogResult Dlg = Showform.ShowDialog();
                    if (Dlg != DialogResult.OK)
                    {
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogo += $"Tables: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
            }
        }

        private bool IsPersonalDetailComplete(DataRow row)
        {
            return !(row["StateAddress"].ToString() == "" ||
                row["CityAddress"].ToString() == "" ||
                row["TownAddress"].ToString() == "" ||
                row["HomeAddress"].ToString() == "" ||
                row["ShoeSize"].ToString() == "" ||
                row["ShirtSize"].ToString() == "" ||
                row["CoatSize"].ToString() == "" ||
                row["PantSize"].ToString() == "" ||
                row["OverSize"].ToString() == "" ||
                row["H_ShSize"].ToString() == "" ||
                row["CollegDegree"].ToString() == "" ||
                row["CollegObject"].ToString() == "");
        }

        // سایر متدهای جداسازی شده برای LoginForm_FormClosing
        private bool LoadUserPersonalInfo()
        {
            string query = "SELECT * FROM Person WHERE P_Num=@PNum";
            DataTable dt = _dbHelper.GetDataTable(query, new[] { AppState.UserPnum.ToString() });

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                AppState.UserName = row["Fname"].ToString() + " " + row["Family"].ToString();
                AppState.UserLnum = row["Line_Num"].ToString();
                AppState.UserStaff = row["P_Staff"].ToString();
                AppState.UserPost = row["P_Post"].ToString();
                AppState.UserTime = row["Shift_Time"].ToString();
                AppState.UserShift = row["Shift_name"].ToString();
                AppState.UserLocal = row["Shift_Loc"].ToString();

                NameStatusLabel.Text = AppState.UserName;
                PostStatusLabel.Text = AppState.UserPost;
                if (AppState.UserPost.IndexOf("راهبر") >= 0)
                {
                    PostStatusLabel.Text += " " + AppState.UserTime;
                }

                PostStatusLabel.Text += " " + AppState.UserShift + " " + AppState.UserLocal;
                LineStatusLabel.Text = AppState.UserStaff + " خط " + AppState.UserLnum;
                AdrsStatusLabel.Text = "IP: " + Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork)?.ToString();
                DateStatusLabel.Text = PersianToday.DayWeek() + " " + PersianToday.Tarikh();
                VersStatusLabel.Text = "نسخه برنامه: " + Application.ProductVersion;

                if (AppState.DatabasePath.Substring(0, 10) == "E:\\Program") AdrsStatusLabel.Text += " *** ";
                // بررسی کامل بودن اطلاعات شخصی
                if (!IsPersonalDetailComplete(row))
                {
                    PersonalDetailForm ShowForm = new PersonalDetailForm
                    {
                        Should = true
                    };

                    DialogResult dlg = ShowForm.ShowDialog(this);
                    if (dlg == DialogResult.Cancel)
                    {
                        Close();
                    }
                }

                AnnounceShowForm ShowForm1 = new AnnounceShowForm();
                ShowForm1.ShowNew(); // بررسی اطلاعیه های فعال
            }
            return true;
        }

        public void CheckBirthday(DataRow row)
        {
            if (row["Birthday"].ToString().Length > 10)
            {
                if (row["Birthday"].ToString().Substring(5, 5) == PersianToday.Tarikh().Substring(5, 5))
                {
                    BirthdayLabel.Image = Properties.Resources.Birthday;
                    BirthdayLabel.Visible = true;
                    BirthdayLabel.Text = "همکار گرامی \n تولدت مبارک \n";
                }
            }
        }

        private bool HasAccessTo(string name)
        {
            if (AccessMap.ContainsKey(name))
            {
                return AccessMap[name];
            }

            return true;
        }

        public void MainSidebar()
        {
            GlassSidebar sidebar = new GlassSidebar();
            //sidebar.AutoScroll=true;
            List<GlassSidebar.SidebarItem> list = new List<GlassSidebar.SidebarItem>();

            foreach (ToolStripMenuItem mi in MainMenu.Items)
            {
                if (HasAccessTo(mi.Name))
                {
                    list.Add(ConvertMenu(mi, 0));
                }
            }

            sidebar.AttachAutoClose(this);
            sidebar.SetItems(list);
            sidebar.Build();
            Controls.Add(sidebar);
            sidebar.BringToFront();
            MainMenu.Visible = false;
        }

        private GlassSidebar.SidebarItem ConvertMenu(ToolStripMenuItem mi, int level)
        {
            GlassSidebar.SidebarItem item = new GlassSidebar.SidebarItem
            {
                Text = mi.Text,
                Icon = mi.Image,
                Click = (s, e) => mi.PerformClick(),
                Level = level
            };

            foreach (ToolStripItem sub in mi.DropDownItems)
            {
                if (sub is ToolStripMenuItem smi)
                {
                    if (HasAccessTo(smi.Name))
                    {
                        item.SubItems.Add(ConvertMenu(smi, level + 1));
                    }
                }
            }

            return item;
        }

        private void SetupMainForm()
        {
            StatusStrip1.Visible = true;
            //Panel2.Visible=true;
            //Panel1.Visible=true;
            PerPicture.Visible = true;
            DateLabelPanel.Visible = true;
        }

        public void SetupWorkLocations()
        {
            if (AppState.UserLevel < 6)
            {
                Locals[0] = "گلشهر";
                Locals[1] = "تهران";
                Locals[2] = "هشتگرد";
                Locals[3] = "پایانه تهران";
                Locals[4] = "پایانه مهرشهر";
            }
            else if (AppState.UserLevel > 3 && AppState.UserLevel < 10)
            {
                Locals[0] = "گلشهر";
                Locals[1] = "تهران";
                Locals[2] = "هشتگرد";
            }
            else if (AppState.UserLevel >= 10)
            {
                Locals[0] = "پایانه تهران";
                Locals[1] = "پایانه مهرشهر";
            }
        }

        public void ApplyAccessRestrictions()
        {
            switch (AppState.UserLevel)
            {
                case 0:
                    Hide0();
                    break;
                case 1:
                    Hide1();
                    break;
                case 2:
                    Hide2();
                    break;
                case 3:
                    Hide3();
                    break;
                case 4:
                    Hide4();
                    break;
                case 5:
                    Hide5();
                    break;
                case 6:
                    Hide6();
                    break;
                case 7:
                    Hide7();
                    break;
                case 8:
                    Hide8();
                    break;
                case 9:
                    Hide9();
                    break;
                case 14:
                    Hide14();
                    break;
                case 15:
                    Hide15();
                    break;
                case 16:
                    Hide16();
                    break;
                case 17:
                    Hide17();
                    break;
                case 18:
                    Hide18();
                    break;
                case 19:
                    Hide19();
                    break;
            }
        }

        public void Hide0() //       ادمین
        {
            AccessMap[اعلامخرابیToolStripMenuItem.Name] = false;
            AccessMap[پردازشلوحههشتگردToolStripMenuItem.Name] = false;
            AccessMap[پردازش2ToolStripMenuItem.Name] = false;
            AccessMap[رزروراهبران12ساعتهToolStripMenuItem.Name] = false;
            AccessMap[تغییراتلوحهاعزامToolStripMenuItem.Name] = false;
            AccessMap[ثبتآزمونجدیدToolStripMenuItem.Name] = false;
            //AccessMap[اجرایمجددToolStripMenuItem.Name]=false;
        }

        public void Hide1() //      مدیر عامل
        {
            Hide0();
            AccessMap[جابجاییتریپراهبرانToolStripMenuItem.Name] = false;
            AccessMap[سقفاضافهکارپرسنلToolStripMenuItem.Name] = false;
            AccessMap[ریسترمزکاربرانToolStripMenuItem.Name] = false;
            AccessMap[ادمینToolStripMenuItem.Name] = false;
            AccessMap[کاربرجدیدToolStripMenuItem.Name] = false;
            AccessMap[پرسنلجدیدToolStripMenuItem.Name] = false;
            AccessMap[ویرایشمشخصاتToolStripMenuItem.Name] = false;
            AccessMap[لیستکاربرانToolStripMenuItem.Name] = false;
            AccessMap[ToolStripMenuItem16.Name] = false;

            AccessMap[اعلامخرابیToolStripMenuItem.Name] = false;
            AccessMap[وضعیتپارکینگToolStripMenuItem.Name] = false;
        }

        public void Hide2() //       مدیر خط
        {
            Hide1();
        }

        public void Hide3() //       کارشناس مدیریت
        {
            Hide2();
            AccessMap[عملیاتقطارجدیدToolStripMenuItem.Name] = false;
            AccessMap[عملیاتقطارویرایشToolStripMenuItem.Name] = false;
            AccessMap[ToolStripMenuItem3.Name] = false;
            AccessMap[پردازشلوحهپایانهToolStripMenuItem.Name] = false;
            AccessMap[ToolStripMenuItem11.Name] = false;
            AccessMap[عملیاتمانورToolStripMenuItem.Name] = false;
            AccessMap[محاسبهکارکردراهبرانToolStripMenuItem.Name] = false;
        }

        public void Hide4() //       کابران لوحه
        {
            Hide2();
            AccessMap[مرخصیساعتیToolStripMenuItem.Name] = false;
            AccessMap[امتیازانضباطیToolStripMenuItem.Name] = false;
            AccessMap[اضافهکارگروهیToolStripMenuItem.Name] = false;
            AccessMap[پارکینگومانورToolStripMenuItem.Name] = false;
            AccessMap[تحویلوتحولقطارToolStripMenuItem.Name] = false;
            AccessMap[درخواستسرویسToolStripMenuItem.Name] = false;
            AccessMap[ToolStripMenuItem8.Name] = false;
            AccessMap[ثبتلوحهنهاییToolStripMenuItem.Name] = false;
            AccessMap[رزرواضطراریراهبرانToolStripMenuItem.Name] = false;
            AccessMap[پایشفنیToolStripMenuItem.Name] = false;
            AccessMap[مدیریتToolStripMenuItem.Name] = false;
            AccessMap[گزارشمدیریتیToolStripMenuItem.Name] = false;
        }

        public void Hide5() //       رئیس خط
        {
            Hide2();
            AccessMap[عملیاتقطارجدیدToolStripMenuItem.Name] = false;
            AccessMap[عملیاتقطارویرایشToolStripMenuItem.Name] = false;
            AccessMap[ToolStripMenuItem3.Name] = false;
            AccessMap[پردازشلوحهروزانهToolStripMenuItem.Name] = false;
            AccessMap[ToolStripMenuItem21.Name] = false;
            AccessMap[پردازشلوحهپایانهToolStripMenuItem.Name] = false;
            AccessMap[ToolStripMenuItem11.Name] = false;
            AccessMap[عملیاتمانورToolStripMenuItem.Name] = false;
            AccessMap[آرایشناوگانثبتToolStripMenuItem.Name] = false;
            AccessMap[آرایشناوگانویرایشToolStripMenuItem.Name] = false;
            AccessMap[ToolStripMenuItem10.Name] = false;
        }

        public void Hide6() //       سرپرست خط
        {
            Hide5();
        }

        public void Hide7() //       مسئول خط
        {
            Hide6();
            AccessMap[ثبتلوحهنهاییToolStripMenuItem.Name] = false;
            AccessMap[پایشفنیToolStripMenuItem.Name] = false;
            AccessMap[مدیریتToolStripMenuItem.Name] = false;
            AccessMap[گزارشمدیریتیToolStripMenuItem.Name] = false;
            AccessMap[پرسنلویرایشToolStripMenuItem.Name] = false;
            AccessMap[ToolStripMenuItem25.Name] = false;
            AccessMap[مجوزویرایشToolStripMenuItem.Name] = false;
            AccessMap[ToolStripMenuItem26.Name] = false;
        }

        public void Hide8() //       تکنیسین خط
        {
            Hide7();
            AccessMap[اضافهکارشیفتToolStripMenuItem.Name] = false;
            AccessMap[امتیازانضباطیToolStripMenuItem.Name] = false;
            AccessMap[اضافهکارجدیدToolStripMenuItem.Name] = false;
            AccessMap[اضافهکارگروهیToolStripMenuItem.Name] = false;
            AccessMap[اضافهکارویرایشToolStripMenuItem.Name] = false;
            AccessMap[ToolStripMenuItem07.Name] = false;
            AccessMap[رزرواضطراریراهبرانToolStripMenuItem.Name] = false;
        }

        public void Hide9() //       راهبر خط
        {
            Hide8();
            AccessMap[مرخصیروزانهجدیدToolStripMenuItem.Name] = false;
            AccessMap[مرخصیروزانهویرایشToolStripMenuItem.Name] = false;
            AccessMap[ToolStripMenuItem04.Name] = false;
            AccessMap[مرخصیساعتیجدیدToolStripMenuItem.Name] = false;
            AccessMap[مرخصیساعتیویرایشToolStripMenuItem.Name] = false;
            AccessMap[ToolStripMenuItem05.Name] = false;
            //AccessMap[درخواستاضافهکارویرایشToolStripMenuItem.Name]=false;
            AccessMap[درخواستکشیکماهانهToolStripMenuItem.Name] = false;
            AccessMap[پذیرشواعزامToolStripMenuItem.Name] = false;
            AccessMap[پردازشلوحهاعزامToolStripMenuItem.Name] = false;
            AccessMap[پرسنلعملیاتToolStripMenuItem.Name] = false;
            AccessMap[مجوزپرسنلToolStripMenuItem.Name] = false;
        }

        public void Hide14() //       کارشناس پایانه
        {
            Hide2();
            AccessMap[کارکردراهبرانToolStripMenuItem.Name] = false;
            AccessMap[امتیازانضباطیToolStripMenuItem.Name] = false;
            AccessMap[اضافهکارجدیدToolStripMenuItem.Name] = false;
            AccessMap[اضافهکارگروهیToolStripMenuItem.Name] = false;
            AccessMap[اضافهکارویرایشToolStripMenuItem.Name] = false;
            AccessMap[ToolStripMenuItem07.Name] = false;
            AccessMap[درخواستسرویسToolStripMenuItem.Name] = false;
            AccessMap[پایشفنیToolStripMenuItem.Name] = false;
            AccessMap[پذیرشواعزامToolStripMenuItem.Name] = false;
            AccessMap[پردازشلوحهاعزامToolStripMenuItem.Name] = false;
            AccessMap[گزارشمدیریتیToolStripMenuItem.Name] = false;
            AccessMap[ToolStripMenuItem17.Name] = false;
            AccessMap[محاسبهکارکردراهبرانToolStripMenuItem.Name] = false;
            AccessMap[عملیاتمانورToolStripMenuItem.Name] = false;
        }

        public void Hide15() //       رئیس پایانه
        {
            Hide2();
            AccessMap[کارکردراهبرانToolStripMenuItem.Name] = false;
            AccessMap[پایشفنیToolStripMenuItem.Name] = false;
            AccessMap[پذیرشواعزامToolStripMenuItem.Name] = false;
            AccessMap[پردازشلوحهاعزامToolStripMenuItem.Name] = false;
            AccessMap[گزارشمدیریتیToolStripMenuItem.Name] = false;
            AccessMap[ToolStripMenuItem17.Name] = false;
            AccessMap[عملیاتمانورToolStripMenuItem.Name] = false;
        }

        public void Hide16() //       سرپرست پایانه
        {
            Hide15();

        }

        public void Hide17() //       مسئول پایانه
        {
            Hide16();
            AccessMap[مدیریتToolStripMenuItem.Name] = false;
            AccessMap[پرسنلویرایشToolStripMenuItem.Name] = false;
            AccessMap[ToolStripMenuItem25.Name] = false;
            AccessMap[مجوزویرایشToolStripMenuItem.Name] = false;
            AccessMap[ToolStripMenuItem26.Name] = false;
        }

        public void Hide18() //       تکنیسین پایانه
        {
            Hide17();
            AccessMap[مرخصیساعتیجدیدToolStripMenuItem.Name] = false;
            AccessMap[مرخصیساعتیویرایشToolStripMenuItem.Name] = false;
            AccessMap[ToolStripMenuItem05.Name] = false;
            AccessMap[امتیازانضباطیToolStripMenuItem.Name] = false;
            AccessMap[ToolStripMenuItem06.Name] = false;
            AccessMap[اضافهکارجدیدToolStripMenuItem.Name] = false;
            AccessMap[اضافهکارگروهیToolStripMenuItem.Name] = false;
            AccessMap[اضافهکارویرایشToolStripMenuItem.Name] = false;
            AccessMap[ToolStripMenuItem07.Name] = false;
        }

        public void Hide19() //       راهبر پایانه
        {
            Hide18();
            AccessMap[اضافهکارشیفتToolStripMenuItem.Name] = false;
            AccessMap[مرخصیروزانهجدیدToolStripMenuItem.Name] = false;
            AccessMap[مرخصیروزانهویرایشToolStripMenuItem.Name] = false;
            AccessMap[ToolStripMenuItem04.Name] = false;
            AccessMap[آرایشناوگانثبتToolStripMenuItem.Name] = false;
            AccessMap[آرایشناوگانویرایشToolStripMenuItem.Name] = false;
            AccessMap[ToolStripMenuItem10.Name] = false;
            AccessMap[عملیاتقطارجدیدToolStripMenuItem.Name] = false;
            AccessMap[عملیاتقطارویرایشToolStripMenuItem.Name] = false;
            AccessMap[ثبتجدولحرکتیدستیToolStripMenuItem.Name] = false;
            AccessMap[ویرایشجدولحرکتیToolStripMenuItem.Name] = false;
            AccessMap[ToolStripMenuItem3.Name] = false;
            AccessMap[عملیاتمانورToolStripMenuItem.Name] = false;
            AccessMap[ToolStripMenuItem11.Name] = false;
            AccessMap[پردازشلوحهپایانهToolStripMenuItem.Name] = false;
            AccessMap[پردازشلوحهروزانهToolStripMenuItem.Name] = false;
            AccessMap[پرسنلعملیاتToolStripMenuItem.Name] = false;
            AccessMap[مجوزپرسنلToolStripMenuItem.Name] = false;
        }

        public void TripChecker()
        {
            try
            {
                using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    if (!PrimLoh && !PrimeWarned)
                    {
                        using (OleDbCommand CMD = new OleDbCommand("SELECT * FROM DailyTripReg WHERE Tarikh='" + PersianToday.Tarikh() + "' AND T_Type='لوحه اولیه' AND Vis=True", StrConnec))
                        using (OleDbDataReader Reader = CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                PrimLoh = true;
                            }
                        }

                        if (!PrimLoh && AppState.UserLevel > 0)
                        {
                            PrimeWarned = true;
                            StrConnec.Close();
                            MessageBoxFa.Show("لوحه اولیه " + PersianToday.Tarikh() + " ثبت نشده است", "خطا", MessageBoxIcon.Error);
                            TripImportPrimeForm ShowForm = new TripImportPrimeForm();
                            ShowForm.ShowDialog(this);
                            PrimeWarned = false;
                        }

                    }
                    //else if (TripTab.Visible)
                    //{
                    //    Taghvim PersianDate=new Taghvim(DateTime.Today.AddDays(-2));
                    //    if (TripFinalView1.Rows.Count + TripFinalView2.Rows.Count == 0)
                    //    {
                    //        foreach (DataGridView DataGr in TripPanel2.Controls)
                    //        {
                    //            DataGr.Rows.Clear();
                    //            DataGr.Columns[1].HeaderText=PersianDate.Tarikh().Substring(5, 5);

                    //            using (OleDbCommand CMD=new OleDbCommand("SELECT * FROM DailyTrip WHERE (O1_Num='" + AppState.UserPnum + "' OR O2_Num='" + AppState.UserPnum + "' OR OT_Num='" + AppState.UserPnum + "') AND Tarikh='" + PersianDate.Tarikh() + "' AND Execu=True AND Vis=True ORDER BY T_Time", StrConnec))
                    //            using (OleDbDataReader Reader=CMD.ExecuteReader())
                    //                while (Reader.Read())
                    //                {
                    //                    string Posi="";
                    //                    if (Reader["O1_Num"].ToString() == AppState.UserPnum)
                    //                        Posi="اصلی";

                    //                    else if (Reader["O2_Num"].ToString() == AppState.UserPnum)
                    //                        Posi="کمکی";

                    //                    else
                    //                        Posi="آموزشی";

                    //                    DataGr.Rows.Add(Reader["T_Time"].ToString(), Reader["Mabdae"].ToString(), Posi);
                    //                }

                    //            PersianDate.AddDay(1);
                    //        }

                    //        if (TripFinalView1.Rows.Count == 0) TripFinalView1.Rows.Add("--", "--", "--");
                    //        if (TripFinalView2.Rows.Count == 0) TripFinalView2.Rows.Add("--", "--", "--");
                    //    }

                    //    if (TripPrimView1.Rows.Count + TripPrimView2.Rows.Count == 0)
                    //    {
                    //        PersianDate.SetDate(DateTime.Today.AddDays(-2));
                    //        foreach (DataGridView DataGr in TripPanel1.Controls)
                    //        {
                    //            DataGr.Rows.Clear();
                    //            DataGr.Columns[1].HeaderText=PersianDate.Tarikh().Substring(5, 5);

                    //            using (OleDbCommand CMD=new OleDbCommand("SELECT * FROM DailyTrip WHERE (O1_Num='" + AppState.UserPnum + "' OR O2_Num='" + AppState.UserPnum + "' OR OT_Num='" + AppState.UserPnum + "') AND Tarikh='" + PersianDate.Tarikh() + "' AND Prime=True AND Vis=True ORDER BY T_Time", StrConnec))
                    //            {
                    //                using (OleDbDataReader Reader=CMD.ExecuteReader())
                    //                {
                    //                    while (Reader.Read())
                    //                    {
                    //                        string Posi="";
                    //                        if (Reader["O1_Num"].ToString() == AppState.UserPnum)
                    //                        {
                    //                            Posi="اصلی";
                    //                        }
                    //                        else if (Reader["O2_Num"].ToString() == AppState.UserPnum)
                    //                        {
                    //                            Posi="کمکی";
                    //                        }
                    //                        else
                    //                        {
                    //                            Posi="آموزشی";
                    //                        }
                    //                        DataGr.Rows.Add(Reader["T_Time"].ToString(), Reader["Mabdae"].ToString(), Posi);
                    //                    }
                    //                }
                    //            }

                    //            PersianDate.AddDay(1);
                    //        }

                    //        if (TripPrimView1.Rows.Count == 0) TripPrimView1.Rows.Add("--", "--", "--", "--");
                    //        if (TripPrimView2.Rows.Count == 0) TripPrimView2.Rows.Add("--", "--", "--", "--");
                    //    }

                    //    //If DayTrip2.Rows(1).Cells(0).Value=Nothing Then
                    //    TripTable.Clear();

                    //    if (TripTable.Rows.Count < 20)
                    //    {
                    //        string ss="SELECT * FROM DailyTrip WHERE Vis=True AND Prime=True AND Tarikh>='" + PersianToday.Tarikh() + "' ORDER BY Tarikh, T_Time, Mabdae";
                    //        OleDbDataAdapter Adap=new OleDbDataAdapter(ss, StrConnec);
                    //        Adap.Fill(TripTable);
                    //        Adap.Dispose();
                    //    }

                    //    //If TripTable.Rows.Count < 20 Then
                    //    //    PersianDate.SetDate(Today.AddDays(1))
                    //    //    Dim ss As String="SELECT * FROM DailyTrip WHERE Vis=True AND Prime=True AND Tarikh>='" & PersianDate.Tarikh & "'"
                    //    //    ss += "ORDER BY Tarikh, T_Time, Mabdae"
                    //    //    Dim Adap As New OleDbDataAdapter(ss, StrConnec)
                    //    //    Adap.Fill(TripTable)
                    //    //    Adap.Dispose()
                    //    //End If

                    //    if (TripTable.Rows.Count < 5)
                    //    {
                    //        if (AppState.UserLevel > 0) // بررسی لوحه اولیه ثبت شده
                    //        {
                    //            MessageBoxFa.Show("لوحه اولیه " + PersianToday.Tarikh() + " ثبت نشده است", "خطا", MessageBoxIcon.Error);
                    //            TripImportPrimeForm ShowForm=new TripImportPrimeForm();
                    //            ShowForm.ShowDialog(this);
                    //        }
                    //    }
                    //    else
                    //    {
                    //        if ((TimeSpan)DayTrip2.Rows[1].Cells[0].Value <= DateTime.Now.TimeOfDay)
                    //        {
                    //            DataRow[] DRow;
                    //            string[,] TimeSrt=new string[11, 5];
                    //            int i;
                    //            int j=0;
                    //            int ID=0;

                    //            ID=0;
                    //            DRow=TripTable.Select();
                    //            foreach (DataRow DtR in DRow)
                    //            {
                    //                if ((DtR["Tarikh"].ToString() == PersianToday.Tarikh() && (TimeSpan)DtR["T_Time"] >= DateTime.Now.TimeOfDay) || string.Compare(DtR["Tarikh"].ToString(), PersianToday.Tarikh()) > 0)
                    //                {
                    //                    break;
                    //                }
                    //                else
                    //                {
                    //                    ID++;
                    //                }
                    //            }

                    //            for (i=0; i <= 10; i++)
                    //            {
                    //                j=ID - 4 + i;
                    //                if (j < DRow.Length & j >= 0)
                    //                {
                    //                    DataRow DtR=DRow[j];
                    //                    TimeSrt[i, 0]=DtR["T_Time"].ToString();
                    //                    TimeSrt[i, 1]=DtR["Mabdae"].ToString();
                    //                    TimeSrt[i, 2]=DtR["O1_Num"].ToString();
                    //                    TimeSrt[i, 3]=DtR["O2_Num"].ToString();
                    //                    TimeSrt[i, 4]=DtR["Tarikh"].ToString();
                    //                }
                    //            }

                    //            //i=0
                    //            //QrStr="T_Time<'" & Now.ToString("HH:mm") & "' AND Tarikh<='" & PersianToday.Tarikh & "'"
                    //            //'   If UserLevel > 3 Then QrStr += " AND Mabdae='" & UserLocal & "'"
                    //            //DRow=TripTable.Select(QrStr, " Tarikh DESC, T_Time DESC, Mabdae DESC")
                    //            //For Each DtR As DataRow In DRow
                    //            //    TimeSrt(3 - i, 0)=DtR.Item("T_Time").ToString
                    //            //    TimeSrt(3 - i, 1)=DtR.Item("Mabdae").ToString
                    //            //    TimeSrt(3 - i, 2)=DtR.Item("O1_Num").ToString
                    //            //    TimeSrt(3 - i, 3)=DtR.Item("O2_Num").ToString
                    //            //    TimeSrt(3 - i, 4)=DtR.Item("Tarikh").ToString

                    //            //    If i=3 Then Exit For Else i += 1
                    //            //Next

                    //            //i=4
                    //            //QrStr="T_Time>='" & Now.ToString("HH:mm") & "' AND Tarikh>='" & PersianToday.Tarikh & "'"
                    //            //If UserLevel > 3 Then QrStr += " AND Mabdae='" & UserLocal & "'"
                    //            //DRow=TripTable.Select(QrStr, "Tarikh, T_Time, Mabdae")
                    //            //For Each DtR As DataRow In DRow
                    //            //    TimeSrt(i, 0)=DtR.Item("T_Time").ToString
                    //            //    TimeSrt(i, 1)=DtR.Item("Mabdae").ToString
                    //            //    TimeSrt(i, 2)=DtR.Item("O1_Num").ToString
                    //            //    TimeSrt(i, 3)=DtR.Item("O2_Num").ToString
                    //            //    TimeSrt(i, 4)=DtR.Item("Tarikh").ToString
                    //            //    i += 1
                    //            //    If i=10 Then Exit For
                    //            //Next

                    //            for (i=0; i <= 9; i++)
                    //            {
                    //                if (TimeSrt[i, 2] != null)
                    //                {
                    //                    if (!string.IsNullOrEmpty(TimeSrt[i, 2].ToString()))
                    //                    {
                    //                        DRow=PersonTable.Select("P_Num='" + TimeSrt[i, 2].ToString() + "'");
                    //                        if (DRow.Length > 0) TimeSrt[i, 2]=DRow[0][0] + " " + DRow[0][1].ToString();
                    //                    }

                    //                    if (!string.IsNullOrEmpty(TimeSrt[i, 3].ToString()))
                    //                    {
                    //                        DRow=PersonTable.Select("P_Num='" + TimeSrt[i, 3].ToString() + "'");
                    //                        if (DRow.Length > 0) TimeSrt[i, 3]=DRow[0][0] + " " + DRow[0][1].ToString();
                    //                    }
                    //                }
                    //            }

                    //            DayTrip1.Rows.Clear();
                    //            DayTrip2.Rows.Clear();
                    //            DayTrip3.Rows.Clear();

                    //            DayTrip1.Rows.Add(TimeSrt[0, 0], TimeSrt[0, 1], TimeSrt[0, 2], TimeSrt[0, 3]);
                    //            DayTrip1.Rows.Add(TimeSrt[1, 0], TimeSrt[1, 1], TimeSrt[1, 2], TimeSrt[1, 3]);
                    //            DayTrip1.Rows.Add(TimeSrt[2, 0], TimeSrt[2, 1], TimeSrt[2, 2], TimeSrt[2, 3]);

                    //            DayTrip2.Rows.Add(TimeSrt[3, 0], TimeSrt[3, 1], TimeSrt[3, 2], TimeSrt[3, 3], TimeSrt[3, 4]);
                    //            DayTrip2.Rows.Add(TimeSrt[4, 0], TimeSrt[4, 1], TimeSrt[4, 2], TimeSrt[4, 3], TimeSrt[4, 4]);
                    //            DayTrip2.Rows.Add(TimeSrt[5, 0], TimeSrt[5, 1], TimeSrt[5, 2], TimeSrt[5, 3], TimeSrt[5, 4]);

                    //            DayTrip3.Rows.Add(TimeSrt[6, 0], TimeSrt[6, 1], TimeSrt[6, 2], TimeSrt[6, 3]);
                    //            DayTrip3.Rows.Add(TimeSrt[7, 0], TimeSrt[7, 1], TimeSrt[7, 2], TimeSrt[7, 3]);
                    //            DayTrip3.Rows.Add(TimeSrt[8, 0], TimeSrt[8, 1], TimeSrt[8, 2], TimeSrt[8, 3]);
                    //            DayTrip3.Rows.Add(TimeSrt[9, 0], TimeSrt[9, 1], TimeSrt[9, 2], TimeSrt[9, 3]);
                    //        }
                    //    }
                    //}
                }


                // Timer1.Interval=25000
            }
            catch (Exception ex)
            {
                ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void PersonRead(OleDbConnection StrConnec)
        {
            try
            {
                PersonTable.Clear();

                if (AppState.UserPnum.Length > 0)
                {
                    using (OleDbDataAdapter Adap = new OleDbDataAdapter("SELECT Fname, Family, P_Num, Line_Num, P_Staff, Shift_Loc, P_Post, Shift_Time, Shift_name, Birthday, Vis, OverTime, Reserv, Trip, Phone, O_Group, LicenseDegree FROM Person WHERE P_Num<>''", StrConnec))
                    {
                        Adap.Fill(PersonTable);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("ارتباط با سرور برقرار نشد ", "خطا", MessageBoxIcon.Error);
                Close();
            }
        }

        private void LoadUserPhoto()
        {
            string pic = AppState.DatabasePath + "\\Pic\\" + AppState.UserPnum;

            if (System.IO.File.Exists(pic + "T"))
            {
                if (System.IO.File.Exists(pic))
                {
                    System.IO.File.Move(pic, pic + PersianToday.Tarikh().Replace("/", "") + DateTime.Now.ToString("HH:mm:ss").Replace(":", ""));
                }
                System.IO.File.Move(pic + "T", pic);
            }

            if (System.IO.File.Exists(pic))
            {
                if (PerPicture.Image != null)
                {
                    PerPicture.Image.Dispose();
                }

                PerPicture.Image = Image.FromFile(pic);
            }
        }

        private void InitAccess()
        {
            AccessMap.Clear();
            foreach (ToolStripMenuItem m in MainMenu.Items)
            {
                FillAccess(m);
            }
        }

        private void FillAccess(ToolStripMenuItem m)
        {
            AccessMap[m.Name] = true;

            foreach (ToolStripItem sub in m.DropDownItems)
            {
                if (sub is ToolStripMenuItem sm)
                {
                    FillAccess(sm);
                }
            }
        }

        public void HistChecker()
        {
            try
            {
                string PNum = "";
                bool Changed = false;
                PNum = "";

                using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    PersonRead(StrConnec);
                    using (OleDbCommand CMD = new OleDbCommand("SELECT ID, P_Num, Fname, Family FROM PersonHis WHERE ID>" + DetalHis.ToString() + " ORDER BY ID DESC", StrConnec))
                    using (OleDbDataReader Reader = CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            if (DetalHis == 0)
                            {
                                DetalHis = Convert.ToInt32(Reader["ID"]);
                                break;
                            }
                            else if (DetalHis < Convert.ToInt32(Reader["ID"]))
                            {
                                DetalHis = Convert.ToInt32(Reader["ID"]);
                            }

                            PNum = Reader["P_Num"].ToString();
                            DataRow[] DRow = PersonTable.Select("P_Num='" + PNum + "'");
                            if (DRow.Length > 0)
                            {
                                string PName = DRow[0]["Fname"].ToString() + " " + DRow[0]["Family"].ToString();

                                string Pic = "";
                                Pic = AppState.DatabasePath + "\\Pic\\" + PNum;
                                if (System.IO.File.Exists(Pic))
                                {
                                    ToastForm slice = new ToastForm(12000, "", "مشخصات فردی " + PName + " تغییر یافت", Pic);
                                    slice.Show();
                                }
                                else
                                {
                                    ToastForm slice = new ToastForm(12000, "", "مشخصات فردی " + PName + " تغییر یافت");
                                    slice.Show();
                                }
                                Changed = true;
                            }
                        }
                    }

                    using (OleDbCommand CMD = new OleDbCommand("SELECT ID, P_Num FROM PostHis WHERE ID>" + PesronHis.ToString() + " ORDER BY ID DESC", StrConnec))
                    using (OleDbDataReader Reader = CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            if (PesronHis == 0)
                            {
                                PesronHis = Convert.ToInt32(Reader["ID"]);
                                break;
                            }
                            else if (PesronHis < Convert.ToInt32(Reader["ID"]))
                            {
                                PesronHis = Convert.ToInt32(Reader["ID"]);
                            }
                            PNum = Reader["P_Num"].ToString();

                            DataRow[] DRow = PersonTable.Select("P_Num='" + PNum + "'");
                            if (DRow.Length > 0)
                            {
                                string PName = DRow[0]["Fname"] + " " + DRow[0]["Family"];

                                string Pic = "";
                                Pic = AppState.DatabasePath + "\\Pic\\" + PNum;
                                if (System.IO.File.Exists(Pic))
                                {
                                    ToastForm slice = new ToastForm(12000, "", "اطلاعات پرسنلی " + PName + " تغییر یافت", Pic);
                                    slice.Show();
                                }
                                else
                                {
                                    ToastForm slice = new ToastForm(12000, "", "اطلاعات پرسنلی " + PName + " تغییر یافت");
                                    slice.Show();
                                }
                                Changed = true;
                            }
                        }
                    }

                    using (OleDbCommand CMD = new OleDbCommand("SELECT ID, P_Num FROM PDetailHis WHERE ID>" + SizeHis.ToString() + " ORDER BY ID DESC", StrConnec))
                    using (OleDbDataReader Reader = CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            if (SizeHis == 0)
                            {
                                SizeHis = Convert.ToInt32(Reader["ID"]);
                                break;
                            }
                            else if (SizeHis < Convert.ToInt32(Reader["ID"]))
                            {
                                SizeHis = Convert.ToInt32(Reader["ID"]);
                            }
                            PNum = Reader["P_Num"].ToString();

                            DataRow[] DRow = PersonTable.Select("P_Num='" + PNum + "'");
                            if (DRow.Length > 0)
                            {
                                string PName = DRow[0]["Fname"] + " " + DRow[0]["Family"];

                                string Pic = "";
                                Pic = AppState.DatabasePath + "\\Pic\\" + PNum;
                                if (System.IO.File.Exists(Pic))
                                {
                                    ToastForm slice = new ToastForm(12000, "", "اطلاعات فردی " + PName + " تغییر یافت", Pic);
                                    slice.Show();
                                }
                                else
                                {
                                    ToastForm slice = new ToastForm(12000, "", "اطلاعات فردی " + PName + " تغییر یافت");
                                    slice.Show();
                                }
                                Changed = true;
                            }
                        }
                    }

                    using (OleDbCommand CMD = new OleDbCommand("SELECT ID, P_Num FROM Permis WHERE ID>" + PermHis.ToString() + " ORDER BY ID DESC", StrConnec))
                    using (OleDbDataReader Reader = CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            if (PermHis == 0)
                            {
                                PermHis = Convert.ToInt32(Reader["ID"]);
                                break;
                            }
                            else if (PermHis < Convert.ToInt32(Reader["ID"]))
                            {
                                PermHis = Convert.ToInt32(Reader["ID"]);
                            }
                            PNum = Reader["P_Num"].ToString();

                            DataRow[] DRow = PersonTable.Select("P_Num='" + PNum + "'");
                            string PName = DRow[0]["Fname"] + " " + DRow[0]["Family"];

                            string Pic = "";
                            Pic = AppState.DatabasePath + "\\Pic\\" + PNum;
                            if (System.IO.File.Exists(Pic))
                            {
                                ToastForm slice = new ToastForm(12000, "", "مجوزهای " + PName + " تغییر یافت", Pic);
                                slice.Show();
                            }
                            else
                            {
                                ToastForm slice = new ToastForm(12000, "", "مجوزهای " + PName + " تغییر یافت");
                                slice.Show();
                            }
                            Changed = true;
                        }
                    }

                    if (Changed)
                    {
                        PersonRead(StrConnec);
                    }
                }

            }
            catch (Exception ex)
            {
                ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("ارتباط با سرور برقرار نشد ", "خطا", MessageBoxIcon.Error);
                Close();
            }
        }

        private void SaveData()
        {
            if (ErrorLogoBox.Text.Length > 0)
            {
                System.IO.File.WriteAllText(AppState.DatabasePath + "\\Logs\\" + Dns.GetHostEntry(Dns.GetHostName().ToString()).AddressList[1].ToString() + "-" + PersianToday.Tarikh().Replace("/", "") + "-" + DateTime.Now.ToString("HH:mm:ss").Replace(":", "") + ".txt", ErrorLogoBox.Text);
            }

            using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
            {
                StrConnec.Open();
                using (OleDbCommand CMD = new OleDbCommand("UPDATE PUserLoggin SET Out_Date='" + PersianToday.Tarikh() + "', Out_Time='" + DateTime.Now.ToString("HH:mm:ss") + "', IsIn=False WHERE ID=( SELECT TOP 1 ID FROM PUserLoggin WHERE Uname='" + AppState.LogginName + "' AND IsIn=True ORDER BY In_Date DESC, In_Time DESC)", StrConnec))
                {
                    CMD.ExecuteNonQuery();
                }
            }
        }

        private void OpenChildForm(Form ChildForm)
        {
            //ChildForm childform = new ChildForm();
            //childform.MdiParent = this;
            // if (newPanel1.Controls.Count > 3)
            foreach (Form ChForm in newPanel1.Controls)
            {
                if (ChForm.Name == ChildForm.Name)
                {
                    ChForm.BringToFront();
                    //  this.MdiChildren.FirstOrDefault(x => x is CalendarFormAD).Activate();
                    return;
                }
            }
            ChildForm.TopLevel = false;
            int ParWidth = (newPanel1.ClientSize.Width - ChildForm.Width) / 2;
            int ParHeight = (newPanel1.ClientSize.Height - ChildForm.Height) / 2;

            ChildForm.Location = new Point(ParWidth, ParHeight);
            newPanel1.Controls.Add(ChildForm);

            //if (this.MdiChildren.FirstOrDefault(x => x is CalendarFormAD) == null)
            ChildForm.BringToFront();
            ChildForm.Show();

        }

        public void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                //Locals[]=null;
                InitAccess();

                // تنظیم محل‌های کاری بر اساس سطح کاربر
                SetupWorkLocations();

                // اعمال محدودیت‌های دسترسی بر اساس سطح کاربر
                ApplyAccessRestrictions();

                // ساخت ساید بار شیشه ای
                MainSidebar();

                Controls.FlipClock clock = new Controls.FlipClock
                {
                    Location = new Point(20, 20),
                    Font = new Font("Tahoma", 20f, FontStyle.Bold), // تنظیم فونت پایه
                    DigitBackColor = Color.FromArgb(180, 180, 180),
                    DigitForeColor = Color.Black
                };
                Controls.Add(clock);
                clock.BringToFront();

                // تنظیم اطلاعات فرم اصلی
                SetupMainForm();

                // بارگذاری عکس پرسنلی
                LoadUserPhoto();

                bool pDetail = false;
                // استفاده از DatabaseHelper برای دریافت اطلاعات شخصی کاربر
                pDetail = LoadUserPersonalInfo();

                //
                Tables();

                // نمایش دکمه تریپ برای سطوح کاربری خاص
                //if (AppState.UserLevel < 10) TripShowButton.Visible=true;

                //  BackgroundImageLayout=ImageLayout.Stretch                
                TrialLabel.Left = (MainMenu.Width - TrialLabel.Width) / 2;
                BirthdayLabel.Left = (MainMenu.Width - BirthdayLabel.Width) / 2;
                BirthdayList.Left = (MainMenu.Width - BirthdayList.Width) / 2;

                System.Globalization.CultureInfo typeOfLanguage = new System.Globalization.CultureInfo("fa-IR");
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(typeOfLanguage);
            }
            catch (Exception ex)
            {
                ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید " + "\n\n" + ex.Message, "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (ShClose)
                {
                    SaveData();
                    return;
                }
                else
                {
                    if (MessageBoxFa.Show("از برنامه خارج می شوید؟", "خروج", MessageBoxIcon.Information, MessageBoxButtons.YesNo, MessageBoxDefaultButton.Button2) == DialogResult.Yes || ShClose)
                    {
                        SaveData();
                        PerPicture.Image = null;
                        PerPicture.Dispose();
                        System.Globalization.CultureInfo TypeOfLanguage = new System.Globalization.CultureInfo("en"); // or "fa-IR" for Farsi(Iran)
                        InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(TypeOfLanguage);
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void دربارهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm ShowForm = new AboutForm
            {
                Owner = this
            };
            ShowForm.ShowDialog(this);
        }

        public void مرخصیساعتیجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimeLeaveRegisterForm ShowForm = new TimeLeaveRegisterForm();
            ShowForm.ShowDialog(this);
            // OpenChildForm(new TimeLeaveRegisterForm());
        }

        public void اولویتتریپرزروهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReserveTripForm ShowForm = new ReserveTripForm();
            ShowForm.ShowDialog(this);
        }

        public void جدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonalRegisterForm ShowForm = new PersonalRegisterForm();
            ShowForm.ShowDialog(this);
        }

        public void کاربرجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserRegisterForm ShowForm = new UserRegisterForm();
            ShowForm.ShowDialog(this);
        }

        public void اضافهکارگزارشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OvertimeReportForm ShowForm = new OvertimeReportForm();
            ShowForm.ShowDialog(this);
        }

        public void ثبتجدولحرکتیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TerminalTableRegForm ShowForm = new TerminalTableRegForm
            {
                Importting = false
            };
            ShowForm.ShowDialog(this);
        }

        public void ثبتجدولحرکتیازفایلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TerminalTableRegForm ShowForm = new TerminalTableRegForm
            {
                Importting = true
            };
            ShowForm.ShowDialog(this);
        }

        public void پرسنلویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonalEditForm ShowForm = new PersonalEditForm();
            ShowForm.ShowDialog(this);
        }

        public void تغییرکلمهعبورToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasswordChangeForm ShowForm = new PasswordChangeForm();
            ShowForm.Show(this);
        }

        public void پرسنلگزارشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonalListForm ShowForm = new PersonalListForm();
            ShowForm.ShowDialog(this);
        }

        public void امتیازانضباطیثبتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FunctionRegisterForm ShowForm = new FunctionRegisterForm();
            ShowForm.ShowDialog(this);
        }

        public void امتیازانضباطیویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FunctionEditForm ShowForm = new FunctionEditForm();
            ShowForm.ShowDialog(this);
        }

        public void امتیازانضباطیگزارشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FunctionReportForm ShowForm = new FunctionReportForm();
            ShowForm.ShowDialog(this);
        }

        public void لیستکاربرانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersListForm ShowForm = new UsersListForm();
            ShowForm.ShowDialog(this);
        }

        public void الگویتریپراهبرانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TerminalPatternRegForm ShowForm = new TerminalPatternRegForm();
            ShowForm.ShowDialog(this);
        }

        public void عملکردفنیثبتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TechnicalFunctionRegForm ShowForm = new TechnicalFunctionRegForm();
            ShowForm.ShowDialog(this);
        }

        public void عملکردفنیگزارشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TechnicalFunctionReportForm ShowForm = new TechnicalFunctionReportForm();
            ShowForm.ShowDialog(this);
        }

        public void مرخصیساعتیویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimeLeaveEditForm ShowForm = new TimeLeaveEditForm();
            ShowForm.ShowDialog(this);
        }

        public void اضافهکارشیفتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShiftOvertimeForm ShowForm = new ShiftOvertimeForm();
            ShowForm.ShowDialog(this);
        }

        public void آخرینتغییراتپرسنلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LastPersonChangeForm ShowForm = new LastPersonChangeForm();
            ShowForm.ShowDialog(this);
        }

        public void تقویمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalendarForm ShowForm = new CalendarForm();
            ShowForm.ShowDialog(this);
        }

        public void مجموعکارکردماهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MonthlyOperatingForm ShowForm=new MonthlyOperatingForm();
            //ShowForm.ShowDialog(this);
        }

        public void اولویترزروراهبران9ساعتهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reserve9Form ShowForm = new Reserve9Form();
            ShowForm.ShowDialog(this);
        }

        private void راهبرانقبلازپردازشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DailyLeaveRegisterOpratorForm ShowForm = new DailyLeaveRegisterOpratorForm();
            ShowForm.ShowDialog(this);
        }

        public void درخواستاضافهکارجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OvertimeRequestRegForm ShowForm = new OvertimeRequestRegForm();
            ShowForm.ShowDialog(this);
        }

        private void همهپرسنلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DailyLeaveRegisterAllForm ShowForm = new DailyLeaveRegisterAllForm();
            ShowForm.ShowDialog(this);
        }

        public void جابجاییتریپراهبرانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TripHandlingForm ShowForm = new TripHandlingForm();
            ShowForm.ShowDialog(this);
        }

        public void اضافهکارجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OvertimeRegisterForm ShowForm = new OvertimeRegisterForm();
            ShowForm.ShowDialog(this);
        }

        public void مرخصیساعتیگزارشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimeLeaveReportForm ShowForm = new TimeLeaveReportForm();
            ShowForm.ShowDialog(this);
        }

        public void گزارشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DailyLeaveReportForm ShowForm = new DailyLeaveReportForm();
            ShowForm.ShowDialog(this);
        }

        public void درخواستاضافهکارگزارشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OvertimeRequestReportForm ShowForm = new OvertimeRequestReportForm();
            ShowForm.ShowDialog(this);
        }

        public void راهبرانرزروToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReserveReportForm ShowForm = new ReserveReportForm();
            ShowForm.ShowDialog(this);
        }

        public void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DailyLeaveEditForm ShowForm = new DailyLeaveEditForm();
            ShowForm.ShowDialog(this);
        }

        public void اضافهکارویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OvertimeEditForm ShowForm = new OvertimeEditForm();
            ShowForm.ShowDialog(this);
        }

        public void درخواستاضافهکارویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OvertimeRequestEditForm ShowForm = new OvertimeRequestEditForm();
            ShowForm.ShowDialog(this);
        }

        public void گزارشامتیازنرمافزارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagePerformanceReportForm ShowForm = new ManagePerformanceReportForm();
            ShowForm.ShowDialog(this);
        }

        public void سقفاضافهکارپرسنلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OvertimeLimitForm ShowForm = new OvertimeLimitForm();
            ShowForm.ShowDialog(this);
        }

        public void پردازشماهانهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OptimizationForm ShowForm = new OptimizationForm();
            ShowForm.ShowDialog(this);
        }

        public void پردازشلوحهروزانهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TerminalDailyProcessForm ShowForm = new TerminalDailyProcessForm();
            ShowForm.ShowDialog(this);
        }

        public void رزرواضطراریراهبرانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReserveEmergencyForm ShowForm = new ReserveEmergencyForm();
            ShowForm.ShowDialog(this);
        }

        public void ریسترمزکاربرانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserPasswordResetForm ShowForm = new UserPasswordResetForm();
            ShowForm.ShowDialog(this);
        }

        public void طبقجدولاعزامToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TerminalTableTripRegForm ShowForm = new TerminalTableTripRegForm();
            ShowForm.ShowDialog(this);
        }

        public void رزروراهبران12ساعتهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reserve12Form ShowForm = new Reserve12Form();
            ShowForm.ShowDialog(this);
        }

        public void عملکردفنیویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TechnicalFunctionEditForm ShowForm = new TechnicalFunctionEditForm();
            ShowForm.ShowDialog(this);
        }

        public void امتیازراهبرانرزروToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageReservReportForm ShowForm = new ManageReservReportForm();
            ShowForm.ShowDialog(this);
        }

        public void ویرایشجدولحرکتیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TerminalTableEditForm ShowForm = new TerminalTableEditForm();
            ShowForm.ShowDialog(this);
        }

        public void اعلامخرابیثبتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FaultsRegisterForm ShowForm = new FaultsRegisterForm();
            ShowForm.ShowDialog(this);
        }

        public void گزارشامتیازپرسنلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageFunctionReportForm ShowForm = new ManageFunctionReportForm();
            ShowForm.ShowDialog(this);
        }

        public void ویرایشکشیکماهانهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KeshikEditForm ShowForm = new KeshikEditForm();
            ShowForm.ShowDialog(this);
        }

        public void لیستکشیکماهانهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KeshikReportForm ShowForm = new KeshikReportForm();
            ShowForm.ShowDialog(this);
        }

        public void جابجاییکشیکToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KeshikReplaceForm ShowForm = new KeshikReplaceForm();
            ShowForm.ShowDialog(this);
        }

        public void سابقهجابجاییشیفتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryPostForm ShowForm = new HistoryPostForm();
            ShowForm.ShowDialog(this);
        }

        public void اضافهکارگروهیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OverTimeGroupForm ShowForm = new OverTimeGroupForm();
            ShowForm.ShowDialog(this);
        }

        public void ویرایشمشخصاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserEditForm ShowForm = new UserEditForm();
            ShowForm.ShowDialog(this);
        }

        public void ثبتخودکارکشیکماهانهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KehsikAutoRegForm ShowForm = new KehsikAutoRegForm();
            ShowForm.ShowDialog(this);
        }

        public void درخواستکشیکماهانهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KeshikRequRegisterForm ShowForm = new KeshikRequRegisterForm();
            ShowForm.ShowDialog(this);
        }

        public void درخواستکشیکماهانهگزارشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KeshikRequReportForm ShowForm = new KeshikRequReportForm();
            ShowForm.ShowDialog(this);
        }

        public void پردازشلوحهروزانهToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form ShowForm = new DailyTripProcessForm();
            ShowForm.ShowDialog(this);
        }

        public void تکتریپToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TripSpecialRegisterForm ShowForm = new TripSpecialRegisterForm();
            ShowForm.ShowDialog(this);
        }
        public void گزارشآمارماهانهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonalDetailReportForm ShowForm = new PersonalDetailReportForm();
            ShowForm.ShowDialog(this);
        }
        public void گزارشآمارماهانهپرسنلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagePersonStatReportForm ShowForm = new ManagePersonStatReportForm();
            ShowForm.ShowDialog(this);
        }

        public void گزارشتفکیکیاضافهکارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageOverTimeDetailForm ShowForm = new ManageOverTimeDetailForm();
            ShowForm.ShowDialog(this);
        }

        public void تریپهایخاصToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TripSpecialReportForm ShowForm = new TripSpecialReportForm();
            ShowForm.ShowDialog(this);
        }

        public void گزارشآماریشیفتهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageShiftStatisticsForm ShowForm = new ManageShiftStatisticsForm();
            ShowForm.ShowDialog(this);
        }

        public void پارامترهایپردازشلوحهویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DailyProcessParametrEditForm ShowForm = new DailyProcessParametrEditForm();
            ShowForm.ShowDialog(this);
        }

        public void اولویتاضافهکارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OvertimePickerForm ShowForm = new OvertimePickerForm();
            ShowForm.ShowDialog(this);
        }

        public void اولویترزروراهبرانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReserveShiftTurnForm ShowForm = new ReserveShiftTurnForm();
            ShowForm.ShowDialog(this);
        }

        public void ثبتنسخهجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateRegisterForm ShowForm = new UpdateRegisterForm();
            ShowForm.ShowDialog(this);
        }

        public void آمارراهبراندرکشیکماهانهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageKeshikReport ShowForm = new ManageKeshikReport();
            ShowForm.ShowDialog(this);
        }

        public void اطلاعیهآموزشیثبتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnnounceRegisterForm ShowForm = new AnnounceRegisterForm();
            ShowForm.ShowDialog(this);
        }

        public void نمایشاطلاعیههاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnnounceShowForm ShowForm = new AnnounceShowForm();
            ShowForm.ShowDialog(this);
        }

        public void آمارکشیکراهبرانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageKeshikReport ShowForm = new ManageKeshikReport();
            ShowForm.ShowDialog(this);
        }

        public void گزارشاطلاعیههاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnnounceReportForm ShowForm = new AnnounceReportForm();
            ShowForm.ShowDialog(this);
        }

        public void ثبتلوحهاعزامToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TripAnalyzeForm ShowForm = new TripAnalyzeForm();
            ShowForm.ShowDialog(this);
        }

        public void تغییراتلوحهاعزامToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // اصلاح
            //ImportFinallLovhehForm.Show()
        }

        public void PhoneBox_Click(object sender, EventArgs e)
        {
            PhoneBookForm ShowForm = new PhoneBookForm();
            ShowForm.ShowDialog(this);
        }

        public void مجوزویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PermisionEditForm ShowForm = new PermisionEditForm();
            ShowForm.ShowDialog(this);
        }

        public void مجوزگزارشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PermisionReportForm ShowForm = new PermisionReportForm();
            ShowForm.ShowDialog(this);
        }

        public void ثبتنظرسنجیجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExamRegisterForm ShowForm = new ExamRegisterForm();
            ShowForm.ShowDialog(this);
        }

        public void انجامنظرسنجیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExamShowForm ShowForm = new ExamShowForm();
            ShowForm.ShowDialog(this);
        }

        public void نتایجنظرسنجیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExamRportForm ShowForm = new ExamRportForm();
            ShowForm.ShowDialog(this);
        }

        public void LearningPicture_Click(object sender, EventArgs e)
        {

            Tables();
            //FormNu=86
            //KartableSelectForm.Show()
        }

        public void دورههایبازآموزیثبتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RetrainingClassRegForm ShowForm = new RetrainingClassRegForm();
            ShowForm.ShowDialog(this);
        }

        public void دورههایبازآموزیگزارشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RetrainingClassReportForm ShowForm = new RetrainingClassReportForm();
            ShowForm.ShowDialog(this);
        }

        public void پردازش2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DailyProcessADForm ShowForm = new DailyProcessADForm();
            ShowForm.ShowDialog(this);
        }

        public void پارامترهایپردازشلوحهجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DailyProcessParametrRegForm ShowForm = new DailyProcessParametrRegForm();
            ShowForm.ShowDialog(this);
        }

        public void MoreTripButton_Click(object sender, EventArgs e)
        {
            TripReportForm ShowForm = new TripReportForm
            {
                MoreTrip = true
            };
            ShowForm.ShowDialog(this);
        }

        public void تریپهایروزانهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TripReportForm ShowForm = new TripReportForm();
            ShowForm.ShowDialog(this);
        }

        public void کارکردروزانهراهبرانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DailyOperatorForm ShowForm = new DailyOperatorForm();
            ShowForm.ShowDialog(this);
        }

        public void بهینهسازیراهبرانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OptimizOperatorForm ShowForm=new OptimizOperatorForm();
            //ShowForm.ShowDialog(this);
        }

        public void کارکردماهانهراهبرانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MonthlyOperatorsForm ShowForm=new MonthlyOperatorsForm();
            //ShowForm.ShowDialog(this);
        }

        public void خارجازجدولاعزامToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TerminalTripRegisterForm ShowForm = new TerminalTripRegisterForm();
            ShowForm.ShowDialog(this);
        }

        public void عملیاتقطارگزارشعملیاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TerminalTripReportForm ShowForm = new TerminalTripReportForm();
            ShowForm.ShowDialog(this);
        }

        public void عملیاتقطارگزارشراهبریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TerminalAllTripReportForm ShowForm = new TerminalAllTripReportForm();
            ShowForm.ShowDialog(this);
        }

        public void DayTrip1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //DayTrip1.Sort(DayTrip1.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
        }

        public void آرایشناوگانثبتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavganRegForm ShowForm = new NavganRegForm();
            ShowForm.ShowDialog(this);
        }

        public void آرایشناوگانگزارشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavganReportForm ShowForm = new NavganReportForm();
            ShowForm.ShowDialog(this);
        }

        public void تریپجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TripCompileForm ShowForm = new TripCompileForm();
            ShowForm.ShowDialog(this);
        }

        public void نمودارمرخصیروزانهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DailyLeaveGraphForm ShowForm = new DailyLeaveGraphForm();
            ShowForm.ShowDialog(this);
        }

        public void ویرایشمشخصاتفردیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonalDetailForm ShowForm = new PersonalDetailForm();
            ShowForm.ShowDialog(this);
        }

        public void عملیاتقطارویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TerminalTripEditForm ShowForm = new TerminalTripEditForm();
            ShowForm.ShowDialog(this);
        }

        public void آرایشناوگانویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavganEditForm ShowForm = new NavganEditForm();
            ShowForm.ShowDialog(this);
        }

        public void پارامترهایپردازشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TerminalParametrForm ShowForm = new TerminalParametrForm();
            ShowForm.ShowDialog(this);
        }

        public void مجموعتریپراهبرانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TripTotalReportForm ShowForm = new TripTotalReportForm();
            ShowForm.ShowDialog(this);
        }

        public void ثبتلوحهاولیهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TripImportPrimeForm ShowForm = new TripImportPrimeForm();
            ShowForm.ShowDialog(this);
        }

        public void ثبتلوحهاجراشدهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TripImportExecutForm ShowForm = new TripImportExecutForm();
            ShowForm.ShowDialog(this);
        }

        public void ثبتلوحهنهاییToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TripImportFinalForm ShowForm = new TripImportFinalForm();
            ShowForm.ShowDialog(this);
        }

        public void گزارشلوحهثبتشدهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TripLovhehReportForm ShowForm = new TripLovhehReportForm();
            ShowForm.ShowDialog(this);
        }

        public void وضعیتپارکینگToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParkingReportForm ShowForm = new ParkingReportForm();
            ShowForm.ShowDialog(this);
        }

        public void تاریخچهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavganHistorForm ShowForm = new NavganHistorForm();
            ShowForm.ShowDialog(this);
        }

        public void ثبتمانورجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TerminalManoverRegForm ShowForm = new TerminalManoverRegForm();
            ShowForm.ShowDialog(this);
        }

        public void تریپدرشیفتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TripInShiftReportForm ShowForm = new TripInShiftReportForm();
            ShowForm.ShowDialog(this);
        }

        public void ثبتانتخاباتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ElectionRegisterForm ShowForm = new ElectionRegisterForm();
            ShowForm.ShowDialog(this);
        }

        public void شرکتدرانتخاباتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ElectionPartyForm ShowForm = new ElectionPartyForm();
            ShowForm.ShowDialog(this);
        }

        public void نتیجهانتخاباتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ElectionResultForm ShowForm = new ElectionResultForm();
            ShowForm.ShowDialog(this);
        }

        public void آلبومپرسنلیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonalAlbumForm ShowForm = new PersonalAlbumForm();
            ShowForm.ShowDialog(this);
        }

        public void محاسبهکارکردجدیدپرسنلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonthlyOperAdvForm ShowForm = new MonthlyOperAdvForm();
            ShowForm.ShowDialog(this);
        }

        public void تقویمکاریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalendarFormAD ShowForm = new CalendarFormAD();
            ShowForm.ShowDialog(this);
        }

        public void اطلاعیهالکترونیکToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BoradNatifRegForm ShowForm = new BoradNatifRegForm();
            ShowForm.ShowDialog(this);
        }

        public void مرخصیروزانهجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DailyLeaveRegisterOpratorForm ShowForm = new DailyLeaveRegisterOpratorForm();
            //DailyLeaveRegisterForm ShowForm=new DailyLeaveRegisterForm();
            ShowForm.ShowDialog(this);
        }

        public void عملکردروزانهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyDailyOperationForm ShowForm = new MyDailyOperationForm();
            ShowForm.ShowDialog(this);
        }

        public void تحویلوتحولقطارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrainExchangeForm ShowForm = new TrainExchangeForm();
            ShowForm.ShowDialog(this);
        }

        public void پردازشلوحههشتگردToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DailyProcess8GRForm ShowForm=new DailyProcess8GRForm();
            //ShowForm.ShowDialog(this);
        }

        public void ورودمتفرقهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportExcelForm ShowForm = new ImportExcelForm();
            ShowForm.ShowDialog(this);
        }

        public void درخواستسرویسToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServiceRequestForm ShowForm = new ServiceRequestForm();
            ShowForm.ShowDialog(this);
        }

        public void نمودارروزانهاضافهکارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OvertimeGraphForm ShowForm = new OvertimeGraphForm();
            ShowForm.ShowDialog(this);
        }

        public void عملکردروزانهراهبرانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TripDailyReportForm ShowForm = new TripDailyReportForm();
            ShowForm.ShowDialog(this);
        }

        public void بهینهسازیتریپToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string StartDate = "";
                string EndDate = "";
                Taghvim PersianDate = new Taghvim(PersianToday.Tarikh());

                int Trips = 0;
                int i;
                DataTable PerTabl = new DataTable();

                using (WaitForm wait = new WaitForm())
                {
                    wait.Show();
                    wait.Refresh();

                    using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();

                        for (i = 0; i <= 5; i++)
                        {
                            PerTabl.Clear();
                            PersianDate.AddMonth(-1);
                            StartDate = PersianDate.FirstOfThisMonth();
                            EndDate = PersianDate.EndOfThisMonth();

                            string ss = "SELECT * FROM TotaMonAdv WHERE Maah='" + PersianToday.Tarikh().Substring(0, 7) + "'";
                            OleDbDataAdapter Adap = new OleDbDataAdapter(ss, StrConnec);
                            Adap.Fill(PerTabl);
                            Adap.Dispose();

                            foreach (DataRow DtR in PerTabl.Select())
                            {
                                Trips = 0;
                                using (OleDbCommand CMD = new OleDbCommand("SELECT COUNT(ID) AS Trip FROM DailyTrip WHERE (O1_Num='" + DtR["P_Num"].ToString() + "' OR O2_Num='" + DtR["P_Num"].ToString() + "' OR OT_Num='" + DtR["P_Num"].ToString() + "') AND Tarikh BETWEEN '" + StartDate + "' AND '" + EndDate + "' AND Vis=True AND Final=True", StrConnec))
                                using (OleDbDataReader Reader = CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                    {
                                        Trips = Convert.ToInt32(Reader["Trip"]);
                                    }
                                }

                                using (OleDbCommand CMD = new OleDbCommand("UPDATE TotaMonAdv SET Trips= " + Trips + " WHERE P_Num='" + DtR["P_Num"].ToString() + "' AND Maah='" + StartDate.Substring(0, 7) + "'", StrConnec))
                                {
                                    CMD.ExecuteNonQuery();
                                }
                            }
                        }

                    }

                    wait.Close();
                }
            }
            catch (Exception ex)
            {
                ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
            }
        }

        public void تماسباادمینToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnnounceRegisterForm ShowForm = new AnnounceRegisterForm();
            ShowForm.KindCombo.Items.Add("ارسال به ادمین");
            ShowForm.KindCombo.SelectedItem = "ارسال به ادمین";
            ShowForm.KindCombo.Enabled = false;
            ShowForm.ShowDialog(this);
        }

        public void بارگذاریمجدددادههاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
            {
                StrConnec.Open();
                PersonRead(StrConnec);
            }

        }

        public void ErorrLogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ErrorLogoBox.Visible)
            {
                ErrorLogoBox.Visible = false;
            }
            else
            {
                ErrorLogoBox.Visible = true;
            }
        }

        public void MainTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                PersianToday.SetDate(DateTime.Today);
                string Tarikh = PersianToday.DayWeek() + " " + PersianToday.Day() + " " + PersianToday.MonthName() + " ماه " + PersianToday.Year();
                if (DateLabel.Text != Tarikh)
                {
                    DateLabel.Text = Tarikh;
                    //If StatusStrip1.Visible Then LoginForm.Tables()
                    //TripPrimView1.Rows.Clear();
                    //TripPrimView2.Rows.Clear();
                    //TripFinalView1.Rows.Clear();
                    //TripFinalView2.Rows.Clear();
                }

                if (AppState.UserPnum != "")
                {
                    if (Odd)
                    {
                        HistChecker();
                    }
                    else
                    {
                        //if (TripTab.Visible || TripShowButton.Visible) 
                        if (AppState.UserLevel < 9)
                        {
                            TripChecker();
                        }
                    }
                    MainTimer.Interval = 30000;
                    Odd = !Odd;
                }

            }
            catch (Exception ex)
            {
                ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void کمکToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // MessageBoxFa.Show("!این صفحه دردسترس نیست", "توجه", MessageBoxIcon.Hand)
            // HelpForm.Show()
            Help.ShowHelp(this, AppState.DatabasePath + "\\help.chm");
        }

        public void MainForm_Resize(object sender, EventArgs e)
        {
            //if (Convert.ToInt32((double)(Height - Panel1.Height - 40) / 2) < 29)
            //    Panel1.Top=20;
            //else
            //    Panel1.Top=Convert.ToInt32((double)(Height - Panel1.Height - 40) / 2);

            NameStatusLabel.Width = Convert.ToInt32(Width * 0.17);
            PostStatusLabel.Width = Convert.ToInt32(Width * 0.23);
            LineStatusLabel.Width = Convert.ToInt32(Width * 0.15);
            AdrsStatusLabel.Width = Convert.ToInt32(Width * 0.15);//20
            DateStatusLabel.Width = Convert.ToInt32(Width * 0.15);
            VersStatusLabel.Width = Convert.ToInt32(Width * 0.12);
        }

        public void اجرایمجددToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShClose = true;
            Application.Restart();
        }

        private void DateLabel_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CalendarFormAD());
        }

        private void PhoneLabel_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PhoneBookForm());
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            ErrorLogoBox.Text = ErrorLogo;
        }
    }
}
