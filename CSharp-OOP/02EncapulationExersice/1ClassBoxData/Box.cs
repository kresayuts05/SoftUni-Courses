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
            get => lenght;
            private set
            {
                ThrowIfInvalideSide(value, nameof(Lenght));

                this.lenght = value;
            }
        }

        public double Width
        {
            get => width;
            private set
            {
                ThrowIfInvalideSide(value, nameof(Width));

                this.width = value;
            }
        }

        public double Height
        {
            get => height;
            private set
            {
                ThrowIfInvalideSide(value, nameof(Height));

                this.height = value;

            }
        }

        public double SurfaceArea()
        {
            return 2 * Lenght * Width + 2 * Lenght * Height + 2 * Width * Height;
        }

        public double LateralSurfaceArea()
        {
            return 2 * Lenght * Height + 2 * Width * Height;
        }

        public double Volume()
        {
            return Lenght * Width * Height;
        }

        private void ThrowIfInvalideSide(double value, string side)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{side} cannot be zero or negative.");
            }
            
        }
    }
}
