using System;

namespace FindTheArtist
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Where is the Artist?";

            Music musicClass = new Music();
            musicClass.Run();
        }
    }
}
