using System;
using System.Collections.Generic;
using System.Linq;
using FigureLibrary.Enums;
using FigureLibrary.FigureModels;
using FigureLibrary.FigureModels.Interface;

namespace FigureLibrary
{
    public class FigureCalculator
    {
        private readonly List<IBaseFigure> _figures = new List<IBaseFigure>() { new Triangle(), new Circle() };

        public double GetFigureAreaByValues(IList<double> values, FigureTypes figureType = FigureTypes.Unknown)
        {
            if (figureType == FigureTypes.Unknown)
            {
                return CalculateAreaToUnknownFigure(values);
            }

            return _figures.Single(f => f.GetType().Equals(figureType)).TryCalculateArea(values);
        }

        public bool IsTriangleRectangular(IList<double> values)
        {
            var triangle = _figures.First(f => f.GetType() == FigureTypes.Triangle) as ITriangle;

            return triangle.IsValidValues(values)
                   && triangle.IsRectangular(values);
        }

        private double CalculateAreaToUnknownFigure(IList<double> values)
        {
            var getFigure = _figures.Where(f => f.IsValidValues(values)).ToList();
            if (getFigure.Count() != 1)
            {
                Console.WriteLine("Cant understand what figure you meen");
                return -1;
            }

            Console.WriteLine($"Calculate area as {getFigure[0].GetType()}");
            return getFigure[0].CalculateArea(values);
        }
    }
}
