using Panuon.UI.Silver.Core;
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
    /// CustomManage.xaml 的交互逻辑
    /// </summary>
    public partial class CustomManage : Window
    {
        List<DataGridTestModel> TestDataList = new List<DataGridTestModel>()
        {
            new DataGridTestModel(){Id = 1, Name = "Judy", Score = 100,  },
            new DataGridTestModel(){Id = 2, Name = "Jack", IsEnabled = true, Score = 100,  },
            new DataGridTestModel(){Id = 3, Name = "Mario", IsEnabled = true, Score = 100,  },
            new DataGridTestModel(){Id = 4, Name = "Chris", IsEnabled = true, Score = 98,  },
            new DataGridTestModel(){Id = 5, Name = "Judy", Score = 100,  },
            new DataGridTestModel(){Id = 6, Name = "Jack", IsEnabled = true, Score = 100,  },
            new DataGridTestModel(){Id = 7, Name = "Mario", IsEnabled = true, Score = 100,  },
            new DataGridTestModel(){Id = 8, Name = "Chris", IsEnabled = true, Score = 98,  },
            new DataGridTestModel(){Id = 9, Name = "Judy", Score = 100,  },
            new DataGridTestModel(){Id = 10, Name = "Jack", IsEnabled = true, Score = 100,  },
            new DataGridTestModel(){Id = 11, Name = "Mario", IsEnabled = true, Score = 100,  },
            new DataGridTestModel(){Id = 12, Name = "Chris", IsEnabled = true, Score = 98,  },
            new DataGridTestModel(){Id = 13, Name = "Judy", Score = 100,  },
            new DataGridTestModel(){Id = 14, Name = "Jack", IsEnabled = true, Score = 100,  },
            new DataGridTestModel(){Id = 15, Name = "Mario", IsEnabled = true, Score = 100,  },
            new DataGridTestModel(){Id = 16, Name = "Chris", IsEnabled = true, Score = 98,  },
            new DataGridTestModel(){Id = 17, Name = "Judy", Score = 100,  },
            new DataGridTestModel(){Id = 18, Name = "Jack", IsEnabled = true, Score = 100,  },
            new DataGridTestModel(){Id = 19, Name = "Mario", IsEnabled = true, Score = 100,  },
            new DataGridTestModel(){Id = 20, Name = "Chris", IsEnabled = true, Score = 98,  },
            new DataGridTestModel(){Id = 21, Name = "Judy", Score = 100,  },
            new DataGridTestModel(){Id = 22, Name = "Jack", IsEnabled = true, Score = 100,  },
            new DataGridTestModel(){Id = 23, Name = "Mario", IsEnabled = true, Score = 100,  },
            new DataGridTestModel(){Id = 24, Name = "Chris", IsEnabled = true, Score = 98,  },
            new DataGridTestModel(){Id = 25, Name = "Judy", Score = 100,  },
            new DataGridTestModel(){Id = 26, Name = "Jack", IsEnabled = true, Score = 100,  },
            new DataGridTestModel(){Id = 27, Name = "Mario", IsEnabled = true, Score = 100,  },
            new DataGridTestModel(){Id = 28, Name = "Chris", IsEnabled = true, Score = 98,  },
            new DataGridTestModel(){Id = 29, Name = "Judy", Score = 100,  },
            new DataGridTestModel(){Id = 30, Name = "Jack", IsEnabled = true, Score = 100,  },
            new DataGridTestModel(){Id = 31, Name = "Mario", IsEnabled = true, Score = 100,  },
            new DataGridTestModel(){Id = 32, Name = "Chris", IsEnabled = true, Score = 98,  },
            new DataGridTestModel(){Id = 33, Name = "Judy", Score = 100,  },
            new DataGridTestModel(){Id = 34, Name = "Jack", IsEnabled = true, Score = 100,  },
            new DataGridTestModel(){Id = 35, Name = "Mario", IsEnabled = true, Score = 100,  },
            new DataGridTestModel(){Id = 36, Name = "Chris", IsEnabled = true, Score = 98,  },
            new DataGridTestModel(){Id = 37, Name = "Judy", Score = 100,  },
            new DataGridTestModel(){Id = 38, Name = "Jack", IsEnabled = true, Score = 100,  },
            new DataGridTestModel(){Id = 39, Name = "Mario", IsEnabled = true, Score = 100,  },
            new DataGridTestModel(){Id = 41, Name = "Chris", IsEnabled = true, Score = 98,  },
            new DataGridTestModel(){Id = 42, Name = "Judy", Score = 100,  },
            new DataGridTestModel(){Id = 43, Name = "Jack", IsEnabled = true, Score = 100,  },
            new DataGridTestModel(){Id = 44, Name = "Mario", IsEnabled = true, Score = 100,  },
            new DataGridTestModel(){Id = 45, Name = "Chris", IsEnabled = true, Score = 98,  },
            new DataGridTestModel(){Id = 32, Name = "Chris", IsEnabled = true, Score = 98,  },
            new DataGridTestModel(){Id = 33, Name = "Judy", Score = 100,  },
            new DataGridTestModel(){Id = 34, Name = "Jack", IsEnabled = true, Score = 100,  },
            new DataGridTestModel(){Id = 35, Name = "Mario", IsEnabled = true, Score = 100,  },
            new DataGridTestModel(){Id = 36, Name = "Chris", IsEnabled = true, Score = 98,  },
            new DataGridTestModel(){Id = 37, Name = "Judy", Score = 100,  },
            new DataGridTestModel(){Id = 38, Name = "Jack", IsEnabled = true, Score = 100,  },
            new DataGridTestModel(){Id = 39, Name = "Mario", IsEnabled = true, Score = 100,  },
            new DataGridTestModel(){Id = 41, Name = "Chris", IsEnabled = true, Score = 98,  },
            new DataGridTestModel(){Id = 42, Name = "Judy", Score = 100,  },
            new DataGridTestModel(){Id = 43, Name = "Jack", IsEnabled = true, Score = 100,  },
            new DataGridTestModel(){Id = 44, Name = "Mario", IsEnabled = true, Score = 100,  },
            new DataGridTestModel(){Id = 45, Name = "Chris", IsEnabled = true, Score = 98,  },
            new DataGridTestModel(){Id = 46, Name = "Judy", Score = 100,  },
            new DataGridTestModel(){Id = 47, Name = "Jack", IsEnabled = true, Score = 100,  },
            new DataGridTestModel(){Id = 48, Name = "Mario", IsEnabled = true, Score = 100,  },
            new DataGridTestModel(){Id = 46, Name = "Judy", Score = 100,  },
            new DataGridTestModel(){Id = 47, Name = "Jack", IsEnabled = true, Score = 100,  },
            new DataGridTestModel(){Id = 48, Name = "Mario", IsEnabled = true, Score = 100,  },
        };

        private int pageSize = 10;
        private int pageIndex = 1;
        public CustomManage()
        {
            InitializeComponent();
            BindData();
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

        private void StepPre_Click(object sender, RoutedEventArgs e)
        {

        }

        private void StepQuery_Click(object sender, RoutedEventArgs e)
        {

        }

        private void StepNext_Click(object sender, RoutedEventArgs e)
        {

        }
        private void BindData()
        {
            DataGridV.ItemsSource = TestDataList.Skip((pageIndex - 1) * pageSize).Take(pageSize);

            PaginationName.CurrentIndex = pageIndex;
            PaginationName.TotalIndex = (TestDataList.Count - 1) / pageSize + 1;
        }

        private void PaginationName_OnCurrentIndexChanged(object sender, CurrentIndexChangedEventArgs e)
        {
          
        }

        private void PaginationName_CurrentIndexChanged(object sender, Panuon.UI.Silver.Core.CurrentIndexChangedEventArgs e)
        {
            pageIndex = e.CurrentIndex;
            BindData();
        }

        /// <summary>
        /// 添加客户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StepAdd_Click(object sender, RoutedEventArgs e)
        {
            AddCustomer custom = new AddCustomer();
            //custom.Owner = this;
            custom.Show();
            this.Close();
        }
    }

    //public class DataGridTestModel
    //{
    //    public int Id { get; set; }

    //    public string Name { get; set; }


    //    public bool IsEnabled { get; set; }

    //    public int Score { get; set; }
    //}
}
