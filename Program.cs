// See https://aka.ms/new-console-template for more information
using System;
namespace Calculator
{
    class Program
    {
        static void Main()
        {
           const float pi=3.14f;
            Console.WriteLine("Enter values:");
            Console.Write("First number: ");
            string firstUserValue=Console.ReadLine();
            Console.Write("Second number: ");
            string secondUserValue=Console.ReadLine();
            decimal firstNumber = Convert.ToDecimal(firstUserValue);
            decimal secondNumber = Convert.ToDecimal(secondUserValue);
            Console.WriteLine("Here your answers:");
            Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber+secondNumber}");
            Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber-secondNumber}");
            Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber*secondNumber}");
            Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber/secondNumber}");
            Console.WriteLine($"{firstNumber} % {secondNumber} = {firstNumber%secondNumber}");

        }
    }
    
}