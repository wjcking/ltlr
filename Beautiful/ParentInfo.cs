using Newtonsoft.Json;
using System;
namespace Beautiful
{
    public interface ITokens
    {
        string[] Tokens { get; }
    }
    [JsonObject("parent_info")]
    public  class ParentInfo : Info, ITokens
    {
        
        [JsonProperty("parent_id")]
        public virtual int ParentID { get; set; } = 0;
        [JsonProperty("parent_name")]
        public virtual string ParentName { get; set; } = String.Empty;
        [JsonIgnore]
        public virtual string Shape { get; set; } = String.Empty;
        
        //edge label category info
        [JsonIgnore]
        public virtual string NodeStyle { get; set; }
        [JsonIgnore]
        public virtual string EdgeStyle { get; set; }
        [JsonIgnore]
        public virtual string TreeStyle { get; set; }

        public virtual string[] Tokens
        {
            get
            {
                var tokens = new string[3];
                tokens[Json.Token_Trees] = "{ " + $"no:{No}, id:{ID}, pId: {ParentID}, name:\"{Name}\", {TreeStyle}" + "},";
                tokens[Json.Token_Nodes] = "{ " + $"no:{No}, id:{ID}, label:\"{Name}\",shape:\"{Shape}\"" + "},";
                tokens[Json.Token_Edges] = "{ " + $"no:{No}, from:{ParentID}, to:{ID},label:\"{Name}\", {EdgeStyle}" + "},";
                return tokens;
            }
        } 
    }
}
