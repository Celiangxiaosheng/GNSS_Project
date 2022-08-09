using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GNSS_Project.IonosphereCoorections
{
    public  class PointInfo : NotificationObject
    {
        /// <summary>
        /// 卫星标识
        /// </summary>
        private string satalliteName;
        public string SatalliteName
        {
            get { return satalliteName; }
            set { satalliteName = value;  this.RaisePropertyChanged("SatelliteName"); }
        }
        /// <summary>
        ///x分量 
        /// </summary>
        private double x;
        public double _x
        {
            get { return x; }
            set { x = value;this.RaisePropertyChanged("_x"); }
        }
        /// <summary>
        /// y分量
        /// </summary>
        private double y;
        public double _y
        {
            get { return y; }
            set { y = value; this.RaisePropertyChanged("_y"); }
        }
        /// <summary>
        /// z分量
        /// </summary>
        private double z;
        public double _z
        {
            get { return z; }
            set { z = value;this.RaisePropertyChanged("_z"); }
        }
        public PointInfo()
        {

        }
        public PointInfo(string name,double x,double y,double z)
        {
            this.SatalliteName = name;
            this._x = x;
            this._y = y;
            this._z = z;
        }
    }
}
