using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class AboutProgramForm
    {
        public AboutProgramForm()
        {
            InitializeComponent();
        }

        public void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Aboutprogram_Load(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection strConnec=new OleDbConnection(AppState.ConnectionString))
                {
                    strConnec.Open();

                    // آخرین نسخه
                    using (OleDbCommand cmd=new OleDbCommand("SELECT TOP 1 * FROM AppVer WHERE Vis=True ORDER BY ID DESC", strConnec))
                    using (OleDbDataReader reader=cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Label1.Text=reader["Tarikh"].ToString();
                            Label2.Text=reader["Ver"].ToString();
                        }
                    }


                    // ۷ نسخه اخیر
                    string changesHtml="";
                    using (OleDbCommand cmd=new OleDbCommand("SELECT TOP 7 * FROM AppVer WHERE Vis=True ORDER BY ID DESC", strConnec))
                    using (OleDbDataReader reader=cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string temp=reader["Mem"].ToString();
                            int i=1;

                            changesHtml += $"<p><span style='FONT-SIZE: 15pt'> نسخه نرم افزار: {reader["Ver"]}</span><br>" +
                                           $"<span style='FONT-SIZE: 14pt'>تاریخ ارائه: {reader["Tarikh"]}</span><br>" +
                                           "<span style='FONT-SIZE: 12pt'>";

                            while (temp.Length > 1)
                            {
                                int dotIndex=temp.IndexOf(".");
                                if (dotIndex >= 0)
                                {
                                    changesHtml += $"{i}) {temp.Substring(0, dotIndex + 1)}<br>";
                                    temp=temp.Substring(dotIndex + 1);
                                }
                                else
                                {
                                    changesHtml += $"{i}) {temp}<br>";
                                    temp="";
                                }
                                i++;
                            }

                            changesHtml += "</span><br></p>\n";
                        }
                    }

                    WebBrowser1.DocumentText=$"<html><head></head><body dir='rtl'><font face='B Nazanin,Nazanin'> {changesHtml}</font></body></html>";
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo=$"{Text}: {ex.Message}\n{MainForm.ErrorLogo}";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }
    }
}
