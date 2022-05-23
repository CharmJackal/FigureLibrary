using System;
using System.Collections.Generic;
using System.Text;

namespace FigureLibrary.FigureModels.Interface
{
    internal interface ITriangle : IBaseFigure
    {
        public bool IsRectangular(IList<double> values);
    }
}
