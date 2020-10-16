using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_POO {

    // clase abstraite Potion qui dérive d'Item: En effet, une potion est u item
    public abstract class Potion : Item {

        //On cré une bariable rendu qui indique la quantité rendu par la potion.
        // On n'indique pas encre si la potion rends des PV, de la force ou autre chose
        protected int rendu;

        // Constructeur de la classe
        // Même si une classe abstraite ne peut pas être créer, on implémente quand même un constructeur pour les classe filles
        public Potion(int r) {
            this.rendu = r;
        }

        // Méthode abstraite qui vas appliquer l'effet de la potion. Chaque effets dépends de la potion donc le code va être différent d'une potion à l'autre
        // Cependant toutes les potions ont un effet, en mettant cette méthode en abstract, on laisse la possibilité aux classes filles d'avoir un comportement
        // différents mais on les oblige à avoir ce comportement
        public abstract void applyEffect(Player player);

        public abstract String getPotionType();

        // Ici la méthode est implémenté. Elle peut donc être appellable par toutes ces filles directement.
        // Get type permet de récupéré le type de potion (soin force).
        public void getDescription() {
            Console.WriteLine("Potion de type " + this.getPotionType());
        }

    }
}
