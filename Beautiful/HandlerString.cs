using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beautiful
{

    public class HandleString
    {
        
        public class Getter
        {

            public string Get { get; set; } = "Get";
            public override string ToString()
            {
                return Get;
            }
            public virtual string ToString(char concate)
            {
                return Get + concate;
            }
        }
        public class Setter : Getter
        {
            public string Set { get; set; } = "Set";
            public override string ToString()
            {
                return Set;
            }
            public override string ToString(char concate)
            {
                return Set + concate;
            }
        }
        public class Type : Setter
        {
            public string Name { get; set; } = "Unknown";
            public TInfo Infos { get; set; }
            public Lists Lists { get; set; }
            public override string ToString()
            {
                return Name;
            }
            public override string ToString(char concate)
            {
                return Name + concate;
            }
        }

        public class TInfo : Type
        {
            public TInfo() { }

            public string Info { get; set; } = "Info";
            public override string ToString()
            {
                return base.ToString() + Info;
            }
            public virtual string ToString(string concate)
            {
                return base.ToString() + concate + Info;
            }

        }
        public class Lists : TInfo
        {
            public Lists() { }

            public string List { get; set; } = "List";
            public override string ToString()
            {
                return base.ToString() + List;
            }
            public override string ToString(char concate)
            {
                return base.ToString() + concate + List;
            }
        }

    }
}
