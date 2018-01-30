using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            var photoNumber = int.Parse(Console.ReadLine());
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var sizeInBytes = double.Parse(Console.ReadLine());
            var photoWidth = int.Parse(Console.ReadLine());
            var photoHeight = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: DSC_{0}.jpg", photoNumber.ToString("D4"));
            Console.WriteLine("Date Taken: {0}/{1}/{2} {3}:{4}",
                day.ToString("D2"), month.ToString("D2"), year.ToString("D4"), hours.ToString("D2"), minutes.ToString("D2"));
            if (sizeInBytes > 0 && sizeInBytes < 1000)
            {
                Console.WriteLine("Size: {0}B", sizeInBytes);
            }
            else if (sizeInBytes / 1000000 >= 1)
            {
                Console.WriteLine("Size: {0}MB", Math.Round(sizeInBytes / 1000000, 1));
            }
            else if (sizeInBytes / 1000000 < 1)
            {
                Console.WriteLine("Size: {0}KB", Math.Round(sizeInBytes / 1000, 1));
            }

            if (photoWidth < photoHeight)
            {
                Console.WriteLine("Resolution: {0}x{1} (portrait)", photoWidth, photoHeight);
            }
            else if (photoWidth == photoHeight)
            {
                Console.WriteLine("Resolution: {0}x{1} (square)", photoWidth, photoHeight);
            }
            else if (photoWidth > photoHeight)
            {
                Console.WriteLine("Resolution: {0}x{1} (landscape)", photoWidth, photoHeight);

            }
        }
    }
}
