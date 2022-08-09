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

namespace GNSS_Project
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
        public void CalIonCoor(object sender,RoutedEventArgs e)
        {
            IonosphereCoorection coor = new IonosphereCoorection();
            coor.Show();
        }
        public void CalTimeConversion(object sender,RoutedEventArgs e)
        {
            TimeSystemConversion tsc = new TimeSystemConversion();
            tsc.Show();
        }
        public void CalTroCoor(object sender,RoutedEventArgs e)
        {
            TroposphericDelayCoorection tro = new TroposphericDelayCoorection();
            tro.Show();
        }
        public void About(object sender,RoutedEventArgs e)
        {
            MessageBox.Show("\tGNSS编程系列软件\n" +
                "开   发  者：冯峥\n" +
                "开发者邮箱：2914147943@qq.com\n" +
                "地        址：陕西省西安市临潼区\n" +
                "                                    2022-7-22", "关于本软件");
        }
    }
}
