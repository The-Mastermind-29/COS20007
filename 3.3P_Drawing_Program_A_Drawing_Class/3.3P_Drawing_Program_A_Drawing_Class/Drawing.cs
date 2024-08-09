using System;
using System.Collections.Generic;
using SplashKitSDK;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3P_Drawing_Program_A_Drawing_Class
{
    internal class Drawings
    {
        private readonly List<Shape> _shapes;
        private Color _background;

        public List<Shape> SelectedShapes()
        {
            List<Shape> shapes = new List<Shape>();
            foreach (Shape shape in _shapes)
            {
                if (shape.Selected)
                {
                    shapes.Add(shape);
                }
            }
            return shapes;
        }

        public int ShapeCount
        {
            get
            {
                return _shapes.Count;
            }
        }

        public Color Background
        {
            get
            {
                return _background;
            }
            set
            {
                _background = value;
            }
        }

        public Drawings() : this(Color.White)
        {
        }

        public Drawings(Color background)
        {
            _shapes = new List<Shape>();
            _background = background;
        }

        public void Draw()
        {
            SplashKit.ClearScreen(_background);

            foreach (Shape shape in _shapes)
            {
                shape.Draw();
            }
        }

        public void SelectShapesAt(Point2D pt)
        {
            foreach (Shape shape in _shapes)
            {
                if (shape.IsAt(pt))
                {
                    shape.Selected = true;
                }
                else
                {
                    shape.Selected = false;
                }
            }
        }

        public void AddShape(Shape s)
        {
            _shapes.Add(s);
        }

        public void RemoveShape()
        {
            foreach (Shape shape in _shapes.ToList())
            {
                if (shape.Selected)
                {
                    _shapes.Remove(shape);
                }
            }
        }
    }
}
