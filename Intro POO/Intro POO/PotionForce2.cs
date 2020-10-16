using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_POO {
    class PotionForce2 : Potion {

        public PotionForce2(int fr): base(fr) {

        }

        public override void applyEffect(Player player) {
            player.addForce(this.rendu);
        }

        public override string getPotionType() {
            return "Force";
        }
    }
}
