using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.IO;

namespace GNSS_Project.IonosphereCoorections
{
    public class IonCoor : NotificationObject
    {
        private ObservableCollection<PointInfo> pointlist = new ObservableCollection<PointInfo>();
        public ObservableCollection<PointInfo> Pointlist
        {
            get { return pointlist; }
            set { pointlist = value;  this.RaisePropertyChanged("Pointlist"); }
        }
        /// <summary>
        /// 读文件
        /// </summary>
        /// <param name="fileName"></param>
        public void ReadText(string fileName)
        {
            string extension = Path.GetExtension(fileName);
            if (extension == ".txt")
            {
                StreamReader sr = new StreamReader(fileName);
                string buffer = null;
                string[] data;
                //int count = 1;
                while(true)
                {
                    buffer = sr.ReadLine();
                    if (buffer == null) return;
                    if (buffer.Length == 0) continue;
                    if (buffer[0] == '#') continue;
                    data = buffer.Split(',');
                    if(data.Length == 4)
                    {
                        PointInfo point = new PointInfo();
                        point.SatalliteName = data[0];
                        point._x = Convert.ToDouble(data[1]);
                        point._y = Convert.ToDouble(data[2]);
                        point._z = Convert.ToDouble(data[3]);
                        Pointlist.Add(point);
                    }
                }
            }
        }

        public string GetResult()
        {
            StringBuilder str = new StringBuilder();
            str.Append("--------------------计算结果---------------------\n");
            return str.ToString();
        }
        public IonCoor()
        {
            this.Pointlist = new ObservableCollection<PointInfo>();
        }
    }
}
