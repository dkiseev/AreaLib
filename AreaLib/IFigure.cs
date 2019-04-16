using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLib
{
    /// <summary>
    /// Интерфейс геометрической фигуры.
    /// </summary>
    public interface IFigure
    {
        /// <summary>
        /// Получение площади фигуры.
        /// </summary>
        /// <returns></returns>
        double GetArea();
    }
}
