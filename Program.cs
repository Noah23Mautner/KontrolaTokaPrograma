using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontrolaTokaPrograma4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite cijenu bez PDV-a:");
            decimal cijenaBezPDVa = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Unesite cijenu s PDV-om:");
            decimal cijenaSPDVom = decimal.Parse(Console.ReadLine());

            decimal iznosPDVa = IzracunajPDV(cijenaBezPDVa, cijenaSPDVom);
            Console.WriteLine("Iznos PDV-a je: " + iznosPDVa);

            decimal stopaPDVa = IzracunajStopuPDVa(cijenaBezPDVa, iznosPDVa);
            Console.WriteLine("Stopa PDV-a je: " + stopaPDVa + "%");
        }

        static decimal IzracunajPDV(decimal cijenaBezPDVa, decimal cijenaSPDVom)
        {
            return cijenaSPDVom - cijenaBezPDVa;
        }

        static decimal IzracunajStopuPDVa(decimal cijenaBezPDVa, decimal iznosPDVa)
        {
            return (iznosPDVa / cijenaBezPDVa) * 100;
        }
    }
    

}
