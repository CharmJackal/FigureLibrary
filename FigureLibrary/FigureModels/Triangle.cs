using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FigureLibrary.Enums;
using FigureLibrary.FigureModels.Interface;

namespace FigureLibrary.FigureModels
{
    public class Triangle : BaseFigure, ITriangle
    {
        public override FigureTypes GetType()
        {
            return FigureTypes.Triangle;
        }

        public bool IsRectangular(IList<double> values)
        {
            var toSort = values.ToList();

            toSort.Sort();

            return toSort[2] * toSort[2] == toSort[0] * toSort[0] + toSort[1] * toSort[1];

        }

        public override double CalculateArea(IList<double> values)
        {
            var p = values.Sum() / 2;

            return Math.Sqrt(p * (p - values[0]) * (p - values[1]) * (p - values[2]));
        }

        public override bool IsValidValues(IList<double> values)
        {
            if (!IsValidValuesBase(values, 3))
            {
                return false;
            }

            return    values[0] + values[1] > values[2]
                   && values[0] + values[2] > values[1]
                   && values[1] + values[2] > values[0];
        }
    }
}
