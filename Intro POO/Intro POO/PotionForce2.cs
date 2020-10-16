using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_POO {
    // Potion qui rends de la force
    class PotionForce2 : Potion {

        // En créant la potion de force, on cré aussi une potion
        // On vas donc créer une sorte d'instance privé de Potion.
        // Pour créer une potion, il faut lui donné (d'aprs le constructeur Potion) une variable de type int qui vas correspondre, pour une potion de force,
        // à la force qui sera rendu. Pour cela on utilise le mot clé base() qui permet d'instancier une classe interne potion avec 
        //les paramètre de notre constructuer

        public PotionForce2(int fr): base(fr) {

        }

        // Comme une potion de force est une potion, elle est donc obligé d'avoir un effet et d'avoir le comportement applyEffect.
        // On vas donc surcharger Potion.applyEffect en écrivant le code source ici. 
        // Pour une potion de force, on ajoute de la force au joueur
        // Ce comportement est disponible uniquement pour les potion de force et non pour les d'autre potion
        public override void applyEffect(Player player) {
            player.addForce(this.rendu);
        }

        public override string getPotionType() {
            return "Force";
        }
    }
}
