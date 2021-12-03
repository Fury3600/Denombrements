using System;

namespace Denombrements
{
    class Program
    {
        /// <summary>
        /// Calcule les factorielles demandée par les opérations pour les arrangements, les combinaisons et les permutations.
        /// (Par exemple: 5! = 1*2*3*4*5)
        /// </summary>
        /// <param name="initialisation"> L'initialisation de la boucle </param>
        /// <param name="totalNombres"> Le nombre jusqu'où va la factorielle </param>
        /// <returns></returns>
        static long MultiplicationFactorielle(int initialisation, int totalNombres)
        {
            long permutations = 1;
            for (int k = initialisation; k <= totalNombres; k++)
            {
                permutations *= k;
            }
            return permutations;
        }
        static int SaisieNombre(string message)
        {
            Console.Write(message);
            int nombre = int.Parse(Console.ReadLine());
            return nombre;
        }

        /// <summary>
        /// Calcule le nombre de permutations d'un total d'éléments, en tenant compte de l'ordre de ces éléments.
        /// </summary>
        static void Permutation()
        {
            int totalNombres = SaisieNombre("Nombre total de nombres à gérer = ");
            Console.WriteLine(totalNombres + "! = " + MultiplicationFactorielle(1, totalNombres));
        }

        /// <summary>
        /// Calcule le nombre d'arrangements d'un nombre d'éléments parmi un tout, en tenant compte de l'ordre de ces éléments.
        /// </summary>
        static void Arrangement()
        {
            int totalNombres = SaisieNombre("Nombre total de nombres à gérer = ");
            int elements = SaisieNombre("Nombre d'éléments dans le sous ensemble = ");
            Console.WriteLine("A(" + totalNombres + "/" + elements + ") = " + MultiplicationFactorielle(totalNombres - elements + 1, totalNombres));
        }

        /// <summary>
        /// Calcule le nombre de combinaisons d'un nombre d'éléments parmi un tout, sans tenir compte de l'ordre
        /// </summary>
        static void Combinaison()
        {
            int totalNombres = SaisieNombre("Nombre total de nombres à gérer = ");
            int elements = SaisieNombre("Nombre d'éléments dans le sous ensemble = ");
            Console.WriteLine("C(" + totalNombres + "/" + elements + ") = " + (MultiplicationFactorielle(totalNombres - elements + 1, totalNombres) / MultiplicationFactorielle(1, elements)));
        }
        static void Main(string[] args)
        {
            char choix = '1';
            while (choix != 0)
            {
                // Demande de saisie
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                choix = Console.ReadKey().KeyChar;
                Console.WriteLine();

                // Traitement de l'entrée
                switch (choix)
                {
                    case '1':
                        Permutation();
                        break;
                    case '2':
                        Arrangement();
                        break;
                    case '3':
                        Combinaison();
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Veuillez entrer une saisie valide.");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
