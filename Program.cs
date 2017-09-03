using System;

namespace Problem01_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.Clear();
             //Print what the program will do
			 Console.WriteLine("This Program will as for two numbers and see which one is greater!");
             // Make two variables for number storage
             var num1 = 0;
             var num2 = 0;
             //Print please enter first number
             Console.WriteLine("Please type in your first number");
             //Check if number
             var isNumber = int.TryParse(Console.ReadLine(), out num1);
            // Print please enter second number
            Console.WriteLine("Please type in your second number");
            // Check if number
             var Number = int.TryParse(Console.ReadLine(), out num2);
            // If is fisrt number print num1 is greater
             if(isNumber){
                 Console.WriteLine($"Number 1, {num1} is greater then number 2, {num2}");
                 }
                 //Else Second number is greater
                 else{
                     Console.WriteLine($"number 2, {num2} is greater then number 1, {num1}");
                 }
                

             




            
			Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();
        }
    }
}
