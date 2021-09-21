using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dojo_geometrie
{
    class Program
    {
        static void Main(string[] args)
        {
            double perimetre = 0, aire = 0, volume = 0;

            Console.Write("Entrez la valeur du côté ou du rayon : ");
            string NString = Console.ReadLine();
            double N;
            bool parseOk = Double.TryParse(NString, out N);
            if (parseOk)
            {
                if (N <= 0)
                {
                    Console.WriteLine("Un côté ou un rayon ne peut pas être inférieur ou égal à 0");
                }
                else
                {
                    Console.Write("Entrez le type de figure (carré, triangle, rond) : ");
                    string T = Console.ReadLine().ToLower();

                    if (T == "carré")
                    {
                        perimetre = N * 4;
                        aire = N * N;
                        volume = Math.Pow(N, 3);

                        Console.WriteLine("Le périmètre du " + T + " de côté " + N + " : " + perimetre);
                        Console.WriteLine("L'aire du " + T + " de côté " + N + " : " + aire);
                        Console.WriteLine("Le volume du cube de cote " + N + " : " + volume);
                    }
                    else if (T == "triangle")
                    {
                        perimetre = N * 3;
                        aire = (Math.Sqrt(3) / 4) * Math.Pow(N, 2);
                        Console.WriteLine("Le périmètre du " + T + " de côté " + N + " : " + perimetre);
                        Console.WriteLine("L'aire du " + T + " de côté " + N + " : " + aire);
                    }

                    else if (T == "rond")
                    {
                        perimetre = 2 * Math.PI * N;
                        aire = Math.PI * N * N;

                        Console.WriteLine("Le périmètre du cercle de rayon " + N + " : " + perimetre);
                        Console.WriteLine("L'aire du disque de rayon " + N + " : " + aire);
                    }

                    else
                    {
                        Console.WriteLine("Désolé le type " + T + " n'existe pas je ne peux pas vous aider !");
                    }
                }
            }
            else
            {
                Console.WriteLine("Impossible de parser la valeur " + NString);
            }

            Console.ReadLine(); // Utilisé pour faire une pause dans la sortie console afin d'avoir le temps de lire le résultat
        }
    }
}
