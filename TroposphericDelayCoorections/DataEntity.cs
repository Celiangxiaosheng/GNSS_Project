using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GNSS_Project;

namespace GNSS_Project.TroposphericDelayCoorections
{
    public class DataEntity_Trop : NotificationObject
    {
        /// <summary>
        /// 测站名
        /// </summary>
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value;  this.RaisePropertyChanged("Name"); }
        }
        private double time;
        public double Time
        {
            get { return time; }
            set { time = value; this.RaisePropertyChanged("Time"); }
        }
        private double L;
        public double _L
        {
            get { return L; }
            set { L = value; this.RaisePropertyChanged("_L"); }
        }
        private double B;
        public double _B
        {
            get { return B; }
            set { B = value; this.RaisePropertyChanged("_B"); }
        }
        private double H;
        public double _H
        {
            get { return H; }
            set { H = value; this.RaisePropertyChanged("_H"); }
        }
        private double zeta;
        public double Zeta
        {
            get { return zeta; }
            set { zeta = value; this.RaisePropertyChanged("Zeta"); }
        }
        public DataEntity_Trop() { }
        public DataEntity_Trop(string name,double time,double L,double B,double H,double zeta )
        {
            Name = name;
            Time = time;
            _L = L;                
            _B = B;
            _H = H;
            Zeta = zeta;
        }

    }
}
