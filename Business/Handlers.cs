using Beautiful;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Business
{
    public class Handlers
    {
        private static IList<Handler> handleList;

        static Handlers()
        {
            if (null == handleList)
                handleList = new List<Handler>();

            handleList.Add(new Handler("role", Handler.Type_Add));
            handleList.Add(new Handler("incident", Handler.Type_Add));

            //handleList.Add(new Handler(typeof(Role).Name);
            //handleList.Add(new Handler("role", Handler.Type_Group));
            //handleList.Add(new Handler("role_category");
            //handleList.Add(new Handler("incident");

        }

    }
}
