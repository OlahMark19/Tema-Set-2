using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tema_Set_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar de la 1 la 17 pentru selectarea unei probleme: ");
            switch (Console.ReadLine())
            {
                case "1":
                    P1();
                    break;
                case "2":
                    P2();
                    break;
                case "3":
                    P3();
                    break;
                case "4":
                    P4();
                    break;
                case "5":
                    P5();
                    break;
                case "6":
                    P6();
                    break;
                case "7":
                    P7();
                    break;
                case "8":
                    P8();
                    break;
                case "9":
                    P9();
                    break;
               case "10":
                    P10();
                    break;
                case "11":
                    P11();
                    break;
                case "12":
                    break;
                case "13":
                    P13();
                    break;
                case "14":
                    P14();
                    break;
                case "15":
                    P15();
                    break;
                case "16":
                    P16();
                    break;
                case "17":
                    P17();
                    break;

            }                        
        }
        private static void P1()
        {
            Console.WriteLine("Introduceti lungimea secventei: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            Console.WriteLine($"Introduceti cele {n} numere: ");
            for (int i = 0; i < n; i++)
            {
                int j = Convert.ToInt32(Console.ReadLine());
                if (j % 2 == 0)
                {
                    k++;
                }
            }
            if (k == 1)
            {
                Console.WriteLine("Un singur numar este par");
            }
            else
            {
                Console.WriteLine($"{k} numere sunt pare");

            }
            Console.ReadKey();
        }
        private static void P2()
        {
            Console.Write("Introduceti lungimea secventei: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int j = 0;
            int k = 0;
            int l = 0;

            Console.WriteLine($"Introduceti cele {n} numere");

            for (int i = 0; i < n; i++)
            {
                int m = Convert.ToInt32(Console.ReadLine());
                if (m < 0)
                {
                    j++;
                }
                else if (m == 0)
                {
                    k++;
                }
                else if (m > 0)
                {
                    l++;
                }
            }
            Console.WriteLine($"In secventa data, sunt {j} numere negative, {k} numere egale cu zero, {l} numere pozitive");
            Console.ReadKey();
        }
        private static void P3()
        {
            Console.Write("Introduceti un numar n: ");
            int n = int.Parse(Console.ReadLine()), s = 0, p = 1;
            for (int i = 1; i <= n; i++)
            {
                s = s + i;
                p = p * i;
            }
            Console.WriteLine($"Suma: {s} Produsul: {p}");
            Console.ReadKey();
        }
        private static void P4()
        {
            Console.Write("Introduceti lungimea secventei: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduceti numarul la care doriti sa aflati pozitia: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Introduceti cele {n} numere: ");
            bool ok = false;
            for (int i = 0; i < n; i++)
            {
                int k = Convert.ToInt32(Console.ReadLine());
                if (k == a)
                {
                    Console.WriteLine($"Numarul {a} se afla pe pozitia {i}");
                    ok = true;
                }
            }
            if (ok == false)
            {
                Console.WriteLine($"Numarul {a} se afla pe pozitia -1");
            }
            Console.ReadKey();
        }
        private static void P5()
        {
            Console.Write("Introduceti lungimea secventei: ");
            int n = Convert.ToInt32(Console.ReadLine()), m = 0;

            Console.WriteLine($"Introduceti cele {n} numere: ");
            for (int i = 0; i < n; i++)
            {
                int k = int.Parse(Console.ReadLine());
                if (k == i)
                {
                    m++;
                }
            }
            Console.WriteLine($"{m} elemente sunt egale cu pozitia lor");
            Console.ReadKey();
        }
        private static void P6()
        {
            int aux = 0, Counter1 = 0, Counter2 = 0;

            Console.Write("Introduceti lungimea secventi: ");
            int n = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"Introduceti cele {n} numere: ");
            for (int i = 0; i < n; i++)
            {
                Counter1++;
                int m = Convert.ToInt32(Console.ReadLine());
                if (aux < m)
                {
                    Counter2++;
                }
                aux = m;
            }
            if (Counter1 == Counter2)
            {
                Console.WriteLine("Sunt in ordine crescatoare!");
            }
            else
            {
                Console.WriteLine("Nu sunt in ordine crescatoare!");

            }
            Console.ReadKey();
        }
        private static void P7()
        {
            int minaux = int.MaxValue, maxaux = 0;

            Console.Write("Introduceti lungimea secventei: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Introduceti cele {n} numere: ");
            for (int i = 0; i < n; i++)
            {
                int k = Convert.ToInt32(Console.ReadLine());
                if (k < minaux)
                {
                    minaux = k;
                }
                else if (k > maxaux)
                {
                    maxaux = k;
                }
            }
            Console.WriteLine($"Valoarea minima din secventa este {minaux}\nValoarea maxima din secventa este {maxaux}.");
            Console.ReadKey();
        }
        private static void P8()
        {           
                int n = int.Parse(Console.ReadLine());
                int x = 0, y = 1, z = 0;
                for (int i = 2; i < n; i++)
                {
                    z = x + y;
                    x = y;
                    y = z;
                }
                Console.WriteLine(z);
                Console.ReadKey();
        }
        private static void P9()
        {
            Console.Write("Introduceti lungimea secventei: ");
            int n = Convert.ToInt32(Console.ReadLine()), aux = 0;

            bool type = true;

            Console.WriteLine($"Introduceti cele {n} numere: ");
            for (int i = 0; i < n; i++)
            {
                int m = Convert.ToInt32(Console.ReadLine());
                if (m < aux)
                {
                    type = false;
                }
                aux = m;
            }
            if (type == false)
            {
                Console.WriteLine("Secventa este descrescatoare");
            }
            else
            {
                Console.WriteLine("Secventa este crescatoare");

            }
            Console.ReadKey();
        }
        private static void P10()
        {
            Console.WriteLine("Introduceti lungimea secventei");
            int n = int.Parse(Console.ReadLine());
            int k = 0, c1 = 1, aux = k, caux = 0;
            bool firstTime = true;
            Console.WriteLine($"Introduceti cele {n} numere: ");
            for (int i = n; i > 0; i--)
            {
                aux = k;
                k = int.Parse(Console.ReadLine());
                if (k == aux && firstTime == false)
                {
                    c1++;
                }
                else if (k != aux && c1 > caux && firstTime == false)
                {
                    caux = c1;
                    c1 = 1;
                }
                firstTime = false;
            }
            if (c1 > caux)
                Console.WriteLine($"Numarul maxim de numere consecutive egale este {c1}");
            else
                Console.WriteLine($"Numarul maxim de numere consecutive egale este {caux}");
            Console.ReadKey();
        }
        private static void P11()
        {
            double suma = 0;
            Console.WriteLine("Introduceti lungimea secventei: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Introduceti cele {n} numere: ");
            for (int i = 0; i < n; i++)
            {
                int m = Convert.ToInt32(Console.ReadLine());
                suma = Math.Pow(m, -1);

            }
            Console.WriteLine($"Suma inverselor numerelor din secventa este {suma}");
            Console.ReadKey();
        }
        private static void P12()
        {
            int counter = 0;
            Console.Write("Introduceti lungimea secventei: ");
            int n = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"Introduceti cele {n} numere:");
            int m = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n - 1; i++)
            {
                int o = Convert.ToInt32(Console.ReadLine());
                if (m != 0 && o == 0)
                {
                    counter++;
                }
                m = o;
            }
            Console.WriteLine($"In secventa sunt {counter} grupuri de numere");
            Console.ReadKey();
        }
        private static void P13()
        {
            Console.Write("Lungimea secventei: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int p = Convert.ToInt32(Console.ReadLine());
            int u = p;
            int descrescator = 0;
            for (int i = 0; i < n - 1; i++)
            {
                int k = Convert.ToInt32(Console.ReadLine());
                if (k < u || k == u)
                {
                    descrescator++;
                }
                u = k;
            }
            if (u > p)
            {
                descrescator++;
            }
            if (descrescator == 0 || descrescator == 0)
            {
                Console.WriteLine("Secventa poate fi o secventa crescatoare rotita");
            }
            else
            {
                Console.WriteLine("Secventa nu poate fi o secventa crescatoare rotita");
            }
            Console.ReadLine();
        }
        private static void P14()
        {

        }
        private static void P15()
        {

        }
        private static void P16()
        {

        }
        private static void P17()
        {

        }
    }
}
