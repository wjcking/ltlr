using System.Windows.Forms;
using Beautiful;
namespace AngelLayout
{
    [System.Runtime.InteropServices.ComVisible(true)]
    public partial class AsnicForm : Form
    {
        public AsnicForm()
        {
            InitializeComponent();
            Languages.Set("en-US");
            angelView.ObjectForScripting = this;
            angelView.Navigate(@"http://192.168.0.102:1000/asnic/template/ketnew.html"); 
            angelView.DocumentCompleted += AngelView_DocumentCompleted;
       
        }

        private void AngelView_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //  System.IO.File.WriteAllText(@"C:\Users\Administrator\Desktop\hotkeys.html", angelView.DocumentText);      
            //angelView.Document.GetElementById("")
            // var asnic = new Asnick(angelView.DocumentText);
            //    angelView.Document.GetElementById("editor").InnerHtml += "fdas fdas";

            var objArray = new object[1];

             //   System.Threading.Thread.Sleep(100);
                angelView.Document.InvokeScript("invoke");
     
        }

        public static void Loading(Control control, System.ComponentModel.ComponentResourceManager resources)
        {
            if (control is MenuStrip)
            {      //将资源与控件对应   
                resources.ApplyResources(control, control.Name);
                MenuStrip ms = (MenuStrip)control;
                if (ms.Items.Count > 0)
                {
                    foreach (var item in ms.Items)
                    {                //遍历菜单         
                       // Loading(item, resources);
                    }
                }
            }
            foreach (Control c in control.Controls)
            {
                resources.ApplyResources(c, c.Name);
                Loading(c, resources);

            }
        }

        private void angelView_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
        }
    }
}
