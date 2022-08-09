using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GNSS_Project;
using System.Collections.ObjectModel;
using System.IO;

namespace GNSS_Project.TroposphericDelayCoorections
{
    public class Trop : NotificationObject
    {
        private ObservableCollection<DataEntity_Trop> troplist = new ObservableCollection<DataEntity_Trop>();
        public ObservableCollection<DataEntity_Trop> Troplist
        {
            get { return troplist; }
            set { troplist = value;  this.RaisePropertyChanged("Troplist"); }
        }

        public void ReadText(string fileName)
        {
            string extension = Path.GetExtension(fileName);
            if(extension == ".txt")
            {
                StreamReader sr = new StreamReader(fileName);
                string buffer = null;
                string[] data;
                while(true)
                {
                    buffer = sr.ReadLine();
                    if (buffer == null) return;
                    if (buffer.Length == 0) continue;
                    if (buffer[0] == '#') continue;
                    data = buffer.Split(',');
                    if(data.Length == 6)
                    {
                        DataEntity_Trop info = new DataEntity_Trop();
                        info.Name = data[0];
                        info.Time = Convert.ToDouble(data[1]);
                        info._L = Convert.ToDouble(data[2]);
                        info._B = Convert.ToDouble(data[3]);
                        info._H = Convert.ToDouble(data[4]);
                        info.Zeta = Convert.ToDouble(data[5]);
                        Troplist.Add(info);
                    }
                }
                
            }
        }

        public Trop()
        {
            this.Troplist = new ObservableCollection<DataEntity_Trop>();
        }
    }
}
