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

namespace SkinWpf
{
    ///
    ///     <MyNamespace:ImageButton/>
    ///
    /// </summary>
    public class ImageButton : System.Windows.Controls.Button
    {

        /// <summary>
        /// 图片
        /// </summary>
        public static readonly DependencyProperty ImageProperty = DependencyProperty.Register("Image", typeof(ImageSource), typeof(ImageButton),
            new PropertyMetadata(null));

        /// <summary>
        /// 图片的宽度
        /// </summary>
        public static readonly DependencyProperty ImageWidthProperty = DependencyProperty.Register("ImageWidth", typeof(double), typeof(ImageButton),
            new PropertyMetadata(double.NaN));

        /// <summary>
        /// 图片的高度
        /// </summary>
        public static readonly DependencyProperty ImageHeightProperty = DependencyProperty.Register("ImageHeight", typeof(double), typeof(ImageButton),
            new PropertyMetadata(double.NaN));

        /// <summary>
        /// 构造函数
        /// </summary>
        static ImageButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ImageButton),
                new System.Windows.FrameworkPropertyMetadata(typeof(ImageButton)));
        }

        /// <summary>
        /// 设置图片
        /// </summary>
        public ImageSource Image
        {
            get
            {
                return GetValue(ImageProperty) as ImageSource;
            }
            set
            {
                SetValue(ImageProperty, value);
            }
        }

        /// <summary>
        /// 图片宽度(属性)
        /// </summary>
        public double ImageWidth
        {
            get
            {
                return (double)GetValue(ImageWidthProperty);
            }
            set
            {
                SetValue(ImageWidthProperty, value);
            }
        }

        /// <summary>
        /// 图片高度(属性)
        /// </summary>
        public double ImageHeight
        {
            get
            {
                return (double)GetValue(ImageHeightProperty);
            }
            set
            {
                SetValue(ImageHeightProperty, value);
            }
        }

    }
}
