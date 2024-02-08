using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZIMay2022
{
    public class Truck : Car
    {
        public Truck(string brand, int year, int mileage, decimal value, int tonnage) : base(brand, year, mileage, value)
        {
            Tonnage = tonnage;
        }

        public int Tonnage {  get; set; }

        public override void Price()
        {
            if (Year >= 2017)
            {
                Value = Value;
            }
            else if (Year < 2017 && Tonnage <= 5)
            {
                Value -= Value * 70 / 100;
            }
            else if (Year < 2017 && (Tonnage >= 5 && Tonnage <= 10))
            {
                Value -= Value * 40 / 100;
            }
            else if (Year < 2017 && Tonnage > 10)
            {
                Value -= Value * 20 / 100;
            }
        }
    }
}