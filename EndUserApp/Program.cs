using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EndUserApp.perxLyrics;
using EndUserApp.perxMusic;

namespace EndUserApp
{
    class Program
    {
        /* 1- Add a service reference
           2- Advance
           3- Add web reference, paste the link to the service.
        */
        static void Main(string[] args)
        {
            Music prxm = new Music();
            Lyrics prxl = new Lyrics();

            Console.WriteLine("Qual o numero da musica");
            int number = Int32.Parse(Console.ReadLine());

            MusicPair music = prxm.getMusicByNumber(number);
            Console.WriteLine("Author: {0}", music.autor);
            Console.WriteLine("Song: {0} \n", music.song);

            var lyrics = prxl.getLyrics(music.autor, music.song);
            Console.WriteLine(lyrics);

            Console.ReadLine();
        }
    }
}
