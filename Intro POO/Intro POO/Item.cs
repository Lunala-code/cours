using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_POO {

    // Une interface c'est une classe 100% abstraite. 
    // En créant une interface Item, on vas obligé tous les item à aveoir une description
    // Cependant une potion et une armure ne vont pas avoir la même description, on vas donc forcer les items à avoir une description
    // Tous en laissant à chaque item la possibilité de personnalisé sa description
    public interface Item {

        void getDescription();
    }
}
