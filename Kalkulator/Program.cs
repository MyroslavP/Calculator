using System;

namespace Kalkulator
{
    class Program
    {


        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            while (true)
            {
                ConsoleKeyInfo PKey;

                Console.WriteLine("\n\n\nFunkcjonalne menu programu: ");

                Console.WriteLine("\n\nA. Obliczanie ceny jednostki paszy (in-line) ");
                Console.WriteLine("B. Obliczanie ceny jednostki paszy (method-call) ");
                Console.WriteLine("C. Obliczanie średniej harmonicznej (in-line) ");
                Console.WriteLine("D. Obliczanie średniej harmonicznej (method-call) ");
                Console.WriteLine("E. Obliczanie średniej geometrycznej (in-line) ");
                Console.WriteLine("F. Obliczanie średniej geometrycznej (method-call) ");
                Console.WriteLine("G. Obliczanie średniej kwadratowej (in-line) ");
                Console.WriteLine("H. Obliczanie średniej kwadratowej (method-call) ");
                Console.WriteLine("I. Obliczanie średniej potegowej (in-line) ");
                Console.WriteLine("J. Obliczanie średniej potegowej (method-call) ");
                Console.WriteLine("K. Obliczanie (konwersja) znakowego zapisu liczby całkowitej w systemie liczbowym o " +
                                                          "\n\t\tpodanej (przez uzytkownika programu) podstawie liczenia (in-line) ");
                Console.WriteLine("L. Obliczanie (konwersja) znakowego zapisu liczby całkowitej w systemie liczbowym o " +
                                                          "\n\t\tpodanej (przez uzytkownika programu) podstawie liczenia (method-call) ");

                Console.WriteLine("\n\nX. Zakonczenie (wyjscie z) programu ");


                Console.Write("\n\nNacisnij klawisz pszypisany odpowiedniej funkcjonalnosci z ktorej chcesz skorzystac:  ");

                PKey = Console.ReadKey();


                if (PKey.Key == ConsoleKey.X)
                {
                    Environment.Exit(0);
                }/////X///////

                Console.Write("\n\n Jeżeli chcesz, aby program realizował obliczenia ze" + 
                    "śledzeniem, to naciśnij klawisz T (lub t), \n\ta gdy naciśniesz dowolny inny" + "klawisz, to uznam, że rezygnujesz ze śledzenia: ");


                bool Trace;
                if (Console.ReadKey().Key == ConsoleKey.T)
                Trace = true;
                else
                Trace = false;


                if (PKey.Key == ConsoleKey.A)
                {
                    Console.WriteLine("\nwpisz, ile będzie elementów ");
                    int l = int.Parse(Console.ReadLine());

                    if(Trace == true)
                    {
                        Console.WriteLine("\nTRACE:będzie"+ " " + l + " " +"elementów ");
                    }

                    float[] mpC = new float[l];
                    int mpN = mpC.Length;

                    int a = 1;
                    for (int i = 0; i < mpN; i++)
                    {
                        Console.WriteLine("\nZapisz wartośc C" + a + "(Cena 1kg),dla każdej wartości  musisz nacisnąć Enter ");
                        mpC[i] = float.Parse(Console.ReadLine());
                        
                        if (Trace == true)
                        {
                            Console.WriteLine("\nTRACE:wartośc C" + a +" "+mpC[i]);
                        }
                        a++;
                    }

                    int b = 1;
                    float[] mpM = new float[l];

                    for (int i = 0; i < mpN; i++)
                    {
                        Console.WriteLine("\nZapisz wartośc M" + b + "(Liczbak kg),dla każdej wartości  musisz nacisnąć Enter ");
                        mpM[i] = float.Parse(Console.ReadLine());

                        if (Trace == true)
                        {
                            Console.WriteLine("\nTRACE:wartośc M" + b +" "+ mpM[i]);
                        }
                        b++;
                    }

                    float MPsum1 = 0;
                    float MPsum2 = 0;
                    for (int i = 0; i < mpN; i++)
                    {
                        MPsum1 += mpC[i] * mpM[i];
                        MPsum2 += mpM[i];
                      
                    }

                    if (Trace == true)
                    {
                        Console.WriteLine("\nTRACE:suma mnożeń m i c wynosi:" + " " + MPsum1);
                    }

                    if (Trace == true)
                    {
                        Console.WriteLine("\nTRACE:suma wszystkich m wynosi:" + " " + MPsum2);
                    }

                    float result = MPsum1 / MPsum2;

                    Console.WriteLine("\nOdpowiedź: " + result);

                }///////A////////////

                if (PKey.Key == ConsoleKey.B)
                {
                    Console.WriteLine("\nwpisz, jaka będzie długość ");
                    int l = int.Parse(Console.ReadLine());

                    if (Trace == true)
                    {
                        Console.WriteLine("\nTRACE:będzie" + " " + l + " " + "elementów ");
                    }

                    float[] mpC = new float[l];

                    int mpL = mpC.Length;

                    int a = 1;
                    for (int i = 0; i < mpL; i++)
                    {
                        Console.WriteLine("\nZapisz wartośc C" + a + "(Cena 1kg),dla każdej wartości  musisz nacisnąć Enter ");
                        mpC[i] = float.Parse(Console.ReadLine());
                        if (Trace == true)
                        {
                            Console.WriteLine("\nTRACE:wartośc C" + a + " " + mpC[i]);
                        }
                        a++;
                    }

                    int b = 1;
                    float[] mpM = new float[l];

                    for (int i = 0; i < mpL; i++)
                    {
                        Console.WriteLine("\nZapisz wartośc M" + b + "(Liczbak kg),dla każdej wartości  musisz nacisnąć Enter ");
                        mpM[i] = float.Parse(Console.ReadLine());
                        if (Trace == true)
                        {
                            Console.WriteLine("\nTRACE:wartośc M" + b + " " + mpM[i]);
                        }
                        b++;
                    }

                    Console.Write("\nOdpowiedź: " + JD(mpM, mpC, mpL,Trace));
                }///////B////////////

                if (PKey.Key == ConsoleKey.C)
                {
                    Console.Write("\nJaka będzie wartość n ");
                    int mpl = int.Parse(Console.ReadLine());

                    if (Trace == true)
                    {
                        Console.WriteLine("\nTRACE:będzie" + " " + mpl + " " + "elementów ");
                    }

                    int a = 1;
                    float[] arr = new float[mpl];
                    int mpn = arr.Length;
                    for (int i = 0; i < mpn; i++)
                    {
                        Console.WriteLine("Zapisz wartości zmiennych n" + a + ", dla każdej wartości  musisz nacisnąć Enter");
                        arr[i] = float.Parse(Console.ReadLine());
                        if (Trace == true)
                        {
                            Console.WriteLine("\nTRACE:wartośc n" + a + " " + arr[i]);
                        }
                        a++;
                    }

                    float mps = 0;
                    for (int i = 0; i < mpn; i++)
                    {
                           mps += (float)1 / arr[i];
                    }

                    if (Trace == true)
                    {
                        Console.WriteLine("\nTRACE:podzielenie elementów n przez 1,0 wynosi:" + " " + mps);
                    }

                    float mpod = (float)mpn / mps;

                    Console.Write("\nOdpowiedź: " + mpod);
                }////////C/////////

                if (PKey.Key == ConsoleKey.D)
                {
                    Console.Write("\nJaka będzie wartość n ");
                    int mpl = int.Parse(Console.ReadLine());
                    if (Trace == true)
                    {
                        Console.WriteLine("\nTRACE:będzie" + " " + mpl + " " + "elementów ");
                    }

                    int a = 1;
                    float[] arr = new float[mpl];
                    int mpn = arr.Length;
                    for (int i = 0; i < mpn; i++)
                    {
                        Console.WriteLine("Zapisz wartości zmiennych n" + a + ", dla każdej wartości  musisz nacisnąć Enter");
                        arr[i] = float.Parse(Console.ReadLine());
                        if (Trace == true)
                        {
                            Console.WriteLine("\nTRACE:wartośc n" + a + " " + arr[i]);
                        }
                        a++;
                    }

                    Console.Write("\nOdpowiedź: " + OSH(arr, mpn,Trace));
                }////////D///////

                if (PKey.Key == ConsoleKey.E)
                {
                    Console.Write("\nJaka będzie wartość n ");
                    int mpl = int.Parse(Console.ReadLine());
                    if (Trace == true)
                    {
                        Console.WriteLine("\nTRACE:będzie wartość n" + " " + mpl);
                    }

                    int a = 1;
                    float[] arr = new float[mpl];
                    int mpn = arr.Length;
                    for (int i = 0; i < mpn; i++)
                    {
                        Console.WriteLine("Zapisz wartości zmiennych n"+ a + ", dla każdej wartości  musisz nacisnąć Enter");
                        arr[i] = float.Parse(Console.ReadLine());
                        if (Trace == true)
                        {
                            Console.WriteLine("\nTRACE:wartośc n" + a + " " + arr[i]);
                        }
                        a++;
                    }

                    float mpp = 1;

                    for (int i = 0; i < mpn; i++)
                    {
                        mpp *= arr[i];
                    }
                    if (Trace == true)
                    {
                        Console.WriteLine("\nTRACE:mnożenie wszystkich zmiennych n wynosi:" + mpp );
                    }
                    float osg = (float)Math.Pow(mpp, (float)1 / mpn);

                    Console.Write("\nOdpowiedź: " + osg);

                }////////E///////

                if (PKey.Key == ConsoleKey.F)
                {
                    Console.Write("\nJaka będzie wartość n ");
                    int mpl = int.Parse(Console.ReadLine());
                    if (Trace == true)
                    {
                        Console.WriteLine("\nTRACE:będzie wartość n" + " " + mpl);
                    }

                    int a = 1;
                    float[] arr = new float[mpl];
                    int mpn = arr.Length;
                    for (int i = 0; i < mpn; i++)
                    {
                        Console.WriteLine("Zapisz wartości zmiennych n"+ a + " , dla każdej wartości  musisz nacisnąć Enter");
                        arr[i] = float.Parse(Console.ReadLine());
                        if (Trace == true)
                        {
                            Console.WriteLine("\nTRACE:wartośc n" + a + " " + arr[i]);
                        }
                        a++;
                    }

                    Console.Write("\nOdpowiedź: " + OSG(arr, mpn,Trace));

                }////////F//////

                if (PKey.Key == ConsoleKey.G)/////////G////////
                {
                    Console.Write("\nJaka będzie wartość n ");
                    int mpl = int.Parse(Console.ReadLine());
                    if (Trace == true)
                    {
                        Console.WriteLine("\nTRACE:będzie wartość n" + " " + mpl);
                    }

                    int a = 1;
                    float[] arr = new float[mpl];
                    int mpn = arr.Length;

                    for (int i = 0; i < mpn; i++)
                    {
                        Console.WriteLine("Zapisz wartości zmiennych n" + a + " , dla każdej wartości  musisz nacisnąć Enter");
                        arr[i] = float.Parse(Console.ReadLine());
                        if (Trace == true)
                        {
                            Console.WriteLine("\nTRACE:wartośc n" + a + " " + arr[i]);
                        }
                        a++;
                    }

                    int mps = 0;
                    float mpm;

                    for (int i = 0; i < mpn; i++)
                    {
                        mps += (int)Math.Pow(arr[i], 2);
                    }

                    if (Trace == true)
                    {
                        Console.WriteLine("\nTRACE:suma n po potęgowaniu " + mps);
                    }

                    mpm = (mps / (float)(mpn));

                    if (Trace == true)
                    {
                        Console.WriteLine("\nTRACE:sum n po podzieleniu przez liczbę zmiennych n " + mpm);
                    }

                    float mposk = (float)Math.Sqrt(mpm);

                    Console.Write("\nOdpowiedź: " + mposk);
                }////////G//////

                if (PKey.Key == ConsoleKey.H) //////////H/////////
                {
                    Console.Write("\nJaka będzie wartość n ");
                    int mpl = int.Parse(Console.ReadLine());
                    if (Trace == true)
                    {
                        Console.WriteLine("\nTRACE:będzie wartość n" + " " + mpl);
                    }


                    int a = 1;
                    float[] arr = new float[mpl];
                    int mpn = arr.Length;
                    for (int i = 0; i < mpn; i++)
                    {
                        Console.WriteLine("Zapisz wartości zmiennych n" + a + " , dla każdej wartości  musisz nacisnąć Enter");
                        arr[i] = float.Parse(Console.ReadLine());
                        if (Trace == true)
                        {
                            Console.WriteLine("\nTRACE:wartośc n" + a + " " + arr[i]);
                        }
                        a++;
                    }
                    Console.Write("\nOdpowiedź: " + OSK(arr, mpn,Trace));

                }////////H//////

                if (PKey.Key == ConsoleKey.I)
                {
                    int mpsq;

                    Console.Write("\nJaki będzie stopień ");
                    mpsq = int.Parse(Console.ReadLine());
                    if (Trace == true)
                    {
                        Console.WriteLine("\nTRACE:będzie stopień" + " " + mpsq);
                    }


                    Console.WriteLine("\nJaka będzie wartość n ");
                    int mpl = int.Parse(Console.ReadLine());
                    if (Trace == true)
                    {
                        Console.WriteLine("\nTRACE:będzie wartość n" + " " + mpl);
                    }


                    int a = 1;
                    float[] arr = new float[mpl];
                    int mpn = arr.Length;
                    for (int i = 0; i < mpn; i++)
                    {
                        Console.WriteLine("Zapisz wartości zmiennych n" + a + " , dla każdej wartości  musisz nacisnąć Enter");
                        arr[i] = float.Parse(Console.ReadLine());
                        if (Trace == true)
                        {
                            Console.WriteLine("\nTRACE:wartośc n" + a + " " + arr[i]);
                        }
                        a++;
                    }

                    float mps = 0;

                    for (int i = 0; i < mpn; i++)
                        mps += (float)Math.Pow(arr[i], mpsq);
                    if (Trace == true)
                    {
                        Console.WriteLine("\nTRACE:suma zmiennych n podniesiona do potęgi" + " " + mps);
                    }

                    float mpmid = (mps / mpn);
                    if (Trace == true)
                    {
                        Console.WriteLine("\nTRACE:będzie stopień" + " " + mpmid);
                    }


                    float mpmid2 = (float)Math.Pow(mpmid, 1.0 / mpsq);

                    Console.Write("\nOdpowiedź: " + mpmid2);

                }//////I////////

                if (PKey.Key == ConsoleKey.J)
                {
                    int mpsq;

                    Console.Write("\nJaki będzie stopień ");
                    mpsq = int.Parse(Console.ReadLine());
                    if (Trace == true)
                    {
                        Console.WriteLine("\nTRACE:będzie stopień" + " " + mpsq);
                    }

                    Console.WriteLine("\nJaka będzie wartość n ");
                    int mpl = int.Parse(Console.ReadLine());
                    if (Trace == true)
                    {
                        Console.WriteLine("\nTRACE:będzie wartość n" + " " + mpl);
                    }

                    int a = 1;
                    float[] arr = new float[mpl];
                    int mpn = arr.Length;
                    for (int i = 0; i < mpn; i++)
                    {
                        Console.WriteLine("Zapisz wartości zmiennych n" + a + " , dla każdej wartości  musisz nacisnąć Enter");
                        arr[i] = float.Parse(Console.ReadLine());
                        if (Trace == true)
                        {
                            Console.WriteLine("\nTRACE:wartośc n" + a + " " + arr[i]);
                        }
                        a++;
                    }
                    Console.Write("\nOdpowiedź: " + OSP(arr, mpn, mpsq,Trace));

                }//////J////////

                if (PKey.Key == ConsoleKey.K)
                {

                    ConsoleKeyInfo MPk;

                    Console.WriteLine("\n\nA. przetłumacz DEC na wszystkie rodzaje ");
                    Console.WriteLine("B. przetłumacz HEX na wszystkie rodzaje ");
                    Console.WriteLine("C. przetłumacz OCT na wszystkie rodzaje ");
                    Console.WriteLine("D. przetłumacz BIN na wszystkie rodzaje ");
                    Console.WriteLine("E. algorytm Hornera ");
                    Console.WriteLine("F. wrócić do main ");
                    MPk = Console.ReadKey();

                    if (MPk.Key == ConsoleKey.A)
                    {

                        Console.Write("\n\nJaki numer przetłumaczyć ");
                        int mpn = Convert.ToInt32(Console.ReadLine());

                        string mpBase = Convert.ToString(mpn, 2);
                        string mpBase2 = Convert.ToString(mpn, 8);

                        string mphexStr = string.Empty;

                        while (mpn > 0)
                        {
                            int hex = mpn % 16;

                            if (hex < 10)
                                mphexStr = mphexStr.Insert(0, Convert.ToChar(hex + 48).ToString());
                            else
                                mphexStr = mphexStr.Insert(0, Convert.ToChar(hex + 55).ToString());
                                mpn /= 16;
                        }

                        Console.WriteLine("\nnumer w Oct: " + mpBase2);
                        Console.WriteLine("numer w Bin: " + mpBase);
                        Console.WriteLine("numer w Hex: " + mphexStr);
                    }

                    if (MPk.Key == ConsoleKey.B)
                    {
                        Console.Write("\n\nJaki numer HEX przetłumaczyć ");
                        string mpn = (Console.ReadLine());

                        int MPHex = int.Parse(mpn, System.Globalization.NumberStyles.HexNumber);
                        string MPBin = Convert.ToString(Convert.ToInt32(mpn, 16), 2);
                        string MPOct = Convert.ToString(Convert.ToInt32(mpn, 16), 8);

                        Console.WriteLine("\nnumer w Oct: " + MPOct);
                        Console.WriteLine("numer w Bin: " + MPBin);
                        Console.WriteLine("numer w Dec: " + MPHex);
                    }


                    if (MPk.Key == ConsoleKey.C)
                    {
                        Console.Write("\n\nJaki numer OCT przetłumaczyć ");
                        string mpn = (Console.ReadLine());

                        string MPBin = Convert.ToString(Convert.ToInt32(mpn, 8), 2);
                        string MPHex = Convert.ToString(Convert.ToInt32(mpn, 8), 16);
                        string MPDec = Convert.ToString(Convert.ToInt32(mpn, 8), 10);

                        Console.WriteLine("\nnumer w Hex: " + MPHex);
                        Console.WriteLine("numer w Bin: " + MPBin);
                        Console.WriteLine("numer w Dec: " + MPDec);

                    }

                    if (MPk.Key == ConsoleKey.D)
                    {
                        Console.Write("\n\nJaki numer BIN przetłumaczyć ");
                        string mpn = (Console.ReadLine());

                        string MPOct = Convert.ToString(Convert.ToInt32(mpn, 2), 8);
                        string MPHex = Convert.ToString(Convert.ToInt32(mpn, 2), 16);
                        string MPDec = Convert.ToString(Convert.ToInt32(mpn, 2), 10);

                        Console.WriteLine("numer w Hex: " + MPHex);
                        Console.WriteLine("numer w Oct: " + MPOct);
                        Console.WriteLine("numer w Dec: " + MPDec);

                    }

                    if (MPk.Key == ConsoleKey.E)
                    {
                        Console.Write("\n\nJaka będzie wartość x ");
                        int x = int.Parse(Console.ReadLine());
                        if (Trace == true)
                        {
                            Console.WriteLine("\nTRACE:wartość x będzie" + " " + x);
                        }

                        Console.Write("\nJaka będzie wartość n ");
                        int mpn = int.Parse(Console.ReadLine());
                        if (Trace == true)
                        {
                            Console.WriteLine("\nTRACE:wartość n będzie" + " " + mpn);
                        }

                        int a = 1;
                        int[] mpM = new int[mpn];
                        int mptn = mpM.Length;

                        for (int i = 0; i < mptn; i++)
                        {
                            Console.WriteLine("Zapisz wartości zmiennych n" + a + " , dla każdej wartości  musisz nacisnąć Enter");
                            mpM[i] = int.Parse(Console.ReadLine());
                            if (Trace == true)
                            {
                                Console.WriteLine("\nTRACE:wartośc C" + a + " " + mpM[i]);
                            }
                            a++;
                        }

                        int mpr = mpM[0];

                        for (int i = 1; i < mptn; i++)
                        {

                            mpr = (mpr * x) + mpM[i];
                        }
                        if (Trace == true)
                        {
                            Console.WriteLine("\nTRACE:wartość n będzie" + " " + mpr);
                        }

                        Console.WriteLine("\nOdpowiedź: " + mpr);

                    }

                    if (MPk.Key == ConsoleKey.F)
                    {
                        continue;
                    }
                }//////K///////

                if (PKey.Key == ConsoleKey.L)
                {

                    Console.WriteLine("\n\nA. przetłumacz DEC na wszystkie rodzaje ");
                    Console.WriteLine("B. przetłumacz HEX na wszystkie rodzaje ");
                    Console.WriteLine("C. przetłumacz OCT na wszystkie rodzaje ");
                    Console.WriteLine("D. przetłumacz BIN na wszystkie rodzaje ");
                    Console.WriteLine("E. algorytm Hornera ");
                    Console.WriteLine("F. wrócić do main ");


                    ConsoleKeyInfo PKeys;
                    PKeys = Console.ReadKey();

                    int mpn = 0;
                    int mpt = 0;
                    int x = 0;
                    string mpns = string.Empty;


                    if (PKeys.Key == ConsoleKey.A)
                    {
                        Console.Write("\nJaki numer przetłumaczyć ");
                        mpn = int.Parse(Console.ReadLine());
                    }

                    else if (PKeys.Key == ConsoleKey.B || PKeys.Key == ConsoleKey.C || PKeys.Key == ConsoleKey.D)
                    {

                        Console.Write("\nJaki numer przetłumaczyć ");
                        mpns = (Console.ReadLine());
                    }

                    else if (PKeys.Key == ConsoleKey.E)
                    {
                        Console.Write("\n\nJaka będzie wartość x ");
                        x = int.Parse(Console.ReadLine());
                        if (Trace == true)
                        {
                            Console.WriteLine("\nTRACE:wartość x będzie" + " " + x);
                        }


                        Console.Write("\nJaka będzie wartość n ");
                        mpt = int.Parse(Console.ReadLine());
                        if (Trace == true)
                        {
                            Console.WriteLine("\nTRACE:suma pierwszego elementu pomnożona przez x i dodana do niego zmienne n" + " " + mpt);
                        }

                    }

                    Console.Write("\nOdpowiedź: " + LC(mpn, mpns, x, mpt, PKeys,Trace));
                }/////L////////



                
            }
        }

