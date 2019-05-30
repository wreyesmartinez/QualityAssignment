using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityAssignment
{

    public class Rectangle
    {
        private int length;
        private int width;

        public Rectangle()
        {
            length = 1;
            width = 1;
        }

        public Rectangle(int l, int w)
        {
            this.length = l;
            this.width = w;
        }



        public int GetLength()
        {
            return length;
        }

        public void SetLength(int length)
        {
            this.length = length;
        }

        public int GetWidth()
        {
            return width;
        }

        public void SetWidth(int width)
        {
            this.width = width;
        }

        public int GetPerimeter()
        {
            return (2 * (length + width));
        }

        public int GetArea()
        {
            return length * width;
        }
    }
}
