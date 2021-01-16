using System;
using static System.Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Asnic;
using System.IO;

namespace AutoTest
{
    [TestClass]
    public class AutoTest
    {
        [TestMethod]
        public void PrintFiles()
        {
            try
            {
                Files.Execute("N a");
                Files.Execute("Move b\\f.html a\\f.html");
                Files.Execute("D d\\");
                Files.Execute("l d\\ketself 'content'");
                Files.Execute("阿斯蒂芬斯蒂芬");

                //  WriteLine(StartPath);
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }
        }
        /// <summary>
        /// Brandkets
        /// </summary>
        [TestMethod]
        public void PrintPrioity()
        {
            //var t = SymbolPrioity.Each | SymbolPrioity.Link | SymbolPrioity.Bracket;
            //Console.WriteLine(t);
            //Console.WriteLine((int)t);
            //var options = FileAttributes.ReadOnly | FileAttributes.System | FileAttributes.Hidden;
            //Console.WriteLine(options);
            //Console.WriteLine((int)options);
        }
        /// <summary>
        /// Brandkets
        /// </summary>
        [TestMethod]
        public void PrintMetric()
        {
           // var s = SideKorner.Bottom&SideKorner.Left;
            //  var text = "{System.String[] GetFileSystemEntries(System.String, System.String, System.IO.SearchOption)}";
            //    WriteLine(clone);
            //flat
            //odin
            //    transtick
                    
            //    transparent
            //        absoulte
            //        whole
            //        total
            //metric 
            //刷子 Radar |\|-|/ sin cos 3.14 arc * radius
            //公元(纪年体系) -  1582年
            //辛亥革命爆发后次年（1912年），当时的中华民国政府采用公历作为国历，纪年方面，公元纪年法与民国纪年法并行。
           //Wrapper Ribber
            WriteLine(float.MaxValue);
             
        }

    }
}
