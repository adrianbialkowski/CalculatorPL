using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorPL
{
    class Program
    {
        static void Main(string[] args)
        {
            int pierwszy;
            int drugi;
            string operacja;
            string wyjscie;

            Console.WriteLine("\n\t\tSIMPLE CALCULATOR BY ADRIAN BIALKOWSKI");

            Poczatek:
            Console.WriteLine("\nWpisz pierwszy numer:");
            pierwszy = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Wybierz dzialanie jakie chcesz przeprowadzic [+ - * / %]");
            operacja = Console.ReadLine();

            Console.WriteLine("Wpisz drugi numer");
            drugi = Convert.ToInt32(Console.ReadLine());

            switch (operacja)
            {
                case "+":
                    Console.WriteLine("Wynik to : " + (pierwszy + drugi));
                    Console.WriteLine();
                    Console.WriteLine("Czy chcesz sprawdzic kolejne dzialanie: Dalej / Wyjscie");
                    wyjscie = Console.ReadLine().ToUpper();
                    switch (wyjscie)
                    {
                        case "DALEJ":
                            Console.Clear();
                            goto Poczatek;
                        default:
                            break;
                    }
                    break;

                case "-":
                    Console.WriteLine("Wynik to : " + (pierwszy - drugi));
                    Console.WriteLine();
                    Console.WriteLine("Czy chcesz sprawdzic kolejne dzialanie: Dalej / Wyjscie");
                    wyjscie = Console.ReadLine().ToUpper();
                    switch (wyjscie)
                    {
                        case "DALEJ":
                            Console.Clear();
                            goto Poczatek;
                        default:
                            break;
                    }
                    break;
                case "*":
                    Console.WriteLine("Wynik to : " + (pierwszy * drugi));
                    Console.WriteLine();
                    Console.WriteLine("Czy chcesz sprawdzic kolejne dzialanie: Dalej / Wyjscie");
                    wyjscie = Console.ReadLine().ToUpper();
                    switch (wyjscie)
                    {
                        case "DALEJ":
                            Console.Clear();
                            goto Poczatek;
                        default:
                            break;
                    }
                    break;
                case "/":
                    Console.WriteLine("Wynik to : " + (pierwszy / drugi));
                    Console.WriteLine();
                    Console.WriteLine("Czy chcesz sprawdzic kolejne dzialanie: Dalej / Wyjscie");
                    wyjscie = Console.ReadLine().ToUpper();
                    switch (wyjscie)
                    {
                        case "DALEJ":
                            Console.Clear();
                            goto Poczatek;
                        default:
                            break;
                    }
                    break;

                case "%":
                    Console.WriteLine("Wynik to : " + (pierwszy % drugi));
                    Console.WriteLine();
                    Console.WriteLine("Czy chcesz sprawdzic kolejne dzialanie: Dalej / Wyjscie");
                    wyjscie = Console.ReadLine().ToUpper();
                    switch (wyjscie)
                    {
                        case "DALEJ":
                            Console.Clear();
                            goto Poczatek;
                        default:
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("Wybrales niepoprawny operator. Sprobuj jeszcze raz.");
                    goto Poczatek;
            }

            Console.ReadKey();
        }
    }
}
