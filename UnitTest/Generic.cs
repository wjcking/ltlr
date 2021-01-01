using Microsoft.VisualStudio.TestTools.UnitTesting;
using static System.Console;

namespace Preditor
{
    [TestClass]
    public class Generic
    {
        [TestMethod]
        public void pad()
        {
         //   "ab".p
        }
        //[TestMethod]
        //public void writejson()
        //{
        //    StringWriter sw = new StringWriter();
        //    JsonTextWriter writer = new JsonTextWriter(sw);

        //    writer.QuoteName = false;
        //    writer.WriteStartObject();
 
        //    writer.
        //    writer.WriteEndObject();
        //    writer.WriteRaw(",");

        //    writer.Flush();
        //    writer.Close();

        //    return sw.GetStringBuilder().ToString();
        //}
        [TestMethod]
        public void TestItokens()
        {
            //var a = Business.Category.GetJsonList();
            //WriteLine(a);
         
            var b = Business.Incident.GetJsonList();
            WriteLine(b);
        }
    }
    //public interface ISource<T> //: SixcomHelper where T : class, new()
    //{
    //    List<T> GetList<TParams>(TParams info);
    //    List<T> GetList();
    //    T GetInfo<TParams>(TParams info);
    //    List<T> GetInfo();
    //    int AddInfo(T info);

    //}
    //public class ISource<T> //: SixcomHelper where T : class, new()
    //{
    //    public List<T> GetList<TParams>(TParams info)
    //    {
    //        return new List<T>();
    //    }

    //    public List<T> GetList()
    //    {
    //        return new List<T>();
    //    }
    //    public T GetInfo<TParams>(TParams info)
    //    {
    //        return default(T);
    //    }
    //    public List<T> GetInfo()
    //    {
    //        return default(List<T>);
    //    }

    //}

}
