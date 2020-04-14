using System;

namespace Inheritance
{
    public class PresentationObject
    {
        public int Width { get; set; }
        public int Heigh { get; set; }

        public void Copy()
        {
            Console.WriteLine("Object copied to clipboard.");
        }

        public void Duplicate()
        {
            Console.WriteLine("Object was duplicated");
        }
    }
}
