using static System.Runtime.CompilerServices.RuntimeHelpers;
using SplashKitSDK;

namespace _3._3P_Drawing_Program_A_Drawing_Class
{
    internal class Program
    {
        public static void Main()
        {
            Window window = new Window("Shape Drawer", 800, 600);
            Drawings myDrawing = new Drawings();

            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();

                if (SplashKit.MouseClicked(MouseButton.LeftButton) == true)
                {
                    Shape shape = new Shape();
                    shape.X = SplashKit.MouseX();
                    shape.Y = SplashKit.MouseY();
                    myDrawing.AddShape(shape);
                }

                if (SplashKit.KeyTyped(KeyCode.SpaceKey) == true)
                {
                    myDrawing.Background = Color.Random();
                }

                if (SplashKit.MouseClicked(MouseButton.RightButton) == true)
                {
                    myDrawing.SelectShapesAt(SplashKit.MousePosition());
                }

                if (SplashKit.KeyTyped(KeyCode.BackspaceKey))
                {
                    myDrawing.RemoveShape();
                }
                myDrawing.Draw();
                SplashKit.RefreshScreen();


            } while (!window.CloseRequested);

        }
    }
}
