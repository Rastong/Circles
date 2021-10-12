using System;
using System.Collections.Generic;
using System.Text;

namespace Circles
{
    class Circle
    {
        private double Radius;
        private double pi;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateCircumference()
        {
            double Circ = 2 * Radius * Math.PI;
            return Circ;
        }

        private string FormatNumber(double value)
        {
            string Format = string.Format("{0:0.00}", value);
            return Format;
        }

        public string CalcFormCirc()
        {
            string circForm = FormatNumber(CalculateCircumference());
            return circForm;
        }

        public double CalculateArea()
        {
            double area = (Radius * Radius) * Math.PI;
            return area;
        }

        public string CalcFormArea()
        {
            string circForm = FormatNumber(CalculateArea());
            return circForm;
        }
    }
}
