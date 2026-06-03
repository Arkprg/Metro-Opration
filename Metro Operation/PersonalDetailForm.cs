using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class PersonalDetailForm
    {
        public PersonalDetailForm()
        {
            InitializeComponent();
        }

        public bool Should=false;
        private string CollegDegree;
        private string CollegObject;
        private string StateAddress;
        private string CityAddress;
        private string TownAddress;
        private string HomeAddress;
        private string Phone;
        private string ShoeSize;
        private string ShirtSize;
        private string CoatSize;
        private string PantSize;
        private string OverSize;
        private string H_ShSize;
        private string Img;

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void PersonalDetailForm_Load(object sender, EventArgs e)
        {
            try
            {
                TabControl1.ItemSize=new Size(1, 1);
                Panel1.Height=130;

                CollegDegree="";
                CollegObject="";
                StateAddress="";
                CityAddress="";
                TownAddress="";
                HomeAddress="";
                Phone="";
                ShoeSize="";
                ShirtSize="";
                CoatSize="";
                PantSize="";
                OverSize="";
                H_ShSize="";

                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    using (OleDbCommand CMD=new OleDbCommand("SELECT DISTINCT StateAddress FROM Person WHERE StateAddress+''<>''", StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            StateCombo.Items.Add(Reader["StateAddress"].ToString());
                        }
                    }

                    using (OleDbCommand CMD=new OleDbCommand("SELECT DISTINCT CollegObject FROM Person WHERE CollegObject+''<>''", StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            ObjectCombo.Items.Add(Reader["CollegObject"].ToString());
                        }
                    }

                    using (OleDbCommand CMD=new OleDbCommand("SELECT * FROM Person WHERE P_Num='" + AppState.UserPnum + "'", StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            CollegDegree=Reader["CollegDegree"].ToString();
                            CollegObject=Reader["CollegObject"].ToString();

                            StateAddress=Reader["StateAddress"].ToString();
                            CityAddress=Reader["CityAddress"].ToString();
                            TownAddress=Reader["TownAddress"].ToString();
                            HomeAddress=Reader["HomeAddress"].ToString();
                            Phone=Reader["Phone"].ToString();

                            ShoeSize=Reader["ShoeSize"].ToString();
                            ShirtSize=Reader["ShirtSize"].ToString();
                            CoatSize=Reader["CoatSize"].ToString();
                            PantSize=Reader["PantSize"].ToString();
                            OverSize=Reader["OverSize"].ToString();
                            H_ShSize=Reader["H_ShSize"].ToString();
                        }
                    }
                }


                string Pic="";
                Pic=AppState.DatabasePath + "\\Pic\\" + AppState.UserPnum;

                if (System.IO.File.Exists(Pic))
                {
                    PictureBox1.Image=Image.FromFile(Pic);
                }

                DegreeCombo.Text=CollegDegree;
                ObjectCombo.Text=CollegObject;

                StateCombo.Text=StateAddress;
                CityCombo.Text=CityAddress;
                TownCombo.Text=TownAddress;
                AddressBox.Text=HomeAddress;
                PhoneBox.Text=Phone;

                ShoeCombo.Text=ShoeSize;
                ShirtCombo.Text=ShirtSize;
                CoatCombo.Text=CoatSize;
                PantCombo.Text=PantSize;
                OverCombo.Text=OverSize;
                HitCombo.Text=H_ShSize;
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void Next0Button_Click(object sender, EventArgs e)
        {
            if (StateCombo.Text.Length < 4)
            {
                ErrorShow(StateCombo, "نام استان را مشخص کنید");
            }
            else if (CityCombo.Text.Length < 3)
            {
                ErrorShow(CityCombo, "نام شهر را مشخص کنید");
            }
            else if (TownCombo.Text.Length < 4)
            {
                ErrorShow(TownCombo, "نام منطقه را مشخص کنید");
            }
            else if (AddressBox.Text.Trim().Length < 10)
            {
                ErrorShow(AddressBox, "آدرس را وارد کنید");
            }
            else if (PhoneBox.Text.Length < 11 || !double.TryParse(PhoneBox.Text, out _))
            {
                ErrorShow(PhoneBox, "شماره تلفن صحیح نیست \n    (09XXXXXXXXX)");
            }
            else if (PhoneBox.Text.Substring(0, 3) != "090" && PhoneBox.Text.Substring(0, 3) != "091" && PhoneBox.Text.Substring(0, 3) != "092" && PhoneBox.Text.Substring(0, 3) != "093" && PhoneBox.Text.Substring(0, 3) != "099")
            {
                ErrorShow(PhoneBox, "شماره تلفن صحیح نیست \n    (09XXXXXXXXX)");
            }
            else if (DegreeCombo.SelectedIndex < 0)
            {
                ErrorShow(DegreeCombo, "آخرین مدرک تحصیلی را مشخص کنید");
            }
            else if (ObjectCombo.Text.Length < 4)
            {
                ErrorShow(ObjectCombo, "رشته تحصیلی را مشخص کنید");
            }
            else if (!int.TryParse(ShoeCombo.Text, out _))
            {
                ErrorShow(ShoeCombo, "اندازه کفش را مشخص کنید");
            }
            else if (int.Parse(ShoeCombo.Text) > 50 || int.Parse(ShoeCombo.Text) < 35)
            {
                ErrorShow(ShoeCombo, "اندازه کفش صحیح نیست");
            }
            else if (ShirtCombo.SelectedIndex < 0)
            {
                ErrorShow(ShirtCombo, "اندازه پیراهن را مشخص کنید");
            }
            else if (OverCombo.SelectedIndex < 0)
            {
                ErrorShow(OverCombo, "اندازه اورکت را مشخص کنید");
            }
            else if (!int.TryParse(CoatCombo.Text, out _))
            {
                ErrorShow(CoatCombo, "اندازه کت را مشخص کنید");
            }
            else if (int.Parse(CoatCombo.Text) > 60 || int.Parse(CoatCombo.Text) < 30)
            {
                ErrorShow(CoatCombo, "اندازه کت صحیح نیست");
            }
            else if (!int.TryParse(PantCombo.Text, out _))
            {
                ErrorShow(PantCombo, "اندازه شلوار را مشخص کنید");
            }
            else if (int.Parse(PantCombo.Text) > 60 || int.Parse(PantCombo.Text) < 30)
            {
                ErrorShow(PantCombo, "اندازه شلوار صحیح نیست");
            }
            else if (HitCombo.SelectedIndex < 0)
            {
                ErrorShow(HitCombo, "اندازه گرمکن را مشخص کنید");
            }
            else if (PictureBox1.Image is null)
            {
                ErrorShow(PictureBox1, "عکس پرسنلی را وارد کنید");
            }
            else
            {

                PictureBox2.Image=null;
                if (PictureBox1.Image is object)
                {
                    PictureBox2.Image=PictureBox1.Image;
                }
                PhoneLabel.Text=PhoneBox.Text;
                DegreeLabel.Text=DegreeCombo.SelectedItem.ToString();
                ObjectLabel.Text=ObjectCombo.Text;

                StateLabel.Text=StateCombo.Text;
                CityLabel.Text=CityCombo.Text;
                TownLabel.Text=TownCombo.Text;
                AddressLabel.Text=AddressBox.Text.Trim();

                ShoeLabel.Text=ShoeCombo.Text.Trim();
                ShirtLabel.Text=ShirtCombo.SelectedItem.ToString();
                OverLabel.Text=OverCombo.SelectedItem.ToString();
                CoatLabel.Text=CoatCombo.Text.Trim();
                PantLabel.Text=PantCombo.Text.Trim();
                HitLabel.Text=HitCombo.SelectedItem.ToString();

                TabControl1.SelectedIndex=1;
            }
        }

        public void PicButton_Click(object sender, EventArgs e)
        {
            try
            {
                PictureBox1.Image=null;
                Img="";

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

        public void Prev2Button_Click(object sender, EventArgs e)
        {
            TabControl1.SelectedIndex=0;
        }

        public void StateCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CityCombo.SelectedIndex=-1;
                CityCombo.Items.Clear();
                if (StateCombo.SelectedIndex >= 0)
                {
                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD=new OleDbCommand("SELECT DISTINCT CityAddress FROM Person WHERE CityAddress+''<>'' AND StateAddress='" + StateCombo.Text + "'", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                CityCombo.Items.Add(Reader["CityAddress"].ToString());
                            }
                        }
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

        public void CityCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TownCombo.SelectedIndex=-1;
                TownCombo.Items.Clear();
                if (CityCombo.SelectedIndex >= 0)
                {
                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD=new OleDbCommand("SELECT DISTINCT TownAddress FROM Person WHERE TownAddress+''<>''  AND StateAddress='" + StateCombo.Text + "' AND CityAddress='" + CityCombo.Text + "'", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                TownCombo.Items.Add(Reader["TownAddress"].ToString());
                            }
                        }
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

        public void RegButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBoxFa.Show("آیا صحت داده ها را تایید می کنید؟ ", "تایید", MessageBoxIcon.Question, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Enabled=false;

                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD=new OleDbCommand("INSERT INTO PDetailHis (P_Num, Phone, StateAddress, CityAddress, TownAddress, HomeAddress, ShoeSize, ShirtSize, CoatSize, PantSize, OverSize, H_ShSize, CollegDegree, CollegObject, U_Reg, T_Reg) VALUES ('" + AppState.UserPnum + "', '" + Phone + "', @StateAddress, @CityAddress, @TownAddress, @HomeAddress, '" + ShoeSize + "', '" + ShirtSize + "', '" + CoatSize + "','" + PantSize + "', '" + OverSize + "', '" + H_ShSize + "', '" + CollegDegree + "', @CollegObject, '" + AppState.UserName + "', '" + MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") + "')", StrConnec))
                        {
                            CMD.Parameters.AddWithValue("@StateAddress", StateCombo.Text);
                            CMD.Parameters.AddWithValue("@CityAddress", CityCombo.Text);
                            CMD.Parameters.AddWithValue("@TownAddress", TownCombo.Text);
                            CMD.Parameters.AddWithValue("@HomeAddress", AddressBox.Text);
                            CMD.Parameters.AddWithValue("@CollegObject", ObjectCombo.Text);
                            CMD.ExecuteNonQuery();
                        }


                        using (OleDbCommand CMD=new OleDbCommand("UPDATE Person SET StateAddress=@StateAddress, CityAddress=@CityAddress, TownAddress=@TownAddress, HomeAddress=@HomeAddress, Phone='" + PhoneBox.Text + "', ShoeSize='" + ShoeCombo.SelectedItem + "', ShirtSize='" + ShirtCombo.SelectedItem + "', CoatSize='" + CoatCombo.SelectedItem + "', PantSize='" + PantCombo.SelectedItem + "', OverSize='" + OverCombo.SelectedItem + "', H_ShSize='" + HitCombo.SelectedItem + "', CollegDegree='" + DegreeCombo.SelectedItem + "', CollegObject=@CollegObject WHERE P_Num ='" + AppState.UserPnum + "'", StrConnec))
                        {
                            CMD.Parameters.AddWithValue("@StateAddress", StateCombo.Text);
                            CMD.Parameters.AddWithValue("@CityAddress", CityCombo.Text);
                            CMD.Parameters.AddWithValue("@TownAddress", TownCombo.Text);
                            CMD.Parameters.AddWithValue("@HomeAddress", AddressBox.Text);
                            CMD.Parameters.AddWithValue("@CollegObject", ObjectCombo.Text);
                            CMD.ExecuteNonQuery();
                        }
                        //MainForm.PersonRead(StrConnec);  ************
                    }

                    if (!string.IsNullOrEmpty(Img))
                    {
                        System.IO.File.Copy(Img, AppState.DatabasePath + "\\Pic\\" + AppState.UserPnum + "T");
                        PictureBox1.Image.Dispose();
                    }

                    Should=false;
                    MessageBoxFa.Show("ثبت با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
                    MessageBoxFa.Show("برای اعمال تغییرات نرم افزار را مجددا اجرا کنید", "تایید", MessageBoxIcon.Exclamation);
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

        public void PersonalDetailForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Should)
            {
                if (MessageBoxFa.Show("از برنامه خارج می شوید؟", "خروج", MessageBoxIcon.Stop, MessageBoxButtons.YesNo, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    e.Cancel=true;
                }
                else
                {
                    MainForm.ShClose=true;
                    DialogResult=DialogResult.Cancel;
                }
            }
        }

        public void AddressRegButton_Click(object sender, EventArgs e)
        {

            if (ComboBox1.SelectedIndex < 0)
            {
                ErrorShow(ComboBox1, "عنوان را انتخاب کنید");
            }
            else if (ComboBox2.SelectedIndex < 1)
            {
                ErrorShow(ComboBox2, "عنوان را انتخاب کنید");
            }
            else if (AddressBox1.Text.Length < 1)
            {
                ErrorShow(AddressBox1, "آدرس را وارد کنید");
            }
            else if (AddressBox2.Text.Length < 1)
            {
                ErrorShow(AddressBox2, "آدرس را وارد کنید");
            }
            else if (AddressBox3.Text.Length < 1)
            {
                ErrorShow(AddressBox3, "آدرس را وارد کنید");
            }
            else if ((string)ComboBox2.SelectedItem != "ساختمان" && (string)ComboBox3.SelectedItem != "ساختمان" && (string)ComboBox4.SelectedItem != "ساختمان" && (string)ComboBox5.SelectedItem != "ساختمان" && (string)ComboBox6.SelectedItem != "ساختمان" && (string)ComboBox2.SelectedItem != "پلاک" && (string)ComboBox3.SelectedItem != "پلاک" && (string)ComboBox4.SelectedItem != "پلاک" && (string)ComboBox5.SelectedItem != "پلاک" && (string)ComboBox6.SelectedItem != "پلاک")
            {
                ErrorShow(Label43, "نام ساختمان یا پلاک الزامی است");
            }
            else
            {

                if (AddressBox4.Enabled && AddressBox4.Text.Length < 1)
                {
                    ErrorShow(AddressBox4, "آدرس را وارد کنید یا عنوان را حذف کنید");
                    return;
                }
                if (AddressBox5.Enabled && AddressBox5.Text.Length < 1)
                {
                    ErrorShow(AddressBox5, "آدرس را وارد کنید یا عنوان را حذف کنید");
                    return;
                }
                if (AddressBox6.Enabled && AddressBox6.Text.Length < 1)
                {
                    ErrorShow(AddressBox6, "آدرس را وارد کنید یا عنوان را حذف کنید");
                    return;
                }

                if (AddressBox1.Enabled)
                {
                    AddressBox.Text=ComboBox1.SelectedItem + " " + AddressBox1.Text.Trim() + " - ";
                }

                if (AddressBox2.Enabled)
                {
                    AddressBox.Text += ComboBox2.SelectedItem + " " + AddressBox2.Text.Trim() + " - ";
                }

                if (AddressBox3.Enabled)
                {
                    AddressBox.Text += ComboBox3.SelectedItem + " " + AddressBox3.Text.Trim() + " - ";
                }

                if (AddressBox4.Enabled)
                {
                    AddressBox.Text += ComboBox4.SelectedItem + " " + AddressBox4.Text.Trim() + " - ";
                }

                if (AddressBox5.Enabled)
                {
                    AddressBox.Text += ComboBox5.SelectedItem + " " + AddressBox5.Text.Trim() + " - ";
                }

                if (AddressBox6.Enabled)
                {
                    AddressBox.Text += ComboBox6.SelectedItem + " " + AddressBox6.Text.Trim() + " - ";
                }

                AddressBox.Text=AddressBox.Text.Substring(0, AddressBox.Text.Length - 3);

                if (AddressBox.Text.Length < 28)
                {
                    MessageBoxFa.Show("تکمیل حداقل سه عنوان الزامی است", "خطا", MessageBoxIcon.Error);
                    AddressBox.Text="";
                }
                else
                {
                    DetailAddressPanel.Visible=false;
                    Panel2.Visible=true;
                }
            }
        }

        public void AddressEditButton_Click(object sender, EventArgs e)
        {
            try
            {
                DetailAddressPanel.Visible=true;
                Panel2.Visible=false;
                string Ads=AddressBox.Text;
                int Ind=0;

                if (Ads.Length > 0)
                {
                    Ind=Ads.IndexOf(" ");
                    ComboBox1.SelectedItem=Ads.Substring(0, Ind);
                    Ads=Ads.Substring(Ind + 1, Ads.Length - Ind - 1);
                    Ind=Ads.IndexOf("-");

                    if (Ind > 0)
                    {
                        AddressBox1.Text=Ads.Substring(0, Ind - 1);
                        Ads=Ads.Substring(Ind + 2, Ads.Length - Ind - 2);
                    }
                    else
                    {
                        AddressBox1.Text=Ads.Substring(0, Ads.Length);
                    }
                }
                if (Ads.Length > 0)
                {
                    Ind=Ads.IndexOf(" ");
                    ComboBox2.SelectedItem=Ads.Substring(0, Ind);
                    Ads=Ads.Substring(Ind + 1, Ads.Length - Ind - 1);
                    Ind=Ads.IndexOf("-");

                    if (Ind > 0)
                    {
                        AddressBox2.Text=Ads.Substring(0, Ind - 1);
                        Ads=Ads.Substring(Ind + 2, Ads.Length - Ind - 2);
                    }
                    else
                    {
                        AddressBox2.Text=Ads.Substring(0, Ads.Length);
                    }
                }
                if (Ads.Length > 0)
                {
                    Ind=Ads.IndexOf(" ");
                    ComboBox3.SelectedItem=Ads.Substring(0, Ind);
                    Ads=Ads.Substring(Ind + 1, Ads.Length - Ind - 1);
                    Ind=Ads.IndexOf("-");

                    if (Ind > 0)
                    {
                        AddressBox3.Text=Ads.Substring(0, Ind - 1);
                        Ads=Ads.Substring(Ind + 2, Ads.Length - Ind - 2);
                    }
                    else
                    {
                        AddressBox3.Text=Ads.Substring(0, Ads.Length);
                    }
                }
                if (Ads.Length > 0)
                {
                    Ind=Ads.IndexOf(" ");
                    ComboBox4.SelectedItem=Ads.Substring(0, Ind);
                    Ads=Ads.Substring(Ind + 1, Ads.Length - Ind - 1);
                    Ind=Ads.IndexOf("-");

                    if (Ind > 0)
                    {
                        AddressBox4.Text=Ads.Substring(0, Ind - 1);
                        Ads=Ads.Substring(Ind + 2, Ads.Length - Ind - 2);
                    }
                    else
                    {
                        AddressBox4.Text=Ads.Substring(0, Ads.Length);
                    }
                }
                if (Ads.Length > 0)
                {
                    Ind=Ads.IndexOf(" ");
                    ComboBox5.SelectedItem=Ads.Substring(0, Ind);
                    Ads=Ads.Substring(Ind + 1, Ads.Length - Ind - 1);
                    Ind=Ads.IndexOf("-");

                    if (Ind > 0)
                    {
                        AddressBox5.Text=Ads.Substring(0, Ind - 1);
                        Ads=Ads.Substring(Ind + 2, Ads.Length - Ind - 2);
                    }
                    else
                    {
                        AddressBox5.Text=Ads.Substring(0, Ads.Length);
                    }
                }
                if (Ads.Length > 0)
                {
                    Ind=Ads.IndexOf(" ");
                    ComboBox6.SelectedItem=Ads.Substring(0, Ind);
                    Ads=Ads.Substring(Ind + 1, Ads.Length - Ind - 1);
                    Ind=Ads.IndexOf("-");

                    if (Ind > 0)
                    {
                        AddressBox6.Text=Ads.Substring(0, Ind - 1);
                        Ads=Ads.Substring(Ind + 2, Ads.Length - Ind - 2);
                    }
                    else
                    {
                        AddressBox6.Text=Ads.Substring(0, Ads.Length);
                    }
                }

                AddressBox1.Focus();
            }
            catch (Exception)
            {
            }
        }

        public void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox1.SelectedIndex >= 0)
            {
                AddressBox1.Enabled=true;

                ComboBox2.Items.Clear();
                ComboBox2.Items.Add("...");
                int j=0;
                if ((string)ComboBox1.SelectedItem == "شهرک" || (string)ComboBox1.SelectedItem == "ساختمان" || (string)ComboBox1.SelectedItem == "پلاک" || (string)ComboBox1.SelectedItem == "طبقه" || (string)ComboBox1.SelectedItem == "واحد")
                {
                    j=1;
                }

                int i;
                for (i=ComboBox1.SelectedIndex + j; i <= ComboBox1.Items.Count - 1; i++)
                {
                    ComboBox2.Items.Add(ComboBox1.Items[i]);
                }
                ComboBox2.Enabled=true;
            }
            else
            {
                AddressBox1.Enabled=false;
                ComboBox2.Enabled=false;
            }

            AddressBox1.Text="";
            ComboBox2.SelectedIndex=0;
        }

        public void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox2.SelectedIndex > 0)
            {
                AddressBox2.Enabled=true;

                ComboBox3.Items.Clear();
                ComboBox3.Items.Add("...");

                int j=0;
                if ((string)ComboBox2.SelectedItem == "شهرک" || (string)ComboBox2.SelectedItem == "ساختمان" || (string)ComboBox2.SelectedItem == "پلاک" || (string)ComboBox2.SelectedItem == "طبقه" || (string)ComboBox2.SelectedItem == "واحد" || ComboBox2.SelectedItem == ComboBox1.SelectedItem)
                {
                    j=1;
                }

                int i;
                for (i=ComboBox2.SelectedIndex + j; i <= ComboBox2.Items.Count - 1; i++)
                {
                    ComboBox3.Items.Add(ComboBox2.Items[i]);
                }
                ComboBox3.Enabled=true;
            }
            else
            {
                AddressBox2.Enabled=false;
                ComboBox3.Enabled=false;
            }

            AddressBox2.Text="";
            ComboBox3.SelectedIndex=0;
        }

        public void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox3.SelectedIndex > 0)
            {
                AddressBox3.Enabled=true;

                ComboBox4.Items.Clear();
                ComboBox4.Items.Add("...");

                int j=0;
                if ((string)ComboBox3.SelectedItem == "شهرک" || (string)ComboBox3.SelectedItem == "ساختمان" || (string)ComboBox3.SelectedItem == "پلاک" || (string)ComboBox3.SelectedItem == "طبقه" || (string)ComboBox3.SelectedItem == "واحد" || ComboBox3.SelectedItem == ComboBox2.SelectedItem)
                {
                    j=1;
                }

                int i;
                for (i=ComboBox3.SelectedIndex + j; i <= ComboBox3.Items.Count - 1; i++)
                {
                    ComboBox4.Items.Add(ComboBox3.Items[i]);
                }
                ComboBox4.Enabled=true;
            }
            else
            {
                AddressBox3.Enabled=false;
                ComboBox4.Enabled=false;
            }

            AddressBox3.Text="";
            ComboBox4.SelectedIndex=0;
        }

        public void ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox4.SelectedIndex > 0)
            {
                AddressBox4.Enabled=true;

                ComboBox5.Items.Clear();
                ComboBox5.Items.Add("...");

                int j=0;
                if ((string)ComboBox4.SelectedItem == "شهرک" || (string)ComboBox4.SelectedItem == "ساختمان" || (string)ComboBox4.SelectedItem == "پلاک" || (string)ComboBox4.SelectedItem == "طبقه" || (string)ComboBox4.SelectedItem == "واحد" || ComboBox4.SelectedItem == ComboBox3.SelectedItem)
                {
                    j=1;
                }

                int i;
                for (i=ComboBox4.SelectedIndex + j; i <= ComboBox4.Items.Count - 1; i++)
                {
                    ComboBox5.Items.Add(ComboBox4.Items[i]);
                }
                ComboBox5.Enabled=true;
            }
            else
            {
                AddressBox4.Enabled=false;
                ComboBox5.Enabled=false;
            }

            AddressBox4.Text="";
            ComboBox5.SelectedIndex=0;
        }

        public void ComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox5.SelectedIndex > 0)
            {
                AddressBox5.Enabled=true;

                ComboBox6.Items.Clear();
                ComboBox6.Items.Add("...");

                int j=0;
                if ((string)ComboBox5.SelectedItem == "شهرک" || (string)ComboBox5.SelectedItem == "ساختمان" || (string)ComboBox5.SelectedItem == "پلاک" || (string)ComboBox5.SelectedItem == "طبقه" || (string)ComboBox5.SelectedItem == "واحد" || ComboBox5.SelectedItem == ComboBox4.SelectedItem)
                {
                    j=1;
                }

                int i;
                for (i=ComboBox5.SelectedIndex + j; i <= ComboBox5.Items.Count - 1; i++)
                {
                    ComboBox6.Items.Add(ComboBox5.Items[i]);
                }
                ComboBox6.Enabled=true;
            }
            else
            {
                AddressBox5.Enabled=false;
                ComboBox6.Enabled=false;
            }

            AddressBox5.Text="";
            ComboBox6.SelectedIndex=0;
        }

        public void ComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox6.SelectedIndex > 0)
            {
                AddressBox6.Enabled=true;
            }
            else
            {
                AddressBox6.Enabled=false;
            }

            AddressBox6.Text="";
        }

    }
}
