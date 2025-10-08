using DeloitteFeladat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeloitteFeladat.Services
{
    internal class TextService
    {
        private const string ExtraText = "Making an impact that matters –Deloitte";

        public bool TryParse(string input, out TextInput text)
        {
            text = null;
            if (input.Length >= 5 && input.Length <= 45)
            {
                text = new TextInput(input);
                return true;
            }
            return false;
        }

        public void PrintProcessed(TextInput input)
        {
            int length = input.Text.Length;
            string extra = ExtraText.Substring(0, Math.Min(length, ExtraText.Length));
            Console.WriteLine($"{input.Text} - {extra}");
        }
    }
}
