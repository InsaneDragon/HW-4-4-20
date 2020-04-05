﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Classes2
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter currentCurrency = new Converter(10.22, 11.4, 0.13);
            Console.Write("Write How much money you want to Convert:");
            double money = double.Parse(Console.ReadLine());
            Console.WriteLine("1.Somoni to USD");
            Console.WriteLine("2.Somoni to Ruble");
            Console.WriteLine("3.Somoni to Euro");
            Console.WriteLine("4.USD to Somoni");
            Console.WriteLine("5.Ruble to Somoni");
            Console.WriteLine("6.Euro to Somoni");
            Console.Write("Choose number from list above:");
            int Currency = int.Parse(Console.ReadLine());
            double after=Classes2.Program.Currency(money,Currency,currentCurrency);
            Console.WriteLine($"Your Money:{after}");
            System.Console.WriteLine("////////////////////////////////////////////////////3");
            System.Console.Write("Write Employee Name:");
            string Name=Console.ReadLine();
            System.Console.Write("Write Employee Surname:");
            string SurName=Console.ReadLine();
            List<string>listofprofessions=new List<string>(){"teacher","programmer","OfficeEmployee","Manager"};
            int count=1;
            foreach(var item in listofprofessions)
            {
                System.Console.WriteLine($"{count}. {item}");
                count++;
            }
            System.Console.Write("Choose Profession from list above:");
            int Profession=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Write Employees Experience(How many year he is working):");
            int Experience=int.Parse(Console.ReadLine());
            double Salary=Classes2.Program.Salary(Profession);
            Salary+=Experience*1000;
            string activity=listofprofessions[Profession-1];
            Employee Human=new Employee(){Name=Name,SurName=SurName,Profession=activity,Expirience=Experience};
            double Taxes=Salary*0.13;
            System.Console.WriteLine($"Name:{Human.Name} SurName:{Human.SurName} Profession:{Human.Profession} Experience:{Human.Expirience} Salary:{Salary} Tax Levy:{Taxes}");
        }
        public static double Currency(double money, int Currency,Converter Current)
        {
            double after=0;
            switch (Currency)
            {
                case 1: after=money*Current.dollar;break;
                case 2: after= money*Current.ruble;break;
                case 3: after= money*Current.euro;break;
                case 4: after= money*0.098;break;
                case 5: after= money*7.48;break;
                case 6: after= money*0.91;break;
            }
            return after;
        }
        public static double Salary(int Profession)
        {
            double Money=0;
            switch(Profession)
            {
                case 1:Money=1200;break;
                case 2:Money=24000;break;
                case 3:Money=2400;break;
                case 4:Money=3600;break;
            }
            return Money;
        }
    }
    public class Converter
    {
        public double som { get; set; }
        public double dollar { get; set; }
        public double euro { get; set; }
        public double ruble { get; set; }
        public Converter(double usd, double eur, double rub) { dollar = usd; euro = eur; ruble = rub; }
    }
    public class Employee
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Profession{get;set;}
        public int Expirience{get;set;}
    }
}