using System;
using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class TerminalParametrForm
    {
        public TerminalParametrForm()
        {
            InitializeComponent();
        }

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public static void PanelCreator(int i, string[] RG, Panel Panl, string SLoc, string ELoc)
        {
            Panel TPanel=new Panel();
            Label TLable=new Label();
            MaskedTextBox TMask=new MaskedTextBox();
            //Dim KLable As New Label
            //Dim KCombo As New ComboBox
            Label GLable=new Label();
            ComboBox GCombo=new ComboBox();
            Label SLable=new Label();
            ComboBox SCombo=new ComboBox();
            Label ELable=new Label();
            ComboBox ECombo=new ComboBox();


            TPanel.Name="TripPanel" + i.ToString();
            TPanel.BorderStyle=BorderStyle.FixedSingle;
            TPanel.BackColor=Color.LightSteelBlue;
            TPanel.Location=new Point(10, (i - 1) * 40 + 5);
            TPanel.Size=(Size)new Point(575, 32);

            TLable.Name="TripLabl" + i.ToString();
            TLable.AutoSize=true;
            TLable.Text="ساعت حرکت:";
            TLable.Location=new Point(483, 7);

            TMask.Name="TimeBox" + i.ToString();
            TMask.Mask="00:00";
            TMask.PromptChar=(char)32;
            TMask.Location=new Point(439, 4);
            TMask.Size=new Size(45, 23);
            TMask.TextAlign=HorizontalAlignment.Center;

            GLable.Name="GroupLabl" + i.ToString();
            GLable.AutoSize=true;
            GLable.Text="گروه راهبری:";
            GLable.Location=new Point(354, 7);

            GCombo.Name="GCombo" + i.ToString();
            GCombo.FormattingEnabled=true;
            GCombo.Location=new Point(269, 3);
            GCombo.Size=new Size(85, 24);
            GCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            foreach (string ST in RG)
            {
                GCombo.Items.Add(ST.ToString());
            }

            //KLable.Name="GroupLabl" & i.ToString
            //KLable.AutoSize=True
            //KLable.Text="نوع حرکت:"
            //KLable.Location=new Point(364, 7)

            //KCombo.Name="KCombo" & i.ToString
            //KCombo.FormattingEnabled=True
            //KCombo.Location=new Point(279, 3)
            //KCombo.Size=New Size(85, 24)
            //KCombo.DropDownStyle=ComboBoxStyle.DropDownList
            //KCombo.Items.AddRange(New Object() {"ورودی", "خروجی"})

            SLable.Name="SLabl" + i.ToString();
            SLable.AutoSize=true;
            SLable.Text="مبدا:";
            SLable.Location=new Point(231, 7);

            SCombo.Name="SCombo" + i.ToString();
            SCombo.FormattingEnabled=true;
            SCombo.Location=new Point(146, 3);
            SCombo.Size=new Size(85, 24);
            SCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            SCombo.Items.AddRange(new object[] { SLoc, ELoc });

            ELable.Name="ELabl" + i.ToString();
            ELable.AutoSize=true;
            ELable.Text="مقصد:";
            ELable.Location=new Point(95, 7);

            ECombo.Name="ECombo" + i.ToString();
            ECombo.FormattingEnabled=true;
            ECombo.Location=new Point(10, 3);
            ECombo.Size=new Size(85, 24);
            ECombo.DropDownStyle=ComboBoxStyle.DropDownList;
            ECombo.Items.AddRange(new object[] { SLoc, ELoc });

            Panl.Controls.Add(TPanel);
            TPanel.Controls.Add(TLable);
            TPanel.Controls.Add(TMask);
            TPanel.Controls.Add(GLable);
            TPanel.Controls.Add(GCombo);
            //TPanel.Controls.Add(KLable)
            //TPanel.Controls.Add(KCombo)
            TPanel.Controls.Add(SLable);
            TPanel.Controls.Add(SCombo);
            TPanel.Controls.Add(ELable);
            TPanel.Controls.Add(ECombo);
        }

        public void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {

                //If CInt(AllTeh1Box.Text) + CInt(AllTeh2Box.Text) + CInt(AllTeh3Box.Text) > 12 Then ' **************   پایانه تهران
                //    MainPanel1.Width += 13
                //    MainPanel1.Left -= 7
                //End If
                //Dim TGR1(CInt(Teh1Box.Text) + CInt(KeshTeh1Box.Text) - 1) As String
                //For i=0 To CInt(Teh1Box.Text) - 1
                //    TGR1(i)="تهران " & (i + 1).ToString
                //Next
                //For i=0 To CInt(KeshTeh1Box.Text) - 1
                //    TGR1(CInt(Teh1Box.Text) + i)="کشیک " & (i + 1).ToString
                //Next
                //For i=1 To CInt(AllTeh1Box.Text)
                //    If i < 13 Then MainPanel1.Height += 35
                //    PanelCreator(i, TGR1, MainPanel1, "تهران", "پایانه")
                //Next
                //Dim TGR2(CInt(Teh2Box.Text) + CInt(KeshTeh2Box.Text) - 1) As String
                //For i=0 To CInt(Teh2Box.Text) - 1
                //    TGR2(i)="تهران " & (i + 1).ToString
                //Next
                //For i=0 To CInt(KeshTeh2Box.Text) - 1
                //    TGR2(CInt(Teh2Box.Text) + i)="کشیک " & (i + 1).ToString
                //Next
                //For i=CInt(AllTeh1Box.Text) + 1 To CInt(AllTeh1Box.Text) + CInt(AllTeh2Box.Text)
                //    If i < 13 Then MainPanel1.Height += 35
                //    PanelCreator(i, TGR2, MainPanel1, "تهران", "پایانه")
                //Next
                //If CInt(AllTeh3Box.Text) > 12 Then
                //    MainPanel1.Width += 13
                //    MainPanel1.Left -= 7
                //End If
                //Dim TGR3(CInt(Teh3Box.Text) + CInt(KeshTeh3Box.Text) - 1) As String
                //For i=0 To CInt(Teh3Box.Text) - 1
                //    TGR3(i)="تهران " & (i + 1).ToString
                //Next
                //For i=0 To CInt(KeshTeh3Box.Text) - 1
                //    TGR3(CInt(Teh3Box.Text) + i)="کشیک " & (i + 1).ToString
                //Next
                //For i=CInt(AllTeh1Box.Text) + CInt(AllTeh2Box.Text) + 1 To CInt(AllTeh1Box.Text) + CInt(AllTeh2Box.Text) + CInt(AllTeh3Box.Text)
                //    If i < 13 Then MainPanel1.Height += 35
                //    PanelCreator(i, TGR3, MainPanel1, "تهران", "پایانه")
                //Next


                //If CInt(All1Box.Text) + CInt(All2Box.Text) + CInt(All3Box.Text) > 12 Then ' **************   پایانه مهرشهر
                //    MainPanel1.Width += 13
                //    MainPanel1.Left -= 7
                //End If
                //Dim MGR1(CInt(Gol1Box.Text) + CInt(Mehr1Box.Text) + CInt(KeshGol1Box.Text) - 1) As String
                //For i=0 To CInt(Gol1Box.Text) - 1
                //    MGR1(i)="گلشهر " & (i + 1).ToString
                //Next
                //For i=0 To CInt(Mehr1Box.Text) - 1
                //    MGR1(CInt(Gol1Box.Text) + i)="مهرشهر " & (i + 1).ToString
                //Next
                //For i=0 To CInt(KeshGol1Box.Text) - 1
                //    MGR1(CInt(Gol1Box.Text) + CInt(Mehr1Box.Text) + i)="کشیک " & (i + 1).ToString
                //Next
                //For i=1 To CInt(All1Box.Text)
                //    If i < 13 Then MainPanel2.Height += 35
                //    PanelCreator(i, MGR1, MainPanel2, "گلشهر", "مهرشهر")
                //Next

                //Dim MGR2(CInt(Gol2Box.Text) + CInt(Mehr2Box.Text) + CInt(KeshGol2Box.Text) - 1) As String
                //For i=0 To CInt(Gol2Box.Text) - 1
                //    MGR2(i)="گلشهر " & (i + 1).ToString
                //Next
                //For i=0 To CInt(Mehr2Box.Text) - 1
                //    MGR2(CInt(Gol2Box.Text) + i)="مهرشهر " & (i + 1).ToString
                //Next
                //For i=0 To CInt(KeshGol2Box.Text) - 1
                //    MGR2(CInt(Gol2Box.Text) + CInt(Mehr2Box.Text) + i)="کشیک " & (i + 1).ToString
                //Next
                //For i=CInt(All1Box.Text) + 1 To CInt(All1Box.Text) + CInt(All2Box.Text)
                //    If i < 13 Then MainPanel2.Height += 35
                //    PanelCreator(i, MGR2, MainPanel2, "گلشهر", "مهرشهر")
                //Next

                //Dim MGR3(CInt(Gol3Box.Text) + CInt(Mehr3Box.Text) + CInt(KeshGol3Box.Text) - 1) As String
                //For i=0 To CInt(Gol3Box.Text) - 1
                //    MGR3(i)="گلشهر " & (i + 1).ToString
                //Next
                //For i=0 To CInt(Mehr3Box.Text) - 1
                //    MGR3(CInt(Gol3Box.Text) + i)="مهرشهر " & (i + 1).ToString
                //Next
                //For i=0 To CInt(KeshGol3Box.Text) - 1
                //    MGR3(CInt(Gol3Box.Text) + CInt(Mehr3Box.Text) + i)="کشیک " & (i + 1).ToString
                //Next
                //For i=CInt(All1Box.Text) + CInt(All2Box.Text) + 1 To CInt(All1Box.Text) + CInt(All2Box.Text) + CInt(All3Box.Text)
                //    If i < 13 Then MainPanel2.Height += 35
                //    PanelCreator(i, MGR3, MainPanel2, "گلشهر", "مهرشهر")
                //Next

                TabControl1.SelectedIndex=1;
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            TabControl1.SelectedIndex=0;

        }

        public void Button2_Click(object sender, EventArgs e)
        {
            NotifyIcon SS=new NotifyIcon();
            SS.ShowBalloonTip(12000, "aa", "SS", ToolTipIcon.Info);
            DataGridView1.Rows.Clear();
            int i;
            for (i=1; i <= int.Parse(AllTeh1Box.Text) + int.Parse(AllTeh2Box.Text) + int.Parse(AllTeh3Box.Text); i++)
            {
                //DataGridView1.Rows.Add(i, MainPanel1.Controls("TripPanel" & i.ToString).Controls("TimeBox" & i.ToString).Text, MainPanel1.Controls("TripPanel" & i.ToString).Controls("SCombo" & i.ToString).Text, MainPanel1.Controls("TripPanel" & i.ToString).Controls("ECombo" & i.ToString).Text, MainPanel1.Controls("TripPanel" & i.ToString).Controls("GCombo" & i.ToString).Text, MainPanel1.Controls("TripPanel" & i.ToString).Controls("GCombo" & i.ToString).Text)
            }
            TabControl1.SelectedIndex=2;
        }

        public void Button5_Click(object sender, EventArgs e)
        {
            DataGridView2.Rows.Clear();
            int i;
            for (i=1; i <= int.Parse(All1Box.Text) + int.Parse(All2Box.Text) + int.Parse(All3Box.Text); i++)
            {
                DataGridView2.Rows.Add(i, MainPanel2.Controls["TripPanel" + i.ToString()].Controls["TimeBox" + i.ToString()].Text, MainPanel2.Controls["TripPanel" + i.ToString()].Controls["SCombo" + i.ToString()].Text, MainPanel2.Controls["TripPanel" + i.ToString()].Controls["ECombo" + i.ToString()].Text, MainPanel2.Controls["TripPanel" + i.ToString()].Controls["GCombo" + i.ToString()].Text, MainPanel2.Controls["TripPanel" + i.ToString()].Controls["GCombo" + i.ToString()].Text);
            }
            TabControl1.SelectedIndex=3;
        }
    }
}
