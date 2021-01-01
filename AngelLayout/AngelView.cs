using System.ComponentModel;
using System.Windows.Forms;

namespace AngelLayout
{
    public partial class AngelView : WebBrowser
    {

        public AngelView()
        {
            InitializeComponent();
        }
  
        public AngelView(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
