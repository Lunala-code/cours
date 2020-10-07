using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace instructionFLow {
    class Program {
        
        static void Main(string[] args) {

            int a = 4;
            int b = 10;

            int c = 5;

            ///----- Base di if else ------
            //if (a == c) {     //l'égalité entre a et c: a == c <=> c == a
            //    //bloc conditionnelle: on y entre si la condition est vrai!!
            //    Console.WriteLine("a = c");
            //} else { //si la condition est fausse
            //    //on exe ce bloc
            //    //if (a > c) {    // '>' l'opérateur de supériorité. a > c <!=> c > a
            //    //    Console.WriteLine("a plus grand que c");
            //    //}
            //    //if (a < c) { // '<' opérateur d'infériorité 
            //    //    Console.WriteLine("a plus petit que c");
            //    //}
            //    Console.WriteLine("a différent de c");
            //}

            ///----- Supérieur ou égale-----
            //if (a <= c) {
            //    Console.WriteLine("a <= c");
            //}
            //if (a >= c) {
            //    Console.WriteLine("a >= c");
            //}

            ///------OU logique --------
            //if ( (a > c) || (c != b) ) { // || => ou logique : vrai si au moins une des conditions est vrais
            //    // != différent: a != b <=> b != a
            //    Console.WriteLine("coucou");
            //}

            ///-------ET logique- -------
            //if( (a<=c) && (c <= b)) { // && => et logique : vrai si LES DEUX CONDITIONS SONT VRAIES 
            //    Console.WriteLine("c appartient a [a,b]");
            //}

            //if (!(a == c)) {
            //    // 1==1 : vrai      
            //    // !(1==1) : faux
            //    Console.WriteLine("a n'est pas égale à b");
            //}

            /*-----Récap-------
                - égalite : a==b
                - différence: a!=b
                - supériorité: a>b
                - infériorité: a<b
                - supérieur ou égale: a>=b
                - inférieur ou égale: a<=b
                - OU logique: cond1 || cond2 => vrai si cond1 ou cond2 ou les deux sont vrais
                - ET logique: cond1 && cond2 => vrais si cond1 et cond2 sont vrais
                - NON logique: !cond => faux si cond est vrai et vrai si cond est faux
            */

            //int max = 10;
            //int v = 3;

            //while (v<max) { //tant que la condition est vrai, on exe le bloc conditionnelle
            //    Console.WriteLine("prout");
            //    v++;
            //}

            //for (int i=1; i<=10; i++) {
            //    for(int j=1; j<=10; j++) {
            //        Console.WriteLine(i + "x" + j + " = " + i * j);
            //    }

            //    Console.WriteLine("\n---------------\n");
            //}
            

        }

    }
    

}
