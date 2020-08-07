using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class Circle
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }
        public double CalculateCircumference()
        {
            double Circumference;
            Circumference = 2 * Math.PI * radius;
            return Circumference;
        }

        public string CalculateFormattedCircumference()
        {
            return FormatNumber(CalculateCircumference());
        }

        public double CalculateArea()
        {
            double Area;
            Area = Math.PI * radius * radius;
            return Area;
        }

        public string CalculateFormattedArea()
        {
            return FormatNumber(CalculateArea());
        }

        private string FormatNumber(double x)
        {
            string TwoPlaces = String.Format("{0:.00}", x);
            return TwoPlaces;
        }
    }
}

