﻿using System;

namespace CenturiesToMin
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            ushort years = 0;
            uint days = 0;
            ulong hours = 0;
            ulong minutes = 0;

            //years = centuries * 100
            //days = years * 365.2422 
            //minutes = (days * 24) * 60

            years = (ushort)(centuries * 100);
            days = (uint)(years * 365.2422);
            hours = days * 24;
            minutes = hours * 60;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} = {minutes} minutes");
        }
    }
}
