using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_POO {
    public abstract class Potion : Item {

        protected int rendu;

        public Potion(int r) {
            this.rendu = r;
        }

        public abstract void applyEffect(Player player);

        public abstract String getPotionType();

        public void getDescription() {
            Console.WriteLine("Potion de type " + this.getPotionType());
        }

    }
}
