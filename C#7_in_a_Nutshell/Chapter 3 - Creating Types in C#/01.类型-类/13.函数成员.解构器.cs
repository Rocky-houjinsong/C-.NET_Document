using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.类型_类
{
    class _13
    {
        public class Rectangle
        {
            public readonly float Width, Height;

            public Rectangle(float width, float height)
            {
                Width = width;
                Height = height;
            }

            public void Deconstruct(out float width, out float height)
            {
                width = Width;
                height = Height;
            }
        }

        //static void Main()
        //{
        //    // To call the deconstructor, we use the following special syntax:
        //    var rect = new Rectangle(3, 4);
        //    (float width, float height) = rect;          // Deconstruction
        //    Console.WriteLine(width + " " + height);    // 3 4

        //    // We can also use implicit typing:  
        //    var (x, y) = rect;          // Deconstruction
        //    Console.WriteLine(x + " " + y);   // 3 4

        //    // If the variables already exist, we can do a *deconstructing assignment*:
        //    (x, y) = rect;
        //    Console.WriteLine(x + " " + y);  // 3 4
        //    Console.ReadKey();
        //}
    }
}
