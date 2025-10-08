using DeloitteFeladat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeloitteFeladat.Services
{
    internal class InputService
    {
        private readonly NumberService _numberService = new();
        private readonly TextService _textService = new();

        public List<object> GetInputs(int count)
        {
            var inputs = new List<object>();
            int i = 0;
            while (i < count)
            {
                Console.WriteLine($"Item {i + 1}/{count}: Would you like to enter a number or text? (n/t)");
                string choice = Console.ReadLine()?.Trim().ToLower();
                if (choice == "n")
                {
                    Console.Write("Enter a number (10-9999): ");
                    string input = Console.ReadLine();
                    if (_numberService.TryParse(input, out var number))
                    {
                        inputs.Add(number);
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("Invalid number! Please try again.");
                    }
                }
                else if (choice == "t")
                {
                    Console.Write("Enter text (5-45 characters): ");
                    string input = Console.ReadLine();
                    if (_textService.TryParse(input, out var text))
                    {
                        inputs.Add(text);
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("Invalid text! Please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Only 'n' or 't' are possible answers!");
                }
            }
            return inputs;
        }
    }
}
