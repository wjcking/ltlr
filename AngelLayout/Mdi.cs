using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngelLayout
{
    public partial class Mdi : Form
    {
        public Mdi()
        {
            InitializeComponent();
            //var symbolics = new Symbolics();
            //symbolics.MdiParent = this;
            //symbolics.Show();

            var main = new AsnicForm();
            main.MdiParent = this;//子窗体的父窗体是当前窗体
            main.WindowState = FormWindowState.Maximized;//子窗体
            main.Show();
        }

        private void tsm_new_Click(object sender, EventArgs e)
        {

        }
    }
}
