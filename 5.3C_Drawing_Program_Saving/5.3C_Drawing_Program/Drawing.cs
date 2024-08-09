using System;
using System.Collections.Generic;
using SplashKitSDK;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3C_Drawing_Program
{
    internal class Drawing
    {
        private readonly List<Shape> _shapes;
        private Color _background;
        StreamWriter writer;

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

        public Drawing() : this(Color.White)
        {
        }

        public Drawing(Color background)
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
                    shape.Selected = !shape.Selected;
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

        public void Save(string filename)
        {
            writer = new StreamWriter(filename);
            writer.WriteColor(Background);
            writer.WriteLine(ShapeCount);

            foreach (Shape shape in _shapes)
            {
                shape.SaveTo(writer);
            }
            writer.Close();
        }

        public void Load(string filename)
        {
            StreamReader reader = new StreamReader(filename);
            Background = reader.ReadColor();
            int count = reader.ReadInteger();
            Shape shape;
            _shapes.Clear();

            try
            {
                for (int i = 0; i < count; i++)
                {
                    string kind = reader.ReadLine();
                    switch (kind)
                    {
                        case "Rectangle":
                            shape = new MyRectangle();
                            break;

                        case "Circle":
                            shape = new MyCircle();
                            break;

                        case "Line":
                            shape = new MyLine();
                            break;

                        default:
                            throw new InvalidDataException($"Error at the shape: {kind}");
                    }

                    shape.LoadFrom(reader);
                    AddShape(shape);
                }
            }
            finally
            {
                reader.Close();
            }
        }
    }
}
