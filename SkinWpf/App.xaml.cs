using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace SkinWpf
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : System.Windows.Application
    {
        public App()
        {
            Initial();
            this.Exit += new ExitEventHandler(App_Exit);
        }

        void App_Exit(object sender, ExitEventArgs e)
        {
            setFreeNotifyIcon();
        }


        #region 成员
        private System.Windows.Forms.NotifyIcon notifyIcon;
        #endregion

        /// <summary>
        /// 初始化托盘区图标
        /// </summary>     
        public void Initial()
        {
            this.notifyIcon = new System.Windows.Forms.NotifyIcon();
            this.notifyIcon.BalloonTipText = "欢迎";

            this.notifyIcon.Icon = new System.Drawing.Icon("ShareWork.ico");
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new MouseEventHandler(notifyIcon_MouseDoubleClick);
            this.notifyIcon.ShowBalloonTip(1000);
            var menuItems = new MenuItem[3];
            menuItems[0] = new MenuItem();
            menuItems[0].Text = "显示主面板";
            menuItems[0].Click += new EventHandler(nofityShow_Click);
            menuItems[1] = new MenuItem();
            menuItems[1].Text = "-";
            menuItems[2] = new MenuItem();
            menuItems[2].Text = "退出";
            menuItems[2].Click += new EventHandler(notifyExit_Click);
            menuItems[0].DefaultItem = true;
            this.notifyIcon.ContextMenu = new ContextMenu(menuItems);
        }


        /// <summary>
        /// 单击托盘区“显示”菜单事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void nofityShow_Click(object sender, EventArgs e)
        {
            //如果主窗体已隐藏
            //for (int i = 0; i < App.Current.Windows.Count; i++)
            //{
            //    if (App.Current.Windows[i] is LoginWindow)
            //    {
            //        WindowExcute(App.Current.Windows[i]);
            //        return;//截断
            //    }
            //}
            WindowExcute(MainWindow);
        }

        /// <summary>
        /// 托盘区图标双击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //for (int i = 0; i < App.Current.Windows.Count; i++)
            //{
            //    if (App.Current.Windows[i] is LoginWindow)
            //    {
            //        WindowExcute(App.Current.Windows[i]);
            //        return;//截断
            //    }
            //}
            WindowExcute(MainWindow);
        }

        /// <summary>
        /// 窗口操作
        /// </summary>
        void WindowExcute(Window window)
        {
            //如果主窗体已隐藏
            window.Visibility = Visibility.Visible;
            window.WindowState = WindowState.Normal;
            window.Activate();
            window.Topmost = true;
            window.Topmost = false;
        }

        /// <summary>
        /// 单击托盘区“退出”菜单事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void notifyExit_Click(object sender, EventArgs e)
        {
            setFreeNotifyIcon();
            Environment.Exit(0);
        }
        /// <summary>
        /// 释放托盘区图标
        /// </summary>
        public void setFreeNotifyIcon()
        {
            this.notifyIcon.Visible = false;
            this.notifyIcon.Dispose();
        }
    }
}
