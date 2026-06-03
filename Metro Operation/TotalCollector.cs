using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{

    public class TotalCollector
    {

        public TotalCollector()
        {
        }

        public static string TotaSummer(string P_Num, string Mon)
        {

            try
            {
                double ShEza=0;
                double ShJoEza=0;
                double PasMon=0;
                double MorSat=0;
                double MorSatJo=0;
                double Eza=0;
                double EzaJo=0;
                double TEza=0;
                double TEzaJo=0;
                double Maza=0;
                double MaxEza=0;
                double ZMorDay=0;
                int EsthMorDay=0;
                int MorDay=0;
                int MorDayJo=0;
                int NAmal=0;
                int PAmal=0;
                int FogFri=0;
                string ShiftTime="";
                string ShiftName;
                string PPost;


                ShiftTime="";
                ShiftName="";
                PPost="";
                ShEza=0;
                ShJoEza=0;
                PasMon=0;
                MorSat=0;
                MorSatJo=0;
                Eza=0;
                EzaJo=0;
                TEza=0;
                TEzaJo=0;
                Maza=0;
                MaxEza=0;
                EsthMorDay=0;
                MorDay=0;
                MorDayJo=0;
                ZMorDay=0;
                PAmal=0;
                NAmal=0;
                FogFri=0;

                if (Mon.Length > 7)
                {
                    Mon=Mon.Substring(0, 7);
                }

                DataRow[] DRow=MainForm.PersonTable.Select("P_Num='" + P_Num + "'");
                ShiftTime=DRow[0]["Shift_time"].ToString();
                ShiftName=DRow[0]["Shift_name"].ToString();
                PPost=DRow[0]["P_Post"].ToString();

                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    using (OleDbCommand CMD=new OleDbCommand("SELECT * FROM ShKar WHERE Tarikh='" + Mon + "'", StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            if (ShiftTime == "9 ساعته")
                            {
                                if (ShiftName == "A")
                                {
                                    FogFri=Convert.ToInt32(Reader["AJom9"].ToString());
                                }
                                else if (ShiftName == "B")
                                {
                                    FogFri=Convert.ToInt32(Reader["BJom9"].ToString());
                                }
                                else if (ShiftName == "C")
                                {
                                    FogFri=Convert.ToInt32(Reader["CJom9"].ToString());
                                }
                            }
                            else if (ShiftTime == "12 ساعته")
                            {
                                if (ShiftName == "A")
                                {
                                    FogFri=Convert.ToInt32(Reader["AJom12"].ToString());
                                }
                                else if (ShiftName == "B")
                                {
                                    FogFri=Convert.ToInt32(Reader["BJom12"].ToString());
                                }
                                else if (ShiftName == "C")
                                {
                                    FogFri=Convert.ToInt32(Reader["CJom12"].ToString());
                                }
                            }
                        }
                    }

                    using (OleDbCommand CMD=new OleDbCommand("SELECT Kind, Tarikh FROM Morakhasi WHERE P_Num='" + P_Num + "' AND Vis=True AND Tarikh LIKE '" + Mon + "%'", StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            if (Reader["Kind"].ToString() == "استحقاقی")
                            {
                                if (ConvertClass.ShamsiToMiladi(Reader["Tarikh"].ToString()).DayOfWeek == DayOfWeek.Friday)
                                {
                                    FogFri--; //// بدون کسر از روز جمعه
                                }
                                //Else
                                MorDay++;
                                //End If
                            }
                            else
                            {
                                EsthMorDay++;
                            }
                        }
                    }

                    if (PPost == "راهبر قطار")
                    {
                        switch (ShiftTime)
                        {
                            case "12 ساعته":
                                ZMorDay=4.5;
                                break;
                            default:
                                ZMorDay=2.5;
                                break;
                        }
                    }
                    else
                    {
                        if (ShiftTime == "12 ساعته")
                        {
                            ZMorDay=3;
                        }
                        else
                        {
                            ZMorDay=2;
                        }
                    }

                    using (OleDbCommand CMD=new OleDbCommand("SELECT Amal, OnvAmal FROM Amal WHERE P_Num='" + P_Num + "' AND Vis=True AND Tarikh LIKE '" + Mon + "%'", StrConnec)) //  *****مرخصی ساعتی *****
                       using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            double Saat=0;
                            while (Reader.Read())
                            {
                                if (Reader["OnvAmal"].ToString() == "ساعتی")
                                {
                                    double SSaati=0;
                                    double ESaati=0;

                                    SSaati=ConvertClass.TimeToDouble(Reader["Amal"].ToString().Substring(0, 5));
                                    ESaati=ConvertClass.TimeToDouble(Reader["Amal"].ToString().Substring(9, 5));
                                    if (SSaati > ESaati)
                                {
                                    ESaati += 24;
                                }

                                Saat=ESaati - SSaati;

                                    //If ShamsiToMiladi(Reader.Item("Tarikh").ToString).DayOfWeek=DayOfWeek.Friday Then    '// بدون کسر از روز جمعه
                                    //    MorSatJo += 2
                                    //    MorSat += Saat - 2
                                    //Else
                                    MorSat += Saat;
                                    //End If
                                }
                                else if (Reader["OnvAmal"].ToString() == "منفی")
                                {
                                    NAmal++;
                                }
                                else if (Reader["OnvAmal"].ToString() == "مثبت")
                                {
                                    PAmal++;
                                }
                            }
                        }


                    using (OleDbCommand CMD=new OleDbCommand("SELECT Tarikh, E_Time FROM Ezafeh WHERE P_Num='" + P_Num + "' AND Vis=True AND Tarikh LIKE '" + Mon + "%'", StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            if (ConvertClass.ShamsiToMiladi(Reader["Tarikh"].ToString()).DayOfWeek == DayOfWeek.Friday)
                            {
                                EzaJo += ConvertClass.TimeToDouble(Reader["E_Time"].ToString());
                            }
                            else
                            {
                                Eza += ConvertClass.TimeToDouble(Reader["E_Time"].ToString());
                            }
                        }
                    }

                    using (OleDbCommand CMD=new OleDbCommand("SELECT PasMo, EzShift, EzJoShift FROM TotaMon WHERE P_Num='" + P_Num + "' AND Maah='" + Mon + "'", StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            PasMon=ConvertClass.TimeToDouble(Reader["PasMo"].ToString());
                            ShEza=ConvertClass.TimeToDouble(Reader["EzShift"].ToString());
                            ShJoEza=ConvertClass.TimeToDouble(Reader["EzJoShift"].ToString());
                            if (!string.IsNullOrEmpty(Reader["MaxEza"].ToString()))
                            {
                                MaxEza=ConvertClass.TimeToDouble(Reader["MaxEza"].ToString());
                            }
                        }
                    }

                    TEza=ShEza + Eza + PasMon - ZMorDay * MorDay - MorSat + PAmal * 2 - NAmal * 2;
                    TEzaJo=ShJoEza + EzaJo - ZMorDay * MorDayJo - MorSatJo;
                    if (TEzaJo < 0)
                    {
                        TEza += TEzaJo;
                        TEzaJo=0;
                    }

                    if (MaxEza > 0)
                    {
                        if (TEzaJo > MaxEza)
                        {
                            Maza=TEzaJo + TEza - MaxEza;
                            TEzaJo=MaxEza;
                            TEza=0;
                        }
                        else
                        {
                            Maza=TEzaJo + TEza - MaxEza;
                            TEza=MaxEza - TEzaJo;
                        }
                    }
                    else
                    {
                        if (TEzaJo > (120 - NAmal * 2))
                        {
                            TEza += 120 - NAmal * 2 - TEzaJo;
                            TEzaJo=120 - NAmal * 2;
                        }
                        if (TEza + TEzaJo > (120 - NAmal * 2))
                        {
                            Maza=TEza + TEzaJo - (120 - NAmal * 2);
                            TEza=120 - NAmal * 2 - TEzaJo;
                        }
                    }
                    using (OleDbCommand CMD=new OleDbCommand("UPDATE TotaMon SET MorSaat='" + ConvertClass.DoubleToTime(MorSat + MorSatJo) + "', MorDay=" + (MorDay + MorDayJo + EsthMorDay).ToString() + ", EzJom='" + ConvertClass.DoubleToTime(EzaJo) + "', Eza='" + ConvertClass.DoubleToTime(Eza) + "', PAmal=" + PAmal.ToString() + ", NAmal=" + NAmal.ToString() + ", FogJom='" + ConvertClass.DoubleToTime(FogFri * 9) + "', TotaJom='" + ConvertClass.DoubleToTime(TEzaJo) + "', Tota='" + ConvertClass.DoubleToTime(TEza) + "', NexMo='" + ConvertClass.DoubleToTime(Maza) + "' WHERE P_Num='" + P_Num + "' AND Maah='" + Mon + "'", StrConnec))
                    {
                        CMD.ExecuteNonQuery();
                    }
                }

                return string.Empty; // بررسی شود
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo="TotalCollector: " + ex.Message + "\n" + MainForm.ErrorLogo;
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                return string.Empty;
            }
        }
    }

}
