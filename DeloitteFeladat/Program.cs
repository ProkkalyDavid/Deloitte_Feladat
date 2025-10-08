using DeloitteFeladat.Controllers;
using DeloitteFeladat.Models;
using DeloitteFeladat.Services;

namespace DeloitteFeladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var controller = new InputController();
            controller.Run(7);
        }
    }
}
