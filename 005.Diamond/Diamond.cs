using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005.Diamond
{
    class Diamond
    {
        static void Main()
        {
            //TUPOTIQ BRAT
            var n = int.Parse(Console.ReadLine());
            var points = new string('.', n );
            var star = new string('*', 3 * n );
            var MidSpace = 3*n;
            Console.WriteLine("{0}{1}{0}", points, star);

            for (int i = 1; i <= n - 1; i++)
            {
                var point = new string('.', n-i);
                var Midpoint = new string('.', MidSpace);
                Console.WriteLine("{0}*{1}*{0}", point,Midpoint );
                MidSpace += 2;
            }
            Console.WriteLine(new string('*', 5*n));
            MidSpace -= 2;

            for (int j = 1; j <= 2 * n ; j++)
            {
                var outPoint = new string('.',  j);
                var Midpoint = new string('.', MidSpace);
                Console.WriteLine("{0}*{1}*{0}", outPoint, Midpoint);
                MidSpace -= 2;

            }
            var outPoints = new string('.', 2 * n+1);
            var stars = new string('*', n-2);
            Console.WriteLine("{0}{1}{0}", outPoints,stars );
        }
    }
}
