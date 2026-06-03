using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class ExamRegisterForm
    {
        public ExamRegisterForm()
        {
            InitializeComponent();
        }

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void ExamRegisterForm_Load(object sender, EventArgs e)
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

            StartCalendar.Today_Click(null, null);
            EndCalendar.LastDayOfMonth_Click(null, null);
            Height=210;
        }

        public void QuesNumButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime StartDate=ConvertClass.ShamsiToMiladi(StartCalendar.Text);
                DateTime EndDate=ConvertClass.ShamsiToMiladi(EndCalendar.Text);

                if (TitrBox.Text == "")
                {
                    ErrorShow(TitrBox, "عنوان را مشخص کنید");
                }
                else if (StartDate == null)
                {
                    ErrorShow(StartCalendar, "تاریخ نمایش را مشخص کنید");
                }
                else if (StartDate < DateTime.Today)
                {
                    ErrorShow(StartCalendar, "تاریخ نمایش صحیح نیست");
                }
                else if (EndDate == null)
                {
                    ErrorShow(StartCalendar, "تاریخ نمایش را مشخص کنید");
                }
                else if (EndDate < DateTime.Today)
                {
                    ErrorShow(StartCalendar, "تاریخ نمایش صحیح نیست");
                }
                else if (EndDate < StartDate)
                {
                    ErrorShow(StartCalendar, "بازه نمایش صحیح نیست");
                }
                else if (KindCombo.SelectedIndex < 0)
                {
                    ErrorShow(KindCombo, "نوع را مشخص کنید");
                }
                else if (LocalCombo.SelectedIndex < 0)
                {
                    ErrorShow(LocalCombo, "مبدا را مشخص کنید");
                }
                else if (PostCombo.SelectedIndex < 0)
                {
                    ErrorShow(PostCombo, "پست سازمانی را مشخص کنید");
                }
                else if (TimeCombo.SelectedIndex < 0)
                {
                    ErrorShow(TimeCombo, "نوع شیفت را مشخص کنید");
                }
                else if (ShiftCombo.SelectedIndex < 0 && ShiftCombo.Enabled)
                {
                    ErrorShow(ShiftCombo, "نام شیفت را مشخص کنید");
                }
                else if (LevelCombo.SelectedIndex < 0)
                {
                    ErrorShow(LevelCombo, "اولویت نمایش را مشخص کنید");
                }
                else if (AnswerCombo.SelectedIndex < 0)
                {
                    ErrorShow(AnswerCombo, "نوع نمایش نتیجه را مشخص کنید");
                }
                else if (!int.TryParse(QuesNumBox.Text, out _))
                {
                    ErrorShow(QuesNumBox, "تعداد سئوال را مشخص کنید");
                }
                else
                {
                    Height=220;
                    KindCombo.Enabled=false;
                    QuesNumBox.Enabled=false;
                    QuesNumButton.Enabled=false;

                    if (int.Parse(QuesNumBox.Text) > 4)
                    {
                        MainPanel.Left -= 9;
                        MainPanel.Width += 18;
                    }

                    int i;
                    for (i=1; i <= int.Parse(QuesNumBox.Text); i++)
                    {
                        if (i <= 4)
                        {
                            MainPanel.Height += 100;
                            Height += 100;
                            Top -= 35;
                        }

                        Panel QPanel=new Panel();
                        Label QLabl=new Label();
                        TextBox QBox=new TextBox();
                        Label GLabl=new Label();
                        ComboBox TrAns=new ComboBox();
                        Label Ans1Lab=new Label();
                        TextBox Ans1Box=new TextBox();
                        Label Ans2Lab=new Label();
                        TextBox Ans2Box=new TextBox();
                        Label Ans3Lab=new Label();
                        TextBox Ans3Box=new TextBox();
                        Label Ans4Lab=new Label();
                        TextBox Ans4Box=new TextBox();

                        QPanel.Name="QuesPanel" + i.ToString();
                        QPanel.BorderStyle=BorderStyle.FixedSingle;
                        QPanel.BackColor=Color.LightSteelBlue;
                        QPanel.Location=new Point(5, (i - 1) * 100 + 5);
                        QPanel.Size=(Size)new Point(735, 90);

                        QLabl.Name="QuesLabl" + i.ToString();
                        QLabl.AutoSize=true;
                        QLabl.Text="سوال " + i.ToString() + ")";
                        QLabl.Location=new Point(670, 20);

                        QBox.Name="Ques" + i.ToString() + "Box";
                        QBox.Multiline=true;
                        QBox.Location=new Point(180, 8);
                        QBox.Size=(Size)new Point(490, 40);

                        if (KindCombo.SelectedIndex == 1)
                        {
                            GLabl.Name="GLabel" + i.ToString();
                            GLabl.AutoSize=true;
                            GLabl.Text="گزینه صحیح:";
                            GLabl.Location=new Point(95, 20);

                            TrAns.Name="TrueAns" + i.ToString();
                            TrAns.Items.Add("1");
                            TrAns.Items.Add("2");
                            TrAns.Items.Add("3");
                            TrAns.Items.Add("4");
                            TrAns.Location=new Point(10, 15);
                            TrAns.DropDownStyle=ComboBoxStyle.DropDownList;
                            TrAns.Size=(Size)new Point(85, 24);

                            QPanel.Controls.Add(GLabl);
                            QPanel.Controls.Add(TrAns);
                        }
                        else
                        {
                            QBox.Location=new Point(10, 8);
                            QBox.Size=(Size)new Point(660, 40);
                        }

                        Ans1Lab.Name="Ans" + i.ToString() + "Label1";
                        Ans1Lab.AutoSize=true;
                        Ans1Lab.Text="گزینه 1)";
                        Ans1Lab.Location=new Point(670, 60);

                        Ans1Box.Name="Ans" + i.ToString() + "Box1";
                        Ans1Box.Location=new Point(560, 57);
                        Ans1Box.Size=(Size)new Point(110, 23);

                        Ans2Lab.Name="Ans" + i.ToString() + "Label2";
                        Ans2Lab.AutoSize=true;
                        Ans2Lab.Text="گزینه 2)";
                        Ans2Lab.Location=new Point(480, 60);

                        Ans2Box.Name="Ans" + i.ToString() + "Box2";
                        Ans2Box.Location=new Point(370, 57);
                        Ans2Box.Size=(Size)new Point(110, 23);

                        Ans3Lab.Name="Ans" + i.ToString() + "Label3";
                        Ans3Lab.AutoSize=true;
                        Ans3Lab.Text="گزینه 3)";
                        Ans3Lab.Location=new Point(290, 60);

                        Ans3Box.Name="Ans" + i.ToString() + "Box3";
                        Ans3Box.Location=new Point(180, 57);
                        Ans3Box.Size=(Size)new Point(110, 23);


                        Ans4Lab.Name="Ans" + i.ToString() + "Label4";
                        Ans4Lab.AutoSize=true;
                        Ans4Lab.Text="گزینه 4)";
                        Ans4Lab.Location=new Point(120, 60);

                        Ans4Box.Name="Ans" + i.ToString() + "Box4";
                        Ans4Box.Location=new Point(10, 57);
                        Ans4Box.Size=(Size)new Point(110, 23);

                        MainPanel.Controls.Add(QPanel);
                        QPanel.Controls.Add(QLabl);
                        QPanel.Controls.Add(QBox);
                        QPanel.Controls.Add(Ans1Lab);
                        QPanel.Controls.Add(Ans1Box);
                        QPanel.Controls.Add(Ans2Lab);
                        QPanel.Controls.Add(Ans2Box);
                        QPanel.Controls.Add(Ans3Lab);
                        QPanel.Controls.Add(Ans3Box);
                        QPanel.Controls.Add(Ans4Lab);
                        QPanel.Controls.Add(Ans4Box);
                        QPanel.TabIndex=i + 2;
                    }
                    Button2.Enabled=true;
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
            }
        }

        public void LocalCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (LocalCombo.Enabled)
                {
                    PostCombo.SelectedIndex=-1;
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
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime StartDate;
                DateTime EndDate;
                StartDate=ConvertClass.ShamsiToMiladi(StartCalendar.Text);
                EndDate=ConvertClass.ShamsiToMiladi(EndCalendar.Text);

                if (TitrBox.Text == "")
                {
                    ErrorShow(TitrBox, "عنوان را مشخص کنید");
                }
                else if (StartDate == null)
                {
                    ErrorShow(StartCalendar, "تاریخ نمایش را مشخص کنید");
                }
                else if (StartDate < DateTime.Today)
                {
                    ErrorShow(StartCalendar, "تاریخ نمایش صحیح نیست");
                }
                else if (EndDate == null)
                {
                    ErrorShow(StartCalendar, "تاریخ نمایش را مشخص کنید");
                }
                else if (EndDate < DateTime.Today)
                {
                    ErrorShow(StartCalendar, "تاریخ نمایش صحیح نیست");
                }
                else if (EndDate < StartDate)
                {
                    ErrorShow(StartCalendar, "بازه نمایش صحیح نیست");
                }
                else if (KindCombo.SelectedIndex < 0)
                {
                    ErrorShow(KindCombo, "نوع را مشخص کنید");
                }
                else if (LocalCombo.SelectedIndex < 0)
                {
                    ErrorShow(LocalCombo, "مبدا را مشخص کنید");
                }
                else if (PostCombo.SelectedIndex < 0)
                {
                    ErrorShow(PostCombo, "پست سازمانی را مشخص کنید");
                }
                else if (TimeCombo.SelectedIndex < 0)
                {
                    ErrorShow(TimeCombo, "نوع شیفت را مشخص کنید");
                }
                else if (ShiftCombo.SelectedIndex < 0 && ShiftCombo.Enabled)
                {
                    ErrorShow(ShiftCombo, "نام شیفت را مشخص کنید");
                }
                else if (LevelCombo.SelectedIndex < 0)
                {
                    ErrorShow(LevelCombo, "اولویت نمایش را مشخص کنید");
                }
                else
                {

                    bool Bol=false;
                    int i;
                    for (i=1; i <= int.Parse(QuesNumBox.Text); i++)
                    {
                        Control with_1=MainPanel.Controls["QuesPanel" + i.ToString()];
                        if (with_1.Controls["Ques" + i.ToString() + "Box"].Text == "")
                        {
                            Bol=true;
                            ErrorShow(with_1.Controls["Ques" + i.ToString() + "Box"], "متن پاسخ را وارد کنید");
                        }
                        else if (with_1.Controls["Ans" + i.ToString() + "Box1"].Text == "")
                        {
                            Bol=true;
                            ErrorShow(with_1.Controls["Ans" + i.ToString() + "Box1"], "متن پاسخ را وارد کنید");
                        }
                        else if (with_1.Controls["Ans" + i.ToString() + "Box2"].Text == "")
                        {
                            Bol=true;
                            ErrorShow(with_1.Controls["Ans" + i.ToString() + "Box2"], "متن پاسخ را وارد کنید");
                        }
                        else if (with_1.Controls["Ans" + i.ToString() + "Box3"].Text == "" && KindCombo.SelectedIndex == 1)
                        {
                            Bol=true;
                            ErrorShow(with_1.Controls["Ans" + i.ToString() + "Box3"], "متن پاسخ را وارد کنید");
                        }
                        else if (with_1.Controls["Ans" + i.ToString() + "Box4"].Text == "" && KindCombo.SelectedIndex == 1)
                        {
                            Bol=true;
                            ErrorShow(with_1.Controls["Ans" + i.ToString() + "Box4"], "متن پاسخ را وارد کنید");
                        }
                        else if (KindCombo.SelectedIndex == 1)
                        {
                            if (with_1.Controls["TrueAns" + i.ToString()].Text == "")
                            {
                                Bol=true;
                                ErrorShow(with_1.Controls["TrueAns" + i.ToString()], "پاسخ صحیح را مشخص کنید");
                            }
                        }
                        if (Bol)
                        {
                            return;
                        }
                    }

                    Enabled=false;
                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        string StrQuer="INSERT INTO Exam (Titr, Mem, P_Line, P_Local, P_Post, P_Time, P_Shift, Tarikh, EndDate, Kind, L_Show, Ans_Type, U_Reg, T_Reg, Vis) VALUES (@Titr, @Mem, '5', '";
                        if (LocalCombo.SelectedIndex == 0)
                        {
                            StrQuer += "همه موارد', '";
                        }
                        else
                        {
                            StrQuer += LocalCombo.SelectedItem + "', '";
                        }
                        if (PostCombo.SelectedIndex == 0)
                        {
                            StrQuer += "همه موارد', '";
                        }
                        else
                        {
                            StrQuer += PostCombo.SelectedItem + "', '";
                        }
                        if (TimeCombo.SelectedIndex == 0)
                        {
                            StrQuer += "همه موارد', '";
                        }
                        else
                        {
                            StrQuer += TimeCombo.SelectedItem + "', '";
                        }
                        if (ShiftCombo.SelectedIndex == 0)
                        {
                            StrQuer += "همه موارد', '";
                        }
                        else
                        {
                            StrQuer += ShiftCombo.SelectedItem + "', '";
                        }
                        StrQuer += StartCalendar.Text + "', '" + EndCalendar.Text + "', '" + KindCombo.SelectedItem + "', '" + LevelCombo.SelectedItem + "', '" + AnswerCombo.SelectedItem + "', '" + AppState.UserName + "', '" + MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") + "', True)";

                        using (OleDbCommand CMD=new OleDbCommand(StrQuer, StrConnec))
                        {
                            CMD.Parameters.AddWithValue("@Titr", TitrBox.Text);
                            CMD.Parameters.AddWithValue("@Mem", MemBox.Text);

                            CMD.ExecuteNonQuery();
                        }


                        int IDNum=0;
                        using (OleDbCommand CMD=new OleDbCommand("SELECT TOP 1 ID FROM Exam WHERE Tarikh='" + StartCalendar.Text + "' AND Titr='" + TitrBox.Text + "' AND U_Reg='" + AppState.UserName + "' ORDER BY ID DESC", StrConnec))
                        {
                            using (OleDbDataReader Reader=CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    IDNum=Convert.ToInt32(Reader["ID"]);
                                }
                            }

                        }


                        for (i=1; i <= int.Parse(QuesNumBox.Text); i++)
                        {
                            Control with_2=MainPanel.Controls["QuesPanel" + i.ToString()];
                            if (with_2.Controls["Ques" + i.ToString() + "Box"].Text != "")
                            {
                                if (with_2.Controls["Ans" + i.ToString() + "Box1"].Text != "" || with_2.Controls["Ans" + i.ToString() + "Box2"].Text != "" || with_2.Controls["Ans" + i.ToString() + "Box3"].Text != "" || with_2.Controls["Ans" + i.ToString() + "Box4"].Text != "")
                                {
                                    StrQuer="INSERT INTO ExamQues (ExamID, Ques, Ansr1, Ansr2, Ansr3, Ansr4, TrueAnsr) VALUES (" + IDNum.ToString() + ", '" + with_2.Controls["Ques" + i.ToString() + "Box"].Text + "', '" + with_2.Controls["Ans" + i.ToString() + "Box1"].Text + "', '" + with_2.Controls["Ans" + i.ToString() + "Box2"].Text + "', '" + with_2.Controls["Ans" + i.ToString() + "Box3"].Text + "', '" + with_2.Controls["Ans" + i.ToString() + "Box4"].Text + "','";
                                    if (KindCombo.SelectedIndex == 1)
                                    {
                                        StrQuer += with_2.Controls["TrueAns" + i.ToString()].Text + "')";
                                    }
                                    else
                                    {
                                        StrQuer += "0')";
                                    }

                                    using (OleDbCommand CMD=new OleDbCommand(StrQuer, StrConnec))
                                    {
                                        CMD.ExecuteNonQuery();
                                    }

                                }
                            }
                        }
                    }

                    MessageBoxFa.Show("ثبت با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
            }
        }

        public void PostCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (PostCombo.Enabled)
                {
                    TimeCombo.SelectedIndex=-1;
                    if (PostCombo.SelectedIndex >= 0)
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
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void TimeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (TimeCombo.Enabled)
                {
                    ShiftCombo.SelectedIndex=-1;
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
