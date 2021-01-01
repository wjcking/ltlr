using JiebaNet.Segmenter.PosSeg;
using System;
using System.Collections.Generic;
using System.Linq;
 
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutoDesk
{
    [TestClass]
    public class Segement
    {
        /// <summary>
        /// single~line：是否过滤重复
        /// Func.metric:[line|pine]
        /// </summary>
        [TestMethod]
        public void PrintSegement()
        {
            //Pick("9月30日，全国烈士纪念日，南京雨花台烈士陵园烈士群雕前，来自江苏南京各行各业的71对新婚夫妇，向雨花英烈敬献鲜花、诵读“雨花英烈家书”，借此表达对革命烈士的崇敬和缅怀，对未来美好生活的向往。你们的功勋，我们会永远铭记！");
          // var text= System.IO.File.ReadAllText(@" F:\VSProjects\AngelWolf\UnitTest\Extendable\Analytical.html");
            var text2 =System.IO.File.ReadAllText(@" C:\Users\Administrator\Desktop\revenez.html",System.Text.Encoding.Default);
            Pick(text2);
        }
        /// <summary>
        /// 根据词性
        /// </summary>
        /// <param name="text"></param>
        public  void Pick(string text)
        {
            //JiebaSegmenter seg = new JiebaSegmenter();
            //var analyser = new JiebaNet.Analyser.TextRankExtractor();
            ////   analyser.ExtractTags("adsf", 2);
           
            var posSeg = new PosSegmenter();  
            var tokens = posSeg.Cut(text);

            Console.Write (string.Join(" ", tokens.Select(token => string.Format("{0}:{1}", token.Word, token.Flag))));

            //var segmenter = new JiebaSegmenter(); 
            // var token2  = segmenter.Tokenize(asdf, TokenizerMode.Default); 
            //foreach (var t in token2)
            //{
            //    Console.WriteLine("{0}: {0,-12} start: {1,-3} end: {2,-3}", t.Word, t.StartIndex,t.EndIndex);
            //}

            //  var analyser = new JiebaNet.Analyser.TextRankExtractor();

            //var analyser = new JiebaNet.Analyser.TextRankExtractor();
            //var pos = new List<string>() { "n", "v" };
            //var list = analyser.ExtractTagsWithWeight(text, 20, pos);
            //Console.WriteLine(Environment.NewLine);
            //foreach (var t in list)
            //{
            //    Console.WriteLine(t.ToString());
            //}
        }

    }
}
