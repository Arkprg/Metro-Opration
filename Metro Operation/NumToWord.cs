using System;
using System.Collections.Generic;

namespace Metro_Operation
{
    public class NumToWord
    {

        public static string ConvertNumber(long Number, bool Count=false)
        {

            List<int> Num=new List<int>();
            List<string> Word=new List<string>();
            string Text="";

            Number=Math.Abs(Number);
            if (Number == 0)
            {
                return "صفر";
            }
            else
            {
                do
                {
                    long A=Number / 1000;
                    long B=Number % 1000;
                    Num.Add((int)B);
                    if (A >= 1000)
                    {
                        Number=A;
                    }
                    else if (A != 0)
                    {
                        Num.Add((int)A);
                        break;
                    }
                    else
                    {
                        break;
                    }
                } while (true);
            }
            //---------------------------------------------------'
            for (int i=0; i <= Num.Count - 1; i++)
            {
                if (Count)
                {
                    Word.Add(Num2Count(Num[i]));
                }
                else
                {
                    Word.Add(Num2Word(Num[i]));
                }
            }
            //---------------------------------------------------'
            for (int Counter=Word.Count - 1; Counter >= 0; Counter--)
            {
                if (Counter == 5)
                {
                    if (Word[5] != "")
                    {
                        if (Word[4] != "" || Word[3] != "" || Word[2] != "" || Word[1] != "" || Word[0] != "")
                        {
                            Text += Word[5] + " بیلیارد و ";
                        }
                        else
                        {
                            Text += Word[5] + " بیلیارد";
                            break;
                        }
                    }
                }
                else if (Counter == 4)
                {
                    if (Word[4] != "")
                    {
                        if (Word[3] != "" || Word[2] != "" || Word[1] != "" || Word[0] != "")
                        {
                            Text += Word[4] + " بیلیون و ";
                        }
                        else
                        {
                            Text += Word[4] + " بیلیون";
                            break;
                        }
                    }
                }
                else if (Counter == 3)
                {
                    if (Word[3] != "")
                    {
                        if (Word[2] != "" || Word[1] != "" || Word[0] != "")
                        {
                            Text += Word[3] + " میلیارد و ";
                        }
                        else
                        {
                            Text += Word[3] + " میلیارد";
                            break;
                        }
                    }
                }
                else if (Counter == 2)
                {
                    if (Word[2] != "")
                    {
                        if (Word[1] != "" || Word[0] != "")
                        {
                            Text += Word[2] + " میلیون و ";
                        }
                        else
                        {
                            Text += Word[2] + " میلیون";
                            break;
                        }
                    }
                }
                else if (Counter == 1)
                {
                    if (Word[1] != "")
                    {
                        if (Word[0] != "")
                        {
                            Text += Word[1] + " هزار و ";
                        }
                        else
                        {
                            Text += Word[1] + " هزار";
                            break;
                        }
                    }
                }
                else
                {
                    Text += Word[0];
                }
            }
            return Text;
        }

        private static string Num2Word(int Number)
        {
            List<string> N=new List<string>();
            string Yekan="";
            string Dahgan="";
            string Sadgan="";
            string Value="";

            do
            {
                int A=Convert.ToInt32(Math.Round((double)Number / 10));
                int B=Number % 10;
                N.Add(B.ToString());
                if (A >= 10)
                {
                    Number=A;
                }
                else
                {
                    N.Add(A.ToString());
                    break;
                }
            } while (true);

            if (N.Count == 3)
            {
                switch (N[2])
                {
                    case "0":
                        Sadgan="";
                        break;
                    case "1":
                        Sadgan="صد";
                        break;
                    case "2":
                        Sadgan="دويست";
                        break;
                    case "3":
                        Sadgan="سيصد";
                        break;
                    case "4":
                        Sadgan="چهارصد";
                        break;
                    case "5":
                        Sadgan="پانصد";
                        break;
                    case "6":
                        Sadgan="ششصد";
                        break;
                    case "7":
                        Sadgan="هفتصد";
                        break;
                    case "8":
                        Sadgan="هشتصد";
                        break;
                    case "9":
                        Sadgan="نهصد";
                        break;
                }
            }

            switch (N[0])
            {
                case "0":
                    Yekan="";
                    break;
                case "1":
                    Yekan="یک";
                    break;
                case "2":
                    Yekan="دو";
                    break;
                case "3":
                    Yekan="سه";
                    break;
                case "4":
                    Yekan="چهار";
                    break;
                case "5":
                    Yekan="پنج";
                    break;
                case "6":
                    Yekan="شش";
                    break;
                case "7":
                    Yekan="هفت";
                    break;
                case "8":
                    Yekan="هشت";
                    break;
                case "9":
                    Yekan="نه";
                    break;
            }

            switch (N[1])
            {
                case "0":
                    Dahgan="";
                    break;
                case "1":
                    switch (N[0])
                    {
                        case "0":
                            Yekan="ده";
                            break;
                        case "1":
                            Yekan="یازده";
                            break;
                        case "2":
                            Yekan="دوازده";
                            break;
                        case "3":
                            Yekan="سیزده";
                            break;
                        case "4":
                            Yekan="چهارده";
                            break;
                        case "5":
                            Yekan="پانزده";
                            break;
                        case "6":
                            Yekan="شانزده";
                            break;
                        case "7":
                            Yekan="هفده";
                            break;
                        case "8":
                            Yekan="هیجده";
                            break;
                        case "9":
                            Yekan="نوزده";
                            break;
                    }
                    break;
                case "2":
                    Dahgan="بیست";
                    break;
                case "3":
                    Dahgan="سی";
                    break;
                case "4":
                    Dahgan="چهل";
                    break;
                case "5":
                    Dahgan="پنجاه";
                    break;
                case "6":
                    Dahgan="شصت";
                    break;
                case "7":
                    Dahgan="هفتاد";
                    break;
                case "8":
                    Dahgan="هشتاد";
                    break;
                case "9":
                    Dahgan="نود";
                    break;
            }

            if (!string.IsNullOrEmpty(Sadgan))
            {
                Value += Sadgan;
                if (!string.IsNullOrEmpty(Dahgan))
                {
                    Value += " و " + Dahgan;
                    if (!string.IsNullOrEmpty(Yekan))
                    {
                        Value += " و " + Yekan;
                    }
                }
                else if (!string.IsNullOrEmpty(Yekan))
                {
                    Value += " و " + Yekan;
                }
            }
            else if (!string.IsNullOrEmpty(Dahgan))
            {
                Value += Dahgan;
                if (!string.IsNullOrEmpty(Yekan))
                {
                    Value += " و " + Yekan;
                }
            }
            else
            {
                Value += Yekan;
            }

            return Value;
        }

