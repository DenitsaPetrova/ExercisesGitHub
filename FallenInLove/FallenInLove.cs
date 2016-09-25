using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class FallenInLove
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var MidDots = 2;
            var OutDots = 2*n-2;
//1vi red
            var Dot = new string('.', 4 * n/2);
            Console.WriteLine("##{0}##{0}##",Dot);
//1va chast ot cveteto
            for (int i = 1; i <= n - 1; i++)
            {
                var wave = new string('~', i);
                var Middle = new string('.', MidDots);
                var Out = new string('.', OutDots);
                Console.WriteLine("#{0}#{1}#{2}#{1}#{0}#",wave,Out,Middle );
                MidDots += 2;
                OutDots -= 2;
            }          
            OutDots = 1;
            for (int a = n; a >= 1; a--)
            {
                var wave = new string('~', a);
                var Middle = new string('.', MidDots);
                var Out = new string('.', OutDots);
                Console.WriteLine("{0}#{1}#{2}#{1}#{0}", Out, wave, Middle);
                MidDots -= 2;
                OutDots += 2;
            }
// sredna chast
            var MiddlePoints = new string('.', 2 * n + 1);
            Console.WriteLine("{0}####{0}", MiddlePoints);

 //posledni redove
                for (int j = 1; j <= n; j++)
                {
                    var Dots = new string('.', 2 * n + 2);
                    Console.WriteLine("{0}##{0}", Dots);
                }
        }
    }

