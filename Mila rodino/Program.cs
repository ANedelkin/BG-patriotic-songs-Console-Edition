using System;
using System.IO;

namespace Mila_rodino
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 220, b = 247, c = 262, d = 294, e = 330, f = 349, g = 392;
            int[] sounds =
            {
                37, 100,
                a, 500,
                d, 400,
                d, 200,
                e, 200,
                f, 400,
                e, 200,
                d, 800,
                a, 400,
                d, 400,
                d, 200,
                e, 200,
                f, 400,
                e, 200,
                d, 800,
                a, 400,
                d, 400,
                d, 200,
                e, 200,
                g, 400,
                f, 200,
                e, 400,
                d, 400,
                c, 400,
                d, 200,
                c, 400,
                b, 400,

                a, 300,
                c, 200,
                d, 200,
                e, 200,
                f, 200,
                g, 200,
                g + 30, 400,
                g, 400,
                f, 300,
                g, 200,
                g + 30, 1200,
                g, 400,
                f, 400,
                e, 200,
                d, 200,
                f, 400,
                g, 800,    

                g, 400,
                f, 400,
                e, 200,
                d, 200,
                c, 400,
                d, 400,
                c, 200,
                b, 200,
                a, 400,
                b, 400,
                a, 300,
                e, 200,
                g, 1000,
            };
            for (int i = 0; i < sounds.Length - 1; i+=2) { Console.Beep(sounds[i] * 4, sounds[i + 1] * 3); }
        }
    }
}
