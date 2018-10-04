using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EndUserApp.perxMusic;

namespace EndUserApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Music prxm = new Music();
           
            Console.WriteLine("Qual o numero da musica");
            int number = Int32.Parse(Console.ReadLine());
            var result = prxm.getMusicByNumber(number);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
