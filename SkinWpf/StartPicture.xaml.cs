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
using System.Windows.Shapes;

namespace SkinWpf
{
    /// <summary>
    /// StartPicture.xaml 的交互逻辑
    /// </summary>
    public partial class StartPicture : Window
    {
        public StartPicture()
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

        /// <summary>
        /// 设置最大化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        }
        #endregion

        /// <summary>
        /// 开始拍照
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartPic_Click(object sender, RoutedEventArgs e)
        {
            this.ImgBox2.Visibility = Visibility.Hidden;
            this.ImgBox1.Visibility = Visibility.Visible;

            //隐藏左边三个图片，显示最左上角一个图片
            this.LeftTop.Visibility = Visibility.Visible;

            this.LeftTopImg.Visibility = Visibility.Hidden;
            this.LeftCenterImg.Visibility = Visibility.Hidden;
            this.leftBottomImg.Visibility = Visibility.Hidden;
            //并且显示右边三张图片
            this.RightTopImg.Visibility = Visibility.Visible;
            this.RightCenterImg.Visibility = Visibility.Visible;
            this.RightBottomImg.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// 返回
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StepPre_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// 点击ok图标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StepOk_Click(object sender, RoutedEventArgs e)
        {
           
        }

        /// <summary>
        /// 点击X图标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StepErr_Click(object sender, RoutedEventArgs e)
        {

        }

    
    }
}
