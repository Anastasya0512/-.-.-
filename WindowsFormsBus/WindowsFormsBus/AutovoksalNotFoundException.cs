using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBus
{
    /// <summary>
    /// Класс-ошибка "Если не найден автомобиль по определенному месту"
    /// </summary>
    public class AutovoksalNotFoundException : Exception
    {
        public AutovoksalNotFoundException(int i) : base("Не найден автобус по месту " + i)
        { }
    }
}
