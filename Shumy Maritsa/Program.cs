using System;

namespace urrraaaaaaaaaaaaaaaa
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 220, b = 247, c = 262, d = 294, e = 330, f = 349, g = 392;
            int[] sounds = 
                { e, 800,
                  d, 400,
                  e, 400,
                  f, 800,
                  e, 800,
                  c, 800,
                  b, 400,
                  c, 400,
                  e, 800,
                  d, 800,
                  b, 800,
                  c, 400,
                  d, 400,

                  f, 800,
                  e, 400,
                  e, 400,
                  d, 400,
                  c, 400,
                  b, 400,
                  a, 400,
                  37, 400,
                  e, 1600,
                  37, 400,
                  g, 1600,

                  g, 400,
                  g + 30, 400,
                  f, 400,
                  d, 400,
                  g, 800,
                  f, 800,
                  b, 800,
                  c, 400,
                  d, 400,
                  f, 800,
                  37, 200,
                  e, 400,

                  e, 400,
                  d, 400,
                  c, 400,
                  b, 400,
                  a, 1600,
                  a, 400,
                  a, 400,
                  a, 400,
                  a, 400
            };
            for (int i = 0; i < sounds.Length - 1; i += 2) { Console.Beep(sounds[i] * 4, sounds[i + 1]); }
        }
    }
}
