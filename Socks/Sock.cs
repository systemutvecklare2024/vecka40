using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socks
{
    internal class Sock
    {
        public int Size { get; private set; }
        public string Color { get; private set; }
        
        private int grade;
        public int Grade
        {
            get { return grade; }
            set {
                if (value > 5 || value < 1)
                    throw new Exception("Invalid grade");

                grade = value; 
            }
        }



        public Sock(int size, string color, int grade)
        {
            Size = size;
            Color = color;
            Grade = grade;
        }

        public override string ToString()
        {
            return $"Size: {Size} Color: {Color} Grade: {Grade}";
        }
    }
}
