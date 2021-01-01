using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KansaiUtils;
namespace Beautiful
{
    public class Json
    {
        public const short Token_Trees = 0;
        public const short Token_Nodes = 1;
        public const short Token_Edges = 2;

        public const string NodeType_Trees = "Trees";
        public const string NodeType_Nodes = "Nodes";
        public const string NodeType_Edges = "Edges";

        private const string Token_Array = "[\r\n{0}\r\n] \r\n";

        /// <summary>
        /// [Nodes:]
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string[] GetTokens<T>(IList<T> list) where T : ITokens
        {

            var json = new string[3];
            var tokens = new StringBuilder[3] { new StringBuilder(), new StringBuilder(), new StringBuilder() };
            foreach (var each in list)
            {
                tokens[Token_Trees].AppendLine(each.Tokens[Token_Trees]);
                tokens[Token_Nodes].AppendLine(each.Tokens[Token_Nodes]);
                tokens[Token_Edges].AppendLine(each.Tokens[Token_Edges]);
            }
            json[Token_Trees] = String.Format(Token_Array, tokens[Token_Trees].ToString());
            json[Token_Nodes] = String.Format(Token_Array, tokens[Token_Nodes].ToString());
            json[Token_Edges] = String.Format(Token_Array, tokens[Token_Edges].ToString());

            return json;

        }
    }
}
