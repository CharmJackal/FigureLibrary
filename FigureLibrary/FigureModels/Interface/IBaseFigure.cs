using System;
using System.Collections.Generic;
using System.Text;
using FigureLibrary.Enums;

namespace FigureLibrary.FigureModels.Interface
{
    internal interface IBaseFigure
    {
        public bool IsValidValues(IList<double> values);

        public double CalculateArea(IList<double> values);

        public double TryCalculateArea(IList<double> values);

        public FigureTypes GetType();
    }
}
