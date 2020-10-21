using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_POO {
    class Program {
        static void Main(string[] args) {

            Player player = new Player();

            // On cré deux potion, une potion de force et une potion de sin
            Potion potion = new PotionSoin(10);
            Potion p2 = new PotionForce(10);

            // Un invenatire, c'est une liste d'item, on peut donc y ajouter nos potion cas Potion hérite de Item
            List<Item> inventaire = new List<Item>();

            inventaire.Add(potion);
            inventaire.Add(p2);

            // Affichage de la description des potions
            potion.getDescription();
            p2.getDescription();
            
            // Affichage des paramètres des joueurs avant avoir bu les potions
            player.present();

            player.drinkPotion(potion);
            player.drinkPotion(p2);

            // Affichage des paramètres des joueurs après avoir bu les potions
            player.present();

        }
    }
}
