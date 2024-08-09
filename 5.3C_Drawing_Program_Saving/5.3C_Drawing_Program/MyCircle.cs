using System;
using System.Collections.Generic;
using SplashKitSDK;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace _5._3C_Drawing_Program
{
    internal class MyCircle : Shape
    {
        private int _radius;

        public MyCircle() : this(Color.Blue, 50)
        {

        }

        public MyCircle(Color color, int radius) : base(color)
        {
            _radius = radius;
        }

        public override void Draw()
        {
            if (Selected)
            {
                DrawOutline();
            }

            SplashKit.FillCircle(Color, X, Y, _radius);
        }

        public override void DrawOutline()
        {
            SplashKit.FillCircle(Color.Black, X, Y, _radius + 2);
        }

        public override bool IsAt(Point2D pt)
        {
            bool isAtX = (Math.Abs(pt.X - X) <= _radius);
            bool isAtY = (Math.Abs(pt.Y - Y) <= _radius);

            if (isAtX && isAtY == true)
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
            writer.WriteLine("Circle");
            base.SaveTo(writer);
            writer.WriteLine(_radius);
        }

        public override void LoadFrom(StreamReader reader)
        {
            base.LoadFrom(reader);
            _radius = reader.ReadInteger();
        }
    }
}
