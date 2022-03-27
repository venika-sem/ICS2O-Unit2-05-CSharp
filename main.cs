// Created by: Venika Sem
// Created on: Mar 2022
//
// This program does calculations

using System;

class Program
{
    public static void Main(string[] args)
    {
       // This function calculates the pay and government tax of the user
        float numberOfHours;
        float hourlyPay;

        Console.WriteLine("Please enter your employment information:");
        Console.WriteLine("");
      
        Console.WriteLine("Number of hours worked: ");
        numberOfHours = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Hourly rate: ");
        hourlyPay = Convert.ToSingle(Console.ReadLine());
      
        Console.WriteLine("");
        Console.WriteLine("Your pay will be $" + ((numberOfHours * hourlyPay) * (1 - 0.18)).ToString("0.00") + ", and the government will take $" + ((numberOfHours * hourlyPay) * 0.18).ToString("0.00") + ".");

        Console.WriteLine("\nDone.");
    }
}