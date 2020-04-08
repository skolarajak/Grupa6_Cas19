using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas19
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestIfs();
            //TestSwitch();
            //Test1();
            //TestIf2();
            //Test2();
            Test3b();
            Console.ReadKey();
        }

        static void Test3b()
        {
            int a = 230;            int b = 135;

            if ((a + b) < 100)
            {
                Console.WriteLine("Zbir a i b je manji od 100");
            }
            if ((a + b) > 100)
            {
                Console.WriteLine("Zbir a i b je veci od 100");
            }
            if ((a + b) > 200)
            {
                Console.WriteLine("Zbir a i b je veci i od 200");
            }
        }

        static void Test3()
        {
            int a = 230;            int b = 135;

            if ((a + b) < 100)            {                Console.WriteLine("Zbir A i B je manji od 100");            } else if ((a + b) > 100)
            {
                Console.WriteLine("Zbir A i B je veci od 100");
                if ((a + b) > 200)
                {
                    Console.WriteLine("Zbir A i B je veci i od 200");
                }
            }            Console.WriteLine("Zbir A i B iznosi: {0}", (a + b));        }

        static void Test2()
        {
            int a = 7;            if (a > 50)            {                Console.WriteLine("A je vece od 50");            }            else if (a > 20)            {                Console.WriteLine("A je vece od 20");            }            else if (a > 10)            {                Console.WriteLine("A je vece od 10");            }            else            {                Console.WriteLine("Vrednost A je: {0}", a);                Console.ReadKey();            }
        }

        static void TestIf2()
        {
            int a = 2, b = 70, c = 19;

            if (a > b)
            {
                Console.WriteLine("A je vece od B");
            }
            else
            {
                Console.WriteLine("B je vece od A");
                if (b > c)
                {
                    Console.WriteLine("B je vece od C");
                }
            }
            Console.WriteLine("Vrednost A je; {0},vrednost B je:{1}, vrednost C je:{2}", a, b, c);
        }

        static void Test1()
        {
            int a = 10;            int b = 150;            int c = 25;            if (b > c)
            {                if (a > b)                {                    Console.WriteLine("A je vece od B");                }                else                {                    Console.WriteLine("B je vece od A");                }            }            else            {                Console.WriteLine("B je manji od C");            }
            Console.WriteLine("Vrednost A je; {0},vrednost B je:{1}, vrednost C je:{2}", a, b, c);        }

        static void TestIfs()
        {
            int a = 10, b = 0;

            if ((a > 0) && (b > 0))
            {
                if (a == b)
                {
                    Console.WriteLine("A je jednako B");
                }
                else if (a > b)
                {
                    Console.WriteLine("A je vece od B");
                }
                else
                {
                    Console.WriteLine("B je vece od A");
                }
            }
            else if (a == 0)
            {
                Console.WriteLine("A je nula.");
            }
            else
            {
                Console.WriteLine("Neki od brojeva je 0.");
            }
            Console.WriteLine("Vrednost A je: {0}, vrednost B je: {1}", a, b);
        }

        static void TestSwitch()
        {
            int a = 10;

            switch(a)
            {
                case 1:
                    Console.WriteLine("A je jednako 1");
                    break;
                case 2:
                    Console.WriteLine("A je jednako 2");
                    break;
                default:
                    Console.WriteLine("A je vece od 2");
                    break;
            }
        }
    }
}
