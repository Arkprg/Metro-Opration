using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class PersonalRegisterForm
    {
        public PersonalRegisterForm()
        {
            InitializeComponent();
        }


        private string Img;

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void RegButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (NameBox.Text == "")
                {
                    ErrorShow(NameBox, "نام را وارد کنید");
                }
                else if (FamilyBox.Text == "")
                {
                    ErrorShow(FamilyBox, "نام خانوادگی را وارد کنید");
                }
                else if (NatIDBox.Text.Trim().Length != 10 || !int.TryParse(NatIDBox.Text, out _))
                {
                    ErrorShow(NatIDBox, "کد ملی را صحیح وارد کنید");
                }
                else if (ConvertClass.ShamsiToMiladi(BirthdayCalender.Text) == null || ConvertClass.ShamsiToMiladi(BirthdayCalender.Text) == null)
                {
                    ErrorShow(BirthdayCalender, "تاریخ تولد را وارد کنید");
                }
                else if (ConvertClass.ShamsiToMiladi(BirthdayCalender.Text) > DateTime.Today.AddYears(-15))
                {
                    ErrorShow(BirthdayCalender, "تاریخ تولد صحیح را وارد کنید");
                }
                else if (NumBox.Text == "" || !int.TryParse(NumBox.Text, out _))
                {
                    ErrorShow(NumBox, "شماره پرسنلی را وارد کنید");
                }
                else if (!int.TryParse(NumBox.Text, out _))
                {
                    ErrorShow(NumBox, "شماره پرسنلی را صحیح وارد کنید");
                }
                else if (ConvertClass.ShamsiToMiladi(EmpolyCalender.Text) == null || ConvertClass.ShamsiToMiladi(EmpolyCalender.Text) == null)
                {
                    ErrorShow(EmpolyCalender, "تاریخ استخدام صحیح را وارد کنید");
                }
                else if (ConvertClass.ShamsiToMiladi(EmpolyCalender.Text) > DateTime.Today)
                {
                    ErrorShow(EmpolyCalender, "تاریخ استخدام صحیح را وارد کنید");
                }
                else if (PostCombo.SelectedIndex < 0)
                {
                    ErrorShow(PostCombo, "پست سازمانی را انتخاب کنید");
                }
                else if (LineCombo.SelectedIndex < 0)
                {
                    ErrorShow(LineCombo, "شماره خط را انتخاب کنید");
                }
                else if (LocalCombo.SelectedIndex < 0)
                {
                    ErrorShow(LocalCombo, "محل شروع کار را انتخاب کنید");
                }
                else if (TimeCombo.SelectedIndex < 0)
                {
                    ErrorShow(TimeCombo, "نوع شیفت کاری را مشخص کنید");
                }
                else if (ShiftCombo.SelectedIndex < 0)
                {
                    ErrorShow(ShiftCombo, "نام شیفت کاری را انتخاب کنید");
                }
                else if (CalcCombo.SelectedIndex < 0)
                {
                    ErrorShow(CalcCombo, "نوع محاسبه کارکرد را انتخاب کنید");
                }
                else if (GavahiCombo.SelectedIndex < 0)
                {
                    ErrorShow(GavahiCombo, "نوع گواهینامه را انتخاب کنید");
                }
                else
                {
                    if (PictureBox1.Image is null)
                    {
                        if (MessageBoxFa.Show("تصویر بارگذاری نشده است \n\n آیا ادامه می دهید؟", "توجه", MessageBoxIcon.Asterisk, MessageBoxButtons.YesNo) == DialogResult.No)
                        {
                            ErrorShow(PictureBox1, "تصویر بارگذاری نشده است");
                            return;
                        }
                    }

                    bool Act=true;
                    string FID="";
                    Enabled=false;

                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD=new OleDbCommand($"SELECT P_Num, NatID, Vis FROM Person WHERE P_Num='{NumBox.Text}'", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                if (Reader["P_Num"].ToString() == NumBox.Text)
                                {
                                    FID="شماره پرسنلی";
                                    Act=Convert.ToBoolean(Reader["Vis"]);
                                }
                                else if (Reader["NatID"].ToString() == NatIDBox.Text)
                                {
                                    FID="کد ملی";
                                    Act=Convert.ToBoolean(Reader["Vis"]);
                                }
                            }
                        }
                    }


                    if (!string.IsNullOrEmpty(FID))
                    {
                        MessageBoxFa.Show(" این {FID} قبلا ثبت شده است", "خطا", MessageBoxIcon.Error);
                        if (!Act)
                        {
                            if (MessageBoxFa.Show("پرسنل مورد نظر غیر فعال می باشد، آیا مایل به فعال سازی مجدد هستید؟", "تایید", MessageBoxIcon.Question, MessageBoxButtons.OKCancel) == DialogResult.OK)
                            {
                                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                                {
                                    StrConnec.Open();
                                    using (OleDbCommand CMD=new OleDbCommand($"UPDATE Person SET Vis=True WHERE P_Num='{NumBox.Text}'", StrConnec))
                                    {
                                        CMD.ExecuteNonQuery();
                                    }
                                }
                            }

                            Enabled=false;
                        }
                    }
                    else
                    {
                        using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                        {
                            StrConnec.Open();
                            using (OleDbCommand CMD=new OleDbCommand($"INSERT INTO Person (Fname, Family, NatID, Calc, Birthday, P_Num, EmpoDate, Line_Num, P_Staff, Shift_Loc, P_Post, Shift_Time, Shift_name, LicenseDegree, LicenseDate, O_Group, Phone, Vis, OverTime, Reserv, Trip) VALUES (@Name, @Family, '{NatIDBox.Text}', '{CalcCombo.SelectedItem}', '{BirthdayCalender.Text}',  '{NumBox.Text.Trim()}', '{EmpolyCalender.Text}', '{LineCombo.SelectedItem}', '{UnitCombo.SelectedItem}', '{LocalCombo.Text}', '{PostCombo.Text}', '{TimeCombo.Text}', '{ShiftCombo.Text}', '{GavahiCombo.Text}', '{GavahiCalendar.Text}', '{OGroupBox.Text}', 0, True, False, False, False)", StrConnec))
                            {
                                CMD.Parameters.AddWithValue("@Name", NameBox.Text.Trim());
                                CMD.Parameters.AddWithValue("@Family", FamilyBox.Text.Trim());
                                CMD.ExecuteNonQuery();
                            }


                            //***************************** Personal History
                            using (OleDbCommand CMD=new OleDbCommand($"INSERT INTO PostHis (P_Num, P_Post, Shift_Time, Shift_name, Line_Num, P_Staff, Shift_Loc, U_Reg, T_Reg) VALUES ('{NumBox.Text}', '{PostCombo.SelectedItem}', '{TimeCombo.SelectedItem}', '{ShiftCombo.SelectedItem}', '{LineCombo.SelectedItem}', '{UnitCombo.SelectedItem}', '{LocalCombo.SelectedItem}', '{AppState.UserName}', '{MainForm.PersianToday.Tarikh()} {DateTime.Now:HH:mm:ss}')", StrConnec))
                            {
                                CMD.ExecuteNonQuery();
                            }

                            using (OleDbCommand CMD=new OleDbCommand($"INSERT INTO PersonHis (P_Num, Fname, Family, O_Group, LicenseDegree, LicenseDate, NatID, Birthday, EmpoDate, Activ, U_Reg, T_Reg) VALUES ('{NumBox.Text}', @Name, @Family, '{OGroupBox.Text}', '{GavahiCombo.SelectedItem}', '{GavahiCalendar.Text}', '{NatIDBox.Text}', '{BirthdayCalender.Text}', '{EmpolyCalender.Text}', True, '{AppState.UserName}', '{MainForm.PersianToday.Tarikh()} {DateTime.Now:HH:mm:ss}')", StrConnec))
                            {
                                CMD.Parameters.AddWithValue("@Name", NameBox.Text.Trim());
                                CMD.Parameters.AddWithValue("@Family", FamilyBox.Text.Trim());
                                CMD.ExecuteNonQuery();
                            }


                            using (OleDbCommand CMD=new OleDbCommand($"INSERT INTO Permis (P_Num, OverTime, Reserv, Trip, U_Reg, T_Reg, Mem, Vis) VALUES ('{NumBox.Text}', False, False, False, '{AppState.UserName}', '{MainForm.PersianToday.Tarikh()} {DateTime.Now:HH:mm:ss}', 'ثبت پرسنل جدید', True)", StrConnec))
                            {
                                CMD.ExecuteNonQuery();
                            }
                        }


                        if (!string.IsNullOrEmpty(Img))
                        {
                            System.IO.File.Copy(Img, AppState.DatabasePath + "\\Pic\\" + NumBox.Text);
                        }

                        NameBox.Text="";
                        FamilyBox.Text="";
                        NumBox.Text="";
                        NatIDBox.Text="";
                        BirthdayCalender.Text="";
                        EmpolyCalender.Text="";
                        PictureBox1.Image=null;
                        if (AppState.UserLevel < 2)
                        {
                            LineCombo.SelectedIndex=-1;
                        }

                        if (AppState.UserLevel < 3)
                        {
                            UnitCombo.SelectedIndex=-1;
                        }

                        PostCombo.SelectedIndex=-1;
                        GavahiCombo.SelectedIndex=-1;
                        GavahiCalendar.Text="";
                        OGroupBox.Text="";

                        Enabled=true;
                        MessageBoxFa.Show("ثبت با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
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
            if ((string)TimeCombo.SelectedItem == "ستادی")
            {
                ShiftCombo.Items.Clear();
                ShiftCombo.Items.Add("ستادی");
                ShiftCombo.SelectedIndex=0;
            }
            else
            {
                ShiftCombo.Items.Clear();
                ShiftCombo.Items.Add("A");
                ShiftCombo.Items.Add("B");
                ShiftCombo.Items.Add("C");
                ShiftCombo.SelectedIndex=-1;
            }
        }

        public void PicButton_Click(object sender, EventArgs e)
        {
            try
            {
                PictureBox1.Image=null;
                OpenFileDialog OpenFileDialog1=new OpenFileDialog()
                {
                    Filter="JPG File|*.jpg"
                };
                if (OpenFileDialog1.ShowDialog(this) == DialogResult.OK)
                {
                    Img=OpenFileDialog1.FileName;

                    if (Image.FromFile(Img).Size.Height > 600)
                    {
                        MessageBoxFa.Show("ارتفاع تصویر بیشتر از حد مجاز است", "خطا", MessageBoxIcon.Error);
                        Img="";
                    }
                    else if (Image.FromFile(Img).Size.Height < 150)
                    {
                        MessageBoxFa.Show("ارتفاع تصویر کمتر از حد مجاز است", "خطا", MessageBoxIcon.Error);
                        Img="";
                    }
                    else if (Image.FromFile(Img).Size.Width > 500)
                    {
                        MessageBoxFa.Show("عرض تصویر بیشتر از حد مجاز است", "خطا", MessageBoxIcon.Error);
                        Img="";
                    }
                    else if (Image.FromFile(Img).Size.Width < 100)
                    {
                        MessageBoxFa.Show("عرض تصویر کمتر از حد مجاز است", "خطا", MessageBoxIcon.Error);
                        Img="";
                    }
                    else if (new System.IO.FileInfo(Img).Length < 10240)
                    {
                        MessageBoxFa.Show("حجم تصویر کمتر از حد مجاز است", "خطا", MessageBoxIcon.Error);
                        Img="";
                    }
                    else if (new System.IO.FileInfo(Img).Length > 409600)
                    {
                        MessageBoxFa.Show("حجم تصویر بیشتر از حد مجاز است", "خطا", MessageBoxIcon.Error);
                        Img="";
                    }
                    else
                    {
                        PictureBox1.Image=Image.FromFile(Img);
                    }
                }
            }
            catch (Exception)
            {
                MessageBoxFa.Show("بارگذاری تصویر نا موفق بود", "خطا", MessageBoxIcon.Error);
            }
        }

        public void PersonnelRegisterForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Help.ShowHelp(this, AppState.DatabasePath + "\\Help\\help.chm", HelpNavigator.TopicId, "0501");
        }

        public void PersonnelRegisterForm_Load(object sender, EventArgs e)
        {
            try
            {
                string QueStr="Vis=True";
                DataRow[] DRow=MainForm.PersonTable.Select(QueStr);

                UnitCombo.Items.Clear();
                foreach (DataRow DtR in DRow)
                {
                    if (UnitCombo.Items.IndexOf(DtR["P_Staff"].ToString()) < 0)
                    {
                        UnitCombo.Items.Add(DtR["P_Staff"].ToString());
                    }
                }

                LocalCombo.Items.Clear();
                foreach (DataRow DtR in DRow)
                {
                    if (LocalCombo.Items.IndexOf(DtR["Shift_Loc"].ToString()) < 0)
                    {
                        LocalCombo.Items.Add(DtR["Shift_Loc"].ToString());
                    }
                }

                PostCombo.Items.Clear();
                foreach (DataRow DtR in DRow)
                {
                    if (PostCombo.Items.IndexOf(DtR["P_Post"].ToString()) < 0)
                    {
                        PostCombo.Items.Add(DtR["P_Post"].ToString());
                    }
                }

                TimeCombo.Items.Clear();
                foreach (DataRow DtR in DRow)
                {
                    if (TimeCombo.Items.IndexOf(DtR["Shift_Time"].ToString()) < 0)
                    {
                        TimeCombo.Items.Add(DtR["Shift_Time"].ToString());
                    }
                }

                ShiftCombo.Items.Clear();
                foreach (DataRow DtR in DRow)
                {
                    if (ShiftCombo.Items.IndexOf(DtR["Shift_name"].ToString()) < 0)
                    {
                        ShiftCombo.Items.Add(DtR["Shift_name"].ToString());
                    }
                }

                EmpolyCalender.Miladi=DateTime.Today;
                BirthdayCalender.Miladi=DateTime.Today;
                GavahiCalendar.Miladi=DateTime.Today;
                LineCombo.SelectedItem=AppState.UserLnum;

                if (AppState.UserLevel > 5 || AppState.UserLevel > 15)
                {
                    LineCombo.Enabled=false;
                }

                if (AppState.UserLevel > 5)
                {
                    UnitCombo.Enabled=false;
                }

                if (AppState.UserLevel > 5)
                {
                    UnitCombo.SelectedItem=AppState.UserStaff;
                }
            }
            catch (Exception ex)
            {
               MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void GavahiCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GavahiCombo.SelectedIndex == 0)
            {
                GavahiCalendar.Enabled=false;
            }
            else
            {
                GavahiCalendar.Enabled=true;
            }
        }
    }
}
