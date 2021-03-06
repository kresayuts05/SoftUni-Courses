using System;

namespace _1ClassBoxData
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                int lenght = int.Parse(Console.ReadLine());
                int width = int.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                Box box = new Box(lenght, width, height);

                box.SurfaceArea();
                box.LateralSurfaceArea();
                box.Volume();
            }
            catch
            {

            }
        }
    }
}