        static public float JD(float[] mpM, float[] mpC, int mpL,bool Trace)
        {

            float MPsum1 = 0;
            float MPsum2 = 0;

            for (int i = 0; i < mpL; i++)
            {
                MPsum1 += mpC[i] * mpM[i];
                MPsum2 += mpM[i];
            }

            if (Trace == true)
            {
                Console.WriteLine("\nTRACE:suma mnożeń m i c wynosi" + " " + MPsum1);
            }

            if (Trace == true)
            {
                Console.WriteLine("\nTRACE:suma wszystkich m wynosi" + " " + MPsum2);
            }

            float result = MPsum1 / MPsum2;

            return result;

        }
        static public float OSH(float[] arr, int mpn,bool Trace)
        {

            float mps = 0;
            for (int i = 0; i < mpn; i++)
                mps += (float)1 / arr[i];

            if (Trace == true)
            {
                Console.WriteLine("\nTRACE:podzielenie elementów n przez 1,0 wynosi:" + " " + mps);
            }

            return (float)mpn / mps;

        }
        static public float OSG(float[] arr, int mpn,bool Trace)
        {

            float mpp = 1;

            for (int i = 0; i < mpn; i++)
            {
                mpp *= arr[i];
            }
            if (Trace == true)
            {
                Console.WriteLine("\nTRACE:mnożenie wszystkich zmiennych n wynosi: " + mpp);
            }
            float mposg = (float)Math.Pow(mpp, (float)1 / mpn);

            return mposg;

        }
        static public float OSK(float[] arr, int mpn,bool Trace)
        {
            int mps = 0;
            float mpm;

            for (int i = 0; i < mpn; i++)
            {
                mps += (int)Math.Pow(arr[i], 2);
            }
            if (Trace == true)
            {
                Console.WriteLine("\nTRACE:suma n po potęgowaniu " + mps);
            }

            mpm = (mps / (float)(mpn));

            if (Trace == true)
            {
                Console.WriteLine("\nTRACE:sum n po podzieleniu przez liczbę zmiennych n " + mpm);
            }

            float mposk = (float)Math.Sqrt(mpm);

            return mposk;

        }
        static public float OSP(float[] arr, int mpn, int mpsq,bool Trace)
        {
            float mps = 0;

            for (int i = 0; i < mpn; i++)
                mps += (float)Math.Pow(arr[i], mpsq);
            if (Trace == true)
            {
                Console.WriteLine("\nTRACE:suma zmiennych n podniesiona do potęgi" + " " + mps);
            }

            float mpmid = (mps / mpn);
            {
                Console.WriteLine("\nTRACE:będzie stopień" + " " + mpmid);
            }
            float mpmid2 = (float)Math.Pow(mpmid, 1.0 / mpsq);

            return mpmid2;
        }
        static public string LC(int mpn, string mpns, int x, int mpt, ConsoleKeyInfo PKeys,bool Trace)
        {
            if (PKeys.Key == ConsoleKey.A)
            {

                string Base = Convert.ToString(mpn, 2);
                string Base2 = Convert.ToString(mpn, 8);

                string MPhexs = string.Empty;

                while (mpn > 0)
                {
                    int mphex = mpn % 16;

                    if (mphex < 10)
                        MPhexs = MPhexs.Insert(0, Convert.ToChar(mphex + 48).ToString());
                    else
                        MPhexs = MPhexs.Insert(0, Convert.ToChar(mphex + 55).ToString());

                    mpn /= 16;
                }

                return _ = "\n" + Base + " number in Binary  \n" + Base2 + " number in  Octal  \n" + MPhexs + " number in  Hexa  \n";
            }

            if (PKeys.Key == ConsoleKey.B)
            {

                int MPHex = int.Parse(mpns, System.Globalization.NumberStyles.HexNumber);
                string MPBin = Convert.ToString(Convert.ToInt32(mpns, 16), 2);
                string MPOct = Convert.ToString(Convert.ToInt32(mpns, 16), 8);


                return _ = "\n" + MPBin + " number in Binary  \n" + MPOct + " number in  Octal  \n" + MPHex + " number in  Hexa  \n";
            }

            if (PKeys.Key == ConsoleKey.C)
            {

                string MPBin = Convert.ToString(Convert.ToInt32(mpns, 8), 2);
                string MPHex = Convert.ToString(Convert.ToInt32(mpns, 8), 16);
                string MPDec = Convert.ToString(Convert.ToInt32(mpns, 8), 10);

                return _ = "\n" + MPBin + " number in BIN  \n" + MPDec + " number in  DEC  \n" + MPHex + " number in  Hexa  \n";
            }

            if (PKeys.Key == ConsoleKey.D)
            {

                string MPOct = Convert.ToString(Convert.ToInt32(mpns, 2), 8);
                string MPHex = Convert.ToString(Convert.ToInt32(mpns, 2), 16);
                string MPDec = Convert.ToString(Convert.ToInt32(mpns, 2), 10);


                return _ = "\n" + MPDec + " number in DEC  \n" + MPOct + " number in  OCT  \n" + MPHex + " number in  HEX  \n";
            }

            if (PKeys.Key == ConsoleKey.E)
            {
                int a = 1;
                int[] mpM = new int[mpt];
                int mptn = mpM.Length;

                for (int i = 0; i < mptn; i++)
                {
                    Console.WriteLine("Zapisz wartości zmiennych n" + a + " , dla każdej wartości  musisz nacisnąć Enter");
                    mpM[i] = int.Parse(Console.ReadLine());
                    a++;
                }

                int mpr = mpM[0];

                for (int i = 1; i < mptn; i++)
                {

                    mpr = (mpr * x) + mpM[i];
                }
                if (Trace == true)
                {
                    Console.WriteLine("\nTRACE:suma pierwszego elementu pomnożona przez x i dodana do niego zmienne n" + " " + mpr);
                }

                string mprs = mpr.ToString();

                return mprs;
            }

            else if (PKeys.Key == ConsoleKey.F)
            {
                return null;
            }

            else
            {
                return null;
            }
        }
    }
}