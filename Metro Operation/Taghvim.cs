using System;

namespace Metro_Operation
{
    public class Taghvim
    {
        private readonly System.Globalization.PersianCalendar PersianDate=new System.Globalization.PersianCalendar();
        private int S;
        private int M;
        private int R;
        private DateTime MiladiDate;

        public DateTime ShamsiToMiladi(string ShamsiDate)
        {
            if (!long.TryParse(ShamsiDate.Replace("/", ""), out _))
            {
                return DateTime.MinValue;
            }
            try
            {
                if (ShamsiDate.Length != 10)
                {
                    return DateTime.MinValue;
                }
                System.Globalization.PersianCalendar Date_Sh=new System.Globalization.PersianCalendar();
                DateTime Date_M=Date_Sh.ToDateTime(Convert.ToInt32(ShamsiDate.Substring(0, 4)), Convert.ToInt32(ShamsiDate.Substring(5, 2)), Convert.ToInt32(ShamsiDate.Substring(8, 2)), 0, 0, 0, 0, System.Globalization.PersianCalendar.PersianEra);
                return DateTime.Parse(Date_M.ToShortDateString());
            }
            catch
            {
                return DateTime.MinValue;
            }
        }

        public string MiladiToHejri(DateTime MiladiDate, int Corect)
        {
            try
            {
                System.Globalization.HijriCalendar Date_He=new System.Globalization.HijriCalendar();
                MiladiDate=MiladiDate.AddDays(Corect);
                string HejriDate=Date_He.GetYear(MiladiDate).ToString("0000") + "/" + Date_He.GetMonth(MiladiDate).ToString("00") + "/" + Date_He.GetDayOfMonth(MiladiDate).ToString("00");
                return HejriDate;
            }
            catch
            {
                return string.Empty;
                //MainForm.ErrorLogoBox.Text="Taghvim: " + ex.Message + "\n" + MainForm.ErrorLogoBox.Text);
                //MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
            }
        }

        private void Ini()
        {
            S=PersianDate.GetYear(MiladiDate);
            M=PersianDate.GetMonth(MiladiDate);
            R=PersianDate.GetDayOfMonth(MiladiDate);
        }

        public Taghvim()
        {
            MiladiDate=DateTime.Today;
            Ini();
        }

        public Taghvim(DateTime MDate)
        {
            MiladiDate=MDate;
            Ini();
        }

