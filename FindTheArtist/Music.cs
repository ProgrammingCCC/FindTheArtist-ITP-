using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheArtist
{
    class Music
    {
        int Artists = 0;
        int ArtistsGiven = 0;

        public void Run()
        {
            Console.Clear();

            Title();
            Menu();

            Console.ReadLine();
            Run();
        }
        private void Title()
        {
            Console.WriteLine("Find the Artist");
            Console.WriteLine("A thrilling adventure game");
            Console.WriteLine("By Neil and the Intro To Programming Class");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("press any key to continue...");
            Console.ReadKey();
        }
        private void HUD()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Artists: " + Artists + " Artists Given: " + ArtistsGiven);
            Console.WriteLine("--------------------------------------------------");
        }
        private void Menu()
        {
            Console.Clear();
            HUD();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Find artist (type find)");
            if (Artists >0)
            {
                Console.WriteLine("Give artist (type give)");
            }
            string input = Console.ReadLine();
            if (input.ToLower() == "find")
            {
                Artists++;
            }
            else if ((Artists > 0) && (input.ToLower() == "give"))
            {
                Artists--;
                ArtistsGiven++;
            }
            else {
                Menu();
            }
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
            Menu();

            //Console.WriteLine("Please pick a Genre");
            //Console.WriteLine("A) Rock");
            //Console.WriteLine("B) Jazz");
            //Console.WriteLine("C) R&B");

            //string input = Console.ReadLine();

            //if (input.ToUpper() == "A")
            //{
            //    Genre rockGenre = new Genre();
            //    rockGenre.Name = "Rock";
            //    rockGenre.Tempo = "Fast";
            //    rockGenre.Style = "Alternative";
            //    rockGenre.Bpm = 140;

            //    rockGenre.Describe();

            //}
            //else if (input.ToUpper() == "B")
            //{
            //    Genre jazzGenre = new Genre("Jazz","Medium Swing","Smooth",200);
            //    jazzGenre.Describe();
            //}
            //else if (input.ToLower() == "c")
            //{

            //    Genre rbGenre = new Genre("R&B","Slow Jams","Easy",88);
            //    rbGenre.Describe();
            //}
            //else
            //{
            //    Run();
            //}

            //switch (input.ToUpper())
            //{
            //    case "A":
            //        Console.WriteLine("Rock and Roll Dude");
            //        break;
            //    case "B":
            //        Console.WriteLine("Jazz Cats");
            //        break;
            //    case "C":
            //        Console.WriteLine("R&B Slow Jams");
            //        break;
            //    default:
            //        Run();
            //        break;
            //}
        }

    }
}
