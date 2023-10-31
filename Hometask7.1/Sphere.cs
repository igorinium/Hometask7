using System;

namespace Hometask7._1
{
    internal class Sphere
    {
        double _x = 0;
        double _y = 0;
        double _z = 0;
        double _radius = 1;
        public Sphere(double x, double y, double z, double radius)
        {
            _x = x;
            _y = y;
            _z = z;
            if (radius > 0)
            {
                _radius = radius;
            }
        }
        public Sphere()
        {

        }
        public Sphere(double radius)
        {
            _radius = radius;
        }
        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                if (_radius > 0)
                {
                    _radius = value;
                }
            }
        }

        public double GetVolume()
        {
            double volume = (4.0 / 3) * Math.PI * (_radius * _radius * _radius);
            return volume;
        }

        public double GetSquare()
        {
            double squareSurface = 4 * Math.PI * (_radius * _radius);
            return squareSurface;
        }

        public string GetCenter()
        {
            string coordinates = $"{_x} {_y} {_z}";
            return coordinates;
        }

        public void SetCenter(double x, double y, double z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        public bool IsPointInside(double x, double y, double z)
        {
            bool isTrue = true;
            if (!((_x + _radius) >= x && (_x - _radius) <= x))
            {
                isTrue = false;
            }
            if (!((_y + _radius) >= y && (_y - _radius) <= y))
            {
                isTrue = false;
            }
            if (!((_z + _radius) >= z && (_z - _radius) <= z))
            {
                isTrue = false;
            }
            return isTrue;
        }
    }
}