        private static string Num2Count(int Number)
        {
            List<string> N=new List<string>();
            string Yekan="";
            string Dahgan="";
            string Sadgan="";
            string Value="";

            do
            {
                int A=Convert.ToInt32(Math.Round((double)Number / 10));
                int B=Number % 10;
                N.Add(B.ToString());
                if (A >= 10)
                {
                    Number=A;
                }
                else
                {
                    N.Add(A.ToString());
                    break;
                }
            } while (true);

            if (N.Count == 3)
            {
                switch (N[2])
                {
                    case "0":
                        Sadgan="";
                        break;
                    case "1":
                        Sadgan="صد";
                        break;
                    case "2":
                        Sadgan="دويست";
                        break;
                    case "3":
                        Sadgan="سيصد";
                        break;
                    case "4":
                        Sadgan="چهارصد";
                        break;
                    case "5":
                        Sadgan="پانصد";
                        break;
                    case "6":
                        Sadgan="ششصد";
                        break;
                    case "7":
                        Sadgan="هفتصد";
                        break;
                    case "8":
                        Sadgan="هشتصد";
                        break;
                    case "9":
                        Sadgan="نهصد";
                        break;
                }
            }

            switch (N[0])
            {
                case "0":
                    Yekan="";
                    break;
                case "1":
                    Yekan="اول";
                    break;
                case "2":
                    Yekan="دوم";
                    break;
                case "3":
                    Yekan="سوم";
                    break;
                case "4":
                    Yekan="چهارم";
                    break;
                case "5":
                    Yekan="پنجم";
                    break;
                case "6":
                    Yekan="ششم";
                    break;
                case "7":
                    Yekan="هفتم";
                    break;
                case "8":
                    Yekan="هشتم";
                    break;
                case "9":
                    Yekan="نهم";
                    break;
            }

            switch (N[1])
            {
                case "0":
                    Dahgan="";
                    break;
                case "1":
                    switch (N[0])
                    {
                        case "0":
                            Yekan="دهم";
                            break;
                        case "1":
                            Yekan="یازدهم";
                            break;
                        case "2":
                            Yekan="دوازدهم";
                            break;
                        case "3":
                            Yekan="سیزدهم";
                            break;
                        case "4":
                            Yekan="چهاردهم";
                            break;
                        case "5":
                            Yekan="پانزدهم";
                            break;
                        case "6":
                            Yekan="شانزدهم";
                            break;
                        case "7":
                            Yekan="هفدهم";
                            break;
                        case "8":
                            Yekan="هیجدهم";
                            break;
                        case "9":
                            Yekan="نوزدهم";
                            break;
                    }
                    break;
                case "2":
                    Dahgan="بیست";
                    break;
                case "3":
                    Dahgan="سی";
                    break;
                case "4":
                    Dahgan="چهل";
                    break;
                case "5":
                    Dahgan="پنجاه";
                    break;
                case "6":
                    Dahgan="شصت";
                    break;
                case "7":
                    Dahgan="هفتاد";
                    break;
                case "8":
                    Dahgan="هشتاد";
                    break;
                case "9":
                    Dahgan="نود";
                    break;
            }

            if (!string.IsNullOrEmpty(Sadgan))
            {
                Value += Sadgan;
                if (!string.IsNullOrEmpty(Dahgan))
                {
                    Value += " و " + Dahgan;
                    if (!string.IsNullOrEmpty(Yekan))
                    {
                        Value += " و " + Yekan;
                    }
                }
                else if (!string.IsNullOrEmpty(Yekan))
                {
                    Value += " و " + Yekan;
                }
            }
            else if (!string.IsNullOrEmpty(Dahgan))
            {
                Value += Dahgan;
                if (!string.IsNullOrEmpty(Yekan))
                {
                    Value += " و " + Yekan;
                }
            }
            else
            {
                Value += Yekan;
            }

            return Value;
        }
    }
}
