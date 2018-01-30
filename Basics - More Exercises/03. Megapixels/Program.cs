using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            var imageWidth = double.Parse(Console.ReadLine());
            var imageHeight = double.Parse(Console.ReadLine());

            var pixels = imageWidth * imageHeight;
            var megaPixels = pixels / 1000000;

            Console.WriteLine("{0}x{1} => {2}MP",
                imageWidth,
                imageHeight,
                Math.Round(megaPixels, 1));
        }
    }
}
