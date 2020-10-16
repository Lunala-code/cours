using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_POO {

    //Potion qui rends de la vie
    public class PotionSoin2 : Potion {

        // En créant la potion de soin, on cré aussi une potion
        // On vas donc créer une sorte d'instance privé de Potion.
        // Pour créer une potion, il faut lui donné (d'aprs le constructeur Potion) une variable de type int qui vas correspondre, pour une potion de soin,
        // au PV qui seront rendu. Pour cela on utilise le mot clé base() qui permet d'instancier une classe interne potion avec 
        //les paramètre de notre constructuer
        public PotionSoin2(int pr) : base(pr) {

        }

        // Comme une potion de soin est une potion, elle est donc obligé d'avoir un effet et d'avoir le comportement applyEffect.
        // On vas donc surcharger Potion.applyEffect en écrivant le code source ici. 
        // Pour une potion de soin, on ajoute des PV au joueur
        // Ce comportement est disponible uniquement pour les potion de soin et non pour les d'autre potion
        public override void applyEffect(Player player) {
            player.addPv(this.rendu);
            
        }

        public override String getPotionType() {
            return "Soin";
        }
    }
}
