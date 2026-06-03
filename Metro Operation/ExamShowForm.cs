using System;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class ExamShowForm
    {
        public ExamShowForm()
        {
            InitializeComponent();
        }

        private int QuesNum;
        private int QuesID;
        private int IDNum;

        public void ExamShowForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (AppState.AnsShould)
                {
                    if (MessageBoxFa.Show("از برنامه خارج می شوید؟", "خروج", MessageBoxIcon.Stop, MessageBoxButtons.YesNo, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    {
                        e.Cancel=true;
                    }
                    else
                    {
                        DialogResult=DialogResult.Cancel;
                        MainForm.ShClose=true;
                        //Application.Exit();
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        public void RegButton_Click(object sender, EventArgs e)
        {
            try
            {
                int Checked=0;
                int i;
                for (i=1; i <= QuesNum; i++)
                {
                    foreach (RadioButton Radio in MainPanel.Controls["QuesPanel" + i.ToString()].Controls.OfType<RadioButton>())
                    {
                        if (Radio.Checked)
                        {
                            @Checked++;
                        }
                    }
                }

                if (QuesNum - @Checked > 0)
                {
                    MessageBoxFa.Show("پاسخ دادن به تمام سوالات الزامی است", "توجه", MessageBoxIcon.Warning);
                    return;
                }

                Enabled=false;

                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    using (OleDbCommand CMD=new OleDbCommand("INSERT INTO ExamResult (P_Num, ExamID, T_Reg, Result, Vis) VALUES (" + AppState.UserPnum + ", " + MainForm.ExamNum.ToString() + ", '" + MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") + "','0', True)", StrConnec))
                    {
                        CMD.ExecuteNonQuery();
                    }

                    using (OleDbCommand CMD=new OleDbCommand("SELECT ID FROM ExamResult WHERE P_Num='" + AppState.UserPnum + "' AND ExamID=" + MainForm.ExamNum.ToString(), StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            IDNum=Convert.ToInt32(Reader["ID"]);
                        }
                    }

                    for (i=0; i <= QuesNum - 1; i++)
                    {
                        string AnsNum="0";
                        string StrQuer="INSERT INTO ExamAnsers (ResultID, QuesNum, AnserNum) VALUES (" + IDNum.ToString() + ", " + (i + QuesID).ToString() + ", ";
                        foreach (RadioButton Radio in MainPanel.Controls["QuesPanel" + (i + 1).ToString()].Controls.OfType<RadioButton>())
                        {
                            if (Radio.Checked)
                            {
                                AnsNum=Radio.Name.Substring(Radio.Name.Length - 1, 1);
                            }
                        }
                        StrQuer += AnsNum + ")";
                        using (OleDbCommand CMD=new OleDbCommand(StrQuer, StrConnec))
                        {
                            CMD.ExecuteNonQuery();
                        }
                    }
                }

                // MainForm.Tables();

                AppState.AnsShould=false;
                MessageBoxFa.Show("ثبت با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }


        public void ExamShowForm_Load(object sender, EventArgs e)
        {
            try
            {
                Height=200;

                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    using (OleDbCommand CMD=new OleDbCommand("SELECT * FROM Exam WHERE ID=" + MainForm.ExamNum.ToString(), StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            TitrLabel.Text=Reader["Titr"].ToString();
                            DateLabel.Text=Reader["Tarikh"].ToString();
                            KindLabel.Text=Reader["Kind"].ToString();
                            MemLabel.Text=Reader["Mem"].ToString();
                            LevLabel.Text=Reader["L_Show"].ToString();
                            RegButton.Enabled=true;
                        }
                    }

                    QuesNum=0;
                    using (OleDbCommand CMD=new OleDbCommand("SELECT * FROM ExamQues WHERE ExamID=" + MainForm.ExamNum.ToString(), StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            QuesNum++;

                            if (QuesNum == 1)
                            {
                                QuesID=Convert.ToInt32(Reader["ID"]);
                            }

                            if (QuesNum <= 5)
                            {
                                MainPanel.Height += 110;
                                Height += 110;
                                Top -= 40;
                            }
                            else if (QuesNum == 6)
                            {
                                MainPanel.Left -= 9;
                                MainPanel.Width += 18;
                            }

                            Panel QPanel=new Panel();
                            Label QNumLabl=new Label();
                            Label QLabl=new Label();

                            QPanel.Name="QuesPanel" + QuesNum.ToString();
                            QPanel.BorderStyle=BorderStyle.FixedSingle;
                            QPanel.BackColor=Color.LightSteelBlue;
                            QPanel.Location=new Point(5, (QuesNum - 1) * 105 + 5);
                            QPanel.Size=(Size)new Point(772, 100);

                            QNumLabl.Name="QuesLabl" + QuesNum.ToString();
                            QNumLabl.AutoSize=true;
                            QNumLabl.Font=new Font("Tahoma", 10, FontStyle.Bold);
                            QNumLabl.Text=QuesNum.ToString() + ")";
                            QNumLabl.Location=new Point(735, 5);

                            QLabl.Name="Ques" + QuesNum.ToString();
                            QLabl.Font=new Font("Tahoma", 10, FontStyle.Bold);
                            QLabl.Text=Reader["Ques"].ToString();
                            QLabl.Location=new Point(10, 5);
                            QLabl.Size=(Size)new Point(725, 36);
                            MainPanel.Controls.Add(QPanel);
                            QPanel.Controls.Add(QNumLabl);
                            QPanel.Controls.Add(QLabl);

                            RadioButton Ans1Raid=new RadioButton()
                            {
                                Name="Ans" + QuesNum.ToString() + "Box1",
                                CheckAlign=ContentAlignment.MiddleLeft,
                                TextAlign=ContentAlignment.MiddleLeft,
                                Text=Reader["Ansr1"].ToString(),
                                Location=new Point(390, 50),
                                Size=(Size)new Point(375, 20)
                            };
                            QPanel.Controls.Add(Ans1Raid);

                            RadioButton Ans2Raid=new RadioButton()
                            {
                                Name="Ans" + QuesNum.ToString() + "Box2",
                                CheckAlign=ContentAlignment.MiddleLeft,
                                TextAlign=ContentAlignment.MiddleLeft,
                                Text=Reader["Ansr2"].ToString(),
                                Location=new Point(390, 75),
                                Size=(Size)new Point(375, 20)
                            };
                            QPanel.Controls.Add(Ans2Raid);

                            if (Reader["Ansr3"].ToString() != "")
                            {
                                RadioButton Ans3Raid=new RadioButton()
                                {
                                    Name="Ans" + QuesNum.ToString() + "Box3",
                                    CheckAlign=ContentAlignment.MiddleLeft,
                                    TextAlign=ContentAlignment.MiddleLeft,
                                    Text=Reader["Ansr3"].ToString(),
                                    Location=new Point(10, 50),
                                    Size=(Size)new Point(375, 20)
                                };
                                QPanel.Controls.Add(Ans3Raid);
                            }

                            if (Reader["Ansr4"].ToString() != "")
                            {
                                RadioButton Ans4Raid=new RadioButton()
                                {
                                    Name="Ans" + QuesNum.ToString() + "Box4",
                                    CheckAlign=ContentAlignment.MiddleLeft,
                                    TextAlign=ContentAlignment.MiddleLeft,
                                    Text=Reader["Ansr4"].ToString(),
                                    Location=new Point(10, 75),
                                    Size=(Size)new Point(375, 20)
                                };
                                QPanel.Controls.Add(Ans4Raid);
                            }

                            RegButton.Enabled=true;
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
    }
}
