using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_POO {
    public class Player {

        private int pv;
        private int force;

        //Constructeur
        public Player() {
            this.pv = 100;
            this.force = 100;
        }

        //Affiche le nombre de PV du joueur
        public void presentPV() {
            Console.WriteLine("Player PV : " + pv);
        }

        //Ajout au PV actuel un nombre déterminé de pv.
        // Ce nombre est passé en paramètres de la méthode
        public void addPv(int pv) {
            this.pv += pv; 
        }

        //Méthode (action) qui permet au joueur de boire une potion
        //La potion que doit boire le joueur est passé en paramètre
        public void drinkPotion(PotionSoin potion) {
            potion.applyEffect(this);   //les pv rendus par la potion en question sont en privé. On ne peux donc pas récupéré les pv rendus par cette potion
            // On fais donc utilisé la méthode applyEffect en donnant une référence à notre objet/classe

            //this.pv = this.pv + potion.PvRendu;
        }

    }
}
