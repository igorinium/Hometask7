using System;

namespace Hometask7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты сферы и её радиус:");
            double[] values = new double[4];
            for (int i = 0; i < values.Length;)
            {
                Console.Write($"Введите значение №{i + 1}: ");
                string inputStr = Console.ReadLine();
                bool isParseSuccess = double.TryParse(inputStr, out values[i]);
                if (isParseSuccess || string.IsNullOrEmpty(inputStr))
                {
                    i++;
                }
            }

            double x = values[0];
            double y = values[1];
            double z = values[2];
            double radius = values[3];
            Sphere sphere = new Sphere(x, y, z, radius);
            double volume = sphere.GetVolume();
            Console.WriteLine($"Объём сферы = {volume}");
            double square = sphere.GetSquare();
            Console.WriteLine($"Площадь поверхности шара = {square}");
            string coordinates = sphere.GetCenter();
            Console.WriteLine($"Коодринаты центра сферы = {coordinates}");
            sphere.SetCenter(34, 12, 99);
            string coordinates2 = sphere.GetCenter();
            Console.WriteLine($"Коодринаты центра сферы = {coordinates2}");
            bool isPointInSphere = sphere.IsPointInside(0, 2, -5);
            Console.WriteLine($"Некая точка внутри сферы = {isPointInSphere}");
            Console.ReadLine();
        }
    }
}
