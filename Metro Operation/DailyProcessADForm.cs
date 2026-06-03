using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class DailyProcessADForm
    {
        public DailyProcessADForm()
        {
            InitializeComponent();
        }


        private string ProceString;
        private string ProcessName;
        private string UserName;
        private string Local1;
        private string Local2;
        private string Shift0;
        private string Shift1;
        private string Shift2;
        private string YesterDay;
        //private bool OverBool; //Showed,
        private bool Holy;
        // private bool Processed;
        public static string Tarikh;

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void ProcessEnable()
        {
            if (Kasr12R1Box.BackColor == Color.Lime && Kasr12S1Box.BackColor == Color.Lime && Kasr9S1Box.BackColor == Color.Lime && Kasr9A1Box.BackColor == Color.Lime && KasrSet1Box.BackColor == Color.Lime && Kasr12R2Box.BackColor == Color.Lime && Kasr12S2Box.BackColor == Color.Lime && Kasr9S2Box.BackColor == Color.Lime && Kasr9A2Box.BackColor == Color.Lime && KasrSet2Box.BackColor == Color.Lime)
            {
                ProcessButton.Enabled = true;
            }
            else
            {
                ProcessButton.Enabled = false;
            }
        }

        public bool ProcessChecker(string DayProcess, string LineNum)
        {
            bool Process = false;

            using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
            {
                StrConnec.Open();
                using (OleDbCommand CMD = new OleDbCommand($"SELECT U_Reg, P_Mod, Mem FROM DailyProcess WHERE Tarikh='{DayProcess}' AND L_Num='{LineNum}' AND Vis=True", StrConnec))
                using (OleDbDataReader Reader = CMD.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        Process = true;
                        UserName = Reader["U_Reg"].ToString();
                        ProcessName = Reader["P_Mod"].ToString();
                        ProceString = Reader["Mem"].ToString();
                    }
                }
            }

            return Process;
        }

        public bool ImportChecker(string TripDay)
        {
            bool Process = false;

            using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
            {
                StrConnec.Open();
                using (OleDbCommand CMD = new OleDbCommand($"SELECT Tarikh FROM DailyTripReg WHERE Tarikh='{TripDay}' AND Vis=True AND T_Type='لوحه اجرا شده'", StrConnec))
                using (OleDbDataReader Reader = CMD.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        Process = true;
                    }
                }
            }

            return Process;
        }

        public string ShiftCounter(string ShiftTime, string ShiftName, string ShiftLocal)
        {
            try
            {
                int i;

                string SelQue = $" P_Post='راهبر قطار' AND Shift_Time='{ShiftTime}' AND Shift_Loc ='{ShiftLocal}' AND Vis=True And Line_Num='{AppState.UserLnum}' AND Trip=True AND Shift_name='{ShiftName}'";
                DataRow[] DRow = MainForm.PersonTable.Select(SelQue);
                i = DRow.Count();

                using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    using (OleDbCommand CMD = new OleDbCommand($"SELECT COUNT(Person.Family) AS Cou FROM Rezerv INNER JOIN Person ON Person.P_Num=Rezerv.P_Num WHERE Person.P_Post='راهبر قطار' AND Person.Shift_Time='{ShiftTime}' AND Person.Shift_Loc ='{ShiftLocal}' AND Person.Vis=True AND Person.Trip=True AND Person.Line_Num='{AppState.UserLnum}' AND Rezerv.Vis=True AND (Rezerv.Mem LIKE 'اضطراری%' OR Rezerv.Mem='شانتر' OR Rezerv.Mem LIKE 'غیر فعال%') AND Rezerv.Tarikh='{PersianCalendar.Text}' AND Shift_name='{ShiftName}'", StrConnec))
                    using (OleDbDataReader Reader = CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            i -= Convert.ToInt32(Reader["Cou"]);
                        }
                    }

                    using (OleDbCommand CMD = new OleDbCommand($"SELECT COUNT(Person.Family) AS Cou FROM TakTrip INNER JOIN Person ON Person.P_Num=TakTrip.P_Num WHERE Person.Shift_Time='{ShiftTime}' AND Person.Shift_Loc ='{ShiftLocal}' AND Person.Vis=True AND Person.Line_Num='{AppState.UserLnum}' AND TakTrip.Vis=True AND TakTrip.Trip='هشتگرد' AND TakTrip.Tarikh='{PersianCalendar.Text}' AND Shift_name='{ShiftName}'", StrConnec))
                    using (OleDbDataReader Reader = CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            i -= Convert.ToInt32(Reader["Cou"]);
                        }
                    }
                }

                return i.ToString();
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show($"لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
                return string.Empty;
            }
        }

        public string KeshikCounter(string KeshikTime, string KeshikLocal)
        {
            try
            {
                int i = 0;
                using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();

                    using (OleDbCommand CMD = new OleDbCommand($"SELECT COUNT(P_Num) AS Cou FROM Keshik WHERE Tarikh='{PersianCalendar.Text}' AND T_Keshik='{KeshikTime}' AND L_Keshik ='{KeshikLocal}' AND Vis=True", StrConnec))
                    using (OleDbDataReader Reader = CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            i = Convert.ToInt32(Reader["Cou"].ToString());
                        }
                    }
                }

                return i.ToString();
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show($"لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
                return string.Empty;
            }
        }

        public string LeaveCounter(string LeaveTime, string LeaveShift, string LeaveLocal)
        {
            try
            {
                int i = 0;
                using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    string StrQuer = $"SELECT COUNT(Person.Family) AS Cou FROM Morakhasi INNER JOIN Person ON Person.P_Num=Morakhasi.P_Num WHERE Person.P_Post='راهبر قطار' AND Person.Trip=True AND Person.Shift_Loc ='{LeaveLocal}' AND Person.Vis=True AND Person.Shift_Time='{LeaveTime}' AND Person.Line_Num='{AppState.UserLnum}' AND Morakhasi.Vis=True AND Morakhasi.Tarikh='{PersianCalendar.Text}'";

                    if (LeaveShift != "")
                    {
                        StrQuer += $" AND Person.Shift_name='{LeaveShift}'";
                    }

                    using (OleDbCommand CMD = new OleDbCommand(StrQuer, StrConnec))
                    using (OleDbDataReader Reader = CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            i = Convert.ToInt32(Reader["Cou"]);
                        }
                    }
                }

                return i.ToString();
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show($"لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
                return string.Empty;
            }
        }

        public string ClassCounter(string ClassTime, string ClassShift, string ClassLocal)
        {
            try
            {
                int i = 0;

                using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    string StrQuer = $"SELECT COUNT(Person.Family) AS Cou FROM Retraining INNER JOIN Person ON Person.P_Num=Retraining.P_Num WHERE Person.P_Post='راهبر قطار' AND Person.Trip=True AND Person.Shift_Loc ='{ClassLocal}' AND Person.Vis=True AND Person.Shift_Time='{ClassTime}' AND Person.Line_Num='{AppState.UserLnum}' AND Retraining.Vis=True AND Retraining.Tarikh='{PersianCalendar.Text}'";

                    if (ClassShift != "")
                    {
                        StrQuer += $" AND Person.Shift_name='{ClassShift}'";
                    }

                    using (OleDbCommand CMD = new OleDbCommand(StrQuer, StrConnec))
                    using (OleDbDataReader Reader = CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            i = Convert.ToInt32(Reader["Cou"]);
                        }
                    }
                }

                return i.ToString();
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show($"لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
                return string.Empty;
            }
        }

        public void Reserv(string ResLocal, string ShiftTime, string ShiftName, int ResNum)
        {
            try
            {
                int i;
                string ResShift = "";
                Taghvim PersianDate = new Taghvim(PersianCalendar.Text);
                PersianDate.AddMonth(-2);

                if (ShiftName == Shift2)
                {
                    if (ShiftTime == "12 ساعته")
                    {
                        ResShift = "شب";
                    }
                    else
                    {
                        ResShift = "عصر";
                    }
                }
                else
                {
                    if (ShiftTime == "12 ساعته")
                    {
                        ResShift = "روز";
                    }
                    else
                    {
                        ResShift = "صبح";
                    }
                }

                DetailGridView.Rows.Clear();

                string SelQue = $"Shift_Time='{ShiftTime}' AND P_Post='راهبر قطار' AND Shift_Loc='{ResLocal}' AND Line_Num='{AppState.UserLnum}' AND Vis=True AND Reserv=True AND Trip=True AND Shift_name='{ShiftName}'";
                DataRow[] DRow = MainForm.PersonTable.Select(SelQue);
                foreach (DataRow DtR in DRow)
                {
                    DetailGridView.Rows.Add(DtR["Fname"].ToString(), DtR["Family"].ToString(), DtR["P_Num"].ToString(), 0.0);
                }

                using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();

                    using (OleDbCommand CMD = new OleDbCommand($"SELECT Person.P_Num FROM Morakhasi INNER JOIN Person ON Person.P_Num=Morakhasi.P_Num WHERE Person.Shift_Time='{ShiftTime}' AND Person.Shift_Loc='{ResLocal}' AND Person.Line_Num='{AppState.UserLnum}' AND Morakhasi.Tarikh='{PersianCalendar.Text}' AND Morakhasi.Vis=True AND Person.Shift_name='{ShiftName}'", StrConnec))
                    using (OleDbDataReader Reader = CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            i = 0;
                            while (i <= DetailGridView.Rows.Count - 1)
                            {
                                if (Reader["P_Num"].ToString() == DetailGridView.Rows[i].Cells[2].Value.ToString())
                                {
                                    DetailGridView.Rows.RemoveAt(i);
                                }
                                else
                                {
                                    i++;
                                }
                            }
                        }
                    }

                    using (OleDbCommand CMD = new OleDbCommand($"SELECT Person.P_Num FROM Retraining INNER JOIN Person ON Person.P_Num=Retraining.P_Num WHERE Person.Shift_Time='{ShiftTime}' AND Person.Shift_Loc='{ResLocal}' AND Person.Line_Num='{AppState.UserLnum}' AND Retraining.Tarikh='{PersianCalendar.Text}' AND Retraining.Vis=True AND Person.Shift_name='{ShiftName}'", StrConnec))
                    using (OleDbDataReader Reader = CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            i = 0;
                            while (i <= DetailGridView.Rows.Count - 1)
                            {
                                if (Reader["P_Num"].ToString() == DetailGridView.Rows[i].Cells[2].Value.ToString())
                                {
                                    DetailGridView.Rows.RemoveAt(i);
                                }
                                else
                                {
                                    i++;
                                }
                            }
                        }
                    }

                    using (OleDbCommand CMD = new OleDbCommand($"SELECT Person.P_Num FROM TakTrip INNER JOIN Person ON Person.P_Num=TakTrip.P_Num WHERE Person.Shift_Time='{ShiftTime}' AND Person.Shift_Loc ='{ResLocal}' AND Person.Vis=True AND Person.Line_Num='{AppState.UserLnum}' AND TakTrip.Vis=True AND TakTrip.Trip='هشتگرد' AND TakTrip.Tarikh='{PersianCalendar.Text}' AND Shift_name='{ShiftName}'", StrConnec))
                    using (OleDbDataReader Reader = CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            i = 0;
                            while (i <= DetailGridView.Rows.Count - 1)
                            {
                                if (Reader["P_Num"].ToString() == DetailGridView.Rows[i].Cells[2].Value.ToString())
                                {
                                    DetailGridView.Rows.RemoveAt(i);
                                }
                                else
                                {
                                    i++;
                                }
                            }
                        }
                    }

                    using (OleDbCommand CMD = new OleDbCommand($"SELECT Person.Fname, Person.Family, Person.P_Num, Rezerv.R_Shift, Rezerv.Loca, Rezerv.Mem, Rezerv.Vis FROM Rezerv INNER JOIN Person ON Person.P_Num=Rezerv.P_Num WHERE Rezerv.Tarikh='{PersianCalendar.Text}' AND Rezerv.Vis=True AND Person.Shift_Time='{ShiftTime}' AND Person.Shift_Loc='{ResLocal}' AND Person.Line_Num='{AppState.UserLnum}' AND Person.Shift_name='{ShiftName}'", StrConnec))
                    using (OleDbDataReader Reader = CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            if (!(Reader["Mem"].ToString().IndexOf($"اضطراری") + 1 > 0))
                            {
                                ResNum--;
                            }

                            i = 0;
                            while (i < DetailGridView.RowCount)
                            {
                                if (Reader["P_Num"].ToString() == DetailGridView.Rows[i].Cells[2].Value.ToString())
                                {
                                    DetailGridView.Rows.RemoveAt(i);
                                    break;
                                }
                                else
                                {
                                    i++;
                                }
                            }
                        }
                    }

                    if (ResNum <= 0)
                    {
                        return;
                    }

                    for (i = 0; i <= DetailGridView.RowCount - 1; i++)
                    {
                        int Emer = 0;
                        int Rez = 0;
                        double Emt = 0;
                        double LastRez = 0;
                        DateTime SelectDate;
                        DateTime Dat;
                        SelectDate = ConvertClass.ShamsiToMiladi(PersianCalendar.Text);

                        Emer = 0;
                        Rez = 0;
                        Emt = 0;
                        LastRez = 0;

                        using (OleDbCommand CMD = new OleDbCommand($"SELECT * FROM Rezerv WHERE P_Num='{DetailGridView.Rows[i].Cells[2].Value}' AND Tarikh BETWEEN '{PersianCalendar.Text}' AND '{PersianDate.Tarikh()}' AND Vis=True AND Mem<>'شانتر'", StrConnec))
                        using (OleDbDataReader Reader = CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                Dat = ConvertClass.ShamsiToMiladi(Reader["Tarikh"].ToString());
                                LastRez = (double)Convert.ToInt32(Reader["Tarikh"].ToString().Substring(2, 8).Replace($"/", "")) / 1000000;
                                if (Reader["Mem"].ToString().IndexOf($"اضطراری") + 1 > 0 || Reader["Mem"].ToString().IndexOf($"غیر فعال") + 1 > 0)
                                {
                                    Emer++;
                                }
                                else
                                {
                                    Rez++;
                                }

                                if (Dat == SelectDate.AddDays(-1))
                                {
                                    Emt += 2;
                                }
                                else if (Dat == SelectDate.AddDays(-2))
                                {
                                    Emt += 1.5;
                                }
                                else if (Dat == SelectDate.AddDays(-3))
                                {
                                    Emt++;
                                }
                                else if (Dat == SelectDate.AddDays(-4))
                                {
                                    Emt += 0.5;
                                }
                            }
                        }

                        using (OleDbCommand CMD = new OleDbCommand($"SELECT * FROM Morakhasi WHERE P_Num='{DetailGridView.Rows[i].Cells[2].Value}' AND Vis=True AND Tarikh BETWEEN '{PersianCalendar.Text}' AND '{PersianDate.Tarikh()}'", StrConnec))
                        using (OleDbDataReader Reader = CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                Dat = ConvertClass.ShamsiToMiladi(Reader["Tarikh"].ToString());
                                if (Dat == SelectDate.AddDays(-1))
                                {
                                    Emt += 2;
                                }
                                else if (Dat == SelectDate.AddDays(-2))
                                {
                                    Emt++;
                                }
                            }
                        }

                        DetailGridView.Rows[i].Cells[3].Value = Emt + Rez + Emer + LastRez;
                    }

                    DetailGridView.Sort(DetailGridView.Columns[3], System.ComponentModel.ListSortDirection.Ascending);

                    if (ResNum <= DetailGridView.RowCount)
                    {
                        for (i = 0; i <= ResNum - 1; i++)
                        {
                            using (OleDbCommand CMD = new OleDbCommand($"INSERT INTO Rezerv (P_NUM, Tarikh, R_Shift, Loca, U_Reg, Vis, Mem) VALUES ('{DetailGridView.Rows[i].Cells[2].Value}','{PersianCalendar.Text}', '{ResShift}', '{ResLocal}', '{AppState.UserName}', True, 'عادی')", StrConnec))
                            {
                                CMD.ExecuteNonQuery();
                            }
                        }
                    }
                    else
                    {
                        StrConnec.Close();
                        MessageBoxFa.Show($"راهبران {ShiftTime} {ResShift} {ResLocal} از تعداد رزروهای مورد نیاز کمتر است", "خطا", MessageBoxIcon.Error);
                        return;
                    }
                }


            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show($"لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void OverTimeTable(string Shift, string Local)
        {
            try
            {
                int i;
                double TopOver = 0;
                double Overtime = 0;
                double Emt = 0;
                bool Find = false;

                DetailGridView.Rows.Clear();

                TopOver = 0;
                using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();

                    using (OleDbCommand CMD = new OleDbCommand($"SELECT MonthTime FROM ShKar WHERE Tarikh='{PersianCalendar.Text.Substring(0, 7)}'", StrConnec))
                    using (OleDbDataReader Reader = CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            TopOver = ConvertClass.TimeToDouble(Reader["MonthTime"].ToString());
                        }
                    }

                    using (OleDbCommand CMD = new OleDbCommand($"SELECT Person.Fname, Person.Family, Person.P_Num FROM JayGozin INNER JOIN Person ON Person.P_Num=JayGozin.P_Num WHERE JayGozin.Tarikh='{PersianCalendar.Text}' AND JayGozin.Vis=True AND JayGozin.Shift_Loc='{Local}' AND Person.Line_Num='{AppState.UserLnum}' AND Person.Trip=True AND Person.OverTime=True AND (JayGozin.Olv1='{Shift}' OR JayGozin.Olv2='{Shift}' OR JayGozin.Olv3='{Shift}' OR JayGozin.Olv4='{Shift}')", StrConnec))
                    using (OleDbDataReader Reader = CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            Find = false;
                            if (Local == Local1)
                            {
                                for (i = 0; i <= DataGridView1.RowCount - 1; i++)
                                {
                                    if (Reader["P_Num"].ToString() == (string)DataGridView1.Rows[i].Cells[2].Value)
                                    {
                                        Find = true;
                                    }
                                }
                            }
                            else
                            {
                                for (i = 0; i <= DataGridView2.RowCount - 1; i++)
                                {
                                    if (Reader["P_Num"].ToString() == (string)DataGridView2.Rows[i].Cells[2].Value)
                                    {
                                        Find = true;
                                    }
                                }
                            }

                            if (!Find)
                            {
                                DetailGridView.Rows.Add(Reader["Fname"].ToString(), Reader["Family"].ToString(), Reader["P_Num"].ToString(), 0.0);
                            }
                        }
                    }

                    i = 0;
                    while (DetailGridView.RowCount > i)
                    {

                        Overtime = 0;
                        Emt = 0;
                        using (OleDbCommand CMD = new OleDbCommand($"SELECT * FROM Ezafeh WHERE ViS=True AND P_Num='{DetailGridView.Rows[i].Cells[2].Value}' AND Tarikh='{PersianCalendar.Text}' AND E_Kind<>'تشویقی' AND E_Kind<>'کلاس آموزشی' AND E_Kind<>'شیفت'", StrConnec))
                        using (OleDbDataReader Reader = CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                Emt += ConvertClass.TimeToDouble(Reader["E_Time"].ToString());
                            }
                        }

                        if (Emt > 11)
                        {
                            DetailGridView.Rows.RemoveAt(i);
                        }
                        else
                        {
                            Emt = 0;
                            using (OleDbCommand CMD = new OleDbCommand($"SELECT * FROM TotaMonAdv WHERE P_Num='{DetailGridView.Rows[i].Cells[2].Value}' AND Maah='{PersianCalendar.Text.Substring(0, 7)}'", StrConnec))
                            {
                                using (OleDbDataReader Reader = CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                    {
                                        if (Reader["Shift"].ToString() == "")
                                        {
                                            Overtime /= 0;
                                        }

                                        if (Reader["Shift"].ToString().Substring(2, 1) == "T")
                                        {
                                            Emt -= 20; //ShTime=7 Else ShTime=4
                                        }

                                        Overtime = ConvertClass.TimeToDouble(Reader["NexMo"].ToString()) + ConvertClass.TimeToDouble(Reader["Tota"].ToString()) + ConvertClass.TimeToDouble(Reader["TotaJom"].ToString());

                                    }
                                }
                            }

                            using (OleDbCommand CMD = new OleDbCommand($"SELECT * FROM Keshik WHERE Vis=True AND P_Num='{DetailGridView.Rows[i].Cells[2].Value}' AND Tarikh BETWEEN '{PersianCalendar.Text.Substring(0, 7)}/31' AND '{PersianCalendar.Text.Substring(0, 7)}/01'", StrConnec))
                            {
                                using (OleDbDataReader Reader = CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                    {
                                        // Kesh += 1
                                        Emt -= 6.5;
                                        if (ConvertClass.ShamsiToMiladi(Reader["Tarikh"].ToString()) == ConvertClass.ShamsiToMiladi(PersianCalendar.Text))
                                        {
                                            Emt += 1000;
                                        }
                                        else if (ConvertClass.ShamsiToMiladi(Reader["Tarikh"].ToString()) > ConvertClass.ShamsiToMiladi(PersianCalendar.Text))
                                        {
                                            Overtime += 13;
                                        }
                                    }
                                }

                            }


                            using (OleDbCommand CMD = new OleDbCommand($"SELECT * FROM Ezafeh WHERE Vis=True AND Tarikh>='{PersianCalendar.Text.Substring(0, 7)}/01' AND P_Num ='{DetailGridView.Rows[i].Cells[2].Value}'", StrConnec))
                            {
                                using (OleDbDataReader Reader = CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                    {
                                        string Kind = Reader["E_Kind"].ToString();
                                        if (Kind == "تشویقی" || Kind == "کلاس آموزشی" || Kind == "شیفت")
                                        {
                                            Emt -= ConvertClass.TimeToDouble(Reader["E_Time"].ToString());
                                        }

                                        if (ConvertClass.ShamsiToMiladi(Reader["Tarikh"].ToString()).DayOfWeek == DayOfWeek.Friday)
                                        {
                                            Emt += ConvertClass.TimeToDouble(Reader["E_Time"].ToString()) * 0.4; // اضافه کار روز جمعه
                                        }
                                    }
                                }

                            }


                            if (Overtime > TopOver + 10)
                            {
                                DetailGridView.Rows.RemoveAt(i);
                            }
                            else
                            {
                                DetailGridView.Rows[i].Cells[3].Value = Overtime + Emt;
                                i++;
                            }
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show($"لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void OverTime()
        {
            try
            {
                int i;

                if (ConvertClass.ShamsiToMiladi(PersianCalendar.Text) != null)
                {

                    using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        if (int.Parse(Kasr12R1Box.Text) != 0 || int.Parse(Kasr12S1Box.Text) != 0 || int.Parse(Kasr9S1Box.Text) != 0 || int.Parse(Kasr9A1Box.Text) != 0 || int.Parse(KasrSet1Box.Text) != 0)
                        {

                            DataGridView1.Rows.Clear();

                            Over12R1Box.Text = "0";
                            Over12S1Box.Text = "0";
                            Over9S1Box.Text = "0";
                            Over9A1Box.Text = "0";
                            OverSet1Box.Text = "0";

                            //if (int.TryParse(All12R1Box.Text) && int.TryParse(Shift12R1Box.Text) && int.TryParse(Keshik12R1Box.Text) && int.TryParse(Daem12R1Box.Text) && int.TryParse(Leave12R1Box.Text) && int.TryParse(Rez12R1Box.Text) && int.TryParse(Class12R1Box.Text) && int.TryParse(Over12R1Box.Text) && int.TryParse(Kasr12R1Box.Text))
                            //{
                            //    Kasr12R1Box.Text=((int.Parse(Shift12R1Box.Text)) + (int.Parse(Keshik12R1Box.Text)) + (int.Parse(Over12R1Box.Text)) + int.Parse(Daem12R1Box.Text)) - ((int.Parse(All12R1Box.Text)) + (int.Parse(Leave12R1Box.Text)) + (int.Parse(Rez12R1Box.Text)) + int.Parse(Class12R1Box.Text)));
                            //}

                            //if (int.TryParse(All12S1Box.Text) && int.TryParse(Shift12S1Box.Text) && int.TryParse(Keshik12S1Box.Text) && int.TryParse(Daem12S1Box.Text) && int.TryParse(Leave12S1Box.Text) && int.TryParse(Rez12S1Box.Text) && int.TryParse(Class12S1Box.Text) && int.TryParse(Over12S1Box.Text) && int.TryParse(Kasr12S1Box.Text))
                            //{
                            //    Kasr12S1Box.Text=((int.Parse(Shift12S1Box.Text)) + (int.Parse(Keshik12S1Box.Text)) + (int.Parse(Over12S1Box.Text)) + int.Parse(Daem12S1Box.Text)) - ((int.Parse(All12S1Box.Text)) + (int.Parse(Leave12S1Box.Text)) + (int.Parse(Rez12S1Box.Text)) + int.Parse(Class12S1Box.Text)));
                            //}

                            //if (int.TryParse(All9S1Box.Text) && int.TryParse(Shift9S1Box.Text) && int.TryParse(Keshik9S1Box.Text) && int.TryParse(Daem9S1Box.Text) && int.TryParse(Leave9S1Box.Text) && int.TryParse(Rez9S1Box.Text) && int.TryParse(Class9S1Box.Text) && int.TryParse(Over9S1Box.Text) && int.TryParse(Kasr9S1Box.Text))
                            //{
                            //    Kasr9S1Box.Text=((int.Parse(Shift9S1Box.Text)) + (int.Parse(Keshik9S1Box.Text)) + (int.Parse(Over9S1Box.Text)) + int.Parse(Daem9S1Box.Text)) - ((int.Parse(All9S1Box.Text)) + (int.Parse(Leave9S1Box.Text)) + (int.Parse(Rez9S1Box.Text)) + int.Parse(Class9S1Box.Text)));
                            //}

                            //if (int.TryParse(All9A1Box.Text) && int.TryParse(Shift9A1Box.Text) && int.TryParse(Keshik9A1Box.Text) && int.TryParse(Daem9A1Box.Text) && int.TryParse(Leave9A1Box.Text) && int.TryParse(Rez9A1Box.Text) && int.TryParse(Class9A1Box.Text) && int.TryParse(Over9A1Box.Text) && int.TryParse(Kasr9A1Box.Text))
                            //{
                            //    Kasr9A1Box.Text=((int.Parse(Shift9A1Box.Text)) + (int.Parse(Keshik9A1Box.Text)) + (int.Parse(Over9A1Box.Text)) + int.Parse(Daem9A1Box.Text)) - ((int.Parse(All9A1Box.Text)) + (int.Parse(Leave9A1Box.Text)) + (int.Parse(Rez9A1Box.Text)) + int.Parse(Class9A1Box.Text)));
                            //}

                            //if (int.TryParse(AllSet1Box.Text) && int.TryParse(ShiftSet1Box.Text) && int.TryParse(KeshikSet1Box.Text) && int.TryParse(DaemSet1Box.Text) && int.TryParse(LeaveSet1Box.Text) && int.TryParse(RezSet1Box.Text) && int.TryParse(ClassSet1Box.Text) && int.TryParse(OverSet1Box.Text) && int.TryParse(KasrSet1Box.Text))
                            //{
                            //    KasrSet1Box.Text=((int.Parse(ShiftSet1Box.Text)) + (int.Parse(KeshikSet1Box.Text)) + (int.Parse(OverSet1Box.Text)) + int.Parse(DaemSet1Box.Text)) - ((int.Parse(AllSet1Box.Text)) + (int.Parse(LeaveSet1Box.Text)) + (int.Parse(RezSet1Box.Text)) + int.Parse(ClassSet1Box.Text)));
                            //}


                            if (int.Parse(Kasr12R1Box.Text) < 0)
                            {
                                OverTimeTable($"12 ساعته روز", Local1);

                                if (DetailGridView.RowCount > 0)
                                {
                                    DetailGridView.Sort(DetailGridView.Columns[3], System.ComponentModel.ListSortDirection.Ascending);
                                    i = 0;
                                    while (int.Parse(Kasr12R1Box.Text) < 0 && DetailGridView.RowCount > i)
                                    {
                                        DataGridView1.Rows.Add(DetailGridView.Rows[i].Cells[0].Value, DetailGridView.Rows[i].Cells[1].Value, DetailGridView.Rows[i].Cells[2].Value, "12 ساعته روز");
                                        Over12R1Box.Text = (int.Parse(Over12R1Box.Text) + 1).ToString();
                                        Kasr12R1Box.Text = (int.Parse(Kasr12R1Box.Text) + 1).ToString();
                                        i++;
                                    }
                                }
                            }

                            if (int.Parse(Kasr12S1Box.Text) < 0)
                            {
                                OverTimeTable($"12 ساعته شب", Local1);

                                if (DetailGridView.RowCount > 0)
                                {
                                    DetailGridView.Sort(DetailGridView.Columns[3], System.ComponentModel.ListSortDirection.Ascending);
                                    i = 0;
                                    while (int.Parse(Kasr12S1Box.Text) < 0 && DetailGridView.RowCount > i)
                                    {
                                        DataGridView1.Rows.Add(DetailGridView.Rows[i].Cells[0].Value, DetailGridView.Rows[i].Cells[1].Value, DetailGridView.Rows[i].Cells[2].Value, "12 ساعته شب");
                                        Over12S1Box.Text = (int.Parse(Over12S1Box.Text) + 1).ToString();
                                        Kasr12S1Box.Text = (int.Parse(Kasr12S1Box.Text) + 1).ToString();
                                        i++;
                                    }
                                }
                            }

                            if (int.Parse(Kasr9A1Box.Text) < 0)
                            {
                                OverTimeTable($"9 ساعته عصر", Local1);

                                if (DetailGridView.RowCount > 0)
                                {
                                    DetailGridView.Sort(DetailGridView.Columns[3], System.ComponentModel.ListSortDirection.Ascending);
                                    i = 0;
                                    while (int.Parse(Kasr9A1Box.Text) < 0 && DetailGridView.RowCount > i)
                                    {
                                        DataGridView1.Rows.Add(DetailGridView.Rows[i].Cells[0].Value, DetailGridView.Rows[i].Cells[1].Value, DetailGridView.Rows[i].Cells[2].Value, "9 ساعته عصر");
                                        Over9A1Box.Text = (int.Parse(Over9A1Box.Text) + 1).ToString();
                                        Kasr9A1Box.Text = (int.Parse(Kasr9A1Box.Text) + 1).ToString();
                                        i++;
                                    }
                                }
                            }

                            if (int.Parse(Kasr9S1Box.Text) < 0)
                            {
                                OverTimeTable($"9 ساعته صبح", Local1);

                                if (DetailGridView.RowCount > 0)
                                {
                                    DetailGridView.Sort(DetailGridView.Columns[3], System.ComponentModel.ListSortDirection.Ascending);
                                    i = 0;
                                    while (int.Parse(Kasr9S1Box.Text) < 0 && DetailGridView.RowCount > i)
                                    {
                                        DataGridView1.Rows.Add(DetailGridView.Rows[i].Cells[0].Value, DetailGridView.Rows[i].Cells[1].Value, DetailGridView.Rows[i].Cells[2].Value, "9 ساعته صبح");
                                        Over9S1Box.Text = (int.Parse(Over9S1Box.Text) + 1).ToString();
                                        Kasr9S1Box.Text = (int.Parse(Kasr9S1Box.Text) + 1).ToString();
                                        i++;
                                    }
                                }
                            }

                            if (int.Parse(KasrSet1Box.Text) < 0)
                            {
                                OverTimeTable($"ستادی", Local1);

                                if (DetailGridView.RowCount > 0)
                                {
                                    DetailGridView.Sort(DetailGridView.Columns[3], System.ComponentModel.ListSortDirection.Ascending);
                                    i = 0;
                                    while (int.Parse(KasrSet1Box.Text) < 0 && DetailGridView.RowCount > i)
                                    {
                                        DataGridView1.Rows.Add(DetailGridView.Rows[i].Cells[0].Value, DetailGridView.Rows[i].Cells[1].Value, DetailGridView.Rows[i].Cells[2].Value, "ستادی");
                                        OverSet1Box.Text = (int.Parse(OverSet1Box.Text) + 1).ToString();
                                        KasrSet1Box.Text = (int.Parse(KasrSet1Box.Text) + 1).ToString();
                                        i++;
                                    }
                                }
                            }
                        }

                        if (int.Parse(Kasr12R2Box.Text) != 0 || int.Parse(Kasr12S2Box.Text) != 0 || int.Parse(Kasr9S2Box.Text) != 0 || int.Parse(Kasr9A2Box.Text) != 0 || int.Parse(KasrSet2Box.Text) != 0)
                        {

                            DataGridView2.Rows.Clear();

                            Over12R2Box.Text = "0";
                            Over12S2Box.Text = "0";
                            Over9S2Box.Text = "0";
                            Over9A2Box.Text = "0";
                            OverSet2Box.Text = "0";

                            //if (int.TryParse(All12R2Box.Text) && int.TryParse(Shift12R2Box.Text) && int.TryParse(Keshik12R2Box.Text) && int.TryParse(Daem12R2Box.Text) && int.TryParse(Leave12R2Box.Text) && int.TryParse(Rez12R2Box.Text) && int.TryParse(Class12R2Box.Text) && int.TryParse(Over12R2Box.Text) && int.TryParse(Kasr12R2Box.Text))
                            //{
                            //    Kasr12R2Box.Text=((int.Parse(Shift12R2Box.Text)) + (int.Parse(Keshik12R2Box.Text)) + (int.Parse(Over12R2Box.Text)) + int.Parse(Daem12R2Box.Text)) - ((int.Parse(All12R2Box.Text)) + (int.Parse(Leave12R2Box.Text)) + (int.Parse(Rez12R2Box.Text)) + int.Parse(Class12R2Box.Text)));
                            //}

                            //if (int.TryParse(All12S2Box.Text) && int.TryParse(Shift12S2Box.Text) && int.TryParse(Keshik12S2Box.Text) && int.TryParse(Daem12S2Box.Text) && int.TryParse(Leave12S2Box.Text) && int.TryParse(Rez12S2Box.Text) && int.TryParse(Class12S2Box.Text) && int.TryParse(Over12S2Box.Text) && int.TryParse(Kasr12S2Box.Text))
                            //{
                            //    Kasr12S2Box.Text=((int.Parse(Shift12S2Box.Text)) + (int.Parse(Keshik12S2Box.Text)) + (int.Parse(Over12S2Box.Text)) + int.Parse(Daem12S2Box.Text)) - ((int.Parse(All12S2Box.Text)) + (int.Parse(Leave12S2Box.Text)) + (int.Parse(Rez12S2Box.Text)) + int.Parse(Class12S2Box.Text)));
                            //}

                            //if (int.TryParse(All9S2Box.Text) && int.TryParse(Shift9S2Box.Text) && int.TryParse(Keshik9S2Box.Text) && int.TryParse(Daem9S2Box.Text) && int.TryParse(Leave9S2Box.Text) && int.TryParse(Rez9S2Box.Text) && int.TryParse(Class9S2Box.Text) && int.TryParse(Over9S2Box.Text) && int.TryParse(Kasr9S2Box.Text))
                            //{
                            //    Kasr9S2Box.Text=((int.Parse(Shift9S2Box.Text)) + (int.Parse(Keshik9S2Box.Text)) + (int.Parse(Over9S2Box.Text)) + int.Parse(Daem9S2Box.Text)) - ((int.Parse(All9S2Box.Text)) + (int.Parse(Leave9S2Box.Text)) + (int.Parse(Rez9S2Box.Text)) + int.Parse(Class9S2Box.Text)));
                            //}

                            //if (int.TryParse(All9A2Box.Text) && int.TryParse(Shift9A2Box.Text) && int.TryParse(Keshik9A2Box.Text) && int.TryParse(Daem9A2Box.Text) && int.TryParse(Leave9A2Box.Text) && int.TryParse(Rez9A2Box.Text) && int.TryParse(Class9A2Box.Text) && int.TryParse(Over9A2Box.Text) && int.TryParse(Kasr9A2Box.Text))
                            //{
                            //    Kasr9A2Box.Text=((int.Parse(Shift9A2Box.Text)) + (int.Parse(Keshik9A2Box.Text)) + (int.Parse(Over9A2Box.Text)) + int.Parse(Daem9A2Box.Text)) - ((int.Parse(All9A2Box.Text)) + (int.Parse(Leave9A2Box.Text)) + (int.Parse(Rez9A2Box.Text)) + int.Parse(Class9A2Box.Text)));
                            //}

                            //if (int.TryParse(AllSet2Box.Text) && int.TryParse(ShiftSet2Box.Text) && int.TryParse(KeshikSet2Box.Text) && int.TryParse(DaemSet2Box.Text) && int.TryParse(LeaveSet2Box.Text) && int.TryParse(RezSet2Box.Text) && int.TryParse(ClassSet2Box.Text) && int.TryParse(OverSet2Box.Text) && int.TryParse(KasrSet2Box.Text))
                            //{
                            //    KasrSet2Box.Text=((int.Parse(ShiftSet2Box.Text)) + (int.Parse(KeshikSet2Box.Text)) + (int.Parse(OverSet2Box.Text)) + int.Parse(DaemSet2Box.Text)) - ((int.Parse(AllSet2Box.Text)) + (int.Parse(LeaveSet2Box.Text)) + (int.Parse(RezSet2Box.Text)) + int.Parse(ClassSet2Box.Text)));
                            //}

                            if (int.Parse(Kasr12R2Box.Text) < 0)
                            {
                                OverTimeTable($"12 ساعته روز", Local2);

                                if (DetailGridView.RowCount > 0)
                                {
                                    DetailGridView.Sort(DetailGridView.Columns[3], System.ComponentModel.ListSortDirection.Ascending);
                                    i = 0;
                                    while (int.Parse(Kasr12R2Box.Text) < 0 && DetailGridView.RowCount > i)
                                    {
                                        DataGridView2.Rows.Add(DetailGridView.Rows[i].Cells[0].Value, DetailGridView.Rows[i].Cells[1].Value, DetailGridView.Rows[i].Cells[2].Value, "12 ساعته روز");
                                        Over12R2Box.Text = (int.Parse(Over12R2Box.Text) + 1).ToString();
                                        Kasr12R2Box.Text = (int.Parse(Kasr12R2Box.Text) + 1).ToString();
                                        i++;
                                    }
                                }
                            }

                            if (int.Parse(Kasr12S2Box.Text) < 0)
                            {
                                OverTimeTable($"12 ساعته شب", Local2);

                                if (DetailGridView.RowCount > 0)
                                {
                                    DetailGridView.Sort(DetailGridView.Columns[3], System.ComponentModel.ListSortDirection.Ascending);
                                    i = 0;
                                    while (int.Parse(Kasr12S2Box.Text) < 0 && DetailGridView.RowCount > i)
                                    {
                                        DataGridView2.Rows.Add(DetailGridView.Rows[i].Cells[0].Value, DetailGridView.Rows[i].Cells[1].Value, DetailGridView.Rows[i].Cells[2].Value, "12 ساعته شب");
                                        Over12S2Box.Text = (int.Parse(Over12S2Box.Text) + 1).ToString();
                                        Kasr12S2Box.Text = (int.Parse(Kasr12S2Box.Text) + 1).ToString();
                                        i++;
                                    }
                                }
                            }

                            if (int.Parse(Kasr9A2Box.Text) < 0)
                            {
                                OverTimeTable($"9 ساعته عصر", Local2);

                                if (DetailGridView.RowCount > 0)
                                {
                                    DetailGridView.Sort(DetailGridView.Columns[3], System.ComponentModel.ListSortDirection.Ascending);
                                    i = 0;
                                    while (int.Parse(Kasr9A2Box.Text) < 0 && DetailGridView.RowCount > i)
                                    {
                                        DataGridView2.Rows.Add(DetailGridView.Rows[i].Cells[0].Value, DetailGridView.Rows[i].Cells[1].Value, DetailGridView.Rows[i].Cells[2].Value, "9 ساعته عصر");
                                        Over9A2Box.Text = (int.Parse(Over9A2Box.Text) + 1).ToString();
                                        Kasr9A2Box.Text = (int.Parse(Kasr9A2Box.Text) + 1).ToString();
                                        i++;
                                    }
                                }
                            }

                            if (int.Parse(Kasr9S2Box.Text) < 0)
                            {
                                OverTimeTable($"9 ساعته صبح", Local2);

                                if (DetailGridView.RowCount > 0)
                                {
                                    DetailGridView.Sort(DetailGridView.Columns[3], System.ComponentModel.ListSortDirection.Ascending);
                                    i = 0;
                                    while (int.Parse(Kasr9S2Box.Text) < 0 && DetailGridView.RowCount > i)
                                    {
                                        DataGridView2.Rows.Add(DetailGridView.Rows[i].Cells[0].Value, DetailGridView.Rows[i].Cells[1].Value, DetailGridView.Rows[i].Cells[2].Value, "9 ساعته صبح");
                                        Over9S2Box.Text = (int.Parse(Over9S2Box.Text) + 1).ToString();
                                        Kasr9S2Box.Text = (int.Parse(Kasr9S2Box.Text) + 1).ToString();
                                        i++;
                                    }
                                }
                            }

                            if (int.Parse(KasrSet2Box.Text) < 0)
                            {
                                OverTimeTable($"ستادی", Local2);

                                if (DetailGridView.RowCount > 0)
                                {
                                    DetailGridView.Sort(DetailGridView.Columns[3], System.ComponentModel.ListSortDirection.Ascending);
                                    i = 0;
                                    while (int.Parse(KasrSet2Box.Text) < 0 && DetailGridView.RowCount > i)
                                    {
                                        DataGridView2.Rows.Add(DetailGridView.Rows[i].Cells[0].Value, DetailGridView.Rows[i].Cells[1].Value, DetailGridView.Rows[i].Cells[2].Value, "ستادی");
                                        OverSet2Box.Text = (int.Parse(OverSet2Box.Text) + 1).ToString();
                                        KasrSet2Box.Text = (int.Parse(KasrSet2Box.Text) + 1).ToString();
                                        i++;
                                    }
                                }
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show($"لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public string ProcessReader()
        {
            int Loc = ProceString.IndexOf($"-") + 1;
            string SString;
            if (Loc == 0)
            {
                SString = ProceString;
            }
            else
            {
                SString = ProceString.Substring(0, Loc - 1);
                ProceString = ProceString.Substring(Loc, ProceString.Length - Loc);
            }
            return SString;
        }

        public string ReservPrint(string ShiftTime, string ShiftName, string ShiftLocal, string ResDate)
        {
            try
            {
                bool EmerRes = false;
                bool Shanter = false;
                string ResName = "";
                EmerRes = false;
                Shanter = false;
                using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();

                    using (OleDbCommand CMD = new OleDbCommand($"Select Person.Fname, Person.Family, Rezerv.Mem FROM Rezerv INNER JOIN Person On Person.P_Num=Rezerv.P_Num WHERE Person.Vis=True And Person.Trip=True And Person.Shift_Loc='{ShiftLocal}' AND Person.Shift_name='{ShiftName}' AND Person.Line_Num='{AppState.UserLnum}' AND Rezerv.Vis=True AND Rezerv.Tarikh='{ResDate}'", StrConnec))
                    {
                        if (ShiftTime != "")
                        {
                            CMD.CommandText += " And Person.Shift_Time ='{ShiftTime}'";
                        }
                        using (OleDbDataReader Reader = CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                if (Reader["Mem"].ToString().IndexOf($"اضطراری") + 1 > 0 || Reader["Mem"].ToString().IndexOf($"غیر فعال") + 1 > 0)
                                {
                                    EmerRes = true;
                                }
                                else if (Reader["Mem"].ToString() == "شانتر")
                                {
                                    Shanter = true;
                                }
                                else
                                {
                                    ResName += $"{Reader["Fname"]} {Reader["Family"]} - ";
                                }
                            }
                        }

                    }


                    if (ResName.Length > 3)
                    {
                        ResName = ResName.Substring(0, ResName.Length - 3);
                    }
                    if (EmerRes)
                    {
                        ResName += " ( راهبر غیرفعال : ";
                        using (OleDbCommand CMD = new OleDbCommand($"SELECT Person.Fname, Person.Family FROM Rezerv INNER JOIN Person ON Person.P_Num=Rezerv.P_Num WHERE Person.Vis=True AND Person.Trip=True AND Person.Shift_Loc='{ShiftLocal}' AND Person.Shift_name='{ShiftName}' AND Person.Line_Num='{AppState.UserLnum}' AND Rezerv.Vis=True AND Rezerv.Tarikh='{ResDate}' AND (Rezerv.Mem LIKE '%اضطراری%' OR Rezerv.Mem LIKE '%غیر فعال%')", StrConnec))
                        {
                            if (ShiftTime != "")
                            {
                                CMD.CommandText += $" And Person.Shift_Time ='{ShiftTime}'";
                            }

                            using (OleDbDataReader Reader = CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    ResName += $"{Reader["Fname"]} {Reader["Family"]} - ";
                                }
                            }

                        }


                        if (ResName.Length > 3)
                        {
                            ResName = ResName.Substring(0, ResName.Length - 3);
                        }
                        ResName += " )";
                    }
                    if (Shanter)
                    {
                        ResName += " ** شانتر شیفت : ";
                        using (OleDbCommand CMD = new OleDbCommand($"SELECT Person.Fname, Person.Family FROM Rezerv INNER JOIN Person ON Person.P_Num=Rezerv.P_Num WHERE Person.Vis=True AND Person.Trip=True AND Person.Shift_Time='{ShiftTime}' AND Person.Shift_Loc='{ShiftLocal}' AND Person.Shift_name='{ShiftName}' AND Person.Line_Num='{AppState.UserLnum}' AND Rezerv.Vis=True AND Rezerv.Tarikh='{ResDate}' AND Rezerv.Mem='شانتر'", StrConnec))
                        {
                            using (OleDbDataReader Reader = CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    ResName += $"{Reader["Fname"]} {Reader["Family"]} - ";
                                }
                            }

                        }


                        if (ResName.Length > 3)
                        {
                            ResName = ResName.Substring(0, ResName.Length - 3);
                        }
                    }
                }


                return ResName;
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show($"لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
                return string.Empty;
            }
        }

        public string LeavePrint(string ShiftTime, string ShiftName, string ShiftLocal, string LeavDate)
        {
            try
            {
                string LeaveName = "";
                using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    string StrQuer = $"SELECT Person.Fname, Person.Family FROM Morakhasi INNER JOIN Person ON Person.P_Num=Morakhasi.P_Num WHERE Person.Vis=True AND Person.P_Post LIKE 'راهبر%' AND Person.Shift_Loc='{ShiftLocal}' AND Person.Shift_name='{ShiftName}' AND Person.Line_Num='{AppState.UserLnum}' AND Morakhasi.Vis=True AND Morakhasi.Tarikh='{LeavDate}'";
                    if (ShiftTime != "")
                    {
                        StrQuer += $" And Person.Shift_Time ='{ShiftTime}'";
                    }

                    StrQuer += " ORDER BY Person.Family, Person.Fname";
                    using (OleDbCommand CMD = new OleDbCommand(StrQuer, StrConnec))
                    using (OleDbDataReader Reader = CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            LeaveName += $"{Reader["Fname"]} {Reader["Family"]} - ";
                        }
                    }
                }

                if (LeaveName.Length > 3)
                {
                    LeaveName = LeaveName.Substring(0, LeaveName.Length - 3);
                }

                return LeaveName;
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show($"لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
                return string.Empty;
            }
        }

        public string SpesialTripPrint(string ShiftTime, string ShiftName, string ShiftLocal, string SpTrip, string TripDate)
        {
            try
            {
                string LeaveName = "";
                using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();

                    using (OleDbCommand CMD = new OleDbCommand($"SELECT Person.Fname, Person.Family FROM TakTrip INNER JOIN Person ON Person.P_Num=TakTrip.P_Num WHERE Person.Vis=True AND TakTrip.Vis=True AND TakTrip.Tarikh='{TripDate}' AND TakTrip.Trip='{SpTrip}' AND Person.Shift_Loc='{ShiftLocal}' AND Person.Shift_Time='{ShiftTime}' And Person.Shift_name='{ShiftName}' ORDER BY Person.Family, Person.Fname", StrConnec))
                    {
                        using (OleDbDataReader Reader = CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                LeaveName += $"{Reader["Fname"]} {Reader["Family"]} - ";
                            }
                        }

                    }

                }


                if (LeaveName.Length > 3)
                {
                    LeaveName = LeaveName.Substring(0, LeaveName.Length - 3);
                }

                return LeaveName;
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show($"لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
                return string.Empty;
            }
        }

        public string OverTimePrint(string OverKind, string OverMem, string OverLocal, string OverDate)
        {
            try
            {
                string OverTimeName = "";
                using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    using (OleDbCommand CMD = new OleDbCommand($"Select Person.Fname, Person.Family FROM Ezafeh INNER JOIN Person On Person.P_Num=Ezafeh.P_Num WHERE Person.Vis=True And Person.Line_Num='{AppState.UserLnum}' AND Ezafeh.Vis=True AND Ezafeh.Tarikh='{OverDate}' AND Ezafeh.E_Local='{OverLocal}' AND Ezafeh.E_Kind='{OverKind}'", StrConnec))
                    {
                        if (OverMem != "")
                        {
                            CMD.CommandText += " AND Ezafeh.E_Mem LIKE '%{OverMem}%'";
                        }
                        CMD.CommandText += " ORDER BY Person.Family, Person.Fname";

                        using (OleDbDataReader Reader = CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                OverTimeName += $"{Reader["Fname"]} {Reader["Family"]} - ";
                            }
                        }

                    }

                }


                if (OverTimeName.Length > 3)
                {
                    OverTimeName = OverTimeName.Substring(0, OverTimeName.Length - 3);
                }

                return OverTimeName;
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show($"لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
                return string.Empty;
            }
        }

        public string ClassPrint(string ClassLocal)
        {
            try
            {
                string ClassName = "";
                string ClassMember = "";

                ClassName = "";
                ClassMember = "";
                using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();

                    using (OleDbCommand CMD = new OleDbCommand($"SELECT Retraining.P_Num, Retraining.Kind, Retraining.L_Class, Retraining.T_Class, Person.Fname, Person.Family, Person.Shift_name FROM Retraining INNER JOIN Person ON Person.P_Num=Retraining.P_Num WHERE Person.Shift_Loc='{ClassLocal}' AND Retraining.Vis=True AND Retraining.Tarikh='{PersianCalendar.Text}' AND Person.Line_Num='{AppState.UserLnum}' ORDER BY Retraining.Kind, Retraining.L_Class, Retraining.T_Class, Person.Family, Person.Fname", StrConnec))
                    {
                        using (OleDbDataReader Reader = CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                if (ClassName == Reader["Kind"].ToString())
                                {
                                    ClassMember += $" - {Reader["Fname"]} {Reader["Family"]}";
                                }
                                else
                                {
                                    if (ClassMember.Length > 0)
                                    {
                                        ClassMember += " ( {ClassName} ) ****  ";
                                    }
                                    ClassName = Reader["Kind"].ToString();
                                    ClassMember += $"{Reader["Fname"]} {Reader["Family"]}";
                                }
                            }
                        }

                    }

                }


                if (ClassMember.Length > 3)
                {
                    ClassMember += " ( {ClassName} )";
                }
                return ClassMember;
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show($" لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
                return string.Empty;
            }
        }

        public void KindCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Enabled = false;
                Height = 105;
                PrintButton.Enabled = false;
                ProcessButton.Enabled = false;
                NameCombo.SelectedIndex = -1;
                NameCombo.Items.Clear();
                if (PersianCalendar.Text == "")
                {
                    ErrorShow(PersianCalendar, "تاریخ پردازش را تعیین کنید");
                }
                else if (KindCombo.SelectedIndex >= 0)
                {

                    using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();

                        using (OleDbCommand CMD = new OleDbCommand($"SELECT Keshik.T_Keshik, Keshik.L_Keshik FROM Keshik INNER JOIN Person ON Keshik.P_Num=Person.P_Num WHERE Keshik.Tarikh='{PersianCalendar.Text}' AND Keshik.Vis=True AND Person.OverTime=False AND Person.Vis=True", StrConnec))
                        {
                            using (OleDbDataReader Reader = CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    string TKesh = "";
                                    string LKesh = "";
                                    TKesh = Reader["T_Keshik"].ToString();
                                    LKesh = Reader["L_Keshik"].ToString();
                                    StrConnec.Close();
                                    Enabled = true;
                                    MessageBoxFa.Show($"کشیک {TKesh} {LKesh} را اصلاح کنید", "خطا", MessageBoxIcon.Error);
                                    return;
                                }
                            }

                        }


                        using (OleDbCommand CMD = new OleDbCommand($"SELECT P_Name, L_Num FROM DailyProcessProgram WHERE P_Kind='{KindCombo.SelectedItem}' AND Vis=True And L_Num='{AppState.UserLnum}' ORDER BY P_Name", StrConnec))
                        {
                            using (OleDbDataReader Reader = CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    NameCombo.Items.Add(Reader["P_Name"].ToString());
                                }
                            }

                        }


                        Shift12R1Box.Text = ShiftCounter($"12 ساعته", Shift1, Local1);
                        Shift12S1Box.Text = ShiftCounter($"12 ساعته", Shift2, Local1);
                        Shift9S1Box.Text = ShiftCounter($"9 ساعته", Shift1, Local1);
                        Shift9A1Box.Text = ShiftCounter($"9 ساعته", Shift2, Local1);
                        Shift12R2Box.Text = ShiftCounter($"12 ساعته", Shift1, Local2);
                        Shift12S2Box.Text = ShiftCounter($"12 ساعته", Shift2, Local2);
                        Shift9S2Box.Text = ShiftCounter($"9 ساعته", Shift1, Local2);
                        Shift9A2Box.Text = ShiftCounter($"9 ساعته", Shift2, Local2);

                        Keshik12R1Box.Text = KeshikCounter($"روز", Local1);
                        Keshik12S1Box.Text = KeshikCounter($"شب", Local1);
                        Keshik9S1Box.Text = KeshikCounter($"صبح", Local1);
                        Keshik9A1Box.Text = KeshikCounter($"عصر", Local1);
                        Keshik12R2Box.Text = KeshikCounter($"روز", Local2);
                        Keshik12S2Box.Text = KeshikCounter($"شب", Local2);
                        Keshik9S2Box.Text = KeshikCounter($"صبح", Local2);
                        Keshik9A2Box.Text = KeshikCounter($"عصر", Local2);

                        Leave12R1Box.Text = LeaveCounter($"12 ساعته", Shift1, Local1);
                        Leave12S1Box.Text = LeaveCounter($"12 ساعته", Shift2, Local1);
                        Leave9S1Box.Text = LeaveCounter($"9 ساعته", Shift1, Local1);
                        Leave9A1Box.Text = LeaveCounter($"9 ساعته", Shift2, Local1);
                        Leave12R2Box.Text = LeaveCounter($"12 ساعته", Shift1, Local2);
                        Leave12S2Box.Text = LeaveCounter($"12 ساعته", Shift2, Local2);
                        Leave9S2Box.Text = LeaveCounter($"9 ساعته", Shift1, Local2);
                        Leave9A2Box.Text = LeaveCounter($"9 ساعته", Shift2, Local2);

                        Class12R1Box.Text = ClassCounter($"12 ساعته", Shift1, Local1);
                        Class12S1Box.Text = ClassCounter($"12 ساعته", Shift2, Local1);
                        Class9S1Box.Text = ClassCounter($"9 ساعته", Shift1, Local1);
                        Class9A1Box.Text = ClassCounter($"9 ساعته", Shift2, Local1);
                        Class12R2Box.Text = ClassCounter($"12 ساعته", Shift1, Local2);
                        Class12S2Box.Text = ClassCounter($"12 ساعته", Shift2, Local2);
                        Class9S2Box.Text = ClassCounter($"9 ساعته", Shift1, Local2);
                        Class9A2Box.Text = ClassCounter($"9 ساعته", Shift2, Local2);

                        if (!Holy && ConvertClass.ShamsiToMiladi(PersianCalendar.Text).DayOfWeek != DayOfWeek.Thursday)
                        {
                            ShiftSet1Box.Text = ShiftCounter($"ستادی", "ستادی", Local1);
                            ShiftSet2Box.Text = ShiftCounter($"ستادی", "ستادی", Local2);
                            KeshikSet1Box.Text = KeshikCounter($"ستادی", Local1);
                            KeshikSet2Box.Text = KeshikCounter($"ستادی", Local2);
                            LeaveSet1Box.Text = LeaveCounter($"ستادی", "ستادی", Local1);
                            LeaveSet2Box.Text = LeaveCounter($"ستادی", "ستادی", Local2);
                            ClassSet1Box.Text = ClassCounter($"ستادی", "ستادی", Local1);
                            ClassSet2Box.Text = ClassCounter($"ستادی", "ستادی", Local2);
                        }
                        else
                        {
                            ShiftSet1Box.Text = "0";
                            ShiftSet2Box.Text = "0";
                            KeshikSet1Box.Text = "0";
                            KeshikSet2Box.Text = "0";
                            LeaveSet1Box.Text = "0";
                            LeaveSet2Box.Text = "0";
                            ClassSet1Box.Text = "0";
                            ClassSet2Box.Text = "0";
                        }
                    }


                    if ((string)KindCombo.SelectedItem == "روز خاص")
                    {
                        NameCombo.Enabled = false;
                        Height = 605;

                        All12R1Box.BackColor = Color.White;
                        All12R1Box.ReadOnly = false;
                        All12S1Box.BackColor = Color.White;
                        All12S1Box.ReadOnly = false;
                        All9S1Box.BackColor = Color.White;
                        All9S1Box.ReadOnly = false;
                        All9A1Box.BackColor = Color.White;
                        All9A1Box.ReadOnly = false;
                        AllSet1Box.BackColor = Color.White;
                        AllSet1Box.ReadOnly = false;
                        All12R2Box.BackColor = Color.White;
                        All12R2Box.ReadOnly = false;
                        All12S2Box.BackColor = Color.White;
                        All12S2Box.ReadOnly = false;
                        All9S2Box.BackColor = Color.White;
                        All9S2Box.ReadOnly = false;
                        All9A2Box.BackColor = Color.White;
                        All9A2Box.ReadOnly = false;
                        AllSet2Box.BackColor = Color.White;
                        AllSet2Box.ReadOnly = false;

                        All12R1Box.Text = "0";
                        All12S1Box.Text = "0";
                        All9S1Box.Text = "0";
                        All9A1Box.Text = "0";
                        AllSet1Box.Text = "0";
                        All12R2Box.Text = "0";
                        All12S2Box.Text = "0";
                        All9S2Box.Text = "0";
                        All9A2Box.Text = "0";
                        AllSet2Box.Text = "0";

                        Daem12R1Box.Text = "0";
                        Daem12S1Box.Text = "0";
                        Daem9S1Box.Text = "0";
                        Daem9A1Box.Text = "0";
                        DaemSet1Box.Text = "0";
                        Daem12R2Box.Text = "0";
                        Daem12S2Box.Text = "0";
                        Daem9S2Box.Text = "0";
                        Daem9A2Box.Text = "0";
                        DaemSet2Box.Text = "0";

                        Kasr12R1Box.Text = "0";
                        Kasr12S1Box.Text = "0";
                        Kasr9S1Box.Text = "0";
                        Kasr9A1Box.Text = "0";
                        KasrSet1Box.Text = "0";
                        Kasr12R2Box.Text = "0";
                        Kasr12S2Box.Text = "0";
                        Kasr9S2Box.Text = "0";
                        Kasr9A2Box.Text = "0";
                        KasrSet2Box.Text = "0";

                        Over12R1Box.Text = "0";
                        Over12S1Box.Text = "0";
                        Over9S1Box.Text = "0";
                        Over9A1Box.Text = "0";
                        OverSet1Box.Text = "0";
                        Over12R2Box.Text = "0";
                        Over12S2Box.Text = "0";
                        Over9S2Box.Text = "0";
                        Over9A2Box.Text = "0";
                        OverSet2Box.Text = "0";

                        Rez12R1Box.Text = "0";
                        Rez12S1Box.Text = "0";
                        Rez9S1Box.Text = "0";
                        Rez9A1Box.Text = "0";
                        RezSet1Box.Text = "0";
                        Rez12R2Box.Text = "0";
                        Rez12S2Box.Text = "0";
                        Rez9S2Box.Text = "0";
                        Rez9A2Box.Text = "0";
                        RezSet2Box.Text = "0";
                    }
                    else
                    {
                        if (!All12R1Box.ReadOnly)
                        {
                            All12R1Box.BackColor = Color.Silver;
                            All12R1Box.ReadOnly = true;
                            All12S1Box.BackColor = Color.Silver;
                            All12S1Box.ReadOnly = true;
                            All9S1Box.BackColor = Color.Silver;
                            All9S1Box.ReadOnly = true;
                            All9A1Box.BackColor = Color.Silver;
                            All9A1Box.ReadOnly = true;
                            AllSet1Box.BackColor = Color.Silver;
                            AllSet1Box.ReadOnly = true;
                            All12R2Box.BackColor = Color.Silver;
                            All12R2Box.ReadOnly = true;
                            All12S2Box.BackColor = Color.Silver;
                            All12S2Box.ReadOnly = true;
                            All9S2Box.BackColor = Color.Silver;
                            All9S2Box.ReadOnly = true;
                            All9A2Box.BackColor = Color.Silver;
                            All9A2Box.ReadOnly = true;
                            AllSet2Box.BackColor = Color.Silver;
                            AllSet2Box.ReadOnly = true;
                        }
                        NameCombo.Enabled = true;
                    }
                }

                Enabled = true;
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show($"لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void NameCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Enabled = false;

                if (NameCombo.SelectedIndex < 0)
                {
                    Height = 105;
                    PrintButton.Enabled = false;
                    ProcessButton.Enabled = false;
                }
                else
                {
                    string ProcessMemo = "";
                    int All12R1 = 0;
                    int All12S1 = 0;
                    int All9S1 = 0;
                    int All9A1 = 0;
                    int AllSet1 = 0;
                    int All12R2 = 0;
                    int All12S2 = 0;
                    int All9S2 = 0;
                    int All9A2 = 0;
                    int AllSet2 = 0;
                    int Rez12R1 = 0;
                    int Rez12S1 = 0;
                    int Rez9S1 = 0;
                    int Rez9A1 = 0;
                    int RezSet1 = 0;
                    int Rez12R2 = 0;
                    int Rez12S2 = 0;
                    int Rez9S2 = 0;
                    int Rez9A2 = 0;
                    int RezSet2 = 0;

                    using (WaitForm wait = new WaitForm())
                    {
                        wait.Show();
                        wait.Refresh();


                        ProcessMemo = "";
                        Rez12R1Box.Text = "-";
                        Rez12S1Box.Text = "-";
                        Rez9S1Box.Text = "-";
                        Rez9A1Box.Text = "-";
                        RezSet1Box.Text = "-";
                        Rez12R2Box.Text = "-";
                        Rez12S2Box.Text = "-";
                        Rez9S2Box.Text = "-";
                        Rez9A2Box.Text = "-";
                        RezSet2Box.Text = "-";

                        All12R1 = 0;
                        All12S1 = 0;
                        All9S1 = 0;
                        All9A1 = 0;
                        AllSet1 = 0;
                        All12R2 = 0;
                        All12S2 = 0;
                        All9S2 = 0;
                        All9A2 = 0;
                        AllSet2 = 0;
                        Rez12R1 = 0;
                        Rez12S1 = 0;
                        Rez9S1 = 0;
                        Rez9A1 = 0;
                        RezSet1 = 0;
                        Rez12R2 = 0;
                        Rez12S2 = 0;
                        Rez9S2 = 0;
                        Rez9A2 = 0;
                        RezSet2 = 0;

                        using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                        {
                            StrConnec.Open();
                            using (OleDbCommand CMD = new OleDbCommand($"SELECT * FROM DailyProcessProgram WHERE P_Kind='{KindCombo.SelectedItem}' AND Vis=True AND P_Name='{NameCombo.SelectedItem}' And L_Num='{AppState.UserLnum}'", StrConnec))
                            using (OleDbDataReader Reader = CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    All12R1 = Convert.ToInt32(Reader["Shift12R1"]);
                                    All12S1 = Convert.ToInt32(Reader["Shift12S1"]);
                                    All9S1 = Convert.ToInt32(Reader["Shift9S1"]);
                                    All9A1 = Convert.ToInt32(Reader["Shift9A1"]);
                                    AllSet1 = Convert.ToInt32(Reader["ShiftSet1"]);

                                    All12R2 = Convert.ToInt32(Reader["Shift12R2"]);
                                    All12S2 = Convert.ToInt32(Reader["Shift12S2"]);
                                    All9S2 = Convert.ToInt32(Reader["Shift9S2"]);
                                    All9A2 = Convert.ToInt32(Reader["Shift9A2"]);
                                    AllSet2 = Convert.ToInt32(Reader["ShiftSet2"]);

                                    Rez12R1 = Convert.ToInt32(Reader["Res12R1"]);
                                    Rez12S1 = Convert.ToInt32(Reader["Res12S1"]);
                                    Rez9S1 = Convert.ToInt32(Reader["Res9S1"]);
                                    Rez9A1 = Convert.ToInt32(Reader["Res9A1"]);
                                    RezSet1 = Convert.ToInt32(Reader["ResSet1"]);

                                    Rez12R2 = Convert.ToInt32(Reader["Res12R2"]);
                                    Rez12S2 = Convert.ToInt32(Reader["Res12S2"]);
                                    Rez9S2 = Convert.ToInt32(Reader["Res9S2"]);
                                    Rez9A2 = Convert.ToInt32(Reader["Res9A2"]);
                                    RezSet2 = Convert.ToInt32(Reader["ResSet2"]);
                                    ProcessMemo = Reader["Mem"].ToString();
                                }
                            }
                        }


                        All12R1Box.Text = All12R1.ToString();
                        All12S1Box.Text = All12S1.ToString();
                        All9S1Box.Text = All9S1.ToString();
                        All9A1Box.Text = All9A1.ToString();
                        AllSet1Box.Text = AllSet1.ToString();
                        All12R2Box.Text = All12R2.ToString();
                        All12S2Box.Text = All12S2.ToString();
                        All9S2Box.Text = All9S2.ToString();
                        All9A2Box.Text = All9A2.ToString();
                        AllSet2Box.Text = AllSet2.ToString();

                        Daem12R1Box.Text = "0";
                        Daem12S1Box.Text = "0";
                        Daem9S1Box.Text = "0";
                        Daem9A1Box.Text = "0";
                        DaemSet1Box.Text = "0";
                        Daem12R2Box.Text = "0";
                        Daem12S2Box.Text = "0";
                        Daem9S2Box.Text = "0";
                        Daem9A2Box.Text = "0";
                        DaemSet2Box.Text = "0";

                        Over12R1Box.Text = "0";
                        Over12S1Box.Text = "0";
                        Over9S1Box.Text = "0";
                        Over9A1Box.Text = "0";
                        OverSet1Box.Text = "0";
                        Over12R2Box.Text = "0";
                        Over12S2Box.Text = "0";
                        Over9S2Box.Text = "0";
                        Over9A2Box.Text = "0";
                        OverSet2Box.Text = "0";

                        Kasr12R1Box.Text = "0";
                        Kasr12S1Box.Text = "0";
                        Kasr9S1Box.Text = "0";
                        Kasr9A1Box.Text = "0";
                        KasrSet1Box.Text = "0";
                        Kasr12R2Box.Text = "0";
                        Kasr12S2Box.Text = "0";
                        Kasr9S2Box.Text = "0";
                        Kasr9A2Box.Text = "0";
                        KasrSet2Box.Text = "0";

                        Rez12R1Box.Text = Rez12R1.ToString();
                        Rez12S1Box.Text = Rez12S1.ToString();
                        Rez9S1Box.Text = Rez9S1.ToString();
                        Rez9A1Box.Text = Rez9A1.ToString();
                        RezSet1Box.Text = RezSet1.ToString();
                        Rez12R2Box.Text = Rez12R2.ToString();
                        Rez12S2Box.Text = Rez12S2.ToString();
                        Rez9S2Box.Text = Rez9S2.ToString();
                        Rez9A2Box.Text = Rez9A2.ToString();
                        RezSet2Box.Text = RezSet2.ToString();

                        if (!Rez12R1Box.ReadOnly || !Rez12S1Box.ReadOnly || !Rez9S1Box.ReadOnly || !Rez9A1Box.ReadOnly || !RezSet1Box.ReadOnly || !Rez12R2Box.ReadOnly || !Rez12S2Box.ReadOnly || !Rez9S2Box.ReadOnly || !Rez9A2Box.ReadOnly || !RezSet2Box.ReadOnly)
                        {
                            Height = 605;
                        }

                        Panel2.Enabled = true;
                        Panel3.Enabled = true;

                        Enabled = true;
                        wait.Close();
                    }
                    if (ProcessMemo.Length > 0)
                    {
                        MessageBoxFa.Show(ProcessMemo, "توجه", MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show($"لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void Rez12R1Box_TextChanged(object sender, EventArgs e)
        {
            //if (int.TryParse(All12R1Box.Text) && int.TryParse(Shift12R1Box.Text) && int.TryParse(Keshik12R1Box.Text) && int.TryParse(Leave12R1Box.Text) && int.TryParse(Rez12R1Box.Text) && int.TryParse(Class12R1Box.Text) && int.TryParse(Over12R1Box.Text) && int.TryParse(Kasr12R1Box.Text) && int.TryParse(Daem12R1Box.Text))
            //{

            //    Kasr12R1Box.Text=((int.Parse(Shift12R1Box.Text)) + (int.Parse(Keshik12R1Box.Text)) + (int.Parse(Over12R1Box.Text)) + int.Parse(Daem12R1Box.Text)) - ((int.Parse(All12R1Box.Text)) + (int.Parse(Leave12R1Box.Text)) + (int.Parse(Class12R1Box.Text)) + int.Parse(Rez12R1Box.Text)));
            //    if (int.Parse(Shift12R1Box.Text) < int.Parse(Rez12R1Box.Text))
            //    {
            //        Rez12R1Box.Text=Shift12R1Box.Text;
            //    }
            //    if (int.Parse(Kasr12R1Box.Text) != 0 && !OverBool && !Processed)
            //    {
            //        OverBool=true;
            //        OverTime();
            //        Rez12R1Box_TextChanged(Nothing, Nothing)
            //    }
            //    OverBool=false;
            //}
        }

        public void Rez12S1Box_TextChanged(object sender, EventArgs e)
        {
            //if (int.TryParse(All12S1Box.Text) && int.TryParse(Shift12S1Box.Text) && int.TryParse(Keshik12S1Box.Text) && int.TryParse(Leave12S1Box.Text) && int.TryParse(Rez12S1Box.Text) && int.TryParse(Class12S1Box.Text) && int.TryParse(Over12S1Box.Text) && int.TryParse(Kasr12S1Box.Text) && int.TryParse(Daem12S1Box.Text))
            //{

            //    //Kasr12S1Box.Text=((int.Parse(Shift12S1Box.Text)) + (int.Parse(Keshik12S1Box.Text)) + (int.Parse(Over12S1Box.Text)) + int.Parse(Daem12S1Box.Text)) - ((int.Parse(All12S1Box.Text)) + (int.Parse(Leave12S1Box.Text)) + (int.Parse(Class12S1Box.Text)) + int.Parse(Rez12S1Box.Text)));
            //    if (int.Parse(Shift12S1Box.Text) < int.Parse(Rez12S1Box.Text))
            //    {
            //        Rez12S1Box.Text=Shift12S1Box.Text;
            //    }
            //    if (int.Parse(Kasr12S1Box.Text) != 0 && !OverBool && !Processed)
            //    {
            //        OverBool=true;
            //        OverTime();
            //        Rez12S1Box_TextChanged(Nothing, Nothing)
            //    }
            //    OverBool=false;
            //}
        }

        public void Rez9S1Box_TextChanged(object sender, EventArgs e)
        {
            //if (int.TryParse(All9S1Box.Text) && int.TryParse(Shift9S1Box.Text) && int.TryParse(Keshik9S1Box.Text) && int.TryParse(Leave9S1Box.Text) && int.TryParse(Rez9S1Box.Text) && int.TryParse(Class9S1Box.Text) && int.TryParse(Over9S1Box.Text) && int.TryParse(Kasr9S1Box.Text) && int.TryParse(Daem9S1Box.Text))
            //{

            //    Kasr9S1Box.Text=((int.Parse(Shift9S1Box.Text)) + (int.Parse(Keshik9S1Box.Text)) + (int.Parse(Over9S1Box.Text)) + int.Parse(Daem9S1Box.Text)) - ((int.Parse(All9S1Box.Text)) + (int.Parse(Leave9S1Box.Text)) + (int.Parse(Rez9S1Box.Text)) + int.Parse(Class9S1Box.Text)));
            //    if (int.Parse(Shift9S1Box.Text) < int.Parse(Rez9S1Box.Text))
            //    {
            //        Rez9S1Box.Text=Shift9S1Box.Text;
            //    }
            //    if (int.Parse(Kasr9S1Box.Text) != 0 && !OverBool && !Processed)
            //    {
            //        OverBool=true;
            //        OverTime();
            //        Rez9S1Box_TextChanged(Nothing, Nothing)
            //    }
            //    OverBool=false;
            //}
        }

        public void Rez9A1Box_TextChanged(object sender, EventArgs e)
        {
            //if (int.TryParse(All9A1Box.Text) && int.TryParse(Shift9A1Box.Text) && int.TryParse(Keshik9A1Box.Text) && int.TryParse(Leave9A1Box.Text) && int.TryParse(Class9A1Box.Text) && int.TryParse(Rez9A1Box.Text) && int.TryParse(Over9A1Box.Text) && int.TryParse(Kasr9A1Box.Text) && int.TryParse(Daem9A1Box.Text))
            //{

            //    Kasr9A1Box.Text=((int.Parse(Shift9A1Box.Text)) + (int.Parse(Keshik9A1Box.Text)) + (int.Parse(Over9A1Box.Text)) + int.Parse(Daem9A1Box.Text)) - ((int.Parse(All9A1Box.Text)) + (int.Parse(Leave9A1Box.Text)) + (int.Parse(Class9A1Box.Text)) + int.Parse(Rez9A1Box.Text)));
            //    if (int.Parse(Shift9A1Box.Text) < int.Parse(Rez9A1Box.Text))
            //    {
            //        Rez9A1Box.Text=Shift9A1Box.Text;
            //    }
            //    if (int.Parse(Kasr9A1Box.Text) != 0 && !OverBool && !Processed)
            //    {
            //        OverBool=true;
            //        OverTime();
            //        Rez9A1Box_TextChanged(Nothing, Nothing)
            //    }
            //    OverBool=false;
            //}
        }

        public void RezSet1Box_TextChanged(object sender, EventArgs e)
        {
            //if (int.TryParse(AllSet1Box.Text) && int.TryParse(ShiftSet1Box.Text) && int.TryParse(KeshikSet1Box.Text) && int.TryParse(LeaveSet1Box.Text) && int.TryParse(ClassSet1Box.Text) && int.TryParse(RezSet1Box.Text) && int.TryParse(OverSet1Box.Text) && int.TryParse(KasrSet1Box.Text) && int.TryParse(DaemSet1Box.Text))
            //{

            //    KasrSet1Box.Text=((int.Parse(ShiftSet1Box.Text)) + (int.Parse(KeshikSet1Box.Text)) + (int.Parse(OverSet1Box.Text)) + int.Parse(DaemSet1Box.Text)) - ((int.Parse(AllSet1Box.Text)) + (int.Parse(LeaveSet1Box.Text)) + (int.Parse(ClassSet1Box.Text)) + int.Parse(RezSet1Box.Text)));
            //    if (int.Parse(ShiftSet1Box.Text) < int.Parse(RezSet1Box.Text))
            //    {
            //        RezSet1Box.Text=ShiftSet1Box.Text;
            //    }
            //    if (int.Parse(KasrSet1Box.Text) != 0 && !OverBool && !Processed)
            //    {
            //        OverBool=true;
            //        OverTime();
            //        RezSet1Box_TextChanged(Nothing, Nothing)
            //    }
            //    OverBool=false;
            //}
        }

        public void Rez12R2box_TextChanged(object sender, EventArgs e)
        {
            //if (int.TryParse(All12R2Box.Text) && int.TryParse(Shift12R2Box.Text) && int.TryParse(Keshik12R2Box.Text) && int.TryParse(Leave12R2Box.Text) && int.TryParse(Rez12R2Box.Text) && int.TryParse(Class12R2Box.Text) && int.TryParse(Over12R2Box.Text) && int.TryParse(Kasr12R2Box.Text) && int.TryParse(Daem12R2Box.Text))
            //{

            //    Kasr12R2Box.Text=((int.Parse(Shift12R2Box.Text)) + (int.Parse(Keshik12R2Box.Text)) + (int.Parse(Over12R2Box.Text)) + int.Parse(Daem12R2Box.Text)) - ((int.Parse(All12R2Box.Text)) + (int.Parse(Leave12R2Box.Text)) + (int.Parse(Class12R2Box.Text)) + int.Parse(Rez12R2Box.Text)));
            //    if (int.Parse(Shift12R2Box.Text) < int.Parse(Rez12R2Box.Text))
            //    {
            //        Rez12R2Box.Text=Shift12R2Box.Text;
            //    }
            //    if (int.Parse(Kasr12R2Box.Text) != 0 && !OverBool && !Processed)
            //    {
            //        OverBool=true;
            //        OverTime();
            //        Rez12R2box_TextChanged(Nothing, Nothing)
            //    }
            //    OverBool=false;
            //}
        }

        public void Rez12S2box_TextChanged(object sender, EventArgs e)
        {
            //if (int.TryParse(All12S2Box.Text) && int.TryParse(Shift12S2Box.Text) && int.TryParse(Keshik12S2Box.Text) && int.TryParse(Leave12S2Box.Text) && int.TryParse(Rez12S2Box.Text) && int.TryParse(Class12S2Box.Text) && int.TryParse(Over12S2Box.Text) && int.TryParse(Kasr12S2Box.Text) && int.TryParse(Daem12S2Box.Text))
            //{

            //    Kasr12S2Box.Text=((int.Parse(Shift12S2Box.Text)) + (int.Parse(Keshik12S2Box.Text)) + (int.Parse(Over12S2Box.Text)) + int.Parse(Daem12S2Box.Text)) - ((int.Parse(All12S2Box.Text)) + (int.Parse(Leave12S2Box.Text)) + (int.Parse(Class12S2Box.Text)) + int.Parse(Rez12S2Box.Text)));
            //    if (int.Parse(Shift12S2Box.Text) < int.Parse(Rez12S2Box.Text))
            //    {
            //        Rez12S2Box.Text=Shift12S2Box.Text;
            //    }
            //    if (int.Parse(Kasr12S2Box.Text) != 0 && !OverBool && !Processed)
            //    {
            //        OverBool=true;
            //        OverTime();
            //        Rez12S2box_TextChanged(Nothing, Nothing)
            //    }
            //    OverBool=false;
            //}
        }

        public void Rez9S2box_TextChanged(object sender, EventArgs e)
        {
            //if (int.TryParse(All9S2Box.Text) && int.TryParse(Shift9S2Box.Text) && int.TryParse(Keshik9S2Box.Text) && int.TryParse(Leave9S2Box.Text) && int.TryParse(Rez9S2Box.Text) && int.TryParse(Class9S2Box.Text) && int.TryParse(Over9S2Box.Text) && int.TryParse(Kasr9S2Box.Text) && int.TryParse(Daem9S2Box.Text))
            //{

            //    Kasr9S2Box.Text=((int.Parse(Shift9S2Box.Text)) + (int.Parse(Keshik9S2Box.Text)) + (int.Parse(Over9S2Box.Text)) + int.Parse(Daem9S2Box.Text)) - ((int.Parse(All9S2Box.Text)) + (int.Parse(Leave9S2Box.Text)) + (int.Parse(Rez9S2Box.Text)) + int.Parse(Class9S2Box.Text)));
            //    if (int.Parse(Shift9S2Box.Text) < int.Parse(Rez9S2Box.Text))
            //    {
            //        Rez9S2Box.Text=Shift9S2Box.Text;
            //    }
            //    if (int.Parse(Kasr9S2Box.Text) != 0 && !OverBool && !Processed)
            //    {
            //        OverBool=true;
            //        OverTime();
            //        Rez9S2box_TextChanged(Nothing, Nothing)
            //    }
            //    OverBool=false;
            //}
        }

        public void Rez9A2box_TextChanged(object sender, EventArgs e)
        {
            //if (int.TryParse(All9A2Box.Text) && int.TryParse(Shift9A2Box.Text) && int.TryParse(Keshik9A2Box.Text) && int.TryParse(Leave9A2Box.Text) && int.TryParse(Class9A2Box.Text) && int.TryParse(Rez9A2Box.Text) && int.TryParse(Over9A2Box.Text) && int.TryParse(Kasr9A2Box.Text) && int.TryParse(Daem9A2Box.Text))
            //{

            //    Kasr9A2Box.Text=((int.Parse(Shift9A2Box.Text)) + (int.Parse(Keshik9A2Box.Text)) + (int.Parse(Over9A2Box.Text)) + int.Parse(Daem9A2Box.Text)) - ((int.Parse(All9A2Box.Text)) + (int.Parse(Leave9A2Box.Text)) + (int.Parse(Class9A2Box.Text)) + int.Parse(Rez9A2Box.Text)));
            //    if (int.Parse(Shift9A2Box.Text) < int.Parse(Rez9A2Box.Text))
            //    {
            //        Rez9A2Box.Text=Shift9A2Box.Text;
            //    }
            //    if (int.Parse(Kasr9A2Box.Text) != 0 && !OverBool && !Processed)
            //    {
            //        OverBool=true;
            //        OverTime();
            //        Rez9A2box_TextChanged(Nothing, Nothing)
            //    }
            //    OverBool=false;
            //}
        }

        public void RezSet2box_TextChanged(object sender, EventArgs e)
        {
            //if (int.TryParse(AllSet2Box.Text) && int.TryParse(ShiftSet2Box.Text) && int.TryParse(KeshikSet2Box.Text) && int.TryParse(LeaveSet2Box.Text) && int.TryParse(ClassSet2Box.Text) && int.TryParse(RezSet2Box.Text) && int.TryParse(OverSet2Box.Text) && int.TryParse(KasrSet2Box.Text) && int.TryParse(DaemSet2Box.Text))
            //{

            //    KasrSet2Box.Text=((int.Parse(ShiftSet2Box.Text)) + (int.Parse(KeshikSet2Box.Text)) + (int.Parse(OverSet2Box.Text)) + int.Parse(DaemSet2Box.Text)) - ((int.Parse(AllSet2Box.Text)) + (int.Parse(LeaveSet2Box.Text)) + (int.Parse(ClassSet2Box.Text)) + int.Parse(RezSet2Box.Text)));
            //    if (int.Parse(ShiftSet2Box.Text) < int.Parse(RezSet2Box.Text))
            //    {
            //        RezSet2Box.Text=ShiftSet2Box.Text;
            //    }
            //    if (int.Parse(KasrSet2Box.Text) != 0 && !OverBool && !Processed)
            //    {
            //        OverBool=true;
            //        OverTime();
            //        RezSet2box_TextChanged(Nothing, Nothing)
            //    }
            //    OverBool=false;
            //}
        }

        //Private Sub All12R1Box_TextChanged(sender As Object, e As EventArgs) Handles All12R1Box.TextChanged
        //    Dim Tem As String=Rez12R1Box.Text
        //    Rez12R1Box.Text="-"
        //    Rez12R1Box.Text=Tem
        //End Sub

        //Private Sub All12s1Box_TextChanged(sender As Object, e As EventArgs) Handles All12S1Box.TextChanged
        //    Dim Tem As String=Rez12S1Box.Text
        //    Rez12S1Box.Text="-"
        //    Rez12S1Box.Text=Tem
        //End Sub

        //Private Sub All9s1Box_TextChanged(sender As Object, e As EventArgs) Handles All9S1Box.TextChanged
        //    Dim Tem As String=Rez9S1Box.Text
        //    Rez9S1Box.Text="-"
        //    Rez9S1Box.Text=Tem
        //End Sub

        //Private Sub All9a1Box_TextChanged(sender As Object, e As EventArgs) Handles All9A1Box.TextChanged
        //    Dim Tem As String=Rez9A1Box.Text
        //    Rez9A1Box.Text="-"
        //    Rez9A1Box.Text=Tem
        //End Sub

        //Private Sub Allset1Box_TextChanged(sender As Object, e As EventArgs) Handles AllSet1Box.TextChanged
        //    Dim Tem As String=RezSet1Box.Text
        //    RezSet1Box.Text="-"
        //    RezSet1Box.Text=Tem
        //End Sub

        //Private Sub All12r2Box_TextChanged(sender As Object, e As EventArgs) Handles All12R2Box.TextChanged
        //    Dim Tem As String=Rez12R2Box.Text
        //    Rez12R2Box.Text="-"
        //    Rez12R2Box.Text=Tem
        //End Sub

        //Private Sub All12s2Box_TextChanged(sender As Object, e As EventArgs) Handles All12S2Box.TextChanged
        //    Dim Tem As String=Rez12S2Box.Text
        //    Rez12S2Box.Text="-"
        //    Rez12S2Box.Text=Tem
        //End Sub

        //Private Sub All9s2Box_TextChanged(sender As Object, e As EventArgs) Handles All9S2Box.TextChanged
        //    Dim Tem As String=Rez9S2Box.Text
        //    Rez9S2Box.Text="-"
        //    Rez9S2Box.Text=Tem
        //End Sub

        //Private Sub All9a2Box_TextChanged(sender As Object, e As EventArgs) Handles All9A2Box.TextChanged
        //    Dim Tem As String=Rez9A2Box.Text
        //    Rez9A2Box.Text="-"
        //    Rez9A2Box.Text=Tem
        //End Sub

        //Private Sub Allset2Box_TextChanged(sender As Object, e As EventArgs) Handles AllSet2Box.TextChanged
        //    Dim Tem As String=RezSet2Box.Text
        //    RezSet2Box.Text="-"
        //    RezSet2Box.Text=Tem
        //End Sub

        public void Kasr12R1Box_TextChanged(object sender, EventArgs e)
        {
            // OverTime()
            if (int.Parse(Kasr12R1Box.Text) > 0)
            {
                Kasr12R1Box.BackColor = Color.Yellow;
            }
            else if (int.Parse(Kasr12R1Box.Text) < 0)
            {
                Kasr12R1Box.BackColor = Color.Red;
            }
            else
            {
                Kasr12R1Box.BackColor = Color.Lime;
            }
            ProcessEnable();
        }

        public void Kasr12s1Box_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(Kasr12S1Box.Text) > 0)
            {
                Kasr12S1Box.BackColor = Color.Yellow;
            }
            else if (int.Parse(Kasr12S1Box.Text) < 0)
            {
                Kasr12S1Box.BackColor = Color.Red;
            }
            else
            {
                Kasr12S1Box.BackColor = Color.Lime;
            }
            ProcessEnable();
        }

        public void Kasr9s1Box_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(Kasr9S1Box.Text) > 0)
            {
                Kasr9S1Box.BackColor = Color.Yellow;
            }
            else if (int.Parse(Kasr9S1Box.Text) < 0)
            {
                Kasr9S1Box.BackColor = Color.Red;
            }
            else
            {
                Kasr9S1Box.BackColor = Color.Lime;
            }
            ProcessEnable();
        }

        public void Kasr9a1Box_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(Kasr9A1Box.Text) > 0)
            {
                Kasr9A1Box.BackColor = Color.Yellow;
            }
            else if (int.Parse(Kasr9A1Box.Text) < 0)
            {
                Kasr9A1Box.BackColor = Color.Red;
            }
            else
            {
                Kasr9A1Box.BackColor = Color.Lime;
            }
            ProcessEnable();
        }

        public void Kasrset1Box_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(KasrSet1Box.Text) > 0)
            {
                KasrSet1Box.BackColor = Color.Yellow;
            }
            else if (int.Parse(KasrSet1Box.Text) < 0)
            {
                KasrSet1Box.BackColor = Color.Red;
            }
            else
            {
                KasrSet1Box.BackColor = Color.Lime;
            }
            ProcessEnable();
        }

        public void Kasr12R2box_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(Kasr12R2Box.Text) > 0)
            {
                Kasr12R2Box.BackColor = Color.Yellow;
            }
            else if (int.Parse(Kasr12R2Box.Text) < 0)
            {
                Kasr12R2Box.BackColor = Color.Red;
            }
            else
            {
                Kasr12R2Box.BackColor = Color.Lime;
            }
            ProcessEnable();
        }

        public void Kasr12s2box_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(Kasr12S2Box.Text) > 0)
            {
                Kasr12S2Box.BackColor = Color.Yellow;
            }
            else if (int.Parse(Kasr12S2Box.Text) < 0)
            {
                Kasr12S2Box.BackColor = Color.Red;
            }
            else
            {
                Kasr12S2Box.BackColor = Color.Lime;
            }
            ProcessEnable();
        }


        public void Kasr9s2box_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(Kasr9S2Box.Text) > 0)
            {
                Kasr9S2Box.BackColor = Color.Yellow;
            }
            else if (int.Parse(Kasr9S2Box.Text) < 0)
            {
                Kasr9S2Box.BackColor = Color.Red;
            }
            else
            {
                Kasr9S2Box.BackColor = Color.Lime;
            }
            ProcessEnable();
        }

        public void Kasr9a2box_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(Kasr9A2Box.Text) > 0)
            {
                Kasr9A2Box.BackColor = Color.Yellow;
            }
            else if (int.Parse(Kasr9A2Box.Text) < 0)
            {
                Kasr9A2Box.BackColor = Color.Red;
            }
            else
            {
                Kasr9A2Box.BackColor = Color.Lime;
            }
            ProcessEnable();
        }

        public void Kasrset2box_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(KasrSet2Box.Text) > 0)
            {
                KasrSet2Box.BackColor = Color.Yellow;
            }
            else if (int.Parse(KasrSet2Box.Text) < 0)
            {
                KasrSet2Box.BackColor = Color.Red;
            }
            else
            {
                KasrSet2Box.BackColor = Color.Lime;
            }
            ProcessEnable();
        }
        public void PersianCalendar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Panel1.Enabled = false;

                Taghvim PersianDate = new Taghvim();
                PersianDate.SetDate(PersianCalendar.Text);
                PersianDate.AddDay(-1);
                YesterDay = PersianDate.Tarikh();

                using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();

                    using (OleDbCommand CMD = new OleDbCommand($"SELECT * FROM Taghvim WHERE Tarikh='{PersianCalendar.Text}' OR Tarikh='{YesterDay}' ", StrConnec))
                    {
                        using (OleDbDataReader Reader = CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                if (Reader["Tarikh"].ToString() == PersianCalendar.Text)
                                {
                                    Shift1 = Reader["Sobh"].ToString();
                                    Shift2 = Reader["Asr"].ToString();
                                    if (int.Parse(Reader["rooz"].ToString()) == 7 || (bool)Reader["Holi"])
                                    {
                                        Holy = true;
                                    }
                                }
                                else
                                {
                                    Shift0 = Reader["Asr"].ToString();
                                }
                            }
                        }

                    }

                }


                // Processed=false;
                PrintButton.Enabled = false;
                Height = 105;

                KindCombo.SelectedIndex = -1;
                KindCombo.Items.Clear();
                if (AppState.UserLevel > 0 && !ProcessChecker(YesterDay, AppState.UserLnum))
                {
                    MessageBoxFa.Show($"پردازش برای تاریخ {YesterDay} انجام نشده است", "خطا", MessageBoxIcon.Error);
                }
                else if (ProcessChecker(PersianCalendar.Text, AppState.UserLnum))
                {
                    //Processed=true;

                    All12R1Box.Text = ProcessReader();
                    All12S1Box.Text = ProcessReader();
                    All9S1Box.Text = ProcessReader();
                    All9A1Box.Text = ProcessReader();
                    AllSet1Box.Text = ProcessReader();
                    All12R2Box.Text = ProcessReader();
                    All12S2Box.Text = ProcessReader();
                    All9S2Box.Text = ProcessReader();
                    All9A2Box.Text = ProcessReader();
                    AllSet2Box.Text = ProcessReader();
                    Shift12R1Box.Text = ProcessReader();
                    Shift12S1Box.Text = ProcessReader();
                    Shift9S1Box.Text = ProcessReader();
                    Shift9A1Box.Text = ProcessReader();
                    ShiftSet1Box.Text = ProcessReader();
                    Shift12R2Box.Text = ProcessReader();
                    Shift12S2Box.Text = ProcessReader();
                    Shift9S2Box.Text = ProcessReader();
                    Shift9A2Box.Text = ProcessReader();
                    ShiftSet2Box.Text = ProcessReader();
                    Keshik12R1Box.Text = ProcessReader();
                    Keshik12S1Box.Text = ProcessReader();
                    Keshik9S1Box.Text = ProcessReader();
                    Keshik9A1Box.Text = ProcessReader();
                    KeshikSet1Box.Text = ProcessReader();
                    Keshik12R2Box.Text = ProcessReader();
                    Keshik12S2Box.Text = ProcessReader();
                    Keshik9S2Box.Text = ProcessReader();
                    Keshik9A2Box.Text = ProcessReader();
                    KeshikSet2Box.Text = ProcessReader();
                    Daem12R1Box.Text = ProcessReader();
                    Daem12S1Box.Text = ProcessReader();
                    Daem9S1Box.Text = ProcessReader();
                    Daem9A1Box.Text = ProcessReader();
                    DaemSet1Box.Text = ProcessReader();
                    Daem12R2Box.Text = ProcessReader();
                    Daem12S2Box.Text = ProcessReader();
                    Daem9S2Box.Text = ProcessReader();
                    Daem9A2Box.Text = ProcessReader();
                    DaemSet2Box.Text = ProcessReader();
                    Leave12R1Box.Text = ProcessReader();
                    Leave12S1Box.Text = ProcessReader();
                    Leave9S1Box.Text = ProcessReader();
                    Leave9A1Box.Text = ProcessReader();
                    LeaveSet1Box.Text = ProcessReader();
                    Leave12R2Box.Text = ProcessReader();
                    Leave12S2Box.Text = ProcessReader();
                    Leave9S2Box.Text = ProcessReader();
                    Leave9A2Box.Text = ProcessReader();
                    LeaveSet2Box.Text = ProcessReader();
                    Class12R1Box.Text = ProcessReader();
                    Class12S1Box.Text = ProcessReader();
                    Class9S1Box.Text = ProcessReader();
                    Class9A1Box.Text = ProcessReader();
                    ClassSet1Box.Text = ProcessReader();
                    Class12R2Box.Text = ProcessReader();
                    Class12S2Box.Text = ProcessReader();
                    Class9S2Box.Text = ProcessReader();
                    Class9A2Box.Text = ProcessReader();
                    ClassSet2Box.Text = ProcessReader();
                    Rez12R1Box.Text = ProcessReader();
                    Rez12S1Box.Text = ProcessReader();
                    Rez9S1Box.Text = ProcessReader();
                    Rez9A1Box.Text = ProcessReader();
                    RezSet1Box.Text = ProcessReader();
                    Rez12R2Box.Text = ProcessReader();
                    Rez12S2Box.Text = ProcessReader();
                    Rez9S2Box.Text = ProcessReader();
                    Rez9A2Box.Text = ProcessReader();
                    RezSet2Box.Text = ProcessReader();
                    Over12R1Box.Text = ProcessReader();
                    Over12S1Box.Text = ProcessReader();
                    Over9S1Box.Text = ProcessReader();
                    Over9A1Box.Text = ProcessReader();
                    OverSet1Box.Text = ProcessReader();
                    Over12R2Box.Text = ProcessReader();
                    Over12S2Box.Text = ProcessReader();
                    Over9S2Box.Text = ProcessReader();
                    Over9A2Box.Text = ProcessReader();
                    OverSet2Box.Text = ProcessReader();

                    Kasr12R1Box.Text = "0";
                    Kasr12S1Box.Text = "0";
                    Kasr9S1Box.Text = "0";
                    Kasr9A1Box.Text = "0";
                    KasrSet1Box.Text = "0";
                    Kasr12R2Box.Text = "0";
                    Kasr12S2Box.Text = "0";
                    Kasr9S2Box.Text = "0";
                    Kasr9A2Box.Text = "0";
                    KasrSet2Box.Text = "0";

                    Height = 605;
                    ProcessButton.Enabled = false;
                    Panel2.Enabled = false;
                    Panel3.Enabled = false;

                    MessageBoxFa.Show($"قبلا پردازش انجام شده، داده ی جدیدی وجود ندارد", "توجه", MessageBoxIcon.Warning);
                    PrintButton.Enabled = true;

                    //ElseIf ShamsiToMiladi(PersianCalendar.Text) <= Today And Not ImportChecker(YesterDay) Then
                    //    MessageBoxFa.Show($"لوحه اجرا شده " & YesterDay & " ثبت نشده است", "خطا", MessageBoxIcon.Error)
                    //ElseIf ShamsiToMiladi(PersianCalendar.Text) > Today And Not ImportChecker(PersianDate.Tarikh(Today.AddDays(-1))) Then
                    //    MessageBoxFa.Show($"لوحه اجرا شده " & PersianDate.Tarikh & " ثبت نشده است", "خطا", MessageBoxIcon.Error)
                }
                else
                {
                    //OptimizationForm.Calc(PersianCalendar.Text)
                    //Me.Activate()

                    if (!ProcessChecker(PersianCalendar.Text, "هشتگرد"))
                    {
                        MessageBoxFa.Show($"پردازش هشتگرد برای تاریخ {PersianCalendar.Text} انجام نشده است", "خطا", MessageBoxIcon.Error);
                    }
                    KindCombo.SelectedIndex = -1;
                    KindCombo.Items.Clear();
                    KindCombo.Items.Add($"شنبه تا چهارشنبه");
                    KindCombo.Items.Add($"پنج شنبه");
                    KindCombo.Items.Add($"جمعه و تعطیل");
                    KindCombo.Items.Add($"روز خاص");
                }

                Panel1.Enabled = true;
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show($"لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void DailyProcessADForm_Load(object sender, EventArgs e)
        {
            Height = 105;
            PrintButton.Enabled = false;
            ProcessButton.Enabled = false;

            // Dim i As Integer=(AppState.UserLnum - 1) * 2
            Local1 = MainForm.Locals[0];
            Local2 = MainForm.Locals[1];

            Local1Label.Text = Local1;
            Local2Label.Text = Local2;

            if (!string.IsNullOrEmpty(Tarikh))
            {
                PersianCalendar.Miladi = ConvertClass.ShamsiToMiladi(Tarikh);
                PersianCalendar.Text = Tarikh;
                PersianCalendar.Focus();
            }
        }

        public void ProcessButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ProcessChecker(PersianCalendar.Text, "هشتگرد"))
                {
                    if (MessageBoxFa.Show($"پردازش لوحه هشتگرد انجام نشده است  \n\n به صفحه پردازش هشتگر منتقل شود؟", "خطا", MessageBoxIcon.Error, MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Close();
                        //DailyProcess8GRForm.Default.Show();
                    }
                }
                else if (MessageBoxFa.Show($"پردازش اطلاعات لوحه انجام شود؟ ", "تایید", MessageBoxIcon.Question, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    if (ProcessChecker(PersianCalendar.Text, AppState.UserLnum))
                    {
                        KindCombo.SelectedIndex = -1;
                        KindCombo.Items.Clear();
                        MessageBoxFa.Show($"قبلا پردازش انجام شده، داده ی جدیدی وجود ندارد", "توجه", MessageBoxIcon.Warning);
                        PrintButton.Enabled = true;
                    }
                    else
                    {
                        int Repla12R1 = 0;
                        int Repla12S1 = 0;
                        int Repla9S1 = 0;
                        int Repla9A1 = 0;
                        int ReplaSet1 = 0;
                        int Repla12R2 = 0;
                        int Repla9S2 = 0;
                        int Repla9A2 = 0;
                        int ReplaSet2 = 0;



                        using (WaitForm wait = new WaitForm())
                        {
                            wait.Show();
                            wait.Refresh();
                            Enabled = false;
                            using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                            {
                                StrConnec.Open();


                                Reserv(Local1, "12 ساعته", Shift1, Convert.ToInt32(Rez12R1Box.Text));
                                Reserv(Local1, "12 ساعته", Shift2, Convert.ToInt32(Rez12S1Box.Text));
                                Reserv(Local1, "9 ساعته", Shift1, Convert.ToInt32(Rez9S1Box.Text));
                                Reserv(Local1, "9 ساعته", Shift2, Convert.ToInt32(Rez9A1Box.Text));
                                Reserv(Local1, "ستادی", "ستادی", Convert.ToInt32(RezSet1Box.Text));

                                Reserv(Local2, "12 ساعته", Shift2, Convert.ToInt32(Rez12S2Box.Text));
                                Reserv(Local2, "12 ساعته", Shift1, Convert.ToInt32(Rez12R2Box.Text));
                                Reserv(Local2, "9 ساعته", Shift1, Convert.ToInt32(Rez9S2Box.Text));
                                Reserv(Local2, "9 ساعته", Shift2, Convert.ToInt32(Rez9A2Box.Text));
                                Reserv(Local2, "ستادی", "ستادی", Convert.ToInt32(RezSet2Box.Text));

                                DetailGridView.Rows.Clear();
                                using (OleDbCommand CMD = new OleDbCommand($"SELECT Person.Fname, Person.Family, Person.P_Num, Person.Line_Num, Keshik.Tarikh, Keshik.T_Keshik, Keshik.L_Keshik FROM Keshik INNER JOIN Person ON Person.P_Num=Keshik.P_Num WHERE Keshik.Vis=True AND T_Keshik<>'کلاس آموزش' AND Keshik.Tarikh='{PersianCalendar.Text}' AND Person.Line_Num='{AppState.UserLnum}' AND Person.P_Staff='{AppState.UserStaff}' AND (L_Keshik='{Local1}' OR L_Keshik='{Local2}') ORDER BY Keshik.L_Keshik, Keshik.T_Keshik", StrConnec))
                                {
                                    using (OleDbDataReader Reader = CMD.ExecuteReader())
                                    {
                                        while (Reader.Read())
                                        {
                                            DetailGridView.Rows.Add($"", Reader["P_Num"].ToString(), Reader["L_Keshik"].ToString(), Reader["T_Keshik"].ToString());
                                        }
                                    }

                                }


                                int i;
                                for (i = 0; i <= DetailGridView.RowCount - 1; i++)
                                {
                                    using (OleDbCommand CMD = new OleDbCommand($"INSERT INTO Ezafeh (P_Num, Tarikh, E_Time, E_Kind, E_Local, E_Mem, U_Reg, T_Reg, Vis) VALUES ('{DetailGridView.Rows[i].Cells[1].Value}', '{PersianCalendar.Text}', '13:00', 'کشیک', '{DetailGridView.Rows[i].Cells[2].Value}', '{DetailGridView.Rows[i].Cells[3].Value}', '{AppState.UserName}', '{MainForm.PersianToday.Tarikh()} {DateTime.Now.ToString($"HH:mm:ss")}', True)", StrConnec))
                                    {
                                        CMD.ExecuteNonQuery();
                                    }


                                    OptimizationForm ShowForm = new OptimizationForm();
                                    ShowForm.PersoOptim(DetailGridView.Rows[i].Cells[1].Value.ToString(), PersianCalendar.Text, StrConnec);
                                }

                                Repla12R1 = 0;
                                Repla12S1 = 0;
                                Repla9S1 = 0;
                                Repla9A1 = 0;
                                ReplaSet1 = 0;
                                Repla12R2 = 0;
                                Repla9S2 = 0;
                                Repla9A2 = 0;
                                ReplaSet2 = 0;

                                for (i = 0; i <= DataGridView1.RowCount - 1; i++)
                                {
                                    Taghvim PersianDate = new Taghvim(PersianCalendar.Text);
                                    string KasStr = "";
                                    string Kind = "";

                                    if ((string)DataGridView1.Rows[i].Cells[3].Value == "12 ساعته روز")
                                    {
                                        if (PersianDate.DayWeek() == "جمعه")
                                        {
                                            KasStr = "13:00";
                                        }
                                        else
                                        {
                                            KasStr = "19:30";
                                        }

                                        Repla12R1++;
                                        Kind = "جایگزین مرخصی روزانه";
                                        if (Repla12R1 > int.Parse(Leave12R1Box.Text))
                                        {
                                            Kind = "اضافه کار";
                                        }

                                    }
                                    else if ((string)DataGridView1.Rows[i].Cells[3].Value == "12 ساعته شب")
                                    {
                                        Repla12S1++;
                                        Kind = "جایگزین مرخصی روزانه";
                                        if (Repla12S1 > int.Parse(Leave12S1Box.Text))
                                        {
                                            Kind = "اضافه کار";
                                        }

                                        if (PersianDate.DayWeek() == "پنج شنبه")
                                        {
                                            KasStr = "08:00";
                                        }
                                        else
                                        {
                                            KasStr = "04:30";

                                            PersianDate.SetDate(PersianCalendar.Text);
                                            PersianDate.AddDay(1);

                                            using (OleDbCommand CMD = new OleDbCommand($"INSERT INTO Ezafeh (P_NUM, Tarikh, E_Time, E_Kind, E_Local, E_Mem, U_Reg, T_Reg, Vis) VALUES ('{DataGridView1.Rows[i].Cells[2].Value}','{PersianDate.Tarikh()}', '10:00', '{Kind} شب قبل', '{Local1}', '{DataGridView1.Rows[i].Cells[3].Value}', '{AppState.UserName}', '{MainForm.PersianToday.Tarikh()} {DateTime.Now.ToString($"HH:mm:ss")}', True)", StrConnec))
                                            {
                                                CMD.ExecuteNonQuery();
                                            }

                                            PersianDate.SetDate(PersianCalendar.Text);
                                        }

                                    }
                                    else if ((string)DataGridView1.Rows[i].Cells[3].Value == "9 ساعته صبح")
                                    {
                                        KasStr = "13:00";

                                        Repla9S1++;
                                        Kind = "جایگزین مرخصی روزانه";
                                        if (Repla9S1 > int.Parse(Leave9S1Box.Text))
                                        {
                                            Kind = "اضافه کار";
                                        }

                                    }
                                    else if ((string)DataGridView1.Rows[i].Cells[3].Value == "9 ساعته عصر")
                                    {
                                        KasStr = "13:00";

                                        Repla9A1++;
                                        Kind = "جایگزین مرخصی روزانه";
                                        if (Repla9A1 > int.Parse(Leave9A1Box.Text))
                                        {
                                            Kind = "اضافه کار";
                                        }

                                    }
                                    else if ((string)DataGridView1.Rows[i].Cells[3].Value == "ستادی")
                                    {
                                        KasStr = "13:00";

                                        ReplaSet1++;
                                        Kind = "جایگزین مرخصی روزانه";
                                        if (ReplaSet1 > int.Parse(LeaveSet1Box.Text))
                                        {
                                            Kind = "اضافه کار";
                                        }
                                    }
                                    else
                                    {
                                        Kind = "اضافه کار";
                                        KasStr = "12:00";
                                    }

                                    using (OleDbCommand CMD = new OleDbCommand($"INSERT INTO Ezafeh (P_NUM, Tarikh, E_Time, E_Kind, E_Local, E_Mem, U_Reg, T_Reg, Vis) VALUES ('{DataGridView1.Rows[i].Cells[2].Value}', '{PersianCalendar.Text}', '{KasStr}', '{Kind}', '{Local1}', '{DataGridView1.Rows[i].Cells[3].Value}', '{AppState.UserName}', '{MainForm.PersianToday.Tarikh()} {DateTime.Now.ToString($"HH:mm:ss")}', True)", StrConnec))
                                    {
                                        CMD.ExecuteNonQuery();
                                    }

                                }

                                for (i = 0; i <= DataGridView2.RowCount - 1; i++)
                                {
                                    Taghvim PersianDate = new Taghvim(PersianCalendar.Text);
                                    string KasStr = "";
                                    string Kind = "";

                                    if ((string)DataGridView2.Rows[i].Cells[3].Value == "12 ساعته روز")
                                    {
                                        if (PersianDate.DayWeek() == "جمعه")
                                        {
                                            KasStr = "13:00";
                                        }
                                        else
                                        {
                                            KasStr = "19:30";
                                        }

                                        Repla12R2++;
                                        Kind = "جایگزین مرخصی روزانه";
                                        if (Repla12R2 > int.Parse(Leave12R2Box.Text))
                                        {
                                            Kind = "اضافه کار";
                                        }

                                    }
                                    else if ((string)DataGridView2.Rows[i].Cells[3].Value == "12 ساعته شب")
                                    {
                                        Repla12S1++;
                                        Kind = "جایگزین مرخصی روزانه";
                                        if (Repla12S1 > int.Parse(Leave12S1Box.Text))
                                        {
                                            Kind = "اضافه کار";
                                        }

                                        if (PersianDate.DayWeek() == "پنج شنبه")
                                        {
                                            KasStr = "08:00";
                                        }
                                        else
                                        {
                                            KasStr = "04:30";

                                            PersianDate.SetDate(PersianCalendar.Text);
                                            PersianDate.AddDay(1);


                                            using (OleDbCommand CMD = new OleDbCommand($"INSERT INTO Ezafeh (P_NUM, Tarikh, E_Time, E_Kind, E_Local, E_Mem, U_Reg, T_Reg, Vis) VALUES ('{DataGridView2.Rows[i].Cells[2].Value}','{PersianDate.Tarikh()}', '10:00', '{Kind} شب قبل', '{Local1}', '{DataGridView2.Rows[i].Cells[3].Value}', '{AppState.UserName}', '{MainForm.PersianToday.Tarikh()} {DateTime.Now.ToString($"HH:mm:ss")}', True)", StrConnec))
                                            {
                                                CMD.ExecuteNonQuery();
                                            }

                                            PersianDate.SetDate(PersianCalendar.Text);
                                        }

                                    }
                                    else if ((string)DataGridView2.Rows[i].Cells[3].Value == "9 ساعته صبح")
                                    {
                                        KasStr = "13:00";

                                        Repla9S2++;
                                        Kind = "جایگزین مرخصی روزانه";
                                        if (Repla9S2 > int.Parse(Leave9S2Box.Text))
                                        {
                                            Kind = "اضافه کار";
                                        }

                                    }
                                    else if ((string)DataGridView2.Rows[i].Cells[3].Value == "9 ساعته عصر")
                                    {
                                        KasStr = "13:00";

                                        Repla9A2++;
                                        Kind = "جایگزین مرخصی روزانه";
                                        if (Repla9A2 > int.Parse(Leave9A2Box.Text))
                                        {
                                            Kind = "اضافه کار";
                                        }

                                    }
                                    else if ((string)DataGridView2.Rows[i].Cells[3].Value == "ستادی")
                                    {
                                        KasStr = "13:00";

                                        ReplaSet2++;
                                        Kind = "جایگزین مرخصی روزانه";
                                        if (ReplaSet2 > int.Parse(LeaveSet2Box.Text))
                                        {
                                            Kind = "اضافه کار";
                                        }
                                    }
                                    else
                                    {
                                        Kind = "اضافه کار";
                                        KasStr = "12:00";
                                    }


                                    using (OleDbCommand CMD = new OleDbCommand($"INSERT INTO Ezafeh (P_NUM, Tarikh, E_Time, E_Kind, E_Local, E_Mem, U_Reg, T_Reg, Vis) VALUES ('{DataGridView2.Rows[i].Cells[2].Value}', '{PersianCalendar.Text}', '{KasStr}', '{Kind}', '{Local2}', '{DataGridView2.Rows[i].Cells[3].Value}', '{AppState.UserName}', '{MainForm.PersianToday.Tarikh()} {DateTime.Now.ToString($"HH:mm:ss")}', True)", StrConnec))
                                    {
                                        CMD.ExecuteNonQuery();
                                    }

                                }

                                UserName = AppState.UserName;
                                ProcessName = KindCombo.SelectedItem + " - " + NameCombo.SelectedItem;
                                string Mem = $"{All12R1Box.Text}-{ All12S1Box.Text}-{ All9S1Box.Text}-{ All9A1Box.Text}-{ AllSet1Box.Text}-{ All12R2Box.Text}-{ All12S2Box.Text}-{ All9S2Box.Text}-{ All9A2Box.Text}-{ AllSet2Box.Text}-{ Shift12R1Box.Text}-{ Shift12S1Box.Text}-{ Shift9S1Box.Text}-{ Shift9A1Box.Text}-{ ShiftSet1Box.Text}-{ Shift12R2Box.Text}-{ Shift12S2Box.Text}-{ Shift9S2Box.Text}-{ Shift9A2Box.Text}-{ ShiftSet2Box.Text}-{ Keshik12R1Box.Text}-{ Keshik12S1Box.Text}-{ Keshik9S1Box.Text}-{ Keshik9A1Box.Text}-{ KeshikSet1Box.Text}-{ Keshik12R2Box.Text}-{ Keshik12S2Box.Text}-{ Keshik9S2Box.Text}-{ Keshik9A2Box.Text}-{ KeshikSet2Box.Text}-{ Daem12R1Box.Text}-{ Daem12S1Box.Text}-{ Daem9S1Box.Text}-{ Daem9A1Box.Text}-{ DaemSet1Box.Text}-{ Daem12R2Box.Text}-{ Daem12S2Box.Text}-{ Daem9S2Box.Text}-{ Daem9A2Box.Text}-{ DaemSet2Box.Text}-{ Leave12R1Box.Text}-{ Leave12S1Box.Text}-{ Leave9S1Box.Text}-{ Leave9A1Box.Text}-{ LeaveSet1Box.Text}-{ Leave12R2Box.Text}-{ Leave12S2Box.Text}-{ Leave9S2Box.Text}-{ Leave9A2Box.Text}-{ LeaveSet2Box.Text}-{ Class12R1Box.Text}-{ Class12S1Box.Text}-{ Class9S1Box.Text}-{ Class9A1Box.Text}-{ ClassSet1Box.Text}-{ Class12R2Box.Text}-{ Class12S2Box.Text}-{ Class9S2Box.Text}-{ Class9A2Box.Text}-{ ClassSet2Box.Text}-{ Rez12R1Box.Text}-{ Rez12S1Box.Text}-{ Rez9S1Box.Text}-{ Rez9A1Box.Text}-{ RezSet1Box.Text}-{ Rez12R2Box.Text}-{ Rez12S2Box.Text}-{ Rez9S2Box.Text}-{ Rez9A2Box.Text}-{ RezSet2Box.Text}-{ Over12R1Box.Text}-{ Over12S1Box.Text}-{ Over9S1Box.Text}-{ Over9A1Box.Text}-{ OverSet1Box.Text}-{ Over12R2Box.Text}-{ Over12S2Box.Text}-{ Over9S2Box.Text}-{ Over9A2Box.Text}-{ OverSet2Box.Text}";

                                using (OleDbCommand CMD = new OleDbCommand($"INSERT INTO DailyProcess (Tarikh, L_Num, P_Mod, Mem, T_Reg , U_Reg, Vis) VALUES ('{PersianCalendar.Text}', '{AppState.UserLnum}', '{ProcessName}', '{Mem}', '{MainForm.PersianToday.Tarikh()} {DateTime.Now.ToString($"HH:mm:ss")}', '{UserName}', True)", StrConnec))
                                {
                                    CMD.ExecuteNonQuery();
                                }


                                if (PersianCalendar.Text.Substring(8, 2) == "01" || PersianCalendar.Text.Substring(8, 2) == "04" || PersianCalendar.Text.Substring(8, 2) == "07" || PersianCalendar.Text.Substring(8, 2) == "10" || PersianCalendar.Text.Substring(8, 2) == "18" || PersianCalendar.Text.Substring(8, 2) == "26")
                                {
                                    OptimizationForm ShowForm = new OptimizationForm();
                                    ShowForm.Calc(MainForm.PersianToday.Tarikh(), StrConnec);
                                }
                                else
                                {
                                    for (i = 0; i <= DetailGridView.RowCount - 1; i++)
                                    {
                                        if (int.TryParse(DetailGridView.Rows[i].Cells[1].Value.ToString(), out _))
                                        {
                                            OptimizationForm ShowForm = new OptimizationForm();
                                            ShowForm.PersoOptim(DetailGridView.Rows[i].Cells[1].Value.ToString(), PersianCalendar.Text, StrConnec);
                                        }
                                    }
                                    for (i = 0; i <= DataGridView1.RowCount - 1; i++)
                                    {
                                        if (int.TryParse(DataGridView1.Rows[i].Cells[2].Value.ToString(), out _))
                                        {
                                            OptimizationForm ShowForm = new OptimizationForm();
                                            ShowForm.PersoOptim(DataGridView1.Rows[i].Cells[2].Value.ToString(), PersianCalendar.Text, StrConnec);
                                        }
                                    }
                                    for (i = 0; i <= DataGridView2.RowCount - 1; i++)
                                    {
                                        if (int.TryParse(DataGridView2.Rows[i].Cells[2].Value.ToString(), out _))
                                        {
                                            OptimizationForm ShowForm = new OptimizationForm();
                                            ShowForm.PersoOptim(DataGridView2.Rows[i].Cells[2].Value.ToString(), PersianCalendar.Text, StrConnec);
                                        }
                                    }
                                }
                            }


                            Enabled = true;
                            wait.Close();
                        }
                        MessageBoxFa.Show($"پردازش با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
                        ProcessButton.Enabled = false;
                        Panel2.Enabled = false;
                        Panel3.Enabled = false;
                        PrintButton.Enabled = true;

                        KindCombo.Items.Clear();
                        NameCombo.Items.Clear();
                        KindCombo.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show($"لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void PrintButton_Click(object sender, EventArgs e)
        {
            try
            {
                string Leav12R1 = "";
                string Leav12S1 = "";
                string Leav9S1 = "";
                string Leav9A1 = "";
                string LeavSet1 = "";
                string Leav12R2 = "";
                string Leav12S2 = "";
                string Leav9S2 = "";
                string Leav9A2 = "";
                string LeavSet2 = "";
                string Leav12S1Last = "";
                string Leav12S2Last = "";
                string Kesh12R1 = "";
                string Kesh12S1 = "";
                string Kesh9S1 = "";
                string Kesh9A1 = "";
                string KeshSet1;
                string Kesh12R2 = "";
                string Kesh12S2 = "";
                string Kesh9S2 = "";
                string Kesh9A2 = "";
                string KeshSet2;
                string Kesh12S1Last;
                string Kesh12S2Last;
                string Jay12R1 = "";
                string Jay12S1 = "";
                string Jay9S1 = "";
                string Jay9A1 = "";
                string JaySet1 = "";
                string Jay12R2 = "";
                string Jay12S2 = "";
                string Jay9S2 = "";
                string Jay9A2 = "";
                string JaySet2 = "";
                string Jay12S1Last = "";
                string Jay12S2Last = "";
                string Eza12R1 = "";
                string Eza12S1 = "";
                string Eza9S1 = "";
                string Eza9A1 = "";
                string EzaSet1 = "";
                string Eza12R2 = "";
                string Eza12S2 = "";
                string Eza9S2 = "";
                string Eza9A2 = "";
                string EzaSet2 = "";
                string Eza12S1Last = "";
                string Eza12S2Last = "";
                string Res12R1 = "";
                string Res12S1 = "";
                string Res9S1 = "";
                string Res9A1 = "";
                string ResSet1 = "";
                string Res12R2 = "";
                string Res12S2 = "";
                string Res9S2 = "";
                string Res9A2 = "";
                string ResSet2 = "";
                string Res12S1Last = "";
                string Res12S2Last = "";
                string Clas12R1 = "";
                string Clas12R2 = "";
                string Clas12R3 = "";
                // Dim Clas12S1, Clas9S1, Clas9A1, ClasSet1, , Clas12S2, Clas9S2, Clas9A2, ClasSet2 As String
                // Dim Over12R1, Over12S1, Over9S1, Over9A1, OverSet1, Over12R2, Over12S2, Over9S2, Over9A2, OverSet2 As String
                string Leav8grd1 = "";
                string Leav8grd2 = "";
                string Rez8grd1 = "";
                string Rez8grd2 = "";
                string Trip8grd9S = "";
                string Trip8grd9A = "";
                string Trip8grd12 = "";
                string Trip8grdLast = "";
                string Eza8grd = "";
                string Kesh8grd9S = "";
                string Kesh8grd9A = "";
                // Dim  Term12R1, Term12S1, Term12Last As String, Rez8grd
                // Dim ResKesh1, ResKesh2 As String

                Stimulsoft.Report.StiReport Report = new Stimulsoft.Report.StiReport();
                using (WaitForm wait = new WaitForm())
                {
                    wait.Show();
                    wait.Refresh();
                    Enabled = false;

                    using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();

                        Res12R1 = ReservPrint($"12 ساعته", Shift1, Local1, PersianCalendar.Text);
                        Res12S1 = ReservPrint($"12 ساعته", Shift2, Local1, PersianCalendar.Text);
                        Res9S1 = ReservPrint($"9 ساعته", Shift1, Local1, PersianCalendar.Text);
                        Res9A1 = ReservPrint($"9 ساعته", Shift2, Local1, PersianCalendar.Text);
                        ResSet1 = ReservPrint($"ستادی", "ستادی", Local1, PersianCalendar.Text);
                        Res12R2 = ReservPrint($"12 ساعته", Shift1, Local2, PersianCalendar.Text);
                        Res12S2 = ReservPrint($"12 ساعته", Shift2, Local2, PersianCalendar.Text);
                        Res9S2 = ReservPrint($"9 ساعته", Shift1, Local2, PersianCalendar.Text);
                        Res9A2 = ReservPrint($"9 ساعته", Shift2, Local2, PersianCalendar.Text);
                        ResSet2 = ReservPrint($"ستادی", "ستادی", Local2, PersianCalendar.Text);
                        Res12S1Last = ReservPrint($"12 ساعته", Shift0, Local1, YesterDay);
                        Res12S2Last = ReservPrint($"12 ساعته", Shift0, Local2, YesterDay);

                        Rez8grd1 = ReservPrint($"", Shift1, "هشتگرد", PersianCalendar.Text);
                        Rez8grd2 = ReservPrint($"", Shift2, "هشتگرد", PersianCalendar.Text);

                        Leav12R1 = LeavePrint($"12 ساعته", Shift1, Local1, PersianCalendar.Text);
                        Leav12S1 = LeavePrint($"12 ساعته", Shift2, Local1, PersianCalendar.Text);
                        Leav9S1 = LeavePrint($"9 ساعته", Shift1, Local1, PersianCalendar.Text);
                        Leav9A1 = LeavePrint($"9 ساعته", Shift2, Local1, PersianCalendar.Text);
                        LeavSet1 = LeavePrint($"ستادی", "ستادی", Local1, PersianCalendar.Text);
                        Leav12R2 = LeavePrint($"12 ساعته", Shift1, Local2, PersianCalendar.Text);
                        Leav12S2 = LeavePrint($"12 ساعته", Shift2, Local2, PersianCalendar.Text);
                        Leav9S2 = LeavePrint($"9 ساعته", Shift1, Local2, PersianCalendar.Text);
                        Leav9A2 = LeavePrint($"9 ساعته", Shift2, Local2, PersianCalendar.Text);
                        LeavSet2 = LeavePrint($"ستادی", "ستادی", Local2, PersianCalendar.Text);
                        Leav12S1Last = LeavePrint($"12 ساعته", Shift0, Local1, YesterDay);
                        Leav12S2Last = LeavePrint($"12 ساعته", Shift0, Local2, YesterDay);

                        //Term12R1=TerminPrint($"12 ساعته", Shift1, Local2, PersianCalendar.Text)
                        //Term12S1=TerminPrint($"12 ساعته", Shift2, Local2, PersianCalendar.Text)
                        //Term12Last=TerminPrint($"12 ساعته", Shift0, Local2, YesterDay)

                        Leav8grd1 = LeavePrint($"", Shift1, "هشتگرد", PersianCalendar.Text);
                        Leav8grd2 = LeavePrint($"", Shift2, "هشتگرد", PersianCalendar.Text);
                        Trip8grd9S = SpesialTripPrint($"9 ساعته", Shift1, Local2, "هشتگرد", PersianCalendar.Text);
                        Trip8grd9A = SpesialTripPrint($"9 ساعته", Shift2, Local2, "هشتگرد", PersianCalendar.Text);
                        Trip8grd12 = SpesialTripPrint($"12 ساعته", Shift2, Local2, "هشتگرد", PersianCalendar.Text);
                        Trip8grdLast = SpesialTripPrint($"12 ساعته", Shift0, Local2, "هشتگرد", YesterDay);

                        Kesh12R1 = OverTimePrint($"کشیک", "روز", Local1, PersianCalendar.Text);
                        Kesh12S1 = OverTimePrint($"کشیک", "شب", Local1, PersianCalendar.Text);
                        Kesh9S1 = OverTimePrint($"کشیک", "صبح", Local1, PersianCalendar.Text);
                        Kesh9A1 = OverTimePrint($"کشیک", "عصر", Local1, PersianCalendar.Text);
                        KeshSet1 = OverTimePrint($"کشیک", "ستادی", Local1, PersianCalendar.Text);
                        Kesh12R2 = OverTimePrint($"کشیک", "روز", Local2, PersianCalendar.Text);
                        Kesh12S2 = OverTimePrint($"کشیک", "شب", Local2, PersianCalendar.Text);
                        Kesh9S2 = OverTimePrint($"کشیک", "صبح", Local2, PersianCalendar.Text);
                        Kesh9A2 = OverTimePrint($"کشیک", "عصر", Local2, PersianCalendar.Text);
                        KeshSet2 = OverTimePrint($"کشیک", "ستادی", Local2, PersianCalendar.Text);
                        Kesh12S1Last = OverTimePrint($"کشیک", "شب", Shift0, YesterDay);
                        Kesh12S2Last = OverTimePrint($"کشیک", "شب", Shift0, YesterDay);
                        Kesh8grd9S = OverTimePrint($"کشیک", "صبح", "هشتگرد", PersianCalendar.Text);
                        Kesh8grd9A = OverTimePrint($"کشیک", "عصر", "هشتگرد", PersianCalendar.Text);

                        Jay12R1 = OverTimePrint($"جایگزین مرخصی روزانه", "12 ساعته روز", Local1, PersianCalendar.Text);
                        Jay12S1 = OverTimePrint($"جایگزین مرخصی روزانه", "12 ساعته شب", Local1, PersianCalendar.Text);
                        Jay9S1 = OverTimePrint($"جایگزین مرخصی روزانه", "9 ساعته صبح", Local1, PersianCalendar.Text);
                        Jay9A1 = OverTimePrint($"جایگزین مرخصی روزانه", "9 ساعته عصر", Local1, PersianCalendar.Text);
                        JaySet1 = OverTimePrint($"جایگزین مرخصی روزانه", "ستادی", Local1, PersianCalendar.Text);
                        Jay12R2 = OverTimePrint($"جایگزین مرخصی روزانه", "12 ساعته روز", Local2, PersianCalendar.Text);
                        Jay12S2 = OverTimePrint($"جایگزین مرخصی روزانه", "12 ساعته شب", Local2, PersianCalendar.Text);
                        Jay9S2 = OverTimePrint($"جایگزین مرخصی روزانه", "9 ساعته صبح", Local2, PersianCalendar.Text);
                        Jay9A2 = OverTimePrint($"جایگزین مرخصی روزانه", "9 ساعته عصر", Local2, PersianCalendar.Text);
                        JaySet2 = OverTimePrint($"جایگزین مرخصی روزانه", "ستادی", Local2, PersianCalendar.Text);
                        Jay12S1Last = OverTimePrint($"جایگزین مرخصی روزانه", "12 ساعته شب", Local1, YesterDay);
                        Jay12S2Last = OverTimePrint($"جایگزین مرخصی روزانه", "12 ساعته شب", Local2, YesterDay);

                        Eza12R1 = OverTimePrint($"اضافه کار", "12 ساعته روز", Local1, PersianCalendar.Text);
                        Eza12S1 = OverTimePrint($"اضافه کار", "12 ساعته شب", Local1, PersianCalendar.Text);
                        Eza9S1 = OverTimePrint($"اضافه کار", "9 ساعته صبح", Local1, PersianCalendar.Text);
                        Eza9A1 = OverTimePrint($"اضافه کار", "9 ساعته عصر", Local1, PersianCalendar.Text);
                        EzaSet1 = OverTimePrint($"اضافه کار", "ستادی", Local1, PersianCalendar.Text);
                        Eza12R2 = OverTimePrint($"اضافه کار", "12 ساعته روز", Local2, PersianCalendar.Text);
                        Eza12S2 = OverTimePrint($"اضافه کار", "12 ساعته شب", Local2, PersianCalendar.Text);
                        Eza9S2 = OverTimePrint($"اضافه کار", "9 ساعته صبح", Local2, PersianCalendar.Text);
                        Eza9A2 = OverTimePrint($"اضافه کار", "9 ساعته عصر", Local2, PersianCalendar.Text);
                        EzaSet2 = OverTimePrint($"اضافه کار", "ستادی", Local2, PersianCalendar.Text);
                        Eza12S1Last = OverTimePrint($"اضافه کار", "12 ساعته شب", Local1, YesterDay);
                        Eza12S2Last = OverTimePrint($"اضافه کار", "12 ساعته شب", Local2, YesterDay);
                        //ResKesh1=OverTimePrint($"همکاری با شیفت", "کشیک رزرو", Local1, PersianCalendar.Text)
                        //ResKesh2=OverTimePrint($"همکاری با شیفت", "کشیک رزرو", Local2, PersianCalendar.Text)

                        Eza8grd = OverTimePrint($"اضافه کار", "", "هشتگرد", PersianCalendar.Text);

                        Clas12R1 = ClassPrint(Local1);
                        Clas12R2 = ClassPrint(Local2);
                        Clas12R3 = ClassPrint($"هشتگرد");
                        if (!string.IsNullOrEmpty(Clas12R3))
                        {
                            Clas12R2 += " *** " + Clas12R3;
                        }

                        //Clas12S1=""
                        //Clas9S1=""
                        //Clas9A1=""
                        //ClasSet1=""


                    }


                    Report.Dictionary.DataStore.Clear();
                    Report.Load(AppState.DatabasePath + "\\Metro.mrt");
                    Report.Compile();
                    Report["DateProcess"] = PersianCalendar.Text;
                    Report["LineProcess"] = AppState.UserLnum;
                    Report["UserProcess"] = UserName;
                    Report["NameProcess"] = ProcessName;
                    Report["Local1"] = Local1;
                    Report["Local2"] = Local2;

                    Report["Rez12R1"] = Res12R1;
                    Report["Rez12S1"] = Res12S1;
                    if (Res12S1Last.Length > 0)
                    {
                        Report["Rez12S1"] += " (شب قبل : {Res12S1Last} )";
                    }
                    Report["Rez9S1"] = Res9S1;
                    Report["Rez9A1"] = Res9A1;
                    Report["RezSet1"] = ResSet1;

                    Report["Leav12R1"] = Leav12R1;
                    Report["Leav12S1"] = Leav12S1;
                    if (Leav12S1Last.Length > 0)
                    {
                        Report["Leav12S1"] += " (شب قبل : {Leav12S1Last} )";
                    }
                    Report["Leav9S1"] = Leav9S1;
                    Report["Leav9A1"] = Leav9A1;
                    Report["LeavSet1"] = LeavSet1;

                    // Report($"Leav12R1")=Leav12R1
                    // Report($"Leav12S1")=Leav12S1
                    Report["Kesh9S1"] = Kesh12R1;
                    Report["Kesh9A1"] = Kesh12S1;
                    if (Kesh12R1.Length > 0 && Kesh9S1.Length > 0)
                    {
                        Report["Kesh9S1"] += " * ";
                    }
                    Report["Kesh9S1"] += Kesh9S1;
                    if (Kesh12S1.Length > 0 && Kesh9A1.Length > 0)
                    {
                        Report["Kesh9A1"] += " * ";
                    }
                    Report["Kesh9A1"] += Kesh9A1;
                    //Report($"LeavSet1")=LeavSet1

                    Report["Over12R1"] = Jay12R1 + " * " + Eza12R1;
                    Report["Over12S1"] = Jay12S1 + " * " + Eza12S1;
                    if (Eza12S1Last.Length > 0 || Jay12S1Last.Length > 0)
                    {
                        Report["Over12S1"] += " (شب قبل : " + Jay12S1Last + " * " + Eza12S1Last + " )";
                    }

                    Report["Over9S1"] = Jay9S1 + " * " + Eza9S1;
                    Report["Over9A1"] = Jay9A1 + " * " + Eza9A1;
                    Report["OverSet1"] = JaySet1 + " * " + EzaSet1;
                    Report["Class1"] = Clas12R1;
                    // If ResKesh1.Length > 0 Then Report($"Mem1")="کشیک رزرو : " & ResKesh1 & " * "

                    Report["Rez12R2"] = Res12R2;
                    Report["Rez12S2"] = Res12S2;
                    if (Res12S2Last.Length > 0)
                    {
                        Report["Rez12S2"] += " (شب قبل : {Res12S2Last} )";
                    }
                    Report["Rez9S2"] = Res9S2;
                    Report["Rez9A2"] = Res9A2;
                    Report["RezSet2"] = ResSet2;

                    Report["Leav12R2"] = Leav12R2;
                    Report["Leav12S2"] = Leav12S2;
                    if (Leav12S2Last.Length > 0)
                    {
                        Report["Leav12S2"] += " (شب قبل : {Leav12S2Last} )";
                    }
                    Report["Leav9S2"] = Leav9S2;
                    Report["Leav9A2"] = Leav9A2;
                    Report["LeavSet2"] = LeavSet2;

                    // Report($"Leav12R2")=Leav12R1
                    // Report($"Leav12S2")=Leav12S1
                    Report["Kesh9S2"] = Kesh12R2;
                    Report["Kesh9A2"] = Kesh12S2;
                    if (Kesh12R2.Length > 0 && Kesh9S2.Length > 0)
                    {
                        Report["Kesh9S2"] += " * ";
                    }
                    Report["Kesh9S2"] += Kesh9S2;
                    if (Kesh12S2.Length > 0 && Kesh9A2.Length > 0)
                    {
                        Report["Kesh9A2"] += " * ";
                    }
                    Report["Kesh9A2"] += Kesh9A2;
                    //Report($"LeavSet")=LeavSet1

                    Report["Over12R2"] = Jay12R2 + " * " + Eza12R2;
                    Report["Over12S2"] = Jay12S2 + " * " + Eza12S2;
                    if (Jay12S2Last.Length > 0 || Eza12S2Last.Length > 0)
                    {
                        Report["Over12S2"] += " (شب قبل : " + Jay12S2Last + " * " + Eza12S2Last + " )";
                    }

                    Report["Over9S2"] = Jay9S2 + " * " + Eza9S2;
                    Report["Over9A2"] = Jay9A2 + " * " + Eza9A2;
                    Report["OverSet2"] = JaySet2 + " * " + EzaSet2;
                    Report["Class2"] = Clas12R2;

                    // If ResKesh2.Length > 0 Then Report($"Mem2")="کشیک رزرو : " & ResKesh2 & " * "
                    // Report($"Mem2") += "راهبر پایانه روز: " & Term12R1 & " * شب: " & Term12S1 & " * شب قبل: " & Term12Last & Chr(13) & Chr(13)
                    if (Rez8grd1.Length > 0 || Rez8grd2.Length > 0)
                    {
                        Report["Mem2"] += $"رزرو هشتگرد : {Rez8grd1} * {Rez8grd2} * \r";
                    }

                    if (Leav8grd1.Length > 0 || Leav8grd2.Length > 0)
                    {
                        Report["Mem2"] += $"مرخصی هشتگرد : {Leav8grd1} * {Leav8grd2} * \r";
                    }

                    if (Eza8grd.Length > 0)
                    {
                        Report["Mem2"] += $"اضافه کار هشتگرد : {Eza8grd} * \r";
                    }

                    if (Kesh8grd9S.Length > 0)
                    {
                        Report["Mem2"] += $"کشیک صبح هشتگرد : {Kesh8grd9S} * \r";
                    }

                    if (Kesh8grd9A.Length > 0)
                    {
                        Report["Mem2"] += $"کشیک عصر هشتگرد : {Kesh8grd9A} * \r";
                    }

                    if (Trip8grd9S.Length > 0)
                    {
                        Report["Mem2"] += $"هشتگرد 9 ساعته صبح : {Trip8grd9S} * \r";
                    }

                    if (Trip8grd9A.Length > 0)
                    {
                        Report["Mem2"] += $"هشتگرد 9 ساعته عصر : {Trip8grd9A} * \r";
                    }

                    if (Trip8grd12.Length > 0)
                    {
                        Report["Mem2"] += $"تریپ هشتگرد 12 ساعته : {Trip8grd12} * \r";
                    }

                    if (Trip8grdLast.Length > 0)
                    {
                        Report["Mem2"] += $" ( شب قبل : {Trip8grdLast} ) * \r";
                    }

                    PrintButton.Enabled = true;

                    Enabled = true;
                    wait.Close();
                }

                Report.Render();
                Report.Show();

            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show($"لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void ProcessButton_EnabledChanged(object sender, EventArgs e)
        {
            if (ProcessButton.Enabled)
            {
                ProcessButton.BackColor = Color.Coral;
            }
            else
            {
                ProcessButton.BackColor = Color.Transparent;
            }
        }

        public void PrintButton_EnabledChanged(object sender, EventArgs e)
        {
            if (PrintButton.Enabled)
            {
                PrintButton.BackColor = Color.Yellow;
            }
            else
            {
                PrintButton.BackColor = Color.Transparent;
            }
        }
    }
}
