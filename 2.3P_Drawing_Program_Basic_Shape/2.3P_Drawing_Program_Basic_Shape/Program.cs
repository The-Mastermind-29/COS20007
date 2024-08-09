using static System.Runtime.CompilerServices.RuntimeHelpers;
using SplashKitSDK;

namespace _2._3P_Drawing_Program_Basic_Shape
{
    public class Program
    {
        public static void Main()
        {
            Window window = new Window("Shape Drawer", 800, 600);
            Shape myShape = new Shape();

            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();

                if (SplashKit.MouseClicked(MouseButton.LeftButton) == true)
                {
                    myShape.X = SplashKit.MouseX();
                    myShape.Y = SplashKit.MouseY();
                }


                if (SplashKit.KeyTyped(KeyCode.SpaceKey) == true)
                {
                    Point2D pt = new Point2D();
                    pt.X = SplashKit.MouseX();
                    pt.Y = SplashKit.MouseY();

                    if (myShape.IsAt(pt) == true)
                    {
                        myShape.Color = Color.Random();
                    }
                }
                myShape.Draw();

                SplashKit.RefreshScreen();


            } while (!window.CloseRequested);
        }
    }
}
