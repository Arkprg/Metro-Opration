using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;

namespace Metro_Operation
{
    public static class FontManager
    {
        private static PrivateFontCollection _fontCollection;
        private static Dictionary<string, FontFamily> _fontFamilies;

        // بارگذاری همه فونت‌ها از پوشه Fonts
        private static void LoadFonts()
        {
            if (_fontCollection != null)
            {
                return;
            }

            _fontCollection=new PrivateFontCollection();
            _fontFamilies=new Dictionary<string, FontFamily>(StringComparer.OrdinalIgnoreCase);

            string fontsPath=Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Fonts");
            if (!Directory.Exists(fontsPath))
            {
                return;
            }

            foreach (string file in Directory.GetFiles(fontsPath, "*.ttf"))
            {
                try
                {
                    _fontCollection.AddFontFile(file);
                    FontFamily family=_fontCollection.Families[_fontCollection.Families.Length - 1];
                    string name=Path.GetFileNameWithoutExtension(file);
                    _fontFamilies[name]=family;
                }
                catch
                {
                    // نادیده گرفتن فونت‌های خراب
                }
            }
        }

        // گرفتن فونت بر اساس نام فایل (بدون پسوند) و اندازه
        public static Font GetFont(string fontName, float size=9.5f, FontStyle style=FontStyle.Regular)
        {
            LoadFonts();

            if (_fontFamilies != null && _fontFamilies.TryGetValue(fontName, out FontFamily family))
            {
                return new Font(family, size, style);
            }
            else
            {
                return new Font("Segoe UI", size, style);
            }
        }

        // گرفتن فونت بر اساس اندیس
        public static Font GetFont(int index, float size=9.5f, FontStyle style=FontStyle.Regular)
        {
            LoadFonts();

            if (_fontCollection != null && index >= 0 && index < _fontCollection.Families.Length)
            {
                return new Font(_fontCollection.Families[index], size, style);
            }
            else
            {
                return new Font("Segoe UI", size, style);
            }
        }

        // گرفتن لیست همه نام فونت‌ها
        public static string[] GetFontNames()
        {
            LoadFonts();
            if (_fontFamilies != null)
            {
                return new List<string>(_fontFamilies.Keys).ToArray();
            }
            else
            {
                return new string[0];
            }
        }

        // ==========================
        // متدهای کمکی برای فونت‌های معروف
        // ==========================
        public static Font Gandom(float size=9.5f, FontStyle style=FontStyle.Regular)
        {
            return GetFont("Gandom", size, style);
        }

        public static Font IranSans(float size=9.5f, FontStyle style=FontStyle.Regular)
        {
            return GetFont("Iranian Sans", size, style);
        }

        public static Font Shabnam(float size=9.5f, FontStyle style=FontStyle.Regular)
        {
            return GetFont("Shabnam", size, style);
        }

        public static Font Tahoma(float size=9.5f, FontStyle style=FontStyle.Regular, GraphicsUnit graph=GraphicsUnit.Point)
        {
            return new Font("Tahoma", size, style, graph);
        }

        public static Font Vazir(float size=9.5f, FontStyle style=FontStyle.Regular)
        {
            return GetFont("Vazir", size, style);
        }

        public static Font Yekan(float size=9.5f, FontStyle style=FontStyle.Regular)
        {
            return GetFont("B Yekan", size, style);
        }

        // می‌توان فونت‌های دیگری هم اضافه کرد یا مستقیماً از GetFont استفاده کرد
    }
}
