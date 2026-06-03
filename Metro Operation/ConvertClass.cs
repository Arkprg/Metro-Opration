using System;

namespace Metro_Operation
{
    public class ConvertClass
    {
        public static DateTime ShamsiToMiladi(string ShamsiDate)
        {
            if (!long.TryParse(ShamsiDate.Replace("/", ""), out _))
            {
                return default;
            }
            try
            {
                if (ShamsiDate.Length != 10)
                {
                    return default;
                }
                System.Globalization.PersianCalendar Date_Sh=new System.Globalization.PersianCalendar();
                DateTime Date_M=Date_Sh.ToDateTime(Convert.ToInt32(ShamsiDate.Substring(0, 4)), Convert.ToInt32(ShamsiDate.Substring(5, 2)), Convert.ToInt32(ShamsiDate.Substring(8, 2)), 0, 0, 0, 0, System.Globalization.PersianCalendar.PersianEra);
                return DateTime.Parse(Date_M.ToShortDateString());
            }
            catch
            {
                return default;
                //MainForm.ErrorLogoBox.Text="ConvertClass: " + ex.Message + "\n" + MainForm.ErrorLogoBox.Text);
                //MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
            }
        }

        public static string MiladiToHejri(DateTime miladiDate, int correctDays=0)
        {
            try
            {
                var hijri=new System.Globalization.HijriCalendar();
                miladiDate=miladiDate.AddDays(correctDays);

                int year=hijri.GetYear(miladiDate);
                int month=hijri.GetMonth(miladiDate);
                int day=hijri.GetDayOfMonth(miladiDate);

                return $"{day:00} {HejriMonthName(month)} {year:0000}";
            }
            catch
            {
                return string.Empty;
            }
        }

        public static string HejriMonthName(int month)
        {
            switch (month)
            {
                case 1: return "محرم";
                case 2: return "صفر";
                case 3: return "ربیع‌الاول";
                case 4: return "ربیع‌الثانی";
                case 5: return "جمادی‌الاول";
                case 6: return "جمادی‌الثانی";
                case 7: return "رجب";
                case 8: return "شعبان";
                case 9: return "رمضان";
                case 10: return "شوال";
                case 11: return "ذی‌القعده";
                case 12: return "ذی‌الحجه";
                default: return string.Empty;
            }
        }


        public static string MiladiToShamsi(DateTime MiladiDate)
        {
            try
            {
                System.Globalization.PersianCalendar Date_He=new System.Globalization.PersianCalendar();
                string ShamsiDate=Date_He.GetYear(MiladiDate).ToString("0000") + "/" + Date_He.GetMonth(MiladiDate).ToString("00") + "/" + Date_He.GetDayOfMonth(MiladiDate).ToString("00");
                return ShamsiDate;
            }
            catch
            {
                return string.Empty;
                //MainForm.ErrorLogoBox.Text="Taghvim: " + ex.Message + "\n" + MainForm.ErrorLogoBox.Text);
                //MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
            }
        }

        public static double TimeToDouble(string Tim, bool H24=false)
        {
            try
            {
                Tim=Tim.Trim();
                if (Tim == ":" || Tim.Length == 0)
                {
                    return 0;
                }
                bool Neg=false;

                if (Tim.Substring(0, 1) == "-")
                {
                    Neg=true;
                    Tim=Tim.Substring(1, Tim.Length - 1);
                }

                byte Loc=(byte)(Tim.IndexOf(":") + 1);
                double Ou=0;

                if (Tim.Length < 5)
                {
                    return -1;
                }
                else if (H24 && double.Parse(Tim.Substring(0, Loc - 1)) > 23)
                {
                    return -1;
                }
                else
                {
                    Ou=double.Parse(Tim.Substring(0, Loc - 1));

                    if (double.Parse(Tim.Substring(Loc, 2)) > 59)
                    {
                        return -1;
                    }
                    else
                    {
                        Ou += Convert.ToDouble(double.Parse(Tim.Substring(Loc, 2)) / 60);
                    }
                }

                if (Neg)
                {
                    Ou *= -1;
                }
                return Ou;
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo="Taghvim: " + ex.Message + "\n" + MainForm.ErrorLogo;
                return -1;
            }
        }

