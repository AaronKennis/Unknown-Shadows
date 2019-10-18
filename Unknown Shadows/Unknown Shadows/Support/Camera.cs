using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unknown_Shadows.Support
{
    static public class Camera
    {
        static private float sScale;
        static private Point sOffset;

        static private Point ConvertToSize(Vector2 value)
        {
            Point point = new Point();
            point.X = (int)(value.X * sScale);
            point.Y = (int)(value.Y * sScale);
            return point;
        }

        static private Point ConvertToPosition(Vector2 value)
        {
            Point point = new Point();
            point.X = (int)(value.X * sScale);
            point.Y = (int)(-value.Y * sScale);
            return sOffset + point;
        }

        static public Rectangle ScreenRectangle(Vector2 position, Vector2 size)
        {
            Point p = ConvertToPosition(position);
            Point s = ConvertToSize(size);

            return new Rectangle(p - new Point(s.X / 2, s.Y / 2), s);
        }

        static public void Setup()
        {
            sOffset.X = Game1.sGraphics.PreferredBackBufferWidth / 2;
            sOffset.Y = Game1.sGraphics.PreferredBackBufferHeight / 2;
            sScale = sOffset.Y;
        }
    }
}
