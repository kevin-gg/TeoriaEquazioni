using System;
using EquazioniLibrary;
namespace Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nIsDetermined \nIsInconsisted \nIsDegree \nDelta \nEqationDegree \nresult \nSeleziona un operazione: ");
            string opzione = Console.ReadLine();
            switch (opzione)
            { 
                case "IsDetermined":
                    Console.WriteLine($"Inserisci il primo membro");
                    double a = double.Parse(Console.ReadLine());
                    bool b = Equazioni.isDetermined(a);
                    if (b == true)
                    {
                        Console.WriteLine("Determinata");
                    }
                    else
                    {
                        Console.WriteLine("Non determinata");
                    }
                    break;
                case "IsInconsisted":
                    Console.WriteLine($"Inserisci il primo membro");
                    double a1 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Inserisci il secondo membro");
                    double b1 = double.Parse(Console.ReadLine());
                    bool b2 = Equazioni.isInconsisted(a1, b1);
                    if (b2 == true)
                    {
                        Console.WriteLine("Impossibile");
                    }
                    else
                    {
                        Console.WriteLine("Non è impossibile");
                    }
                    break;
                case "IsDegree":
                    Console.WriteLine($"Inserisci il grado dell'equazione");
                    double x = double.Parse(Console.ReadLine());
                    bool risposta2 = Equazioni.isDegree2(x);
                    if (risposta2 == true)
                    {
                        Console.WriteLine("Equazione di secondo grado");
                    }
                    else
                    {
                        Console.WriteLine("l'equazione non è di secondo grado");
                    }
                    break;
                case "Delta":
                    Console.WriteLine($"Inserisci il primo membro");
                    double a3 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Inserisci il secondo membro");
                    double b3 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Inserisci il terzo membro");
                    double c3 = double.Parse(Console.ReadLine());
                    double delta = Equazioni.Delta(a3, b3, c3);
                    Console.WriteLine($"Il delta è: {delta}");
                    break;
                case "EquationDegree":
                    Console.WriteLine($"Inserisci il primo membro");
                    double a4 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Inserisci il secondo membro");
                    double b4 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Inserisci il terzo membro");
                    double c4 = double.Parse(Console.ReadLine());
                    string risultato4 = Equazioni.EquationDegree1(a4, b4, c4);
                    Console.WriteLine($"Il risultato è: {risultato4}");
                    break;
                case "Result":
                    Console.WriteLine($"Inserisci il primo membro");
                    double a5 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Inserisci il secondo membro");
                    double b5 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Inserisci il terzo membro");
                    double c5 = double.Parse(Console.ReadLine());
                    string risultato = Equazioni.Result(a5, b5, c5);
                    Console.WriteLine($"Il risultato è: {risultato}");
                    break;
            }
        }
    }
}
