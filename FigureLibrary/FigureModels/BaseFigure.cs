using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FigureLibrary.Enums;
using FigureLibrary.FigureModels.Interface;

namespace FigureLibrary.FigureModels
{
    public abstract class BaseFigure : IBaseFigure
    {

        public abstract FigureTypes GetType();

        public abstract double CalculateArea(IList<double> values);

        public abstract bool IsValidValues(IList<double> values);

        public double TryCalculateArea(IList<double> values)
        {
            if (IsValidValues(values))
            {
                return CalculateArea(values);
            }
            else
            {
                Console.WriteLine("Invalid arguments to calculate area");
                return -1;
            }
        }

        private bool IsValidSingleValue(double value)
        {
            return value >= 0;
        }

        protected bool IsValidValuesBase(IList<double> values, int count)
        {
            return !(values == null || values.Count() != count || values.Any(v => !IsValidSingleValue(v)));
        }
    }
}
