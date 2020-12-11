using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBus
{
    public class BusComparer : IComparer<EasyBus>
    {
        public int Compare(EasyBus x, EasyBus y)
        {
            if (x is BusGarm && y is BusGarm)
            {
                return ComparerBusGarm((BusGarm)x, (BusGarm)y);
            }
            if (x is BusGarm && y is Bus)
            {
                return -1;
            }
            if (x is Bus && y is BusGarm)
            {
                return 1;
            }
            if (x is Bus && y is Bus)
            {
                return ComparerBus((Bus)x, (Bus)y);
            }
            return 0;
        }
        private int ComparerBus(Bus x, Bus y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }
        private int ComparerBusGarm(BusGarm x, BusGarm y)
        {
            var res = ComparerBus(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.Garmoshka != y.Garmoshka)
            {
                return x.Garmoshka.CompareTo(y.Garmoshka);
            }
            if (x.ThirdOs != y.ThirdOs)
            {
                return x.ThirdOs.CompareTo(y.ThirdOs);
            }
            return 0;
        }
    }
}
