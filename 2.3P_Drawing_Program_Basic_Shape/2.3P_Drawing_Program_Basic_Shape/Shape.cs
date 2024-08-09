using System;
using System.Collections.Generic;
using SplashKitSDK;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3P_Drawing_Program_Basic_Shape
{
    internal class Shape
    {
        private Color _color;
        public Color Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }

        private float _x;
        public float X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }

        private float _y;
        public float Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }

        private int _width;
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }

        private int _height;
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }

        public Shape()
        {
            _color = Color.Green;
            _x = 0f;
            _y = 0f;
            _width = 100;
            _height = 100;
        }

        public void Draw()
        {
            SplashKit.FillRectangle(_color, _x, _y, _width, _height);
        }

        public bool IsAt(Point2D pt)
        {
            bool isAtX = pt.X >= _x && pt.X <= (_width + _x);
            bool isAtY = pt.Y >= _y && pt.Y <= (_height + _y);

            if (isAtX == true && isAtY == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
