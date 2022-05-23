using FigureLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FigureLibrary.FigureModels
{
    public class Circle : BaseFigure
    {
        public override FigureTypes GetType()
        {
            return FigureTypes.Circle;
        }

        public override double CalculateArea(IList<double> values)
        {
            return values[0] * values[0] * Math.PI;
        }

        public override bool IsValidValues(IList<double> values)
        {
            return IsValidValuesBase(values, 1);
        }
    }
}