        public Taghvim(string ShDate)
        {
            MiladiDate=ShamsiToMiladi(ShDate);
            Ini();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public void SetDate(DateTime MDate)
        {
            MiladiDate=MDate;
            Ini();
        }

        public void SetDate(string Tarikh)
        {
            MiladiDate=ShamsiToMiladi(Tarikh);
            Ini();
        }

        public int Year()
        {
            return S;
        }

        public int Year(DateTime Miladi_Date)
        {
            return PersianDate.GetYear(Miladi_Date);
        }

        public int Month()
        {
            return M;
        }

        public int Month(DateTime Miladi_Date)
        {
            return PersianDate.GetMonth(Miladi_Date);
        }

        public string MonthName()
        {
            switch (PersianDate.GetMonth(MiladiDate))
            {
                case 1:
                    return "فروردین";
                case 2:
                    return "اردیبهشت";
                case 3:
                    return "خرداد";
                case 4:
                    return "تیر";
                case 5:
                    return "مرداد";
                case 6:
                    return "شهریور";
                case 7:
                    return "مهر";
                case 8:
                    return "آبان";
                case 9:
                    return "آذر";
                case 10:
                    return "دی";
                case 11:
                    return "بهمن";
                case 12:
                    return "اسفند";
                default:
                    return string.Empty;
            }
        }

        public string MonthName(DateTime Miladi_Date)
        {
            switch (PersianDate.GetMonth(Miladi_Date))
            {
                case 1:
                    return "فروردین";
                case 2:
                    return "اردیبهشت";
                case 3:
                    return "خرداد";
                case 4:
                    return "تیر";
                case 5:
                    return "مرداد";
                case 6:
                    return "شهریور";
                case 7:
                    return "مهر";
                case 8:
                    return "آبان";
                case 9:
                    return "آذر";
                case 10:
                    return "دی";
                case 11:
                    return "بهمن";
                case 12:
                    return "اسفند";
                default:
                    return string.Empty;
            }
        }

        public int Day()
        {
            return R;
        }

        public int Day(DateTime Miladi_Date)
        {
            return PersianDate.GetDayOfMonth(Miladi_Date);
        }

        public int DaysInThisMonth()
        {
            return PersianDate.GetDaysInMonth(S, M);
        }

        public int DaysInPrevMonth()
        {
            S=PersianDate.GetYear(PersianDate.AddMonths(MiladiDate, -1));
            M=PersianDate.GetMonth(PersianDate.AddMonths(MiladiDate, -1));
            return PersianDate.GetDaysInMonth(S, M);
        }

        public int DaysInNextMonth()
        {
            S=PersianDate.GetYear(PersianDate.AddMonths(MiladiDate, -1));
            M=PersianDate.GetMonth(PersianDate.AddMonths(MiladiDate, 1));
            return PersianDate.GetDaysInMonth(S, M);
        }

        public int DaysInMonth(DateTime Miladi_Date)
        {
            S=PersianDate.GetYear(Miladi_Date);
            M=PersianDate.GetMonth(Miladi_Date);
            return PersianDate.GetDaysInMonth(S, M);
        }

        public string Tarikh()
        {
            return S.ToString("0000") + "/" + M.ToString("00") + "/" + R.ToString("00");
        }

        public string Tarikh(DateTime Miladi_Date)
        {
            S=PersianDate.GetYear(Miladi_Date);
            M=PersianDate.GetMonth(Miladi_Date);
            R=PersianDate.GetDayOfMonth(Miladi_Date);
            return S.ToString("0000") + "/" + M.ToString("00") + "/" + R.ToString("00");
        }

        public DateTime Miladi()
        {
            return MiladiDate;
        }

        public string DayWeek()
        {
            switch (PersianDate.GetDayOfWeek(MiladiDate))
            {
                case DayOfWeek.Saturday:
                    return "شنبه";
                case DayOfWeek.Sunday:
                    return "یک شنبه";
                case DayOfWeek.Monday:
                    return "دو شنبه";
                case DayOfWeek.Tuesday:
                    return "سه شنبه";
                case DayOfWeek.Wednesday:
                    return "چهار شنبه";
                case DayOfWeek.Thursday:
                    return "پنج شنبه";
                case DayOfWeek.Friday:
                    return "جمعه";
                default:
                    return string.Empty;
            }
        }

      public int DayWeekNum()
        {
            switch (PersianDate.GetDayOfWeek(MiladiDate))
            {
                case DayOfWeek.Saturday:
                    return 1;
                case DayOfWeek.Sunday:
                    return 2;
                case DayOfWeek.Monday:
                    return 3;
                case DayOfWeek.Tuesday:
                    return 4;
                case DayOfWeek.Wednesday:
                    return 5;
                case DayOfWeek.Thursday:
                    return 6;
                case DayOfWeek.Friday:
                    return 7;
                default:
                    return -1;
            }
        }

        public string DayWeek(DateTime Miladi_Date)
        {
            switch (PersianDate.GetDayOfWeek(Miladi_Date))
            {
                case DayOfWeek.Saturday:
                    return "شنبه";
                case DayOfWeek.Sunday:
                    return "یک شنبه";
                case DayOfWeek.Monday:
                    return "دو شنبه";
                case DayOfWeek.Tuesday:
                    return "سه شنبه";
                case DayOfWeek.Wednesday:
                    return "چهار شنبه";
                case DayOfWeek.Thursday:
                    return "پنج شنبه";
                case DayOfWeek.Friday:
                    return "جمعه";
                default:
                    return string.Empty;
            }
        }

        public string AddDay(int Day)
        {
            MiladiDate=PersianDate.AddDays(MiladiDate, Day);
            return Tarikh(MiladiDate);
        }

        public string AddDay(DateTime Miladi_Date, int Day)
        {
            Miladi_Date=PersianDate.AddDays(Miladi_Date, Day);
            return Tarikh(Miladi_Date);
        }

        public string AddMonth(int Month)
        {
            MiladiDate=PersianDate.AddMonths(MiladiDate, Month);
            return Tarikh(MiladiDate);
        }
        public string AddMonth(DateTime Miladi_Date, int Month)
        {
            Miladi_Date=PersianDate.AddMonths(Miladi_Date, Month);
            return Tarikh(Miladi_Date);
        }

        public string AddYear(int Year)
        {
            MiladiDate=PersianDate.AddYears(MiladiDate, Year);
            return Tarikh(MiladiDate);
        }

        public string AddYear(DateTime Miladi_Date, int Year)
        {
            Miladi_Date=PersianDate.AddYears(Miladi_Date, Year);
            return Tarikh(Miladi_Date);
        }

        public int FisrtDayInMonth() //Whith Last Date
        {
            return (int)MiladiDate.AddDays(-(PersianDate.GetDayOfMonth(MiladiDate) - 2)).DayOfWeek;
        }

        public int FisrtDayInMonth(DateTime Miladi_Date)
        {
            return (int)Miladi_Date.AddDays(-(PersianDate.GetDayOfMonth(Miladi_Date) - 2)).DayOfWeek;
        }

        public string FirstOfThisMonth() //Whith Last Date
        {
            return S.ToString("0000") + "/" + M.ToString("00") + "/01";
        }

        public string EndOfThisMonth() //Whith Last Date
        {
            return S.ToString("0000") + "/" + M.ToString("00") + "/" + DaysInThisMonth().ToString("00");
        }
    }
}
