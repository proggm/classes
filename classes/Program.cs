using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Cars cars = new Cars();
            cars.model = " Tesla model S";
            cars.horsepower = 666.6;
            cars.Winnum = 1234567890;

            Console.WriteLine($"model: {cars.model},  horsepower: {cars.horsepower},  Winnum: {cars.Winnum}");
            Console.ReadKey();
        }
    }
}

public class Cars
    {
    public string model { get; set; }   
    public double horsepower { get; set; } 
    public int  Winnum { get; set; }
    }
