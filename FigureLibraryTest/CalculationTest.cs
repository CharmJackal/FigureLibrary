using System;
using System.Collections.Generic;
using FigureLibrary;
using FigureLibrary.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FigureLibraryTest
{
    [TestClass]
    public class CalculationTest
    {
        [TestMethod]
        public void CheckUnknownCalculationForCircle()
        {
            var figureCalulator = new FigureCalculator();

            var res = figureCalulator.GetFigureAreaByValues(new List<double>() { 1 });

            Assert.AreEqual(Math.PI, res);
        }

        [TestMethod]
        public void CheckCalculationForTriangle()
        {
            var figureCalulator = new FigureCalculator();

            var res = figureCalulator.GetFigureAreaByValues(new List<double>() { 6, 10, 8 });

            Assert.AreEqual(24, res);
        }

        [TestMethod]
        public void CheckFigureValidation()
        {
            var figureCalulator = new FigureCalculator();

            var res = figureCalulator.GetFigureAreaByValues(new List<double>() { 1, 2, -1 }, FigureTypes.Triangle);

            Assert.AreEqual(-1, res);
        }

        [TestMethod]
        public void CheckTriangleRectangulation()
        {
            var figureCalulator = new FigureCalculator();

            var res = figureCalulator.IsTriangleRectangular(new List<double>() { 6, 10, 8 });

            Assert.AreEqual(true, res);
        }

    }
}
