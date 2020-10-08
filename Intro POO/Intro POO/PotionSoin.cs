using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_POO {
    public class PotionSoin {

        private int PvRendu;

        //Constructeur
        public PotionSoin() {
            this.PvRendu = 10;
        }

        //La potion a pour action d'appliquer son effets: ici rendre des PV
        // Rendre des PV à qui? Au joueur player de type Player
        public void applyEffect(Player player) {
            player.addPv(PvRendu);  //étant donné que les PV du joueurs sont privé ont utilise une action du joueur qui permets de lui ajouter des PV
            // On appelle ce genre de fonction des "Modificateurs"
            // Les get/set sont les modificateur les plus connues
        }

    }
}
