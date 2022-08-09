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
using GNSS_Project.IonosphereCoorections;
using Microsoft.Win32;

namespace GNSS_Project
{
    /// <summary>
    /// IonosphereCoorection.xaml 的交互逻辑
    /// </summary>
    public partial class IonosphereCoorection : Window
    {
        IonCoor ion = new IonCoor();
        public IonosphereCoorection()
        {
            InitializeComponent();
            this.DataContext = ion;
        }
        public void Open(object sender,RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.DefaultExt = ".txt";
            dlg.Filter = "卫星轨道数据|*.txt|All File|*.*";
            if (dlg.ShowDialog() != true) return;
            this.ion.ReadText(dlg.FileName);
            Console.Beep();
            MessageBox.Show("数据导入成功！");
        }

        public void Calculate(object sender,RoutedEventArgs e)
        {
            this.Result.Text = this.ion.GetResult();
            MessageBox.Show("已生成计算结果！");
        }
        public void Exit(object sender,RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
