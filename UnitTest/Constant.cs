using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asnic
{
    public static class Constant
    {
        public const char Dashed = '\\';
        public const char Space = ' ';
        public const char Dot = '.';
        public const char BracketLeft = '[';
        public const char BracketRight = ']';
        public const char ParentLeft = '(';
        public const char ParentRight = ')';

        public const ushort AsciiSpace = 32;

        /// <summary>
        /// 回车做一个函数区间空格  
        /// LF：Linefeed，对应ASCII中转义字符\n，表示换行
        /// </summary>
        public static char[] NextLine = "\n".ToCharArray();
        /// <summary>
        /// CR：CarriageReturn，对应ASCII中转义字符\r，表示回车
        /// </summary>
        public static char[] Return = "\r".ToCharArray();
    }
}
