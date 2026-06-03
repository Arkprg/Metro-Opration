using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class PersonalEditForm
    {
        public PersonalEditForm()
        {
            InitializeComponent();
        }

        private string PName;
        private string PFamily;
        private string PNum;
        private string PPost;
        private string PShift;
        private string PTime;
        private string PGavahi;
        private string PGavahiDate;
        private string PGroup;
        private string PLocal;
        private string PLine;
        private string PUnit;
        private string PNID;
        private string PBirth;
        private string PEmploy;
        private string Calc;
        private string Img;

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void Clears()
        {
            PersonBox.Text="";
            PictureBox1.Image=null;
            NameBox.Text="";
            FamilyBox.Text="";
            NatIDBox.Text="";
            BirthdayCalender.Text="";
            NumBox.Text="";
            EmpolyCalender.Text="";
            PostCombo.SelectedIndex=-1;
            LineCombo.SelectedIndex=-1;
            LocalCombo.SelectedIndex=-1;
            UnitCombo.SelectedIndex=-1;
            TimeCombo.SelectedIndex=-1;
            ShiftCombo.SelectedIndex=-1;
            GavahiCombo.SelectedIndex=-1;
            GavahiCalendar.Text="";
            CalcCombo.SelectedIndex=-1;
            OGroupBox.Text="";
            PersonalButton.Image=Properties.Resources.user;

            RegButton.Enabled=false;
            DelButton.Enabled=false;
        }

        public void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                PictureBox1.Image=null;
                if (PersonBox.Text == "")
                {
                    ErrorShow(PersonBox, "لطفا نام پرسنل را مشخص کنید ");
                }
                else
                {
                    RegButton.Enabled=false;
                    DelButton.Enabled=false;
                    PictureBox1.Image=null;
                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD=new OleDbCommand($"SELECT * FROM Person WHERE P_Num='{PNum}'", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                PName=Reader["Fname"].ToString();
                                PFamily=Reader["Family"].ToString();
                                PNum=Reader["P_Num"].ToString();
                                PPost=Reader["P_Post"].ToString();
                                PUnit=Reader["P_Staff"].ToString();
                                PShift=Reader["Shift_Name"].ToString();
                                PTime=Reader["Shift_Time"].ToString();
                                PLine=Reader["Line_Num"].ToString();
                                PLocal=Reader["Shift_Loc"].ToString();
                                PGavahi=Reader["LicenseDegree"].ToString();
                                PGavahiDate=Reader["LicenseDate"].ToString();
                                PNID=Reader["NatID"].ToString();
                                PBirth=Reader["Birthday"].ToString();
                                PEmploy=Reader["EmpoDate"].ToString();
                                Calc=Reader["Calc"].ToString();

                                PGroup=Reader["O_Group"].ToString();
                            }
                        }
                    }


                    NameBox.Text=PName;
                    FamilyBox.Text=PFamily;
                    NatIDBox.Text=PNID;
                    BirthdayCalender.Text=PBirth;
                    NumBox.Text=PNum;
                    EmpolyCalender.Text=PEmploy;
                    LineCombo.SelectedItem=PLine;
                    UnitCombo.SelectedItem=PUnit;
                    LocalCombo.SelectedItem=PLocal;
                    PostCombo.SelectedItem=PPost;
                    TimeCombo.SelectedItem=PTime;
                    ShiftCombo.SelectedItem=PShift;
                    GavahiCombo.SelectedItem=PGavahi;
                    GavahiCalendar.Text=PGavahiDate;
                    OGroupBox.Text=PGroup;
                    CalcCombo.SelectedItem=Calc;

                    if (NumBox.Text == "")
                    {
                        MessageBoxFa.Show(" موردی با مشخصات پیدا نشد", "خطا", MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (System.IO.File.Exists(AppState.DatabasePath + "\\Pic\\" + NumBox.Text))
                        {
                            PictureBox1.Image=Image.FromFile(AppState.DatabasePath + "\\Pic\\" + NumBox.Text);
                        }

                        if (AppState.UserLevel < 2)
                        {
                            DelButton.Enabled=true;
                        }

                        if (AppState.UserLevel > 5 || AppState.UserLevel > 15)
                        {
                            DelButton.Enabled=true;
                        }

                        RegButton.Enabled=true;
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
                ShiftCombo.Items.Add($"ستادی");
                ShiftCombo.SelectedIndex=0;
            }
            else
            {
                ShiftCombo.Items.Clear();
                ShiftCombo.Items.Add($"A");
                ShiftCombo.Items.Add($"B");
                ShiftCombo.Items.Add($"C");
                ShiftCombo.SelectedIndex=-1;
            }
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
                else if (NatIDBox.Text.Length < 10)
                {
                    ErrorShow(NatIDBox, "کد ملی را صحیح وارد کنید");
                }
                else if (NumBox.Text == "")
                {
                    ErrorShow(NumBox, "شماره پرسنلی را وارد کنید");
                }
                else if (!int.TryParse(NumBox.Text, out _))
                {
                    ErrorShow(NumBox, "شماره پرسنلی را صحیح وارد کنید");
                }
                else if (ConvertClass.ShamsiToMiladi(BirthdayCalender.Text) == null)
                {
                    ErrorShow(BirthdayCalender, "تاریخ تولد را وارد کنید");
                }
                else if (ConvertClass.ShamsiToMiladi(BirthdayCalender.Text) > DateTime.Today.AddYears(-15))
                {
                    ErrorShow(BirthdayCalender, "تاریخ تولد صحیح را وارد کنید");
                }
                else if (ConvertClass.ShamsiToMiladi(EmpolyCalender.Text) == null)
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
                    if (ShiftCombo.Enabled)
                    {
                        if (ShiftCombo.SelectedIndex < 0)
                        {
                            ErrorShow(ShiftCombo, "لطفا نام شیفت کاری را انتخاب کنید");
                            return;
                        }
                    }
                    if (PictureBox1.Image is null)
                    {
                        if (MessageBoxFa.Show("تصویر بارگذاری نشده است \n\n آیا ادامه می دهید؟", "توجه", MessageBoxIcon.Asterisk, MessageBoxButtons.YesNo) == DialogResult.No)
                        {
                            ErrorShow(PictureBox1, "تصویر بارگذاری نشده است");
                            return;
                        }
                    }

                    bool Changed=false;
                    //Enabled=False
                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();

                        //***************************** Personal History
                        if ((string)PostCombo.SelectedItem != PPost || (string)TimeCombo.SelectedItem != PTime || (string)ShiftCombo.SelectedItem != PShift || (string)LineCombo.SelectedItem != PLine || (string)UnitCombo.SelectedItem != PUnit || (string)LocalCombo.SelectedItem != PLocal || (string)LocalCombo.SelectedItem != Calc)
                        {
                            using (OleDbCommand CMD=new OleDbCommand($"INSERT INTO PostHis (P_Num, P_Post, Shift_Time, Shift_name, Line_Num, P_Staff, Shift_Loc, U_Reg, T_Reg) VALUES ('{PNum}', '{PPost}', '{PTime}', '{PShift}', '{PLine}', '{PUnit}', '{PLocal}', '{AppState.UserName}', '{MainForm.PersianToday.Tarikh()} {DateTime.Now:HH:mm:ss}')", StrConnec))
                            {
                                CMD.ExecuteNonQuery();
                            }

                            using (OleDbCommand CMD=new OleDbCommand($"UPDATE JayGozin SET Vis=False WHERE P_Num='{PNum}' AND Tarikh > '{MainForm.PersianToday.Tarikh()}'", StrConnec))
                            {
                                CMD.ExecuteNonQuery();
                            }

                            Changed=true;
                        }

                        if (NameBox.Text != PName || FamilyBox.Text != PFamily || OGroupBox.Text != PGroup || (string)GavahiCombo.SelectedItem != PGavahi || GavahiCalendar.Text != PGavahiDate || NatIDBox.Text != PNID || BirthdayCalender.Text != PBirth || EmpolyCalender.Text != PEmploy || NatIDBox.Text != PNID)
                        {
                            using (OleDbCommand CMD=new OleDbCommand($"INSERT INTO PersonHis (P_Num, Fname, Family, O_Group, LicenseDegree, LicenseDate, NatID, Birthday, EmpoDate, Activ, U_Reg, T_Reg) VALUES ('{PNum}', '{PName}', '{PFamily}', '{PGroup}', '{PGavahi}', '{PGavahiDate}', '{PNID}', '{PBirth}', '{PEmploy}', True, '{AppState.UserName}', '{MainForm.PersianToday.Tarikh()} {DateTime.Now:HH:mm:ss}')", StrConnec))
                            {
                                CMD.ExecuteNonQuery();
                            }

                            Changed=true;
                        }

                        if (Changed)
                        {
                            using (OleDbCommand CMD=new OleDbCommand($"UPDATE Person SET Fname=@Name, Family=@Family, Calc='{CalcCombo.SelectedItem}', NatID ='{NatIDBox.Text}', Birthday='{BirthdayCalender.Text}', EmpoDate='{EmpolyCalender.Text}', Line_Num='{LineCombo.SelectedItem}', P_Staff='{UnitCombo.Text}', Shift_Loc='{LocalCombo.Text}', P_Post='{PostCombo.Text}', Shift_Time='{TimeCombo.Text}', Shift_name='{ShiftCombo.Text}', LicenseDegree='{GavahiCombo.Text}', LicenseDate='{GavahiCalendar.Text}', O_Group='{OGroupBox.Text}', Vis=True WHERE P_Num='{NumBox.Text}'", StrConnec))
                            {
                                CMD.Parameters.AddWithValue("@Name", NameBox.Text);
                                CMD.Parameters.AddWithValue("@Family", FamilyBox.Text);
                                CMD.ExecuteNonQuery();
                            }
                        }
                        //MainForm.PersonRead(StrConnec); ************
                    }


                    if (!string.IsNullOrEmpty(Img))
                    {
                        if (System.IO.File.Exists(AppState.DatabasePath + "\\Pic\\" + NumBox.Text))
                        {
                            System.IO.File.Delete(AppState.DatabasePath + "\\Pic\\" + NumBox.Text);
                        }

                        System.IO.File.Copy(Img, AppState.DatabasePath + "\\Pic\\" + NumBox.Text);
                        PictureBox1.Image.Dispose();
                    }

                    //Me.Enabled=True
                    if (Changed)
                    {
                        MessageBoxFa.Show("ثبت با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
                        Clears();
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

        public void PersonalButton_Click(object sender, EventArgs e)
        {
            Clears();
            PersonalButton.Image=Properties.Resources.user;
            if (AppState.UserLevel > 10)
            {
                PersonalSelectForm.Per="پایانه";
            }

            PersonalSelectForm ShowForm=new PersonalSelectForm();
            if (ShowForm.ShowDialog() == DialogResult.OK)
            {
                PFamily=PersonalSelectForm.PFamily;
                PName=PersonalSelectForm.PName;
                PNum=PersonalSelectForm.PNum;

                PersonBox.Text=PName + " " + PFamily;
                PersonalButton.Image=Properties.Resources.cancel1;
            }
            ShowButton.Focus();
        }

        public void DelButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBoxFa.Show("مشخصات پرسنل حذف گردد؟", "", MessageBoxIcon.Question, MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Enabled=false;

                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD=new OleDbCommand($"INSERT INTO PersonHis (P_Num, Fname, Family, O_Group, LicenseDegree, LicenseDate, NatID, Birthday, EmpoDate, Activ, U_Reg, T_Reg) VALUES ('{PNum}', '{PName}', '{PFamily}', '{PGroup}', '{PGavahi}', '{PGavahiDate}', '{PNID}', '{PBirth}', '{PEmploy}', False, '{AppState.UserName}', '{MainForm.PersianToday.Tarikh()} {DateTime.Now:HH:mm:ss}')", StrConnec))
                        {
                            CMD.ExecuteNonQuery();
                        }

                        using (OleDbCommand CMD=new OleDbCommand($"UPDATE Person SET Vis=False, Tarikh='{MainForm.PersianToday.Tarikh()}' WHERE P_Num='{NumBox.Text}'", StrConnec))
                        {
                            CMD.ExecuteNonQuery();
                        }
                    }

                    Clears();

                    Enabled=true;
                    MessageBoxFa.Show("حذف با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
               MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void PersonnelEditForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Help.ShowHelp(this, AppState.DatabasePath + "\\Help\\help.chm", HelpNavigator.TopicId, "0502");
        }

        public void Form9_Load(object sender, EventArgs e)
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

                if (AppState.UserLevel < 3 || (AppState.UserLevel > 9 && AppState.UserLevel < 12))
                {
                    LineCombo.Enabled=true;
                }

                if (AppState.UserLevel < 6 || (AppState.UserLevel > 9 && AppState.UserLevel < 13))
                {
                    UnitCombo.Enabled=true;
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

        public void PicButton_Click(object sender, EventArgs e)
        {
            try
            {
                // PictureBox1.Image=Nothing
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
                        if (PictureBox1.Image != null)
                        {
                            PictureBox1.Image.Dispose();
                        }
                        PictureBox1.Image=Image.FromFile(Img);
                    }
                }
            }
            catch (Exception)
            {
                MessageBoxFa.Show("بارگذاری تصویر ناموفق بود", "خطا", MessageBoxIcon.Error);
            }
        }

        public void PicDelButton_Click(object sender, EventArgs e)
        {
            Img="";
            PictureBox1.Image=null;
        }
    }
}
