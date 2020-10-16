using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_POO {
    class Program {
        static void Main(string[] args) {

            Player player = new Player();
            //PotionSoin potion1 = new PotionSoin();
            //Potion potion = new Potion(10);
            Potion potion = new PotionSoin2(10);
            Potion p2 = new PotionForce2(10);

            List<Item> inventaire = new List<Item>();

            inventaire.Add(potion);
            inventaire.Add(p2);


            potion.getDescription();
            p2.getDescription();



            player.present();

            player.drinkPotion(potion);
            player.drinkPotion(p2);

            player.present();

        }
    }
}
