using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheArtist
{
    class Genre
    {
        public string Tempo;
        public string Style;
        public string Name;
        public int Bpm;

        public Genre()
        {

        }
        public Genre(string passedInName, string passedInTempo, string passedInStyle, int passedInBpm)
        {
            Name = passedInName;
            Tempo = passedInTempo;
            Style = passedInStyle;
            Bpm = passedInBpm;
        }
        public void Describe()
        {
            Console.WriteLine("Name: "+ Name);
            Console.WriteLine("Tempo: " + Tempo);
            Console.WriteLine("Style: " + Style);
            Console.WriteLine("Bpm: " + Bpm);

            
        }
    }
}
