using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WorkingLib
{
    public static class Bank
    {
        public static int GetAge(int year)
        {
            return DateTime.Now.Year - year;
        }
        public static double Billing(int age)
        {
            return Math.Abs(Math.Sin(age));
        }
    }
    [Serializable]
    public class Human
    {
        int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Age can't be below zero.");
                else
                {
                    age = value;
                }
            }
        }
        public string Name { get; set; }
        public double Tariff { get; set; }
        public override string ToString()
        {
            if (String.IsNullOrEmpty(Name))
                Name = "Anonymous";
            return Name + "'s (" + Age.ToString() + ") tarrif is " + Math.Round(Tariff, 3);
        }
        
    }
}
