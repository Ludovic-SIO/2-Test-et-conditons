using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Test_et_conditons
{
    internal class Program
    {
        static void Main(string[] args)

        {
            

            Console.WriteLine("Quel est l'age de votre enfant ?");
            double categorie =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" 1: (6 à 7 ans = Poussin)\n 2: (8 à 9 ans = Pupille)\\n 3: (10 à 11 ans = Minime)\\n 4: (après 12 ans = Cadet )\\ ");
            int choix = Convert.ToInt32
            (Console.ReadLine());
            double taux = 0;
            if (choix == 1) categorie = poussin;
            if (choix == 2) categorie = 
            if (choix == 3) categorie = 
            if (choix == 4) categorie = 

            Console.ReadKey();
        }
    }
}
