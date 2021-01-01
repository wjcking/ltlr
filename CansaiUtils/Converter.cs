using System;

namespace KansaiUtils
{
    /// <summary>
    /// StringUtility 的摘要说明。
    /// </summary>
    public static class Converter
    {
        /// <summary>
        /// To json "\r\n", "\\r\\n"
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Translate(this string str)
        {
            if (string.IsNullOrEmpty(ToString(str)))
                return String.Empty;

            str = str.Replace("\r", "\\r");
            str = str.Replace("\n", "\\n");
            str = str.Replace("\r\n", "\\r\\n");
            return str;
        }
        public static String ToString(Object objStr, String defaultValue)
        {
            try
            {

                return (objStr == null) ? defaultValue : System.Convert.ToString(objStr);
            }
            catch  
            {
                return string.Empty;
            }
        }

        public static String ToString(Object objStr)
        {
            return ToString(objStr, String.Empty);
        }

        public static Boolean ToBoolean(object objBoolean, Boolean defaultValue)
        {
            if (objBoolean == null)
                return defaultValue;

            try
            {
                return System.Convert.ToBoolean(objBoolean);
            }
            catch
            {
                return defaultValue;
            }
        }

        public static Boolean ToBoolean(object objBoolean)
        {
            return ToBoolean(objBoolean, false);
        }

        public static Byte ToByte(object objByte, Byte defaultValue)
        {
            if (objByte == null)
                return defaultValue;

            try
            {
                return System.Convert.ToByte(objByte);
            }
            catch
            {
                return defaultValue;
            }
        }

        public static Byte ToByte(object objByte)
        {
            return ToByte(objByte, 0);
        }

        public static Int16 ToInt16(Object objInt16, Int16 defaultValue)
        {
            if (objInt16 == null)
                return defaultValue;

            try
            {
                return System.Convert.ToInt16(objInt16);
            }
            catch
            {
                return defaultValue;
            }
        }

        public static Int16 ToInt16(Object objInt16)
        {
            return ToInt16(objInt16, 0);
        }

        public static Int32 ToInt32(Object objInt32, Int32 defaultValue)
        {
            if (objInt32 == null)
                return defaultValue;

            try
            {
                return System.Convert.ToInt32(objInt32);
            }
            catch
            {
                return defaultValue;
            }
        }

        public static Int32 ToInt32(Object objInt32)
        {
            return ToInt32(objInt32, 0);
        }

        public static Int64 ToInt64(Object objInt64, Int64 defaultValue)
        {
            if (objInt64 == null)
                return defaultValue;

            try
            {
                return System.Convert.ToInt64(objInt64);
            }
            catch
            {
                return defaultValue;
            }
        }

        public static Int64 ToInt64(Object objInt64)
        {
            return ToInt64(objInt64, 0);
        }

        public static Decimal ToDecimal(object objDecimal, Decimal defaultValue)
        {
            if (objDecimal == null)
                return defaultValue;

            try
            {
                return System.Convert.ToDecimal(objDecimal);
            }
            catch
            {
                return defaultValue;
            }
        }

        public static Decimal ToDecimal(object objDecimal)
        {
            return ToDecimal(objDecimal, 0.00M);
        }

        public static DateTime ToDateTime(object objDateTime, DateTime defaultValue)
        {
            if (objDateTime == null)
                return defaultValue;

            try
            {
                return System.Convert.ToDateTime(objDateTime);
            }
            catch
            {
                return defaultValue;
            }
        }

        public static DateTime ToDateTime(object objDateTime)
        {
            return ToDateTime(objDateTime, DateTime.Now);
        }
        public static string  ToTimeString(this object objDateTime)
        {
            return ToDateTime(objDateTime, DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss:fff");
        }
        public static String FormatCurrency(Object objDecimal, Decimal defaultValue)
        {
            return ToDecimal(objDecimal, defaultValue).ToString("F");
        }

        public static String FormatCurrency(Object objDecimal)
        {
            return ToDecimal(objDecimal).ToString("C");
        }
    }
}
