using DeloitteFeladat.Models;
using DeloitteFeladat.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeloitteFeladat.Controllers
{
    internal class InputController
    {
        private readonly InputService _inputService;
        private readonly NumberService _numberService;
        private readonly TextService _textService;

        public InputController()
        {
            _inputService = new InputService();
            _numberService = new NumberService();
            _textService = new TextService();
        }

        public void Run(int itemCount)
        {

            var inputs = _inputService.GetInputs(itemCount);

            int numCount = 0, textCount = 0;
            foreach (var input in inputs)
            {
                if (input is NumberInput number)
                {
                    if (numCount == 0) Console.WriteLine("\nNumbers:");
                    _numberService.PrintProcessed(number);
                    numCount++;
                }
            }
            foreach (var input in inputs)
            {
                if (input is TextInput text)
                {
                    if (textCount == 0) Console.WriteLine("\nTexts:");
                    _textService.PrintProcessed(text);
                    textCount++;
                }
            }
        }
    }
}
