using System;
namespace Denombrements
{
    class Program
    {
        static long CalculP(long rep, int n)
        {
            for (int k = 1; k <= n; k++)
            {
                rep *= k;
            }
            return rep;
        }
        static long CalculN(long rep, int t, int n)
        {
            for (int k = (t - n + 1); k <= t; k++)
            {
                rep *= k;
            }
            return rep;
        }
        static int SaisieEnsemble()
        {
            // saisie nombres d'éléments à gérer
            Console.Write("nombre total d'éléments à gérer = ");
            return int.Parse(Console.ReadLine());
        }
        static int SaisieSousEnsemble()
        {
            // saisie nombres d'éléments à gérer dans le sous-ensemble
            Console.Write("nombre d'éléments dans le sous ensemble = ");
            return int.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int choix = 1;
            long r, r1, r2;
            while (choix != 0)
            {
                try
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Permutation ...................... 1");
                        Console.WriteLine("Arrangement ...................... 2");
                        Console.WriteLine("Combinaison ...................... 3");
                        Console.WriteLine("Quitter .......................... 0");
                        Console.Write("Choix :                            ");
                        choix = int.Parse(Console.ReadLine());
                    } while (choix != 1 & choix != 2 & choix != 3 & choix != 0);
                    r = 1;
                    r1 = 1;
                    r2 = 1;
                    if (choix == 0) 
                    {
                        Environment.Exit(0);
                    }
                    if (choix == 1)
                    {
                        int n = SaisieEnsemble();
                        // calcul de r
                        r = CalculP(r, n);
                        Console.WriteLine(n + "! = " + r);
                    }
                    else
                    {
                        if (choix == 2)
                        {
                            int t = SaisieEnsemble();
                            int n = SaisieSousEnsemble();
                            // calcul de r
                            r = CalculN(r, t, n);
                            Console.WriteLine("A(" + t + "/" + n + ") = " + r);
                        }
                        else
                        {
                            int t = SaisieEnsemble();
                            int n = SaisieSousEnsemble();
                            // calcul de r1
                            r1 = CalculN(r1, t, n);
                            // calcul de r2
                            r2 = CalculP(r2, n);
                            // calcul et affichage de r3
                            Console.WriteLine("C(" + t + "/" + n + ") = " + (r1 / r2));
                        }
                    }
                    Console.WriteLine("Pressez n'importe quelle touche pour avancer");

                    Console.ReadKey();
                }
                catch
                {
                    Console.WriteLine("Erreur dans la saisie, Veuillez recommencer (n'importe quelle touche pour reprendre)");
                    Console.ReadKey();
                }
            }
            Console.ReadLine();
        }
    }
}