        public static string DoubleToTime(double Dou)
        {
            try
            {
                string Ou="";
                double H=0;
                double M=0;
                if (Dou < 0)
                {
                    Dou *= -1;
                    Ou="-";
                }
                Dou=Math.Round(Dou, 2);
                H=Math.Truncate(Dou);
                M=Math.Round((Dou - Math.Truncate(Dou)) * 60);
                Ou += ((int)Math.Truncate(H)).ToString("00") + ":" + ((int)M).ToString("00");
                return Ou;
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo="Taghvim: " + ex.Message + "\n" + MainForm.ErrorLogo;
                return string.Empty;
            }
        }

        public static string DoubleToTime(double Dou, bool RoundUp)
        {
            string Ou="";
            double H;
            double M;
            if (Dou < 0)
            {
                Dou *= -1;
                Ou="-";
            }
            Dou=Math.Round(Dou, 2);
            H=Math.Truncate(Dou);
            M=Math.Round((Dou - Math.Truncate(Dou)) * 60);

            if (RoundUp)
            {
                if (M > 0 && M <= 15)
                {
                    M=15;
                }
                else if (M > 15 && M <= 30)
                {
                    M=30;
                }
                else if (M > 30 && M <= 45)
                {
                    M=30;
                }
                else if (M > 45 && M <= 60)
                {
                    H++;
                    M=0;
                }
            }
            else
            {
                if (M > 0 && M < 15)
                {
                    M=0;
                }
                else if (M >= 15 && M < 30)
                {
                    M=15;
                }
                else if (M >= 30 && M < 45)
                {
                    M=30;
                }
                else if (M >= 45 && M < 60)
                {
                    M=45;
                }
            }

            Ou += ((int)Math.Truncate(H)).ToString("00") + ":" + ((int)M).ToString("00");
            return Ou;
        }

        public static int TimeToMinute(string Tim)
        {
            bool Mines=false;
            int H;
            int M;
            int Ou;

            if (Tim.Substring(0, 1) == "-")
            {
                Mines=true;
                Tim=Tim.Substring(1, Tim.Length - 1);
            }
            H=Convert.ToInt32(double.Parse(Tim.Substring(0, Tim.IndexOf(":"))) * 60);
            M=Convert.ToInt32(Tim.Substring(Tim.IndexOf(":") + 1, Tim.Length - Tim.IndexOf(":") - 1));
            Ou=H + M;
            if (Mines)
            {
                Ou *= -1;
            }

            return Ou;
        }

        public static string MinuteToTime(int Dou)
        {
            string Ou="";
            double H;
            double M;

            if (Dou < 0)
            {
                Ou="-";
            }

            H=Math.Truncate((double)Dou / 60);
            M=Dou - (int)H * 60;
            Ou += ((int)H).ToString("00") + ":" + ((int)M).ToString("00");
            return Ou;
        }

        public static int DateToDays(string Dat)
        {
            if (Dat.Length != 10)
            {
                return 0;
            }

            int S=int.Parse(Dat.Substring(0, 4)) - 1;
            int M=int.Parse(Dat.Substring(5, 2)) - 1;
            int R=int.Parse(Dat.Substring(8, 2)) - 1;
            return Convert.ToInt32(S * 365.25 + M * 30.4375 + R);
        }

        public static string DaysToDate(int Days)
        {
            string Ou="";
            int S=(int)Math.Truncate(Days / 365.25);
            int M=(int)Math.Truncate((Days - S * 365.25) / 30.4375);
            int R=(int)Math.Truncate(Days - S * 365.25 - M * 30.4375);
            Ou += S.ToString("00") + "/" + M.ToString("00") + "/" + R.ToString("00");
            return Ou;
        }

        public static bool DateChecker(string SelectDate)
        {
            Taghvim PersianDate=new Taghvim(SelectDate);
            bool Ret=false;

            if (PersianDate.Miladi() > MainForm.PersianToday.Miladi() && PersianDate.Miladi() < MainForm.PersianToday.Miladi().AddDays(10))
            {
                Ret=true;
            }
            else if (PersianDate.Month() == MainForm.PersianToday.Month())
            {
                if (AppState.UserLevel == 9 || AppState.UserLevel == 19)
                {
                    if (PersianDate.Miladi() > DateTime.Today)
                    {
                        Ret=true;
                    }
                }
                else
                {
                    Ret=true;
                }
            }
            else if (PersianDate.Month() == MainForm.PersianToday.Month() - 1)
            {
                if ((AppState.UserLevel > 4 && MainForm.PersianToday.Day() < 5) || (AppState.UserLevel < 5 && MainForm.PersianToday.Day() < 7) || AppState.UserLevel == 0)
                {
                    Ret=true;
                }
            }

            return Ret;
        }
    }

}
