using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;

namespace WindowsFormsBus
{ 
    public class Autovoksal<T> : IEnumerator<T>, IEnumerable<T> where T : class, ITransport
    {
        private readonly List<T> _places;

        private readonly int _maxCount;

        private readonly int pictureWidth;

        private readonly int pictureHeight;

        private readonly int _placeSizeWidth = 300;

        private readonly int _placeSizeHeight = 80;

        private int _currentIndex;
        public T Current => _places[_currentIndex];
        object IEnumerator.Current => _places[_currentIndex];

        public Autovoksal(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _maxCount = width * height;
            pictureWidth = picWidth;
            pictureHeight = picHeight;
            _places = new List<T>();
            _currentIndex = -1;
        }

        public static bool operator +(Autovoksal<T> p, T bus)
        {
            if (p._places.Count >= p._maxCount)
            {
                throw new AutovoksalOverflowException();
            }
            if (p._places.Contains(bus))
            {
                throw new AutovoksalAlreadyHaveException();
            }
            p._places.Add(bus);
            return true;
        }

        public static T operator -(Autovoksal<T> p, int index)
        {
            if (index < -1 || index > p._places.Count)
            {
                throw new AutovoksalNotFoundException(index);
            }

            T bus = p._places[index];
            p._places.RemoveAt(index);
            return bus;
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Count; ++i)
            {
                _places[i].SetPosition(i / (pictureHeight / _placeSizeHeight) * _placeSizeWidth + 5, i % (pictureHeight / _placeSizeHeight) * _placeSizeHeight + 5, pictureWidth, pictureHeight);
                _places[i].DrawTransport(g);
            }
        }

        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; j++)
                {
                    g.DrawLine(pen, i * _placeSizeWidth + 3, j * _placeSizeHeight, i * _placeSizeWidth + _placeSizeWidth / 2 + 110, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth + 3, 0, i * _placeSizeWidth + 3, (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }
        public T GetNext(int index)
        {
            if (index < 0 || index >= _places.Count)
            {
                return null;
            }
            return _places[index];
        }
        /// <summary>
        /// Сортировка автобусов на парковке
        /// </summary>
        public void Sort() => _places.Sort((IComparer<T>)new BusComparer());
        /// <summary>
        /// Метод интерфейса IEnumerator, вызываемый при удалении объекта
        /// </summary>
        public void Dispose()
        {
        }
        /// <summary>
        /// Метод интерфейса IEnumerator для перехода к следующему элементу или началу коллекции
        /// </summary>
        /// <returns></returns>
        public bool MoveNext()
        {
            _currentIndex++;
            return (_currentIndex < _places.Count);
        }
        /// <summary>
        /// Метод интерфейса IEnumerator для сброса и возврата к началу коллекции
        /// </summary>
        public void Reset()
        {
            _currentIndex = -1;
        }
        /// <summary>
        /// Метод интерфейса IEnumerable
        /// </summary>
        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }
        /// <summary>
        /// Метод интерфейса IEnumerable
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
    }
}

