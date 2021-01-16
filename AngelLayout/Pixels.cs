using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngelLayout
{
    public static class Pixels
    {
        /// <summary>
        /// 获取指定窗口的设备场景
        /// </summary>
        /// <param name="hwnd">将获取其设备场景的窗口的句柄。若为0，则要获取整个屏幕的DC</param>
        /// <returns>指定窗口的设备场景句柄，出错则为0</returns>
        [DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);

        /// <summary>
        /// 释放由调用GetDC函数获取的指定设备场景
        /// </summary>
        /// <param name="hwnd">要释放的设备场景相关的窗口句柄</param>
        /// <param name="hdc">要释放的设备场景句柄</param>
        /// <returns>执行成功为1，否则为0</returns>
        [DllImport("user32.dll")]
        public static extern Int32 ReleaseDC(IntPtr hwnd, IntPtr hdc);

        /// <summary>
        /// 在指定的设备场景中取得一个像素的RGB值
        /// </summary>
        /// <param name="hdc">一个设备场景的句柄</param>
        /// <param name="nXPos">逻辑坐标中要检查的横坐标</param>
        /// <param name="nYPos">逻辑坐标中要检查的纵坐标</param>
        /// <returns>指定点的颜色</returns>
        [DllImport("gdi32.dll")]
        public static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);


        public static Color GetColor(int x, int y)
        {
            IntPtr hdc = GetDC(IntPtr.Zero); uint pixel = GetPixel(hdc, x, y);
            ReleaseDC(IntPtr.Zero, hdc);
            Color color = Color.FromArgb((int)(pixel & 0x000000FF), (int)(pixel & 0x0000FF00) >> 8, (int)(pixel & 0x00FF0000) >> 16);
            return color;
        }
        public static int[] GetColorInteger(int x, int y, Control control)
        {
            Bitmap bmp = new Bitmap(control.Size.Width, control.Size.Height);
            Rectangle rt = new Rectangle(0, 0, control.Size.Width, control.Size.Height);
            control.DrawToBitmap(bmp, rt);
            //int a, r, g, b;
            //a = bmp.GetPixel(x, y).A;
            //r = bmp.GetPixel(x, y).R;
            //g = bmp.GetPixel(x, y).G;
            //b = bmp.GetPixel(x, y).B;
            //alpha Alpha 是出现在 32 位位图文件中的一类数据,用于向图像中的像素指定透明度。
            //24 位真彩文件包含三种颜色信息通道:红、绿和蓝或 RGB。
            //每个通道在各个像素上都拥有具体的强度或值。每个通道的强度决定图像中像素的颜色。通过添加第四种
            //alpha 通道,文件可以指定每个像素的透明度或不
            return new int[4]
               {
            bmp.GetPixel(x, y).A,
            bmp.GetPixel(x, y).R,
            bmp.GetPixel(x, y).G,
            bmp.GetPixel(x, y).B
         };
        }
        public static Color GetColor(int x, int y, Control control)
        {
            //try sequence next time
            var argb = GetColorInteger(x, y, control);
            return Color.FromArgb(argb[0], argb[1], argb[2], argb[3]) ;
        }
    }
}