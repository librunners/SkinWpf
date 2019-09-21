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
        /// 禁止窗体移动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //if (e.ChangedButton == MouseButton.Left) this.DragMove();
        }
        /// <summary>
        /// 关闭窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("确定退出系统?", "提示!", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
            {
                this.Close();
                Environment.Exit(0);
            }
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
            if (timeNum == 2)
            {
                this.load.IsRunning = false;
                this.logoImg.Visibility = Visibility.Visible;
                //显示按钮
                this.custerManageBox.Visibility = Visibility.Visible;
                timer.Stop();
            }


        }

        /// <summary>
        /// 客户管理按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CusterManage_Click(object sender, RoutedEventArgs e)
        {
            CustomManage custom = new CustomManage();
            //custom.Owner = this;
            custom.Show();
            //this.Close();
         
        }

        /// <summary>
        /// 设置按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Seting_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("点击按钮干啥");
        }

        /// <summary>
        /// 退出按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("确定退出系统?", "提示!", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
            {
                this.Close();
                Environment.Exit(0);
            }
           
        }

        /// <summary>
        /// 化妆品管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MaquillageManage_Click(object sender, RoutedEventArgs e)
        {
            MaquillageManage MaquillageManage = new MaquillageManage();
            MaquillageManage.Show();
        }
    }
}
