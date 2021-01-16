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
    public partial class Mdi : Form,IMessageFilter
    {
        public Mdi()
        {
            InitializeComponent();
            //var symbolics = new Symbolics();
            //symbolics.MdiParent = this;
            //symbolics.Show();

            //var main = new AsnicForm();
            //main.MdiParent = this;//子窗体的父窗体是当前窗体
            //main.WindowState = FormWindowState.Maximized;//子窗体
            //main.Show();  
      
      //      Application.AddMessageFilter(this);
        }
        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //label1.ForeColor = Pixels.GetColor(e.X, e.Y, this);
            //label1.Text = Pixels.GetColor(e.X, e.Y, this).ToString();
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_CLOSE = 0xF060;

            //if (m.Msg == WM_SYSCOMMAND && (int)m.WParam == SC_CLOSE)
            //{
            //    // 屏蔽传入的消息事件   
            //    this.WindowState = FormWindowState.Minimized;
            //    return;
            //}
            base.WndProc(ref m);
        }
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {
            int WM_KEYDOWN = 256;
            int WM_SYSKEYDOWN = 260;

            if (msg.Msg == WM_KEYDOWN | msg.Msg == WM_SYSKEYDOWN)
            {
         //     textBox1.AppendText( keyData.ToString());
                switch (keyData)
                {
                    case Keys.Escape:
                        this.Close();

                        break;
                }
            }
            return false;
        }
        private const int WM_LBUTTONDOWN = 0x201;
        public bool PreFilterMessage(ref Message m)
        {
            //
            //if (m.Msg == 522)
            if (m.Msg == WM_LBUTTONDOWN)
            {
             
                // Do stuffs
                //m.Result.
            }
            return false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            label1.Location = new Point(0, 300);
     //       label1.BackColor = Color.Transparent;
            textBox1.Controls.Add(label1);
        }

    }
}
