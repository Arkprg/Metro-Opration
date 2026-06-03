using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class TripAnalyzeForm
    {
        public TripAnalyzeForm()
        {
            InitializeComponent();
        }

        private DataSet DtSet=new DataSet();

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void TripReg() // اصلاح برای جدول تریپ جدید
        {
            try
            {
                int i;
                for (i=0; i <= TripGridView.RowCount - 1; i++)
                {

                    //Using CMD As New OleDbCommand("INSERT INTO DailyTripExecu (P_NUM, Tarikh, T_Time, Mabdae, Maghsad, T_Status, U_Reg, T_Reg, Vis) VALUES ('" & TripGridView.Rows(i).Cells(3).Value.ToString & "','" & TripGridView.Rows(i).Cells(8).Value.ToString & "', '" & TripGridView.Rows(i).Cells(4).Value.ToString & "', '" & TripGridView.Rows(i).Cells(5).Value.ToString & "', '" & TripGridView.Rows(i).Cells(6).Value.ToString & "', '" & TripGridView.Rows(i).Cells(7).Value.ToString & "', '" & AppState.UserName & "', '" & MainForm.PersianToday.Tarikh & " " & Now.ToString("HH:mm:ss") & "', True)", StrConnec)
                    //    '  CMD.ExecuteNonQuery()
                    //End Using
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void ShiftCounter(string PPost, string Local, string ShiftName, string TimeName)
        {
            string DPost;
            if (PPost == "راهبر پایانه")
            {
                DPost="راهبر پایانه";
            }
            else
            {
                DPost="شیفت";
            }
            string DefTime;
            string ShiftTime;
            switch (TimeName)
            {
                case "12 ساعته شب قبل":
                case "12 ساعته شب":
                    ShiftTime="12 ساعته";
                    DefTime="06:00";
                    break;

                case "12 ساعته روز":
                    ShiftTime="12 ساعته";
                    DefTime="12:00";
                    break;

                case "ستادی":
                    ShiftTime="ستادی";
                    DefTime="09:00";
                    break;

                default:
                    ShiftTime="9 ساعته";
                    DefTime="09:00";
                    break;
            }

            string QueStr="P_Post='" + PPost + "' AND Shift_Time='" + ShiftTime + "' AND Shift_Loc ='" + Local + "' AND Vis=True And Line_Num='" + AppState.UserLnum + "' AND Shift_name='" + ShiftName + "'";
            DataRow[] DRow=MainForm.PersonTable.Select(QueStr);
            foreach (DataRow DtR in DRow)
            {
                ShowGridView.Rows.Add(0, DtR["Fname"], DtR["Family"], DtR["P_Num"], TimeName, Local, 0, DPost, DefTime);
            }
        }

        public void NameButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (DtSet.Tables.Count > 0)
                {
                    if (MessageBoxFa.Show("داده های موجود نشده است \n\n فایل جدید بارگذاری گردد؟", "توجه", MessageBoxIcon.Exclamation, MessageBoxButtons.YesNo, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    {
                        return;
                    }
                }

                ShowGridView.Rows.Clear();
                FaultGridView.Rows.Clear();
                OverTimeGrid.Rows.Clear();
                LeavGridView.Rows.Clear();
                ReservGridView.Rows.Clear();
                TripGridView.Rows.Clear();

                DatabaseButton.Enabled=false;
                // InternetButton.Enabled=False
                UserNameLabel.Text="";
                LineLabel.Text="";
                DateLabel.Text="";
                Label4.Visible=false;
                FaltLabel.Visible=false;
                Label2.Visible=true;
                UserNameLabel.Visible=true;
                Label3.Visible=true;
                DateLabel.Visible=true;
                Label5.Visible=true;
                LineLabel.Visible=true;

                if (NameBox.Text != "")
                {

                    OleDbConnection ExcelConnection=new OleDbConnection("provider=Microsoft.Ace.OLEDB.12.0; Data Source='" + NameBox.Text + "'; Extended Properties=Excel 12.0;");
                    OleDbDataAdapter MyCommand=new OleDbDataAdapter("SELECT * FROM [Sheet1$]", ExcelConnection);

                    if (DtSet.Tables.Count > 0)
                    {
                        DtSet.Tables.Remove("Test");
                    }
                    DataSet DtSetTemp=new DataSet();
                    ExcelConnection.Open();
                    MyCommand.TableMappings.Add("Table", "Test");
                    MyCommand.Fill(DtSetTemp);
                    ExcelConnection.Close();

                    UserNameLabel.Text=AppState.UserName;
                    DateLabel.Text=DtSetTemp.Tables[0].Rows[2][7].ToString();
                    DtSetTemp.Tables[0].Columns[0].ColumnName="اعزام";
                    DtSetTemp.Tables[0].Columns[1].ColumnName="پرسنلی";
                    DtSetTemp.Tables[0].Columns[2].ColumnName="نام";
                    DtSetTemp.Tables[0].Columns[3].ColumnName="خانوادگی";
                    DtSetTemp.Tables[0].Columns[4].ColumnName="مقصد";
                    DtSetTemp.Tables[0].Columns[5].ColumnName="مبدا";
                    DtSetTemp.Tables[0].Columns[6].ColumnName="ساعت";
                    DtSetTemp.Tables[0].Columns[7].ColumnName="تاریخ";

                    DataRow[] Dr;


                    int j=0;
                    int Falt=0;
                    bool Holy=false;
                    Taghvim TripDate=new Taghvim(DateLabel.Text);
                    string Local1="";
                    string Local2="";
                    string Shift1="";
                    string Shift2="";
                    string LastShift="";


                    // Dim i As Integer=(AppState.UserLnum - 1) * 2
                    Local1=MainForm.Locals[0];
                    Local2=MainForm.Locals[1];

                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD=new OleDbCommand("SELECT ID FROM DailyStatus WHERE Tarikh='" + DateLabel.Text + "'", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                StrConnec.Close();
                                MessageBoxFa.Show("کارکرد برای این تاریخ تایید شده است ", "خطا ", MessageBoxIcon.Error);
                                return;
                            }
                        }

                        Shift1="";
                        Shift2="";
                        using (OleDbCommand CMD=new OleDbCommand("SELECT Sobh, Asr, Holi FROM Taghvim WHERE Tarikh='" + TripDate.Tarikh() + "'", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                Shift1=Reader["Sobh"].ToString();
                                Shift2=Reader["Asr"].ToString();
                                Holy=Convert.ToBoolean((bool)Reader["Holi"]);
                            }
                        }

                        LastShift="";
                        TripDate.AddDay(-1);
                        using (OleDbCommand CMD=new OleDbCommand("SELECT Asr FROM Taghvim WHERE Tarikh='" + TripDate.Tarikh() + "'", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                LastShift=Reader["Asr"].ToString();
                            }
                        }

                        Shift1Label.Text=Shift1;
                        Shift2Label.Text=Shift2;
                        LastShiftLabel.Text=LastShift;

                        bool Exist=false;
                        using (OleDbCommand CMD=new OleDbCommand("SELECT ID FROM DailyStatus WHERE Tarikh='" + TripDate.Tarikh() + "'", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                Exist=true;
                            }
                        }

                        if (!Exist)
                        {
                            StrConnec.Close();
                            MessageBoxFa.Show(" کارکرد برای تاریخ " + TripDate.Tarikh() + "  تایید نشده است ", "خطا ", MessageBoxIcon.Error);
                            return;
                        }

                        ShiftCounter("راهبر قطار", Local1, LastShift, "12 ساعته شب قبل");
                        ShiftCounter("راهبر پایانه", Local1, LastShift, "12 ساعته شب قبل");
                        ShiftCounter("راهبر قطار", Local1, Shift1, "9 ساعته صبح");
                        ShiftCounter("راهبر پایانه", Local1, Shift1, "9 ساعته صبح");
                        if (!Holy)
                        {
                            ShiftCounter("راهبر قطار", Local1, "", "ستادی");
                        }
                        if (!Holy)
                        {
                            ShiftCounter("راهبر پایانه", Local1, "", "ستادی");
                        }
                        ShiftCounter("راهبر قطار", Local1, Shift1, "12 ساعته روز");
                        ShiftCounter("راهبر پایانه", Local1, Shift1, "12 ساعته روز");
                        ShiftCounter("راهبر قطار", Local1, Shift2, "9 ساعته عصر");
                        ShiftCounter("راهبر پایانه", Local1, Shift2, "9 ساعته عصر");
                        ShiftCounter("راهبر قطار", Local1, Shift2, "12 ساعته شب");
                        ShiftCounter("راهبر پایانه", Local1, Shift2, "12 ساعته شب");

                        ShiftCounter("راهبر قطار", Local2, LastShift, "12 ساعته شب قبل");
                        ShiftCounter("راهبر پایانه", Local2, LastShift, "12 ساعته شب قبل");
                        ShiftCounter("راهبر قطار", Local2, Shift1, "9 ساعته صبح");
                        ShiftCounter("راهبر پایانه", Local2, Shift1, "9 ساعته صبح");
                        if (!Holy)
                        {
                            ShiftCounter("راهبر قطار", Local2, "", "ستادی");
                        }

                        if (!Holy)
                        {
                            ShiftCounter("راهبر پایانه", Local2, "", "ستادی");
                        }

                        ShiftCounter("راهبر قطار", Local2, Shift1, "12 ساعته روز");
                        ShiftCounter("راهبر پایانه", Local2, Shift1, "12 ساعته روز");
                        ShiftCounter("راهبر قطار", Local2, Shift2, "9 ساعته عصر");
                        ShiftCounter("راهبر پایانه", Local2, Shift2, "9 ساعته عصر");
                        ShiftCounter("راهبر قطار", Local2, Shift2, "12 ساعته شب");
                        ShiftCounter("راهبر پایانه", Local2, Shift2, "12 ساعته شب");

                        int i;
                        for (i=0; i <= ShowGridView.RowCount - 1; i++)
                        {
                            ShowGridView.Rows[i].Cells[0].Value=i + 1;
                        }

                        if (int.TryParse(DtSetTemp.Tables[0].Rows[4][1].ToString(), out _) ||
                                int.TryParse(DtSetTemp.Tables[0].Rows[DtSetTemp.Tables[0].Rows.Count / 10][1].ToString(), out _) ||
                                int.TryParse(DtSetTemp.Tables[0].Rows[DtSetTemp.Tables[0].Rows.Count / 5][1].ToString(), out _) ||
                                int.TryParse(DtSetTemp.Tables[0].Rows[DtSetTemp.Tables[0].Rows.Count / 2][1].ToString(), out _))
                        {
                            DtSet=DtSetTemp;
                            j=0;

                            for (i=1; i <= DtSet.Tables[0].Rows.Count - 1; i++)
                            {
                                if (int.TryParse(DtSet.Tables[0].Rows[i][1].ToString(), out int O))
                                {
                                    if (AppState.UserLnum == "5")
                                    {
                                        if (DtSet.Tables[0].Rows[i][4].ToString() == "تهران - صادقيه")
                                        {
                                            DtSet.Tables[0].Rows[i][4]="تهران";
                                        }

                                        if (DtSet.Tables[0].Rows[i][5].ToString() == "تهران - صادقيه")
                                        {
                                            DtSet.Tables[0].Rows[i][5]="تهران";
                                        }
                                    }
                                    else
                                    {
                                        if (DtSet.Tables[0].Rows[i][4].ToString() == "تهران - صادقيه")
                                        {
                                            DtSet.Tables[0].Rows[i][4]="صادقیه";
                                        }

                                        if (DtSet.Tables[0].Rows[i][5].ToString() == "تهران - صادقيه")
                                        {
                                            DtSet.Tables[0].Rows[i][5]="صادقیه";
                                        }
                                    }
                                    TripGridView.Rows.Add(j + 1, DtSet.Tables[0].Rows[i][2].ToString(), DtSet.Tables[0].Rows[i][3].ToString(), DtSet.Tables[0].Rows[i][1].ToString(), DtSet.Tables[0].Rows[i][6].ToString(), DtSet.Tables[0].Rows[i][5].ToString(), DtSet.Tables[0].Rows[i][4].ToString(), DtSet.Tables[0].Rows[i][0].ToString(), DtSet.Tables[0].Rows[i][7].ToString());
                                    j++;
                                }
                            }

                            Falt=0;
                            for (i=0; i <= ShowGridView.RowCount - 1; i++)
                            {

                                Dr=DtSet.Tables[0].Select("پرسنلی=" + ShowGridView.Rows[i].Cells[3].Value.ToString());
                                ShowGridView.Rows[i].Cells[6].Value=Dr.Length;
                                if (Dr.Length % 2 != 0)
                                {
                                    ShowGridView.Rows[i].DefaultCellStyle.BackColor=Color.OrangeRed;
                                    Falt++;
                                    FaultGridView.Rows.Add(FaultGridView.RowCount + 1, ShowGridView.Rows[i].Cells[1].Value, ShowGridView.Rows[i].Cells[2].Value, ShowGridView.Rows[i].Cells[3].Value, ShowGridView.Rows[i].Cells[4].Value, ShowGridView.Rows[i].Cells[5].Value, "فرد بودن تعداد حرکت", i);
                                }

                                if ((string)ShowGridView.Rows[i].Cells[7].Value == "شیفت")
                                {
                                    string DrStr="";
                                    if (ShowGridView.Rows[i].Cells[4].Value.ToString() == "12 ساعته شب")
                                    {
                                        DrStr="پرسنلی=" + ShowGridView.Rows[i].Cells[3].Value.ToString() + " And ساعت>'19:00'";
                                    }
                                    else if (ShowGridView.Rows[i].Cells[4].Value.ToString() == "12 ساعته شب قبل")
                                    {
                                        DrStr="پرسنلی=" + ShowGridView.Rows[i].Cells[3].Value.ToString() + " And ساعت<'08:00'";
                                    }
                                    else if (ShowGridView.Rows[i].Cells[4].Value.ToString() == "12 ساعته روز")
                                    {
                                        DrStr="پرسنلی=" + ShowGridView.Rows[i].Cells[3].Value.ToString() + " And ساعت>'07:30' AND ساعت<'19:30'";
                                    }
                                    else if (ShowGridView.Rows[i].Cells[4].Value.ToString() == "9 ساعته صبح")
                                    {
                                        DrStr="پرسنلی=" + ShowGridView.Rows[i].Cells[3].Value.ToString() + " And ساعت>'05:00' AND ساعت<'14:30'";
                                    }
                                    else if (ShowGridView.Rows[i].Cells[4].Value.ToString() == "9 ساعته عصر")
                                    {
                                        DrStr="پرسنلی=" + ShowGridView.Rows[i].Cells[3].Value.ToString() + " And ساعت>'13:00' AND ساعت<'23:30'";
                                    }
                                    else if (ShowGridView.Rows[i].Cells[4].Value.ToString() == "ستادی")
                                    {
                                        DrStr="پرسنلی=" + ShowGridView.Rows[i].Cells[3].Value.ToString() + " And ساعت>'07:00' AND ساعت<'16:00'";
                                    }
                                    Dr=DtSet.Tables[0].Select(DrStr);
                                    ShowGridView.Rows[i].Cells[6].Value=Dr.Length;

                                    if (ShowGridView.Rows[i].Cells[4].Value.ToString() == "12 ساعته شب قبل")
                                    {
                                        using (OleDbCommand CMD=new OleDbCommand("SELECT * FROM Morakhasi WHERE P_Num='" + ShowGridView.Rows[i].Cells[3].Value.ToString() + "' AND Tarikh='" + TripDate.Tarikh() + "' AND Vis=True", StrConnec))
                                        {
                                            using (OleDbDataReader Reader=CMD.ExecuteReader())
                                            {
                                                while (Reader.Read())
                                                {
                                                    ShowGridView.Rows[i].Cells[7].Value="مرخصی روزانه";

                                                    LeavGridView.Rows.Add(LeavGridView.RowCount + 1, ShowGridView.Rows[i].Cells[1].Value, ShowGridView.Rows[i].Cells[2].Value, ShowGridView.Rows[i].Cells[3].Value, ShowGridView.Rows[i].Cells[4].Value, ShowGridView.Rows[i].Cells[5].Value.ToString());
                                                    if ((int)ShowGridView.Rows[i].Cells[6].Value != 0)
                                                    {
                                                        ShowGridView.Rows[i].DefaultCellStyle.BackColor=Color.OrangeRed;
                                                        FaultGridView.Rows.Add(FaultGridView.RowCount + 1, ShowGridView.Rows[i].Cells[1].Value, ShowGridView.Rows[i].Cells[2].Value, ShowGridView.Rows[i].Cells[3].Value, ShowGridView.Rows[i].Cells[4].Value, ShowGridView.Rows[i].Cells[5].Value, "ثبت تریپ در زمان مرخصی روزانه ", i);
                                                        Falt++;
                                                    }
                                                }
                                            }

                                        }


                                        if ((string)ShowGridView.Rows[i].Cells[7].Value == "شیفت")
                                        {
                                            using (OleDbCommand CMD=new OleDbCommand("SELECT * FROM Rezerv WHERE P_Num='" + ShowGridView.Rows[i].Cells[3].Value.ToString() + "' AND Tarikh='" + TripDate.Tarikh() + "' AND Vis=True", StrConnec))
                                            using (OleDbDataReader Reader=CMD.ExecuteReader())
                                            {
                                                while (Reader.Read())
                                                {
                                                    ShowGridView.Rows[i].Cells[7].Value="رزرو";
                                                    int trip=0;
                                                    if (Reader["Trip1"].ToString() != "")
                                                    {
                                                        if (DateTime.Parse(Reader["Trip1"].ToString()) < DateTime.Parse("08:00"))
                                                        {
                                                            trip++;
                                                        }
                                                    }

                                                    if (Reader["Trip2"].ToString() != "")
                                                    {
                                                        if (DateTime.Parse(Reader["Trip2"].ToString()) < DateTime.Parse("08:00"))
                                                        {
                                                            trip++;
                                                        }
                                                    }

                                                    if (Reader["Trip3"].ToString() != "")
                                                    {
                                                        if (DateTime.Parse(Reader["Trip3"].ToString()) < DateTime.Parse("08:00"))
                                                        {
                                                            trip++;
                                                        }
                                                    }

                                                    ReservGridView.Rows.Add(ReservGridView.RowCount + 1, ShowGridView.Rows[i].Cells[1].Value, ShowGridView.Rows[i].Cells[2].Value, ShowGridView.Rows[i].Cells[3].Value, ShowGridView.Rows[i].Cells[4].Value, ShowGridView.Rows[i].Cells[5].Value.ToString());

                                                    if (trip * 2 != (int)ShowGridView.Rows[i].Cells[6].Value)
                                                    {
                                                        ShowGridView.Rows[i].DefaultCellStyle.BackColor=Color.OrangeRed;
                                                        Falt++;
                                                        FaultGridView.Rows.Add(FaultGridView.RowCount + 1, ShowGridView.Rows[i].Cells[1].Value, ShowGridView.Rows[i].Cells[2].Value, ShowGridView.Rows[i].Cells[3].Value, ShowGridView.Rows[i].Cells[4].Value, ShowGridView.Rows[i].Cells[5].Value, "اختلاف در تریپ راهبر رزرو", i);
                                                    }
                                                }
                                            }
                                        }

                                        if (Convert.ToInt32(ShowGridView.Rows[i].Cells[6].Value) > 1)
                                        {
                                            ShowGridView.Rows[i].Cells[8].Value="06:45";
                                        }
                                        else
                                        {
                                            ShowGridView.Rows[i].Cells[8].Value="06:00";
                                        }
                                        if ((int)ShowGridView.Rows[i].Cells[6].Value == 0 && (string)ShowGridView.Rows[i].Cells[7].Value == "شیفت")
                                        {
                                            ShowGridView.Rows[i].DefaultCellStyle.BackColor=Color.OrangeRed;
                                            Falt++;
                                            FaultGridView.Rows.Add(FaultGridView.RowCount + 1, ShowGridView.Rows[i].Cells[1].Value, ShowGridView.Rows[i].Cells[2].Value, ShowGridView.Rows[i].Cells[3].Value, ShowGridView.Rows[i].Cells[4].Value, ShowGridView.Rows[i].Cells[5].Value, "راهبر شیفت بدون تریپ ثبت شده", i);
                                        }

                                    }
                                    else // //  شیفت روز جاری
                                    {

                                        using (OleDbCommand CMD=new OleDbCommand("SELECT * FROM Morakhasi WHERE P_Num='" + ShowGridView.Rows[i].Cells[3].Value.ToString() + "' AND Tarikh='" + DateLabel.Text + "' AND Vis=True", StrConnec))
                                        {
                                            using (OleDbDataReader Reader=CMD.ExecuteReader())
                                            {
                                                while (Reader.Read())
                                                {
                                                    ShowGridView.Rows[i].Cells[7].Value="مرخصی روزانه";

                                                    LeavGridView.Rows.Add(LeavGridView.RowCount + 1, ShowGridView.Rows[i].Cells[1].Value, ShowGridView.Rows[i].Cells[2].Value, ShowGridView.Rows[i].Cells[3].Value, ShowGridView.Rows[i].Cells[4].Value, ShowGridView.Rows[i].Cells[5].Value.ToString());
                                                    if ((int)ShowGridView.Rows[i].Cells[6].Value != 0)
                                                    {
                                                        ShowGridView.Rows[i].DefaultCellStyle.BackColor=Color.OrangeRed;
                                                        FaultGridView.Rows.Add(FaultGridView.RowCount + 1, ShowGridView.Rows[i].Cells[1].Value, ShowGridView.Rows[i].Cells[2].Value, ShowGridView.Rows[i].Cells[3].Value, ShowGridView.Rows[i].Cells[4].Value, ShowGridView.Rows[i].Cells[5].Value, "ثبت تریپ در زمان مرخصی روزانه", i);
                                                        Falt++;
                                                    }
                                                }
                                            }

                                        }


                                        if ((string)ShowGridView.Rows[i].Cells[7].Value == "شیفت")
                                        {
                                            using (OleDbCommand CMD=new OleDbCommand("SELECT * FROM Rezerv WHERE P_Num='" + ShowGridView.Rows[i].Cells[3].Value.ToString() + "' AND Tarikh='" + DateLabel.Text + "' AND Vis=True", StrConnec))
                                            {
                                                using (OleDbDataReader Reader=CMD.ExecuteReader())
                                                {
                                                    while (Reader.Read())
                                                    {
                                                        ShowGridView.Rows[i].Cells[7].Value="رزرو";
                                                        int Trip=0;
                                                        if (ShowGridView.Rows[i].Cells[4].Value.ToString() == "12 ساعته شب")
                                                        {
                                                            if (Reader["Trip1"].ToString() != "")
                                                            {
                                                                if (DateTime.Parse(Reader["Trip1"].ToString()) > DateTime.Parse("19:00"))
                                                                {
                                                                    Trip++;
                                                                }
                                                            }
                                                            if (Reader["Trip2"].ToString() != "")
                                                            {
                                                                if (DateTime.Parse(Reader["Trip2"].ToString()) > DateTime.Parse("19:00"))
                                                                {
                                                                    Trip++;
                                                                }
                                                            }
                                                            if (Reader["Trip3"].ToString() != "")
                                                            {
                                                                if (DateTime.Parse(Reader["Trip3"].ToString()) > DateTime.Parse("19:00"))
                                                                {
                                                                    Trip++;
                                                                }
                                                            }
                                                        }
                                                        else
                                                        {
                                                            if (Reader["Trip1"].ToString() != "")
                                                            {
                                                                Trip++;
                                                            }

                                                            if (Reader["Trip2"].ToString() != "")
                                                            {
                                                                Trip++;
                                                            }

                                                            if (Reader["Trip3"].ToString() != "")
                                                            {
                                                                Trip++;
                                                            }
                                                        }

                                                        ReservGridView.Rows.Add(ReservGridView.RowCount + 1, ShowGridView.Rows[i].Cells[1].Value, ShowGridView.Rows[i].Cells[2].Value, ShowGridView.Rows[i].Cells[3].Value, ShowGridView.Rows[i].Cells[4].Value, ShowGridView.Rows[i].Cells[5].Value.ToString());

                                                        if (Trip * 2 != (int)ShowGridView.Rows[i].Cells[6].Value)
                                                        {
                                                            ShowGridView.Rows[i].DefaultCellStyle.BackColor=Color.OrangeRed;
                                                            Falt++;
                                                            FaultGridView.Rows.Add(FaultGridView.RowCount + 1, ShowGridView.Rows[i].Cells[1].Value, ShowGridView.Rows[i].Cells[2].Value, ShowGridView.Rows[i].Cells[3].Value, ShowGridView.Rows[i].Cells[4].Value, ShowGridView.Rows[i].Cells[5].Value, "اختلاف در تریپ راهبر رزرو", i);
                                                        }
                                                    }
                                                }

                                            }


                                        }

                                        if (ShowGridView.Rows[i].Cells[4].Value.ToString() == "9 ساعته صبح" || ShowGridView.Rows[i].Cells[4].Value.ToString() == "9 ساعته عصر" || ShowGridView.Rows[i].Cells[4].Value.ToString() == "ستادی")
                                        {
                                            if (Convert.ToInt32(ShowGridView.Rows[i].Cells[6].Value) > 2)
                                            {
                                                ShowGridView.Rows[i].Cells[8].Value="13:00";
                                            }
                                            else if (Convert.ToInt32(ShowGridView.Rows[i].Cells[6].Value) > 0)
                                            {
                                                ShowGridView.Rows[i].Cells[8].Value="10:15";
                                            }
                                        }
                                        else if (ShowGridView.Rows[i].Cells[4].Value.ToString() == "12 ساعته روز")
                                        {
                                            if (Convert.ToInt32(ShowGridView.Rows[i].Cells[6].Value) > 4)
                                            {
                                                ShowGridView.Rows[i].Cells[8].Value="13:45";
                                            }
                                            else if (Convert.ToInt32(ShowGridView.Rows[i].Cells[6].Value) > 2)
                                            {
                                                ShowGridView.Rows[i].Cells[8].Value="13:10";
                                            }
                                            else if (Convert.ToInt32(ShowGridView.Rows[i].Cells[6].Value) > 0)
                                            {
                                                ShowGridView.Rows[i].Cells[8].Value="12:35";
                                            }
                                        }
                                        else if (ShowGridView.Rows[i].Cells[4].Value.ToString() == "12 ساعته شب")
                                        {
                                            if (Convert.ToInt32(ShowGridView.Rows[i].Cells[6].Value) > 0)
                                            {
                                                ShowGridView.Rows[i].Cells[8].Value="06:45";
                                            }
                                        }
                                        if ((int)ShowGridView.Rows[i].Cells[6].Value == 0 && (string)ShowGridView.Rows[i].Cells[7].Value == "شیفت")
                                        {
                                            ShowGridView.Rows[i].DefaultCellStyle.BackColor=Color.OrangeRed;
                                            Falt++;
                                            FaultGridView.Rows.Add(FaultGridView.RowCount + 1, ShowGridView.Rows[i].Cells[1].Value, ShowGridView.Rows[i].Cells[2].Value, ShowGridView.Rows[i].Cells[3].Value, ShowGridView.Rows[i].Cells[4].Value, ShowGridView.Rows[i].Cells[5].Value, "راهبر شیفت بدون تریپ ثبت شده", i);
                                        }
                                    }
                                }
                            }

                            j=1;
                            using (OleDbCommand CMD=new OleDbCommand("SELECT Person.Fname, Person.Family, Ezafeh.P_Num, Ezafeh.Tarikh, Ezafeh.E_Time, Ezafeh.E_Local, Ezafeh.E_Kind, Ezafeh.E_Mem, Ezafeh.U_Reg FROM Ezafeh INNER JOIN Person ON Ezafeh.P_Num=Person.P_Num WHERE Ezafeh.Tarikh='" + DateLabel.Text + "' AND Ezafeh.Vis=True", StrConnec))
                            {
                                using (OleDbDataReader Reader=CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                    {
                                        OverTimeGrid.Rows.Add(j, Reader["Fname"], Reader["Family"], Reader["P_Num"], Reader["E_Time"], Reader["E_Local"], 0, Reader["E_Kind"] + " " + Reader["E_Mem"], Reader["U_Reg"]);
                                        j++;
                                    }
                                }

                            }


                            for (i=0; i <= OverTimeGrid.RowCount - 1; i++)
                            {
                                Dr=DtSet.Tables[0].Select("پرسنلی=" + OverTimeGrid.Rows[i].Cells[3].Value.ToString());
                                OverTimeGrid.Rows[i].Cells[6].Value=Dr.Length;
                            }

                            j=1;
                            using (OleDbCommand CMD=new OleDbCommand("Select Person.Fname, Person.Family, Person.P_Num, Person.Shift_Loc, Amal.Tarikh, Amal.Amal, Amal.U_Reg, Amal.T_Reg From Amal INNER JOIN Person ON Person.P_Num=Amal.P_Num WHERE Amal.Tarikh='" + DateLabel.Text + "' AND Amal.Vis= True And Amal.OnvAmal='ساعتی' AND Person.Line_Num='" + LineLabel.Text + "'", StrConnec))
                            {

                                using (OleDbDataReader Reader=CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                    {
                                        TimeLeaveGridView.Rows.Add(j, Reader["Fname"], Reader["Family"], Reader["P_Num"], "", Reader["Shift_Loc"], Reader["Amal"]);
                                        j++;
                                    }
                                }

                            }


                        }
                        else
                        {
                            for (i=0; i <= ShowGridView.RowCount - 1; i++)
                            {
                                using (OleDbCommand CMD=new OleDbCommand("SELECT * FROM Morakhasi WHERE P_Num='" + ShowGridView.Rows[i].Cells[3].Value.ToString() + "' AND Tarikh='" + TripDate.Tarikh() + "' AND Vis=True", StrConnec))
                                {
                                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                                    {
                                        while (Reader.Read())
                                        {
                                            ShowGridView.Rows[i].Cells[7].Value="مرخصی روزانه";
                                            LeavGridView.Rows.Add(LeavGridView.RowCount + 1, ShowGridView.Rows[i].Cells[1].Value, ShowGridView.Rows[i].Cells[2].Value, ShowGridView.Rows[i].Cells[3].Value, ShowGridView.Rows[i].Cells[4].Value, ShowGridView.Rows[i].Cells[5].Value);
                                        }
                                    }

                                }

                            }
                        }
                    }


                    if (Falt > 0)
                    {
                        FaltLabel.Visible=true;
                        Label4.Visible=true;
                    }
                    else
                    {
                        DatabaseButton.Enabled=true;
                    }
                    FaltLabel.Text=Falt.ToString();
                    ShowGridView.CurrentRow.Selected=false;
                }

            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("فایل مورد نظر دارای فرمت صحیح نمی باشد ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                //  Me.Close()
            }
        }

        public void FaultGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    TripFaultsForm ShowForm=new TripFaultsForm();

            //    ShowForm.TabControl1.ItemSize=new Size(1, 1);
            //    ShowForm.DateBox.Text=DateLabel.Text;
            //    ShowForm.NameBox.Text=FaultGridView.CurrentRow.Cells[1].Value.ToString() + " " + FaultGridView.CurrentRow.Cells[2].Value.ToString();
            //    ShowForm.PNumBox.Text=FaultGridView.CurrentRow.Cells[3].Value.ToString();
            //    ShowForm.ShiftBox.Text=FaultGridView.CurrentRow.Cells[4].Value.ToString();
            //    ShowForm.LocalBox.Text=FaultGridView.CurrentRow.Cells[5].Value.ToString();

            //    if (FaultGridView.CurrentRow.Cells[6].Value.ToString() == "اختلاف در تریپ راهبر رزرو")
            //    {

            //        ShowForm.LabelR1.Visible=false;
            //        ShowForm.LabelR2.Visible=false;
            //        ShowForm.LabelR3.Visible=false;
            //        ShowForm.LabelR4.Visible=false;
            //        ShowForm.LabelR5.Visible=false;
            //        ShowForm.LabelR6.Visible=false;
            //        ShowForm.LabelR7.Visible=true;
            //        ShowForm.LabelR8.Visible=true;
            //        ShowForm.LabelR9.Visible=true;

            //        ShowForm.RegTripBox1.Visible=false;
            //        ShowForm.RegTripBox2.Visible=false;
            //        ShowForm.RegTripBox3.Visible=false;
            //        ShowForm.DoneTripBox1.Visible=false;
            //        ShowForm.DoneTripBox2.Visible=false;
            //        ShowForm.DoneTripBox3.Visible=false;
            //        ShowForm.EditTripBox1.Visible=true;
            //        ShowForm.EditTripBox2.Visible=true;
            //        ShowForm.EditTripBox3.Visible=true;

            //        ShowForm.EditTripBox1.Text="__:__";
            //        ShowForm.EditTripBox2.Text="__:__";
            //        ShowForm.EditTripBox3.Text="__:__";

            //        DataRow[] Dr;
            //        if (FaultGridView.CurrentRow.Cells[4].Value.ToString() == "12 ساعته شب قبل")
            //        {
            //            Dr=DtSet.Tables[0].Select("پرسنلی=" + FaultGridView.CurrentRow.Cells[3].Value.ToString() + " AND ساعت<'08:00'");

            //            Taghvim Yester=new Taghvim(DateLabel.Text);
            //            Yester.AddDay(-1);
            //            using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
            //            {
            //                StrConnec.Open();
            //                using (OleDbCommand CMD=new OleDbCommand("SELECT * FROM Rezerv WHERE P_Num='" + FaultGridView.CurrentRow.Cells[3].Value.ToString() + "' AND Tarikh='" + Yester.Tarikh() + "' AND Vis=True", StrConnec))
            //                {
            //                    using (OleDbDataReader Reader=CMD.ExecuteReader())
            //                    {
            //                        while (Reader.Read())
            //                        {
            //                            if (Reader["Trip1"].ToString() != "")
            //                            {
            //                                ShowForm.RegTripBox1.Text=Reader["Trip1"].ToString();
            //                                if (DateTime.Parse(Reader["Trip1"].ToString()) < DateTime.Parse("08:00"))
            //                                {
            //                                    ShowForm.LabelR1.Visible=true;
            //                                    ShowForm.RegTripBox1.Visible=true;
            //                                }
            //                                else
            //                                {
            //                                    ShowForm.EditTripBox1.Text=Reader["Trip1"].ToString();
            //                                    ShowForm.EditTripBox1.Visible=false;
            //                                    ShowForm.LabelR7.Visible=false;
            //                                }
            //                            }
            //                            if (Reader["Trip2"].ToString() != "")
            //                            {
            //                                ShowForm.RegTripBox2.Text=Reader["Trip2"].ToString();
            //                                if (DateTime.Parse(Reader["Trip2"].ToString()) < DateTime.Parse("08:00"))
            //                                {
            //                                    ShowForm.LabelR2.Visible=true;
            //                                    ShowForm.RegTripBox2.Visible=true;
            //                                }
            //                                else
            //                                {
            //                                    ShowForm.EditTripBox2.Text=Reader["Trip2"].ToString();
            //                                    ShowForm.EditTripBox2.ReadOnly=false;
            //                                    ShowForm.LabelR8.Visible=false;
            //                                }
            //                            }
            //                            if (Reader["Trip3"].ToString() != "")
            //                            {
            //                                ShowForm.RegTripBox3.Text=Reader["Trip3"].ToString();
            //                                if (DateTime.Parse(Reader["Trip3"].ToString()) < DateTime.Parse("08:00"))
            //                                {
            //                                    ShowForm.LabelR3.Visible=true;
            //                                    ShowForm.RegTripBox3.Visible=true;
            //                                }
            //                                else
            //                                {
            //                                    ShowForm.EditTripBox3.Text=Reader["Trip3"].ToString();
            //                                    ShowForm.EditTripBox3.Visible=false;
            //                                    ShowForm.LabelR9.Visible=false;
            //                                }
            //                            }
            //                        }
            //                    }

            //                }

            //            }


            //        }
            //        else if (FaultGridView.CurrentRow.Cells[4].Value.ToString() == "12 ساعته شب")
            //        {
            //            Dr=DtSet.Tables[0].Select("پرسنلی=" + FaultGridView.CurrentRow.Cells[3].Value.ToString() + " AND ساعت>'19:00'");

            //            using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
            //            {
            //                StrConnec.Open();
            //                Taghvim Yester=new Taghvim(DateLabel.Text);
            //                Yester.AddDay(-1);
            //                using (OleDbCommand CMD=new OleDbCommand("SELECT * FROM Rezerv WHERE P_Num='" + FaultGridView.CurrentRow.Cells[3].Value.ToString() + "' AND Tarikh='" + Yester.Tarikh() + "' AND Vis=True", StrConnec))
            //                using (OleDbDataReader Reader=CMD.ExecuteReader())
            //                    while (Reader.Read())
            //                    {
            //                        if (Reader["Trip1"].ToString() != "")
            //                        {
            //                            ShowForm.RegTripBox1.Text=Reader["Trip1"].ToString();
            //                            if (DateTime.Parse(Reader["Trip1"].ToString()) > DateTime.Parse("19:00"))
            //                            {
            //                                ShowForm.LabelR1.Visible=true;
            //                                ShowForm.RegTripBox1.Visible=true;
            //                            }
            //                            else
            //                            {
            //                                ShowForm.EditTripBox1.Text=Reader["Trip1"].ToString();
            //                                ShowForm.EditTripBox1.Visible=false;
            //                                ShowForm.LabelR7.Visible=false;
            //                            }
            //                        }
            //                        if (Reader["Trip2"].ToString() != "")
            //                        {
            //                            ShowForm.RegTripBox2.Text=Reader["Trip2"].ToString();
            //                            if (DateTime.Parse(Reader["Trip2"].ToString()) > DateTime.Parse("19:00"))
            //                            {
            //                                ShowForm.LabelR2.Visible=true;
            //                                ShowForm.RegTripBox2.Visible=true;
            //                            }
            //                            else
            //                            {
            //                                ShowForm.EditTripBox2.Text=Reader["Trip2"].ToString();
            //                                ShowForm.EditTripBox2.Visible=false;
            //                                ShowForm.LabelR8.Visible=false;
            //                            }
            //                        }
            //                        if (Reader["Trip3"].ToString() != "")
            //                        {
            //                            ShowForm.RegTripBox3.Text=Reader["Trip3"].ToString();
            //                            if (DateTime.Parse(Reader["Trip3"].ToString()) > DateTime.Parse("19:00"))
            //                            {
            //                                ShowForm.LabelR3.Visible=true;
            //                                ShowForm.RegTripBox3.Visible=true;
            //                            }
            //                            else
            //                            {
            //                                ShowForm.EditTripBox3.Text=Reader["Trip3"].ToString();
            //                                ShowForm.EditTripBox3.Visible=false;
            //                                ShowForm.LabelR9.Visible=false;
            //                            }
            //                        }
            //                    }
            //            }

            //        }
            //        else
            //        {

            //            using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
            //            {
            //                StrConnec.Open();
            //                using (OleDbCommand CMD=new OleDbCommand("SELECT * FROM Rezerv WHERE P_Num='" + FaultGridView.CurrentRow.Cells[3].Value.ToString() + "' AND Tarikh='" + DateLabel.Text + "' AND Vis=True", StrConnec))
            //                {
            //                    using (OleDbDataReader Reader=CMD.ExecuteReader())
            //                    {
            //                        while (Reader.Read())
            //                        {
            //                            if (Reader["Trip1"].ToString().Length > 0)
            //                            {
            //                                ShowForm.RegTripBox1.Text=Reader["Trip1"].ToString();
            //                                ShowForm.LabelR1.Visible=true;
            //                                ShowForm.RegTripBox1.Visible=true;
            //                            }
            //                            if (Reader["Trip2"].ToString().Length > 0)
            //                            {
            //                                ShowForm.RegTripBox2.Text=Reader["Trip2"].ToString();
            //                                ShowForm.LabelR2.Visible=true;
            //                                ShowForm.RegTripBox2.Visible=true;
            //                            }
            //                            if (Reader["Trip3"].ToString().Length > 0)
            //                            {
            //                                ShowForm.RegTripBox3.Text=Reader["Trip3"].ToString();
            //                                ShowForm.LabelR3.Visible=true;
            //                                ShowForm.RegTripBox3.Visible=true;
            //                            }
            //                        }
            //                    }

            //                }


            //            }


            //            if (FaultGridView.CurrentRow.Cells[4].Value.ToString() == "12 ساعته شب")
            //            {
            //                Dr=DtSet.Tables[0].Select("پرسنلی=" + FaultGridView.CurrentRow.Cells[3].Value.ToString() + " AND ساعت>'19:00'");
            //            }
            //            else if (FaultGridView.CurrentRow.Cells[4].Value.ToString() == "12 ساعته روز")
            //            {
            //                Dr=DtSet.Tables[0].Select("پرسنلی=" + FaultGridView.CurrentRow.Cells[3].Value.ToString() + " AND ساعت>'07:30' AND ساعت<'19:30'");
            //            }
            //            else if (FaultGridView.CurrentRow.Cells[4].Value.ToString() == "9 ساعته صبح")
            //            {
            //                Dr=DtSet.Tables[0].Select("پرسنلی=" + FaultGridView.CurrentRow.Cells[3].Value.ToString() + " AND ساعت>'05:00' AND ساعت<'14:30'");
            //            }
            //            else if (FaultGridView.CurrentRow.Cells[4].Value.ToString() == "9 ساعته عصر")
            //            {
            //                Dr=DtSet.Tables[0].Select("پرسنلی=" + FaultGridView.CurrentRow.Cells[3].Value.ToString() + " AND ساعت>'13:30' AND ساعت<'23:00'");
            //            }
            //            else if (FaultGridView.CurrentRow.Cells[4].Value.ToString() == "ستادی")
            //            {
            //                Dr=DtSet.Tables[0].Select("پرسنلی=" + FaultGridView.CurrentRow.Cells[3].Value.ToString() + " AND ساعت>'07:30' AND ساعت<'15:30'");
            //            }
            //            else
            //            {
            //                Dr=DtSet.Tables[0].Select("پرسنلی=" + FaultGridView.CurrentRow.Cells[3].Value.ToString();
            //            }
            //        }

            //        if (Dr.Length > 0)
            //        {
            //            ShowForm.DoneTripBox1.Text=Dr[0].ItemArray.GetValue(6).ToString();
            //            ShowForm.LabelR4.Visible=true;
            //            ShowForm.DoneTripBox1.Visible=true;
            //        }
            //        if (Dr.Length > 2)
            //        {
            //            ShowForm.DoneTripBox2.Text=Dr[2].ItemArray.GetValue(6).ToString();
            //            ShowForm.LabelR5.Visible=true;
            //            ShowForm.DoneTripBox2.Visible=true;
            //        }
            //        if (Dr.Length > 6)
            //        {
            //            ShowForm.DoneTripBox3.Text=Dr[4].ItemArray.GetValue(6).ToString();
            //            ShowForm.LabelR6.Visible=true;
            //            ShowForm.DoneTripBox3.Visible=true;
            //        }

            //        ShowForm.TabControl1.SelectedIndex=0;
            //        if (ShowForm.ShowDialog() == DialogResult.OK)
            //        {
            //            ShowGridView.Rows[(int)FaultGridView.CurrentRow.Cells[7].Value].DefaultCellStyle.BackColor=DefaultBackColor;
            //            FaultGridView.Rows.RemoveAt(FaultGridView.CurrentRow.Index);
            //        }

            //    }
            //    else if (FaultGridView.CurrentRow.Cells[6].Value.ToString() == "راهبر شیفت بدون تریپ ثبت شده")
            //    {

            //        ShowForm.TabControl1.SelectedIndex=1;
            //        ShowForm.TimeRadio.Visible=false;
            //        ShowForm.LastNightLabel.Visible=false;

            //        if (FaultGridView.CurrentRow.Cells[4].Value.ToString() == "12 ساعته شب" || FaultGridView.CurrentRow.Cells[4].Value.ToString() == "12 ساعته شب قبل")
            //        {
            //            ShowForm.TimeRadio.Visible=true;
            //            if (FaultGridView.CurrentRow.Cells[4].Value.ToString() == "12 ساعته شب قبل")
            //            {
            //                ShowForm.TimeRadio.Visible=true;
            //                ShowForm.LastNightLabel.Visible=true;

            //                Taghvim Yester=new Taghvim(DateLabel.Text);
            //                Yester.AddDay(-1);
            //                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
            //                {
            //                    StrConnec.Open();
            //                    using (OleDbCommand CMD=new OleDbCommand("SELECT * FROM DailyStatus WHERE P_Num='" + FaultGridView.CurrentRow.Cells[3].Value.ToString() + "' AND Tarikh='" + Yester.Tarikh() + "' AND Vis=True", StrConnec))
            //                    {
            //                        using (OleDbDataReader Reader=CMD.ExecuteReader())
            //                        {
            //                            while (Reader.Read())
            //                            {
            //                                ShowForm.LastNightLabel.Text="عملکرد شب قبل: " + Reader["D_Status"].ToString() + " - " + Reader["D_Trip"].ToString() + " تریپ - " + Reader["D_Time"].ToString() + " کارکرد";
            //                            }
            //                        }

            //                    }

            //                }

            //            }
            //        }

            //        if (ShowForm.ShowDialog() == DialogResult.OK)
            //        {
            //            ShowGridView.Rows[(int)FaultGridView.CurrentRow.Cells[7].Value].DefaultCellStyle.BackColor=DefaultBackColor;

            //            if (ShowForm.TimeRadio.Checked)
            //            {
            //                ShowGridView.Rows[(int)FaultGridView.CurrentRow.Cells[7].Value].Cells[7].Value="شیفت";
            //            }
            //            else if (ShowForm.LeavRadio.Checked)
            //            {
            //                ShowGridView.Rows[(int)FaultGridView.CurrentRow.Cells[7].Value].Cells[7].Value="مرخصی روزانه";
            //            }
            //            else if (ShowForm.ReservRadio.Checked)
            //            {
            //                ShowGridView.Rows[(int)FaultGridView.CurrentRow.Cells[7].Value].Cells[7].Value="رزرو";
            //            }
            //            else if (ShowForm.ShunterRadio.Checked)
            //            {
            //                ShowGridView.Rows[(int)FaultGridView.CurrentRow.Cells[7].Value].Cells[7].Value="راهبر پایانه";
            //            }

            //            FaultGridView.Rows.RemoveAt(FaultGridView.CurrentRow.Index);
            //            FaltLabel.Text=FaultGridView.RowCount.ToString();
            //        }

            //    }
            //    else if (FaultGridView.CurrentRow.Cells[6].Value.ToString() == "ثبت تریپ در زمان مرخصی روزانه")
            //    {
            //        if (MessageBoxFa.Show("مرخصی روزانه " + FaultGridView.CurrentRow.Cells[1].Value.ToString() + " " + FaultGridView.CurrentRow.Cells[2].Value.ToString() + " در تاریخ " + DateLabel.Text + " حذف شوند؟", "تایید", MessageBoxIcon.Information, MessageBoxButtons.YesNo, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            //        {

            //            using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
            //            {
            //                StrConnec.Open();
            //                using (OleDbCommand CMD=new OleDbCommand("UPDATE Morakhasi SET Vis=False, U_Reg='" + AppState.UserName + "', T_Reg='" + MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") + "' WHERE P_Num='" + FaultGridView.CurrentRow.Cells[3].Value.ToString() + "' AND Tarikh='" + DateLabel.Text + "'", StrConnec))
            //                {
            //                    CMD.ExecuteNonQuery();
            //                }

            //            }


            //            ShowGridView.Rows[(int)FaultGridView.CurrentRow.Cells[7].Value].DefaultCellStyle.BackColor=DefaultBackColor;
            //            ShowGridView.Rows[(int)FaultGridView.CurrentRow.Cells[7].Value].Cells[7].Value="شیفت";

            //            FaultGridView.Rows.RemoveAt(FaultGridView.CurrentRow.Index);

            //        }
            //        else if (MessageBoxFa.Show("تریپ های  " + FaultGridView.CurrentRow.Cells[1].Value.ToString() + " " + FaultGridView.CurrentRow.Cells[2].Value.ToString() + " در تاریخ " + DateLabel.Text + " حذف شوند؟", "تایید", MessageBoxIcon.Information, MessageBoxButtons.YesNo, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            //        {

            //            ShowGridView.Rows[(int)FaultGridView.CurrentRow.Cells[7].Value].DefaultCellStyle.BackColor=DefaultBackColor;
            //            ShowGridView.Rows[(int)FaultGridView.CurrentRow.Cells[7].Value].Cells[6].Value=0;
            //            ShowGridView.Rows[(int)FaultGridView.CurrentRow.Cells[7].Value].Cells[8].Value="09:00";

            //            FaultGridView.Rows.RemoveAt(FaultGridView.CurrentRow.Index);
            //        }
            //    }
            //    else if (FaultGridView.CurrentRow.Cells[6].Value.ToString() == "فرد بودن تعداد حرکت")
            //    {
            //        DataRow[] Dr;
            //        Dr=DtSet.Tables[0].Select("پرسنلی=" + FaultGridView.CurrentRow.Cells[3].Value.ToString();
            //        if (Dr.Length >= 1)
            //        {
            //            ShowForm.TripLabel1.Text=Dr[0].ItemArray.GetValue(6).ToString() + "  " + Dr[0].ItemArray.GetValue(5).ToString() + "  " + Dr[0].ItemArray.GetValue(0).ToString();
            //            ShowForm.TripLabel1.Visible=true;
            //        }
            //        else
            //        {
            //            ShowForm.TripLabel1.Visible=false;
            //        }
            //        if (Dr.Length >= 2)
            //        {
            //            ShowForm.TripLabel2.Text=Dr[1].ItemArray.GetValue(6).ToString() + "  " + Dr[1].ItemArray.GetValue(5).ToString() + "  " + Dr[0].ItemArray.GetValue(0).ToString();
            //            ShowForm.TripLabel2.Visible=true;
            //        }
            //        else
            //        {
            //            ShowForm.TripLabel2.Visible=false;
            //        }
            //        if (Dr.Length >= 3)
            //        {
            //            ShowForm.TripLabel3.Text=Dr[2].ItemArray.GetValue(6).ToString() + "  " + Dr[2].ItemArray.GetValue(5).ToString() + "  " + Dr[0].ItemArray.GetValue(0).ToString();
            //            ShowForm.TripLabel3.Visible=true;
            //        }
            //        else
            //        {
            //            ShowForm.TripLabel3.Visible=false;
            //        }
            //        if (Dr.Length >= 4)
            //        {
            //            ShowForm.TripLabel4.Text=Dr[3].ItemArray.GetValue(6).ToString() + "  " + Dr[3].ItemArray.GetValue(5).ToString() + "  " + Dr[0].ItemArray.GetValue(0).ToString();
            //            ShowForm.TripLabel4.Visible=true;
            //        }
            //        else
            //        {
            //            ShowForm.TripLabel4.Visible=false;
            //        }
            //        if (Dr.Length >= 5)
            //        {
            //            ShowForm.TripLabel5.Text=Dr[4].ItemArray.GetValue(6).ToString() + "  " + Dr[4].ItemArray.GetValue(5).ToString() + "  " + Dr[0].ItemArray.GetValue(0).ToString();
            //            ShowForm.TripLabel5.Visible=true;
            //        }
            //        else
            //        {
            //            ShowForm.TripLabel5.Visible=false;
            //        }
            //        if (Dr.Length >= 6)
            //        {
            //            ShowForm.TripLabel6.Text=Dr[5].ItemArray.GetValue(6).ToString() + "  " + Dr[5].ItemArray.GetValue(5).ToString() + "  " + Dr[0].ItemArray.GetValue(0).ToString();
            //            ShowForm.TripLabel6.Visible=true;
            //        }
            //        else
            //        {
            //            ShowForm.TripLabel6.Visible=false;
            //        }
            //        if (Dr.Length >= 7)
            //        {
            //            ShowForm.TripLabel7.Text=Dr[6].ItemArray.GetValue(6).ToString() + "  " + Dr[6].ItemArray.GetValue(5).ToString() + "  " + Dr[0].ItemArray.GetValue(0).ToString();
            //            ShowForm.TripLabel7.Visible=true;
            //        }
            //        else
            //        {
            //            ShowForm.TripLabel7.Visible=false;
            //        }
            //        if (Dr.Length >= 8)
            //        {
            //            ShowForm.TripLabel8.Text=Dr[7].ItemArray.GetValue(6).ToString() + "  " + Dr[7].ItemArray.GetValue(5).ToString() + "  " + Dr[0].ItemArray.GetValue(0).ToString();
            //            ShowForm.TripLabel8.Visible=true;
            //        }
            //        else
            //        {
            //            ShowForm.TripLabel8.Visible=false;
            //        }

            //        ShowForm.TabControl1.SelectedIndex=3;
            //        if (ShowForm.ShowDialog() == DialogResult.OK)
            //        {
            //            ShowGridView.Rows[(int)FaultGridView.CurrentRow.Cells[7].Value].DefaultCellStyle.BackColor=DefaultBackColor;
            //            FaultGridView.Rows.RemoveAt(FaultGridView.CurrentRow.Index);
            //            FaltLabel.Text=FaultGridView.RowCount.ToString();
            //        }
            //    }

            //    FaltLabel.Text=FaultGridView.RowCount.ToString();
            //    if (FaultGridView.RowCount == 0)
            //    {
            //        DatabaseButton.Enabled=true;
            //    }
            //    else
            //    {
            //        int i;
            //        for (i=0; i <= FaultGridView.RowCount - 1; i++)
            //        {
            //            FaultGridView.Rows[i].Cells[0].Value=i + 1;
            //        }
            //        DatabaseButton.Enabled=false;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
            //    MessageBoxFa.Show("فایل مورد نظر دارای فرمت صحیح نمی باشد ", "خطا در اجرای دستور", MessageBoxIcon.Error);
            //    //  Me.Close()
            //}
        }

        public void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControl1.SelectedTab.Name == "TripTab" && AppState.UserLevel == 0)
            {
                TripRegButton.Visible=true;
            }
            else
            {
                TripRegButton.Visible=false;
            }
        }

        public void DatabaseButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBoxFa.Show("داده ها ثبت شوند؟", "تایید", MessageBoxIcon.Information, MessageBoxButtons.YesNo, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    using (WaitForm wait=new WaitForm())
                    {
                        wait.Show();
                        wait.Refresh();



                        Taghvim TripYesterday=new Taghvim(DateLabel.Text);
                        TripYesterday.AddDay(-1);

                        using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                        {
                            StrConnec.Open();

                            int i;
                            for (i=0; i <= ShowGridView.RowCount - 1; i++)
                            {
                                if (ShowGridView.Rows[i].Cells[4].Value.ToString() == "12 ساعته شب قبل")
                                {
                                    double DTrip=0;
                                    double DTime=0;
                                    DTrip=0;
                                    DTime=0;

                                    using (OleDbCommand CMD=new OleDbCommand("SELECT * FROM DailyStatus WHERE P_Num='" + ShowGridView.Rows[i].Cells[3].Value.ToString() + "' AND Tarikh='" + TripYesterday.Tarikh() + "' AND Vis=True", StrConnec))
                                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                                    {
                                        while (Reader.Read())
                                        {
                                            DTime=ConvertClass.TimeToDouble(Reader["D_Time"].ToString());
                                            DTrip=double.Parse(Reader["D_Trip"].ToString());
                                        }
                                    }

                                    DTime += ConvertClass.TimeToDouble(ShowGridView.Rows[i].Cells[8].Value.ToString());
                                    DTrip += Convert.ToDouble(Convert.ToInt32(ShowGridView.Rows[i].Cells[6].Value) / 2);

                                    if (DTime < 12)
                                    {
                                        DTime=12;
                                    }

                                    using (OleDbCommand CMD=new OleDbCommand("UPDATE DailyStatus SET D_Time='" + ConvertClass.DoubleToTime(DTime) + "', D_Trip=" + DTrip.ToString() + " WHERE P_NUM='" + ShowGridView.Rows[i].Cells[3].Value.ToString() + "' AND Tarikh='" + TripYesterday.Tarikh() + "' AND Vis=True", StrConnec))
                                    {
                                        CMD.ExecuteNonQuery();
                                    }
                                }
                                else
                                {
                                    using (OleDbCommand CMD=new OleDbCommand("INSERT INTO DailyStatus (P_NUM, Tarikh, D_Status, D_Trip, D_Time, U_Reg, T_Reg, Vis) VALUES ('" + ShowGridView.Rows[i].Cells[3].Value.ToString() + "', '" + DateLabel.Text + "', '" + ShowGridView.Rows[i].Cells[7].Value.ToString() + "'," + (Convert.ToInt32(ShowGridView.Rows[i].Cells[6].Value) / 2).ToString() + ", '" + ShowGridView.Rows[i].Cells[8].Value.ToString() + "', '" + AppState.UserName + "', '" + MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") + "', True)", StrConnec))
                                    {
                                        CMD.ExecuteNonQuery();
                                    }
                                }
                            }
                            TripReg();
                        }


                        wait.Close();
                    }
                    MessageBoxFa.Show("ثبت با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);

                    DtSet.Tables.Remove("Test");
                    ShowGridView.Rows.Clear();
                    TripGridView.Rows.Clear();
                    FaultGridView.Rows.Clear();
                    LeavGridView.Rows.Clear();
                    ReservGridView.Rows.Clear();
                    DatabaseButton.Enabled=false;
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void DatabaseButton_EnabledChanged(object sender, EventArgs e)
        {
            if (DatabaseButton.Enabled)
            {
                DatabaseButton.BackColor=Color.Lime;
            }
            else
            {
                DatabaseButton.BackColor=DefaultBackColor;
            }
        }

        public void TripRegButton_Click(object sender, EventArgs e)
        {
            using (WaitForm wait=new WaitForm())
            {
                wait.Show();
                wait.Refresh();

                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    TripReg();
                }

                wait.Close();
            }
            MessageBoxFa.Show("ثبت با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
        }

        public void InternetButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt=new DataTable();
                dt.Columns.Add("P_Num");
                dt.Columns.Add("T_Date");
                dt.Columns.Add("T_Time");
                dt.Columns.Add("Mabda");
                dt.Columns.Add("Maghsad");
                dt.Columns.Add("Pos");

                int i;
                int j=0;
                for (i=0; i <= TripGridView.RowCount - 1; i++)
                {
                    DataRow dRow=dt.NewRow();
                    for (j=0; j <= 4; j++)
                    {
                        dRow[j]=TripGridView.Rows[i].Cells[j + 2].Value.ToString();
                    }
                    switch (TripGridView.Rows[i].Cells[7].Value.ToString())
                    {
                        case "راهبر":
                            dRow[5]="H";
                            break;
                        case "كمك راهبر":
                            dRow[5]="R";
                            break;
                        case "راهبر آموزشي":
                            dRow[5]="T";
                            break;
                    }
                    dt.Rows.Add(dRow);
                }

                //Dim lohe As String=JsonConvert.SerializeObject(dt)
                //Dim Serv As New ir.seiroharekat.AliServ
                //Dim Res As String=Serv.GetLoheh(lohe)
                //If Res=1 Then
                //    MessageBoxFa.Show("ارسال با موفقیت انجام شده است ")
                //ElseIf Res=3 Then
                //    MessageBoxFa.Show("داده ها قبلا ثبت شده است", "خطا", MessageBoxIcon.Error)
                //Else
                //    MessageBoxFa.Show("لطفا با ادمین تماس بگیرید ", "خطا در ارسال اطلاعات ", MessageBoxIcon.Error)
                //End If

            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا ارتباط اینترنت را بررسی کنید \n درصورت عدم رفع خطا با ادمین تماس بگیرید \n", "خطا در ارسال اطلاعات ", MessageBoxIcon.Error);
            }
        }

        public void SelectButton_Click(object sender, EventArgs e)
        {
            if (DtSet.Tables.Count > 0)
            {
                if (MessageBoxFa.Show("داده های موجود نشده است \n\n فایل جدید بارگذاری گردد؟", "توجه", MessageBoxIcon.Exclamation, MessageBoxButtons.YesNo, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }
            }

            OpenFileDialog OpenFileDialog1=new OpenFileDialog()
            {
                Filter="Excel Worksheets|*.xls;*.xlsx"
            };
            DialogResult Resul=OpenFileDialog1.ShowDialog(this);
            if (Resul == DialogResult.OK)
            {
                NameBox.Text=OpenFileDialog1.FileName;

            }
        }
    }
}
