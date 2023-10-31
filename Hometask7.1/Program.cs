using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты сферы:");
            double x;
            double y;
            double z;
            double radius;

            while (true)
            {
                Console.Write("Координата x: ");
                string inputStr = Console.ReadLine();
                bool isParseSuccess = double.TryParse(inputStr, out x);
                if (isParseSuccess || string.IsNullOrEmpty(inputStr))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели неверное число");
                }
            }
            while (true)
            {
                Console.Write("Координата y: ");
                string inputStr = Console.ReadLine();
                bool isParseSuccess = double.TryParse(inputStr, out y);
                if (isParseSuccess || string.IsNullOrEmpty(inputStr))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели неверное число");
                }
            }
            while (true)
            {
                Console.Write("Координата z: ");
                string inputStr = Console.ReadLine();
                bool isParseSuccess = double.TryParse(inputStr, out z);
                if (isParseSuccess || string.IsNullOrEmpty(inputStr))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели неверное число");
                }
            }
            while (true)
            {
                Console.Write("Введите радиус: ");
                string inputStr = Console.ReadLine();
                bool isParseSuccess = double.TryParse(inputStr, out radius);
                if (isParseSuccess || string.IsNullOrEmpty(inputStr))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели неверное число");
                }
            }

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
