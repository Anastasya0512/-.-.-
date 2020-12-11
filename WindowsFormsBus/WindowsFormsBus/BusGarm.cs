using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsBus
{
    public class BusGarm : Bus, IEquatable<BusGarm>
    {
        public Color DopColor { private set; get; }

        public bool Garmoshka { private set; get; }

        public bool ThirdOs { private set; get; }

        public BusGarm(int maxSpeed, float weight, Color mainColor, Color dopColor, bool garmoshka, bool thirdOs) : base(maxSpeed, weight, mainColor, 194, 68)
        {
            DopColor = dopColor;
            Garmoshka = garmoshka;
            ThirdOs = thirdOs;
        }
        public BusGarm(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Garmoshka = Convert.ToBoolean(strs[4]);
                ThirdOs = Convert.ToBoolean(strs[5]);
            }
        }

        public override void DrawTransport(Graphics g)
        {
            Brush brDop = new SolidBrush(DopColor);
            Pen os = new Pen(Color.Black, 4);
            Pen luke = new Pen(Color.Black);
            Brush white = new SolidBrush(Color.White);
            Brush red = new SolidBrush(MainColor);
            Brush okno = new SolidBrush(Color.DarkGray);

            base.DrawTransport(g);

            //отрисуем гармошку
            if (Garmoshka)
            {
                //отрисуем кузов автобуса
                g.FillRectangle(red, _startPosX + 136, _startPosY + 5, 80, 53);

                //правый люк
                g.DrawRectangle(luke, _startPosX + 150, _startPosY, 29, 6);
                g.FillRectangle(white, _startPosX + 151, _startPosY + 1, 28, 5);

                //окно автобуса
                g.DrawRectangle(luke, _startPosX + 137, _startPosY + 14, 78, 29);
                g.FillRectangle(okno, _startPosX + 138, _startPosY + 15, 77, 28);

                //гармошка
                g.FillRectangle(brDop, _startPosX + 118, _startPosY + 8, 19, 47);
            }
            //отрисуем третью ось колес
            if (ThirdOs)
            {
                g.DrawEllipse(os, _startPosX + 148, _startPosY + 50, 17, 17);
                g.FillEllipse(white, _startPosX + 150, _startPosY + 52, 13, 13);
            }
        }
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
        public override string ToString()
        {
            return
           $"{base.ToString()}{separator}{DopColor.Name}{separator}{Garmoshka}{separator}{ThirdOs}";
        }
        public bool Equals(BusGarm other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (Garmoshka != other.Garmoshka)
            {
                return false;
            }
            if (ThirdOs != other.ThirdOs)
            {
                return false;
            }
            return true;
        }
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is BusGarm busObj))
            {
                return false;
            }
            else
            {
                return Equals(busObj);
            }
        }
    }
}