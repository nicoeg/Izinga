using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzingaTimeTracking {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("ID til projekt?");
            int projetID = int.Parse(Console.ReadLine());
            Console.WriteLine("ID til område?");
            int areaID = int.Parse(Console.ReadLine());
            Console.WriteLine("Antal timer?");
            double hours = double.Parse(Console.ReadLine());
            Console.WriteLine("Evt. Kommentarer?");
            string comment = Console.ReadLine();

            Console.WriteLine("Du har arbejdet på projekt: " + projetID);
            Console.WriteLine("Du har arbejdet med: " + areaID);
            Console.WriteLine("Du har arbejdet i: " + hours + " timer");
            Console.WriteLine("Kommentar: " + comment);

            Console.ReadKey();
        }
    }
}
