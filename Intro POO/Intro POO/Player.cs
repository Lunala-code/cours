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
        public void present() {
            Console.WriteLine("Player PV : " + pv);
            Console.WriteLine("Player force : " + force);
        }

        //Ajout au PV actuel un nombre déterminé de pv.
        // Ce nombre est passé en paramètres de la méthode
        public void addPv(int pv) {
            this.pv += pv; 
        }

        public void addForce(int f) {
            this.force += f;
        }

        public void isAttack(int deg) {
            this.pv -= deg;
        }

        //Méthode (action) qui permet au joueur de boire une potion
        //La potion que doit boire le joueur est passé en paramètre
        //public void drinkPotion(PotionSoin potion)

        // Aveec notre architecture basé sur l'héritage, le joueur vas boire une Potion, puis, en fonction de la potion, les effets seront différents.
        // Cependant, pour le joeur c'est totalement indépendant.
        public void drinkPotion(Potion potion) {
            potion.applyEffect(this); 
            // On fais donc utilisé la méthode applyEffect en donnant une référence à notre objet/classe

            //this.pv = this.pv + potion.PvRendu;
        }

    }
}

