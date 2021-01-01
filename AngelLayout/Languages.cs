using System.Globalization;
using System.Threading;

namespace AngelLayout
{
    public class Languages
    {

        public static void Set(string lang)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang, false);
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(lang);
        }

        public static void SetChinese()
        {
            Set("zh-CN");
        }

        public static void SetEnglish()
        {
            Set("en");
        }
    }
}
