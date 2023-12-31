using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Set1_Probleme_Vonhala_Raul
{
    internal class Program
    {
        static void Prob1()
        {
            float a, b, x;
            x = 0;
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            if (a == 0 && b == 0)
                Console.WriteLine("Ecuatia are o infinitate de solutii");
            else
                if (a == 0 && b != 0)
                Console.WriteLine("Ecuatia nu este posibila");
            else
            {
                x = b * (-1) / a;

            }
            Console.WriteLine($"Solutia este {x} ");
            Console.ReadKey();
        }
        static void Prob2() 
        {
            float a, b, c, delta;
            a= float.Parse(Console.ReadLine());
            b= float.Parse(Console.ReadLine());
            c= float.Parse(Console.ReadLine());
            double x1, x2;
            delta = (b * b) - (4 * a * c);
            if (a == 0 && b == 0 && c == 0)
                Console.WriteLine("Ecuatia are o infinitate de solutii");
            if (a == 0 && b == 0 && c != 0)
                Console.WriteLine("Ecuatia nu are solutii");
            if (a == 0 && b != 0)
            {
                x1 = b * (-1) / a;
                Console.WriteLine($"Solutia este {x1}");
            }
            if(a!=0)
            {
                if (delta < 0)
                {
                    Console.WriteLine("Ecuatia nu are solutii reale");
                }

                else
                {
                    if (delta == 0)
                    {
                        x1 = (b * (-1) + (Math.Sqrt(delta))) / (2 * a);
                        Console.WriteLine($"Solutia este unica egala cu {x1}");
                    }
                    else
                    {
                       

                        x1 = (b * (-1) + (Math.Sqrt(delta))) / (2 * a);
                        
                        x2 = (b * (-1) - (Math.Sqrt(delta))) / (2 * a);
                        Console.WriteLine($"Solutiile ecuatiei sunt {x1} si {x2}");
                    }
                }
                
            }
            
            Console.ReadKey();

        }
        static void Prob3()
        {
            int n, k;
            Console.WriteLine("Introduceti un numar ");
            n=int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti un numar cu care se divide sau nu ");
            k=int.Parse(Console.ReadLine());
            if (n % k == 0)
                Console.WriteLine($"Numarul {n} se divide exact cu {k}");
            else
                Console.WriteLine($"Numarul {n} nu se divide exact cu {k}");
            Console.ReadKey();
        }

        static void Prob4()
        {
            int y;
            Console.WriteLine("Introduceti un an ");
            y=int.Parse(Console.ReadLine());
            if ((y % 400 == 0 || (y % 4 == 0 && y % 100 != 0)))
                Console.WriteLine($"Anul {y} este bisect");
            else
                Console.WriteLine($"Anul {y} nu este bisect");
            Console.ReadKey();


        }
        static void Prob5()
        {
            Console.WriteLine("Introduceti un numar ");
            string n = Console.ReadLine();
            Console.WriteLine("Introduceti pozitia k ");
            int k = int.Parse(Console.ReadLine());
            if (k >= 1 && k <= n.Length)
            {
                char cif = n[n.Length - k];
                Console.WriteLine(cif);
            }
            else
                Console.WriteLine("Valoarea lui k nu este buna");
            Console.ReadKey();
      
        }

        static void Prob6()
        {
            float a, b, c;
            a=float.Parse(Console.ReadLine());
            b=float.Parse(Console.ReadLine());
            c=float.Parse(Console.ReadLine());
            if (a + b > c && a + c > b && b + c > a)
                Console.WriteLine("Aceste numere pot fi laturile unui triunghi");
            else
                Console.WriteLine("Aceste numere nu pot fi laturile unui triunghi");
            Console.ReadKey();
        }

        static void Prob7()
        {
            float a, b, aux;
            aux = 0;
            a=float.Parse(Console.ReadLine());
            b=float.Parse(Console.ReadLine());
            aux = a;
            a = b;
            b = aux;
            Console.WriteLine($"Numerele inversate sunt {a} si {b}");
            Console.ReadKey();

        }

        static void Prob8()
        {
            float a, b;
            a=float.Parse(Console.ReadLine());
            b=float.Parse(Console.ReadLine());
            (a, b) = (b, a);
            Console.WriteLine($"Numerele inversate sunt {a} si {b}");
            Console.ReadKey();
        }

        static void Prob9()
        {
            int n, d = 1;
            n=int.Parse(Console.ReadLine());
            for (d = 1; d <= n; d++)
            {
                if (n % d == 0)
                {
                    Console.WriteLine($"Divizorul numarului este {d}");
                }
            }
            Console.ReadKey();
                

        }

        
        static void Prob10()
        {
            int n;
            n=int.Parse (Console.ReadLine());
            bool ok=true;
            if (n < 2)
                ok = false;
            for (int d = 2; d*d<= n; d ++)
                if (n % d == 0)
                    ok = false;
                else
                    ok = true;
            if(ok)
                Console.WriteLine($"Numarul {n} este prim");
            else
                Console.WriteLine($"Numarul {n} nu este prim");
            Console.ReadKey();
            
        }

        static void Prob11()
        {
            int n,cif;
            cif = 0;
            n=int.Parse (Console.ReadLine()); 
            while(n!=0)
            {
                cif =cif*10+ n % 10;
                
                n = n / 10;
            }
            Console.WriteLine($"Inversul numarului dat este {cif}");
            Console.ReadKey();


        }

        static void Prob12()
        {
            int a, b, n, nr;
            
            nr = 0;
            Console.WriteLine("Introduceti intervalul ");
            a=int.Parse (Console.ReadLine());
            b=int.Parse (Console.ReadLine());
            Console.WriteLine("Introduceti n ");
            n=int.Parse(Console.ReadLine());
            for(int i=a;i<=b;i++)
            {
                
                if (i % n == 0)
                    nr++;

                
            }
            Console.WriteLine($"Sunt {nr} numere divizibile cu n din intervalul dat");
            Console.ReadKey();

        }

        static void Prob13()
        {
            int y1, y2,nr;
            nr = 0;
            y1=int.Parse (Console.ReadLine());
            y2=int.Parse (Console.ReadLine());
            for(int i=y1+1;i<y2;i++)
            {
                if ((i % 400 == 0 || (i % 4 == 0 && i % 100 != 0)))
                    nr++;
            }
            Console.WriteLine($"Intre anii {y1} si {y2} sunt {nr} ani bisecti");
            Console.ReadKey();
        }

        static void Prob14()
        {
            int n, cif;
            cif = 0;
            n=int.Parse((Console.ReadLine ()));
            int aux = n;
            while(n!=0)
            {
                cif = cif * 10 + n % 10;
                n = n / 10;
            }
            if (cif == aux)
                Console.WriteLine($"Numarul {aux} este palindrom");
            else
                Console.WriteLine($"Numarul {aux} nu este palindrom");
            Console.ReadKey();
                
            
        }

        static void Prob15()
        {
            int a, b, c;
            a = int.Parse((Console.ReadLine()));
            b= int.Parse((Console.ReadLine()));
            c = int.Parse((Console.ReadLine()));
            if (a > b && a > c && b > c)
                Console.WriteLine($"Ordinea crescatoare a numerelor este {c} {b} {a}");
            if(a>b && a>c && c>b)
                Console.WriteLine($"Ordinea crescatoare a numerelor este {b} {c} {a}");
            if(a>b && a<c && c>b)
                Console.WriteLine($"Ordinea crescatoare a numerelor este {b} {a} {c}");
            if(a<b && b<c && a<c)
                Console.WriteLine($"Ordinea crescatoare a numerelor este {a} {b} {c}");
            if(a<b && a>c && c<b)
                Console.WriteLine($"Ordinea crescatoare a numerelor este {c} {a} {b}");
            if(a<b && a<c && c<b)
                Console.WriteLine($"Ordinea crescatoare a numerelor este {a} {c} {b}");
            Console.ReadKey();

        }

        static void Prob16()
        {
            int a, b, c, d, e;
            a=int.Parse((Console.ReadLine()));
            b=int.Parse((Console.ReadLine())); 
            c=int.Parse((Console.ReadLine()));
            d=int.Parse((Console.ReadLine()));
            e=int.Parse((Console.ReadLine()));
            int aux;
            if(a>b)
            {
                aux = a;
                a = b;
                b = aux;
            }
            if(b>c)
            {
                aux = b;
                b = c;
                c = aux;
            }
            if(c>d)
            {
                aux = c;
                c = d;
                d = aux;
            }
            if(d>e)
            {
                aux = d;
                d = e;
                e = aux;
            }
            if(a>b)
            {
                aux = a;
                a = b;
                b = aux;
            }
            if(b>c)
            {
                aux = b;
                b = c;
                c = aux;
            }
            if(c>d)
            {
                aux = c;
                c = d;
                d = aux;
            }
            Console.WriteLine($"Numerele ordonate crescator sunt {a} {b} {c} {d} {e}");
            Console.ReadKey();
        }


        static int cmmdc(int x,int y)
        {
            while (y != 0)
            {
                int r = y;
                y = x % y;
                x= r;
            }
            return x;
        }
        static int cmmmc(int x,int y)
        {
            int aux1, aux2;
            aux1 = x;
            aux2 = y;
            while(aux1!=aux2)
            {
                if (aux1 < aux2)
                    aux1 = aux1 + x;
                if (aux2 < aux1)
                    aux2 = aux2 + y;
            }
            return aux1;
        }
        static void Prob17()
        {
            int x, y;
            x=int.Parse(Console.ReadLine());
            y=int.Parse(Console.ReadLine());
            Console.WriteLine($"Cmmdc al numerelor este {cmmdc(x, y)}, iar cmmmc este {cmmmc(x, y)}");
            Console.ReadKey();
            

        }

        static void Prob18()
        {
            int n, d, e;
            n=int.Parse(Console.ReadLine());
            d = 2;
            while(n!=1)
            {
                e = 0;
                while(n%d==0)
                {
                    e++;
                    n = n / d;

                }
                if (e > 0)
                    Console.WriteLine($"{d} ^ {e}");
                d++;
            }
            Console.ReadKey();
        }

        static void Prob19()
        {
            string n;
            n= Console.ReadLine();
            int verif = 0;
            for(int i=1;i<=n.Length;i++)
            {
                
                verif=n.Distinct().Count();
                
            }
            if (verif > 2)
                Console.WriteLine("Numarul nu este bun");
            else
                Console.WriteLine("Numarul este bun");

            Console.ReadKey();
        }


        static bool verif(int n)
        {
            while (n % 2 == 0)
                n = n / 2;
            while (n % 5 == 0)
                n = n / 5;
            return n == 1;
        }
        static void Prob20()
        {
            int m, n;
            Console.Write("Introduceti numaratorul ");
            m = int.Parse(Console.ReadLine());
            Console.Write("Introduceti numitorul ");
            n=int.Parse(Console.ReadLine());
            if (verif(n))
                Console.WriteLine($"Fractia {m}/{n} este egala cu {1.0 * m / n}");
            else
            {
                Console.Write($"Fractia {m}/{n} este egala cu 0.");
                int[] pozr = new int[n];
                for (int i = 0; i < n; i++)
                    pozr[i] = -1;
                int parteintreaga = m / n;
                Console.Write(parteintreaga);
                int r = m % n;
                while (r != 0 && pozr[r] == -1)
                {
                    pozr[r] = Console.CursorLeft;
                    r = r * 10;
                    Console.Write(r / n);
                    r = r % n;
                }
                if (r != 0)
                {
                    Console.Write(')');
                    Console.SetCursorPosition(pozr[r], Console.CursorTop);
                    Console.Write('(');
                }
                Console.WriteLine();
            Console.ReadKey();

            }

        }

        static void Prob21()
        {
            int minim = 1;
            int maxim = 1024;
            int x;
            Console.WriteLine("Alegeți un număr între 1 și 1024.");
            Console.WriteLine("Voi încerca să ghicesc numărul folosind întrebări.");
            do
            {
                x = (minim + maxim) / 2;
                Console.Write($"Numărul este mai mare sau egal decât {x}?");
                string rasp = Console.ReadLine();
                if (rasp.ToLower() == "da")
                {
                    minim = x + 1;
                }
                else if (rasp.ToLower() == "nu")
                {
                    maxim = x;
                }
                else
                {

                }
            } while (minim < maxim);
            Console.WriteLine($"Numarul pe care l-ati ales este: {minim}");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {

            //Prob1();
            //Prob2();
            //Prob3();
            //Prob4();
            //Prob5();
            //Prob6();
            //Prob7();
            //Prob8();
            //Prob9();
            //Prob10();
            //Prob11();
            //Prob12();
            //Prob13();
            //Prob14();
            //Prob15();
            //Prob16();
            //Prob17();
            //Prob18();
            //Prob19();
            Prob20();
            //Prob21();

            
        }
    }
}
