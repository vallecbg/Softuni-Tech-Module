using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
                    double priceCPU = double.Parse(Console.ReadLine()) * 1.57;
                    double priceVGA = double.Parse(Console.ReadLine()) * 1.57;
                    double priceRAM = double.Parse(Console.ReadLine()) * 1.57;
                    int quantityRAM = int.Parse(Console.ReadLine());
                    double discount = double.Parse(Console.ReadLine());

                    var price = (priceCPU - (priceCPU * discount)) + (priceVGA - (priceVGA * discount)) + (priceRAM * quantityRAM);


                    Console.WriteLine("Money needed - " + "{0:f2}", price + " leva.");
                }
            }

        
    
