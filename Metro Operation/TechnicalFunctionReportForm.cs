using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class TechnicalFunctionReportForm
    {
        public TechnicalFunctionReportForm()
        {
            InitializeComponent();
        }


        private string PName;
        private string PFamily;
        private string PNum;

        public void Clean()
        {
            EditButton.Enabled=false;
            CompeletView.Rows.Clear();
            DetailView.Rows.Clear();
            FaultBox.Clear();
            MemBox.Clear();
        }

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void DetailShow()
        {
            if (DetailView.CurrentCellAddress.Y >= 0)
            {
                int i=0;
                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    using (OleDbCommand CMD=new OleDbCommand("SELECT * FROM Fanni WHERE P_Num='" + CompeletView.SelectedRows[0].Cells[3].Value + "' AND Tarikh='" + DetailView.CurrentRow.Cells[1].Value + "' AND  Loco='" + DetailView.CurrentRow.Cells[2].Value + "' AND E_Time='" + DetailView.CurrentRow.Cells[3].Value + "' AND E_Loc='" + DetailView.CurrentRow.Cells[4].Value + "' AND Shomare='" + DetailView.CurrentRow.Cells[5].Value + "' AND Vis=True", StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            if ((bool)Reader["Nach"])
                            {
                                i++;
                                FaultBox.Text += i.ToString() + ") عدم استفاده صحيح از ناچ حركتی\n";
                            }
                            if ((bool)Reader["Tormoz"])
                            {
                                i++;
                                FaultBox.Text += i.ToString() + ") عدم استفاده صحيح از ترمز قطار\n";
                            }

                            if ((bool)Reader["RedSig"])
                            {
                                i++;
                                FaultBox.Text += i.ToString() + ") عبور از چراغ قرمز یا آبی شانت\n";
                            }

                            if ((bool)Reader["NoDoor"])
                            {
                                i++;
                                FaultBox.Text += i.ToString() + ") باز نكردن دربها در طول مسير\n";
                            }
                            if ((bool)Reader["OpenDoor"])
                            {
                                i++;
                                FaultBox.Text += i.ToString() + ") حركت با درب باز بر روی سکو\n";
                            }
                            if ((bool)Reader["Falt"])
                            {
                                i++;
                                FaultBox.Text += i.ToString() + ") مسافرگيري قبل از رفع فالت\n";
                            }
                            if ((bool)Reader["Etela"])
                            {
                                i++;
                                FaultBox.Text += i.ToString() + ") عدم اطلاع رسانی به موقع\n";
                            }
                            if ((bool)Reader["RM_Teh"])
                            {
                                i++;
                                FaultBox.Text += i.ToString() + ") فعال كردن مد RM(تهران)\n";
                            }
                            if ((bool)Reader["Hi_Sooz"])
                            {
                                i++;
                                FaultBox.Text += i.ToString() + ") سرعت بالا روي سوزنها\n";
                            }
                            if ((bool)Reader["Bolo_Off"])
                            {
                                i++;
                                FaultBox.Text += i.ToString() + ") حركت با بلور خاموش\n";
                            }
                            if ((bool)Reader["Arno_Off"])
                            {
                                i++;
                                FaultBox.Text += i.ToString() + ") خاموش نمودن آرنو\n";
                            }
                            if ((bool)Reader["ATP_Off"])
                            {
                                i++;
                                FaultBox.Text += i.ToString() + ") خاموش نمودن ATP\n";
                            }
                            if ((bool)Reader["EM_ATP"])
                            {
                                i++;
                                FaultBox.Text += i.ToString() + ") عدم رعايت كد ATP\n";
                            }
                            if ((bool)Reader["Hi_Speed"])
                            {
                                i++;
                                FaultBox.Text += i.ToString() + ") سرعت بالا\n";
                            }
                            if ((bool)Reader["N_etc"])
                            {
                                i++;
                                FaultBox.Text += i.ToString() + ") ساير (منفي)\n";
                            }
                            if ((bool)Reader["P_etc"])
                            {
                                i++;
                                FaultBox.Text += i.ToString() + ") ساير (مثبت)\n";
                            }
                            MemBox.Text=Reader["Mem"].ToString();
                        }
                    }
                }
            }
        }
        public void TechnicalFunctionReportForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Help.ShowHelp(this, AppState.DatabasePath + "\\Help\\help.chm", HelpNavigator.TopicId, "040402");
        }

        public void Form19_Load(object sender, EventArgs e)
        {
            try
            {
                if (AppState.UserLevel == 9 || AppState.UserLevel == 19)
                {
                    PNum=AppState.UserPnum;
                    NameButton.Enabled=false;
                    NameBox.Text=AppState.UserName;
                }

                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    UserCombo.Items.Add("همه کاربران");

                    using (OleDbCommand CMD=new OleDbCommand("SELECT DISTINCT U_Extr FROM Fanni WHERE U_Extr<>'' ORDER BY U_Extr", StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            UserCombo.Items.Add(Reader["U_Extr"].ToString());
                        }
                    }
                }


                StartCalendar.FirstDayOfMonth_Click(null, null);
                EndCalendar.LastDayOfMonth_Click(null, null);

                if (AppState.UserLevel == 1 || AppState.UserLevel == 2 || AppState.UserLevel == 3 || AppState.UserLevel == 5)
                {
                    EditButton.Visible=true;
                }
                else
                {
                    EditButton.Visible=false;
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DetailView.Rows.Clear();
                FaultBox.Text="";
                MemBox.Text="";
                if (CompeletView.SelectedRows.Count > 0)
                {
                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        int i=1;

                        string QueStr="SELECT * FROM Fanni WHERE P_Num='" + CompeletView.CurrentRow.Cells[3].Value.ToString() + "' AND Vis=True AND Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "'";
                        if ((string)UserCombo.SelectedItem != "همه موارد")
                        {
                            QueStr += " AND (U_Reg='" + UserCombo.Text + "' OR U_Extr='" + UserCombo.Text + "')";
                        }

                        using (OleDbCommand CMD=new OleDbCommand(QueStr, StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                DetailView.Rows.Add(i, Reader["Tarikh"].ToString(), Reader["Loco"].ToString(), Reader["E_Time"].ToString(), Reader["E_Loc"].ToString(), Reader["Shomare"].ToString(), Reader["Emt"].ToString(), Reader["U_Extr"].ToString(), Reader["U_Reg"].ToString());
                                i++;
                            }
                        }
                    }

                    if (DetailView.Rows.Count == 0)
                    {
                        DetailView.Enabled=false;
                        MessageBoxFa.Show(" داده ای یافت نشد ", "توجه", MessageBoxIcon.Warning);
                    }
                    if (DetailView.RowCount == 0)
                    {
                        DetailView.Enabled=false;
                    }
                    else
                    {
                        DetailView.Enabled=true;
                        DetailShow();
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

        public void DetailView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FaultBox.Text="";
            MemBox.Text="";
            if (DetailView.SelectedRows.Count > 0)
            {
                DetailShow();
            }
        }

        public void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void EditButton_Click(object sender, EventArgs e)
        {
            if (CompeletView.CurrentRow.Index >= 0)
            {
                TechnicalFunctionEditForm ShowForm=new TechnicalFunctionEditForm();
                ShowForm.SearchNameBox.Text=CompeletView.CurrentRow.Cells[1].Value.ToString() + " " + CompeletView.CurrentRow.Cells[2].Value.ToString();
                ShowForm.PNum=CompeletView.CurrentRow.Cells[3].Value.ToString();
                ShowForm.SearchPersianCalendar.Text=DetailView.CurrentRow.Cells[1].Value.ToString();
                ShowForm.SearchLocoBox.Text=DetailView.CurrentRow.Cells[2].Value.ToString();
                ShowForm.SearchTimeBox.Text=DetailView.CurrentRow.Cells[3].Value.ToString();
                ShowForm.SearchLocalCombo.Text=DetailView.CurrentRow.Cells[4].Value.ToString();
                ShowForm.SearchLetterBox.Text=DetailView.CurrentRow.Cells[5].Value.ToString();
                ShowForm.Show();
                Close();
            }
        }

        public void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                CompeletView.Rows.Clear();
                EditButton.Enabled=false;
                DateTime StartDate;
                DateTime EndDate;
                StartDate=ConvertClass.ShamsiToMiladi(StartCalendar.Text);
                EndDate=ConvertClass.ShamsiToMiladi(EndCalendar.Text);

                if (UserCombo.SelectedIndex < 0)
                {
                    ErrorShow(UserCombo, " نام کاربر را مشخص کنید");
                }
                else if (StartDate == null)
                {
                    ErrorShow(StartCalendar, "تاریخ شروع گزارش را مشخص کنید");
                }
                else if (EndDate == null)
                {
                    ErrorShow(EndCalendar, "تاریخ پایان گزارش را مشخص کنید");
                }
                else if (EndDate < StartDate)
                {
                    ErrorShow(StartCalendar, "بازه زمانی گزارش صحیح نیست");
                    ErrorShow(EndCalendar, "بازه زمانی گزارش صحیح نیست");
                }
                else
                {
                    int i;
                    int j=0;
                    int Negat=0;
                    int Posit=0;
                    int Emt=0;
                    i=1;
                    Enabled=false;

                    string QueStr="LicenseDegree<>'بدون گواهینامه'";
                    if (NameBox.Text.Length > 0)
                    {
                        QueStr += " AND P_Num='" + PNum + "'";
                    }
                    else if (AppState.UserLevel > 1)
                    {
                        QueStr += " AND Line_Num='" + AppState.UserLnum + "'";
                    }

                    DataRow[] DRow=MainForm.PersonTable.Select(QueStr, "Family");
                    foreach (DataRow DtR in DRow)
                    {
                        CompeletView.Rows.Add(i, DtR["Fname"].ToString(), DtR["Family"].ToString(), DtR["P_Num"].ToString(), 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                        i++;
                    }

                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        for (i=0; i <= CompeletView.RowCount - 1; i++)
                        {
                            j=0;
                            Negat=0;
                            Posit=0;
                            Emt=0;

                            QueStr="SELECT * FROM Fanni WHERE P_Num='" + CompeletView.Rows[i].Cells[3].Value.ToString() + "' AND Vis=True AND Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "'";
                            if ((string)UserCombo.SelectedItem != "همه موارد")
                            {
                                QueStr += " AND (U_Reg='" + UserCombo.Text + "' OR U_Extr='" + UserCombo.Text + "')";
                            }

                            using (OleDbCommand CMD=new OleDbCommand(QueStr, StrConnec))
                            using (OleDbDataReader Reader=CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    if ((bool)Reader["Nach"])
                                    {
                                        Negat++;
                                    }

                                    if ((bool)Reader["Tormoz"])
                                    {
                                        Negat++;
                                    }

                                    if ((bool)Reader["RedSig"])
                                    {
                                        Negat++;
                                    }

                                    if ((bool)Reader["NoDoor"])
                                    {
                                        Negat++;
                                    }

                                    if ((bool)Reader["OpenDoor"])
                                    {
                                        Negat++;
                                    }

                                    if ((bool)Reader["Falt"])
                                    {
                                        Negat++;
                                    }

                                    if ((bool)Reader["Etela"])
                                    {
                                        Negat++;
                                    }

                                    if ((bool)Reader["RM_Teh"])
                                    {
                                        Negat++;
                                    }

                                    if ((bool)Reader["Hi_Sooz"])
                                    {
                                        Negat++;
                                    }

                                    if ((bool)Reader["Bolo_Off"])
                                    {
                                        Negat++;
                                    }

                                    if ((bool)Reader["Arno_Off"])
                                    {
                                        Negat++;
                                    }

                                    if ((bool)Reader["ATP_Off"])
                                    {
                                        Negat++;
                                    }

                                    if ((bool)Reader["EM_ATP"])
                                    {
                                        Negat++;
                                    }

                                    if ((bool)Reader["Hi_Speed"])
                                    {
                                        Negat++;
                                    }

                                    if ((bool)Reader["N_etc"])
                                    {
                                        Negat++;
                                    }

                                    if ((bool)Reader["P_etc"])
                                    {
                                        Posit++;
                                    }

                                    if (Reader["Emt"].ToString() != "0" && !string.IsNullOrEmpty(Reader["Emt"].ToString()))
                                    {
                                        Emt += Convert.ToInt32(Reader["Emt"]);
                                    }

                                    j++;
                                }
                            }

                            CompeletView.Rows[i].Cells[4].Value=j;
                            CompeletView.Rows[i].Cells[5].Value=Negat;
                            CompeletView.Rows[i].Cells[6].Value=Posit;
                            CompeletView.Rows[i].Cells[7].Value=Emt;
                        }
                    }

                    CompeletView.CurrentRow.Selected=false;
                    EditButton.Enabled=true;
                    Enabled=true;
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void NameButton_Click(object sender, EventArgs e)
        {
            Clean();
            NameBox.Text="";
            NameButton.Image=Properties.Resources.user;
            PersonalSelectForm ShowForm=new PersonalSelectForm();
            if (ShowForm.ShowDialog() == DialogResult.OK)
            {
                PFamily=PersonalSelectForm.PFamily;
                PName=PersonalSelectForm.PName;
                PNum=PersonalSelectForm.PNum;
                NameBox.Text=PName + " " + PFamily;
                NameButton.Image=Properties.Resources.cancel1;
            }
        }

        public void UserCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clean();
        }

        private void StartCalendar_Enter(object sender, EventArgs e)
        {
            Clean();
        }
    }
}
