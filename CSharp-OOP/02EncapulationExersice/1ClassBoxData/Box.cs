using System;
using System.Collections.Generic;
using System.Text;

namespace _1ClassBoxData
{
    public class Box
    {
        private double lenght;
        private double width;
        private double height;

        public Box(double lenght, double width, double height)
        {
            Lenght = lenght;
            Width = width;
            Height = height;
        }

        public double Lenght
        {
            get
            {
                return lenght;
            }
            private set
            {
                if (lenght <= 0)
                {
                    throw new ArgumentException("Lenght cannot be zero or negative.");
                    lenght = value;
                }

            }
        }

        public double Width
        {
            get
            {
                return width;
            }
            private set
            {
                if (width <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                    width = value;
                }

            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            private set
            {
                if (height <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                    height = value;
                }

            }
        }

        public void SurfaceArea()
        {
            double surfaceArea = 2 * Lenght * Width + 2 * Lenght * Height + 2 * Width * Height;
            Console.WriteLine($"Surface Area - {surfaceArea:f2}");
        }

        public void LateralSurfaceArea()
        {
            double lateralSurfaceArea = 2 * Lenght * Height + 2 * Width * Height;

            Console.WriteLine($"Lateral Surface Area - {lateralSurfaceArea:f2}");
        }

        public void Volume()
        {
            double volume = Lenght * Width * Height;
            Console.WriteLine($"Volume - {volume:f2}");
        }
    }
}
