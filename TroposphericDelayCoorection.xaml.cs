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
using GNSS_Project.TroposphericDelayCoorections;
using Microsoft.Win32;

namespace GNSS_Project
{
    /// <summary>
    /// TroposphericDelayCoorection.xaml 的交互逻辑
    /// </summary>
    public partial class TroposphericDelayCoorection : Window
    {
        Trop tro = new Trop();
        public TroposphericDelayCoorection()
        {
            InitializeComponent();
            this.DataContext = tro;
        }
        public void Open(object sender,RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.DefaultExt = ".txt";
            dlg.Filter = "坐标信息|*.txt|All File|*.*";
            if (dlg.ShowDialog() != true) return;
            this.tro.ReadText(dlg.FileName);

            MessageBox.Show("数据导入成功！");
        }
    }
}
