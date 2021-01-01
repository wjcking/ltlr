using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Asnic.Compiler
{
    public class Preditor
    {
        /*At the end of organised the ket array, it will add top and bottom
        * Further discusstion:handle faimly kid metric
        * C P P P P P P   C
        * L 0 1 2 3 4 5
        * L 1 a b c d e e t
        * L 2 啊是的方的
        * L 4 % % @ @ ！R E
        * C A A A A A A   C
        * 
        * Absoulute Solid.Metric.Matrix
        * Dot circle
        * Triangle Square 
        * Diamond
        */
        public void PrintketStruct()
        {
            var doc = new HtmlDocument();

            doc.Load(@"C:\Users\Administrator\Desktop\keynote.html", Encoding.Default);
            if (string.Empty == doc.Text)
                return;
            //var xpath = "//head[@id='']";
            var xpath = "//body";
            var value = doc.DocumentNode.SelectNodes(xpath).First().InnerHtml;
            var filestring = File.ReadAllLines(@"C:\Users\Administrator\Desktop\keynote.html");
            var htmlTexts = value.Split(Constant.NextLine, StringSplitOptions.None);
            int number = 0;
            char[] charLine;
            //遍历每一行 求出最大ket count 
            int volume = 0;
            KetLine[] ketlines = new KetLine[htmlTexts.Length];

            for (int i = 0; i < ketlines.Length; i++)
            {
                ketlines[i] = new KetLine();


                charLine = htmlTexts[i].ToCharArray();
                ketlines[i].KetChars = new List<Ket>(charLine.Length);
                //是否记住下标
                volume = charLine.Length > volume ? charLine.Length : volume++;
                for (int k = 0; k < charLine.Length; k++)
                {
                    ketlines[i].KetChars.Add(new Ket());
                    ketlines[i].KetChars[k].Number = number++;
                    ketlines[i].KetChars[k].Value = charLine[k];
                    ketlines[i].SpaceLength = charLine[k];

                }
            }

            //**************print ********************

            for (int i = 0; i < ketlines.Length; i++)
            {
                for (int k = ketlines[i].KetChars.Count; k < volume; k++)
                {
                    ketlines[i].KetChars.Add(new Ket());
                    ketlines[i].KetChars[k].Value = '$';
                }
            }
            var sb = new StringBuilder();

            for (int i = 0; i < ketlines.Length; i++)
            {
                for (int k = 0; k < ketlines[i].KetChars.Count; k++)
                    sb.Append(ketlines[i].KetChars[k].Value);
                sb.AppendLine();
            }
            //GetketPine
            //vertically check for Kansai and more
            for (int k = 0; k < volume; k++)
            {
                for (int i = 0; i < ketlines.Length; i++)
                    sb.Append(ketlines[i].KetChars[k].Value);
                //     
                sb.AppendLine();
            }

          //  Write(sb.ToString());
            //  File.WriteAllText(@"C:\Users\Administrator\Desktop\pad.txt", sb.ToString());
        }
    }
}
