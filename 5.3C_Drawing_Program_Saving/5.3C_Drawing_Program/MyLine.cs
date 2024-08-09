using System;
using System.Collections.Generic;
using SplashKitSDK;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3C_Drawing_Program
{
    internal class MyLine : Shape
    {
        private float _endX;

        public float EndX
        {
            get
            {
                return _endX;
            }
            set
            {
                _endX = value;
            }
        }

        public float EndY
        {
            get
            {
                return _endY;
            }
            set
            {
                _endY = value;
            }
        }

        private float _endY;

        public MyLine() : this(Color.Red, 0.0f, 0.0f, 50.0f, 50.0f)
        {

        }

        public MyLine(Color color, float startX, float startY, float endX, float endY) : base(color)
        {
            _endX = endX;
            _endY = endY;
            Color = color;
        }

        public override void Draw()
        {
            if (Selected)
            {
                DrawOutline();
            }
            SplashKit.DrawLine(Color, X, Y, X + EndX, Y + EndY);
        }

        public override void DrawOutline()
        {
            SplashKit.FillCircle(Color.Black, X, Y, 5);
            SplashKit.FillCircle(Color.Black, X + EndX, Y + EndY, 5);

        }

        public override bool IsAt(Point2D pt)
        {
            bool isAtX = pt.X >= X && pt.X <= (EndX + X);
            bool isAtY = pt.Y >= Y && pt.Y <= (EndY + Y);

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
            writer.WriteLine("Line");
            base.SaveTo(writer);
            writer.WriteLine(EndX);
            writer.WriteLine(EndY);
        }

        public override void LoadFrom(StreamReader reader)
        {
            base.LoadFrom(reader);
            EndX = reader.ReadInteger();
            EndY = reader.ReadInteger();
        }
    }
}
