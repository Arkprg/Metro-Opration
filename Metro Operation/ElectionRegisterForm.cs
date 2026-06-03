using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class ElectionRegisterForm
    {
        public ElectionRegisterForm()
        {
            InitializeComponent();
        }

        private string MemberName;
        private string MemberFamily;
        private string MemberNum;
        private string KandidName;
        private string KandidFamily;
        private string KandidNum;

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void KandidGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 4)
                {
                    KandidGridView.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        public void KandidGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            KandidGridView.Sort(KandidGridView.Columns[2], System.ComponentModel.ListSortDirection.Ascending);

            int i=0;
            while (i < KandidGridView.Rows.Count)
            {
                KandidGridView.Rows[i].Cells[0].Value=i + 1;
                i++;
            }
            if (KandidGridView.Rows.Count > 0)
            {
                KandidGridView.CurrentRow.Selected=false;
            }
        }

        public void MemberGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MemberGridView.Sort(MemberGridView.Columns[2], System.ComponentModel.ListSortDirection.Ascending);

            int i=0;
            while (i < MemberGridView.Rows.Count)
            {
                MemberGridView.Rows[i].Cells[0].Value=i + 1;
                i++;
            }

            if (MemberGridView.Rows.Count > 0)
            {
                MemberGridView.CurrentRow.Selected=false;
            }
        }

        public void RegButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (KandidGridView.Rows.Count == 0)
                {
                    ErrorShow(MemberNameBox, "نام کاندیدها را وارد کنید");
                }
                else if (MemberGridView.Rows.Count == 0)
                {
                    ErrorShow(MemberNameBox, "نام شرکت کنندگان را وارد کنید");
                }
                else if (TitrBox.Text.Length < 5)
                {
                    ErrorShow(TitrBox, "عنوان انتخابات را مشخص کنید");
                }
                else if (!int.TryParse(NumBox.Text, out _))
                {
                    ErrorShow(NumBox, "تعداد انتخاب را مشخص کنید");
                }
                else if (Convert.ToInt16(NumBox.Text) < 1)
                {
                    ErrorShow(NumBox, "تعداد انتخاب حداقل یک می باشد");
                }
                else if (Convert.ToInt16(NumBox.Text) + 1 > KandidGridView.Rows.Count)
                {
                    ErrorShow(KandidAddButton, "تعداد کاندید از تعداد انتخاب کمتر است");
                }
                else if (LevelCombo.SelectedIndex < 0)
                {
                    ErrorShow(LevelCombo, "اولویت نمایش را وارد کنید");
                }
                else if (AnswerCombo.SelectedIndex < 0)
                {
                    ErrorShow(AnswerCombo, "نوع نتیجه را وارد کنید");
                }
                else if (ConvertClass.ShamsiToMiladi(StartCalendar.Text) < DateTime.Today)
                {
                    ErrorShow(StartCalendar, "تاریخ شروع را وارد کنید");
                }
                else if (ConvertClass.ShamsiToMiladi(EndCalendar.Text) < DateTime.Today)
                {
                    ErrorShow(EndCalendar, "تاریخ پایان را وارد کنید");
                }
                else if (ConvertClass.ShamsiToMiladi(StartCalendar.Text) > ConvertClass.ShamsiToMiladi(EndCalendar.Text))
                {
                    ErrorShow(EndCalendar, "بازه انتخابات صحیح نیست");
                }
                else
                {
                    Enabled=false;
                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();

                        using (OleDbCommand CMD=new OleDbCommand("SELECT ID FROM Election WHERE Vis=True AND E_Name=@Titr", StrConnec))
                        {
                            CMD.Parameters.AddWithValue("@Titr", TitrBox.Text.Trim());
                            using (OleDbDataReader Reader=CMD.ExecuteReader())
                            {
                                if (Reader.Read())
                                {
                                    StrConnec.Close();
                                    MessageBoxFa.Show("این عنوان قبلا ثبت شده است", "خطا", MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }


                        int i;
                        string StrQuer="INSERT INTO Election (E_Name, E_Num, E_Candids, E_Mem, L_Show, Ans_Type, E_Start, E_End, U_Reg, T_Reg, Vis) VALUES (@Titr, " + NumBox.Text + ", '";
                        for (i=0; i <= KandidGridView.Rows.Count - 1; i++)
                        {
                            StrQuer += KandidGridView.Rows[i].Cells[3].Value.ToString() + "-";
                        }
                        StrQuer += "', '" + MemBox.Text.Trim() + "', '" + LevelCombo.SelectedItem + "', '" + AnswerCombo.SelectedItem + "', '" + StartCalendar.Text + "', '" + EndCalendar.Text + "', '" + AppState.UserName + "', '" + MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") + "', True)";

                        using (OleDbCommand CMD=new OleDbCommand(StrQuer, StrConnec))
                        {
                            CMD.Parameters.AddWithValue("@Titr", TitrBox.Text.Trim());

                            //CMD.Parameters.AddWithValue("@Mem", MemBox.Text.Trim)
                            CMD.ExecuteNonQuery();
                        }


                        int ID=0;
                        using (OleDbCommand CMD=new OleDbCommand("SELECT ID FROM Election WHERE Vis=True AND E_Name=@Titr AND E_Start='" + StartCalendar.Text + "'", StrConnec))
                        {
                            CMD.Parameters.AddWithValue("@Titr", TitrBox.Text.Trim());
                            using (OleDbDataReader Reader=CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    ID=Convert.ToInt32(Reader["ID"]);
                                }
                            }
                        }

                        for (i=0; i <= MemberGridView.Rows.Count - 1; i++)
                        {
                            using (OleDbCommand CMD=new OleDbCommand("INSERT INTO ElectionMember (E_ID, P_Num, Vis) VALUES (" + ID + ", '" + MemberGridView.Rows[i].Cells[3].Value.ToString() + "', True)", StrConnec))
                            {
                                CMD.ExecuteNonQuery();
                            }
                        }
                    }

                    Enabled=true;
                    MemberGridView.Rows.Clear();
                    KandidGridView.Rows.Clear();
                    LevelCombo.SelectedIndex=-1;
                    AnswerCombo.SelectedIndex=-1;
                    TitrBox.Text="";
                    NumBox.Text="";
                    MemBox.Text="";
                    StartCalendar.Text="";
                    EndCalendar.Text="";
                    MessageBoxFa.Show("ثبت با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
               MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void MemberAddButton_Click(object sender, EventArgs e)
        {
            if (MemberNameBox.Text == "")
            {
                ErrorShow(MemberNameBox, "نام پرسنل را مشخص کنید");
            }
            else
            {
                int i=0;
                while (i < MemberGridView.Rows.Count)
                {
                    if (MemberGridView.Rows[i].Cells[3].Value.ToString() == MemberNum)
                    {
                        MessageBoxFa.Show("این شخص قبلا به لیست شرکت کنندگان اضافه شده است", "خطا", MessageBoxIcon.Error);
                        return;
                    }
                    i++;
                }

                MemberGridView.Rows.Add(MemberGridView.Rows.Count + 1, MemberName, MemberFamily, MemberNum, "حذف");
                MemberFamily="";
                MemberName="";
                MemberNum="";
                MemberNameBox.Text="";
                MemberNameButton.Image=Properties.Resources.user;
                MemberGridView.CurrentRow.Selected=false;

                MemberGridView_ColumnHeaderMouseClick(null, null);
            }
        }

        public void KandidAddButton_Click(object sender, EventArgs e)
        {
            if (KandidNameBox.Text == "")
            {
                ErrorShow(KandidNameBox, "نام پرسنل را مشخص کنید");
            }
            else if (KandidGridView.Rows.Count > 35)
            {
                ErrorShow(KandidNameBox, "امکان ثبت حداکثر 35 کاندید ها وجود دارد");
            }
            else
            {
                int i;
                if (KandidGridView.Rows.Count > 0)
                {
                    i=0;
                    while (i < KandidGridView.Rows.Count)
                    {
                        if (KandidGridView.Rows[i].Cells[3].Value.ToString() == KandidNum)
                        {
                            MessageBoxFa.Show("این شخص قبلا به لیست شرکت کاندیدها اضافه شده است", "خطا", MessageBoxIcon.Error);
                            return;
                        }
                        i++;
                    }
                }

                KandidGridView.Rows.Add(KandidGridView.Rows.Count + 1, KandidName, KandidFamily, KandidNum, "حذف");
                KandidFamily="";
                KandidName="";
                KandidNum="";
                KandidNameBox.Text="";
                KandidNameButton.Image=Properties.Resources.user;

                KandidGridView_ColumnHeaderMouseClick(null, null);
            }
        }

        public void MemberNameButton_Click(object sender, EventArgs e)
        {
            MemberNameBox.Text="";
            MemberNameButton.Image=Properties.Resources.user;
            PersonalSelectForm ShowForm=new PersonalSelectForm();
            if (ShowForm.ShowDialog() == DialogResult.OK)
            {
                MemberFamily=PersonalSelectForm.PFamily;
                MemberName=PersonalSelectForm.PName;
                MemberNum=PersonalSelectForm.PNum;
                MemberNameBox.Text=MemberName + " " + MemberFamily;
                MemberNameButton.Image=Properties.Resources.cancel1;

            }
        }

        public void KandidNameButton_Click(object sender, EventArgs e)
        {
            KandidNameBox.Text="";
            KandidNameButton.Image=Properties.Resources.user;
            PersonalSelectForm ShowForm=new PersonalSelectForm();
            if (ShowForm.ShowDialog() == DialogResult.OK)
            {
                KandidFamily=PersonalSelectForm.PFamily;
                KandidName=PersonalSelectForm.PName;
                KandidNum=PersonalSelectForm.PNum;
                KandidNameBox.Text=KandidName + " " + KandidFamily;
                KandidNameButton.Image=Properties.Resources.cancel1;
            }
        }
    }
}
