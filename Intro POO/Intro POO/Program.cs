using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_POO {
    class Program {
        static void Main(string[] args) {

            Player player = new Player();
            PotionSoin potion1 = new PotionSoin();

            player.presentPV();

            player.drinkPotion(potion1);

            player.presentPV();

        }
    }
}
