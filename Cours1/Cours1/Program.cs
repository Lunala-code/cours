using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours1 {

    class Toto {

        static void Main(string[] args) {
            //int age = 22;
            //Console.WriteLine("J'ai :"+age+" ans");


            //String name;
            //int age;

            //name = Console.ReadLine();
            //age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Votre nom est: " + name + " et votre age est: "+age);

            ////Type de données
            //String phrase = "coucou";
            //char charactère = 'a';
            //byte monByte = 4; //0->255 pas de valeur négative!!!!
            //int monInt = -154752; //sur 32 bit signé: 1 bit de signe et 31 bit de donnée
            //long monLong = 1478523; //64 bit signé => 1 bit de sign et 63 bit de donnée
            //float monFloat = 3.14f; //nombre a virgule
            //double monDouble = 3.14f; //plus précis que le float

            int n = 2;
            String nom = "urélie";

            if (nom == "Aurélie") {
                Console.WriteLine("Coucou du if");
            } else {
                Console.WriteLine("Ton nom n'est pas Aurélie!!");
                return;
            }

            Console.WriteLine("Prout");


        }
    }

}
