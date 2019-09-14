using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using Panuon.UI.Silver;

namespace SkinWpf
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
    
        }
        #region 界面元素操作
        /// <summary>
        /// 窗体移动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left) this.DragMove();
        }
        /// <summary>
        /// 关闭窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            //App.Current.Shutdown();
            Environment.Exit(0);
        }
        /// <summary>
        /// 窗体最小化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMin_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = System.Windows.WindowState.Minimized;
        }

        #endregion
        DispatcherTimer timer = new DispatcherTimer();
        int timeNum = 0;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // 设置全屏
            this.WindowState = System.Windows.WindowState.Normal;
            this.WindowStyle = System.Windows.WindowStyle.None;
            this.ResizeMode = System.Windows.ResizeMode.NoResize;
            this.Topmost = true;

            this.Left = 0.0;
            this.Top = 0.0;
            this.Width = System.Windows.SystemParameters.PrimaryScreenWidth;
            this.Height = System.Windows.SystemParameters.PrimaryScreenHeight;

          
            timer.Interval = TimeSpan.FromMilliseconds(1000);
            timer.Tick += Timer_Tick; ;  //你的事件
            timer.Start();
        


        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timeNum++;
            if (timeNum == 3)
            {
                //隐藏logo  显示“程序正在启动...”
                this.load.IsRunning = true;
                this.logoImg.Visibility = Visibility.Hidden;
                this.btnStar.Visibility = Visibility.Visible;
            }
            if (timeNum == 9)
            {
                //隐藏提示内容 显示Logo 并且显示 右上角左下角按钮
                this.load.IsRunning = false;
                this.logoImg.Visibility = Visibility.Visible;
                this.btnStar.Visibility = Visibility.Hidden;
                timer.Stop();
            }

        }
    }
}
