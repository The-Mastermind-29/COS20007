using System;
using System.Collections.Generic;
using System.Linq;
using SplashKitSDK;
using System.Text;
using System.Threading.Tasks;

namespace _5._3C_Drawing_Program
{
    internal class MyRectangle : Shape
    {
        private int _width;

        private int _height;

        public MyRectangle() : this(Color.Green, 0.0f, 0.0f, 100, 100)
        {

        }

        public MyRectangle(Color color, float x, float y, int width, int height) : base(color)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

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

        public override void Draw()
        {
            if (Selected)
            {
                DrawOutline();
            }
            SplashKit.FillRectangle(Color, X, Y, Width, Height);
        }

        public override void DrawOutline()
        {
            SplashKit.FillRectangle(Color.Black, X - 2, Y - 2, _width + 4, _height + 4);
        }

        public override bool IsAt(Point2D pt)
        {
            bool isAtX = pt.X >= X && pt.X <= (_width + X);
            bool isAtY = pt.Y >= Y && pt.Y <= (_height + Y);

            if (isAtX == true && isAtY == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void SaveTo(StreamWriter writer)
        {
            writer.WriteLine("Rectangle");
            base.SaveTo(writer);
            writer.WriteLine(Width);
            writer.WriteLine(Height);
        }

        public override void LoadFrom(StreamReader reader)
        {
            base.LoadFrom(reader);
            Width = reader.ReadInteger();
            Height = reader.ReadInteger();
        }
    }
}
