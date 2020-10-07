using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace characterMaker {
    class Program {
        static void Main(string[] args) {
            String name;
            String race ="";
            int age =0;
            char sexe =' ';
            int pv =100;
            int force =100;
            int puissance =100;
            int Resistance = 100;

            //Je saisie le nom
            Console.WriteLine("Saisir votre nom:");
            name = Console.ReadLine();

            Console.WriteLine("\n-------------\n");
            

            while (age <= 0) {
                Console.WriteLine("Saisir votre age: ");
                age = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\n-------------\n");
            

            while((sexe != 'H') && (sexe != 'F')) {
                Console.WriteLine("Saisir votre sexe (H/F): ");
                sexe = Convert.ToChar(Console.ReadLine());
            }

            Console.WriteLine("\n-------------\n");
            Console.WriteLine("Présentation des race:\n" +
                "- Elfe: peu de PV et de résistance mais une forte puissance magique\n" +
                "- Orc: Beaucoup de PV et bonne résistance mais peu offensif\n" +
                " -Humain: PV et résistance moyen mais beaucoup de force physique\n");
            Console.Write("Saisir votre race:");
            race = Console.ReadLine();

            if(race == "Elfe") {
                pv = pv + 50;
                Resistance = Resistance + 20;
                force = force + 10;
                puissance = puissance + 200;
                
            } else if(race == "Orc") {
                pv = pv + 400;
                Resistance = Resistance + 200;
                force = force + 10;
                puissance = puissance - 30;

            } else if(race == "Humain") {
                pv = pv + 100;
                Resistance = Resistance + 50;
                force = force + 150;
                puissance = puissance + 50;
            } else {
                Console.WriteLine("La race saisie n'existe pas!!");
                return;
            }


            Console.WriteLine("\n----------PERSONNAGE----------\n");
            Console.WriteLine("Nom : " + name+"\n");
            Console.WriteLine("Age : " + age + "\n");
            Console.WriteLine("Sexe: " + sexe + "\n");
            Console.WriteLine("Race : " + race + "\n");
            Console.WriteLine("Point de vie: " + pv + "\n");
            Console.WriteLine("Résistance: " + Resistance + "\n");
            Console.WriteLine("Force physique: " + force + "\n");
            Console.WriteLine("Puissance magique: " + puissance + "\n");
        }
    }
}
