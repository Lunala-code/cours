using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_POO {
    public class PotionSoin2 : Potion {

        public PotionSoin2(int r2) : base(r2) {

        }

        public override void applyEffect(Player player) {
            player.addPv(this.rendu);
            
        }

        public override String getPotionType() {
            return "Soin";
        }
    }
}
