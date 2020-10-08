# Résumé du cours de POO

## Paradigme de programmation orienté objets

Dans ce paradigme de programmation, on considère non plus une suite d'instruction qui s'excécute séquentiellement 
En POO, on dispose d'objets qui vont intéragir entre eux quand le programe va s'exécuté.

## Définition d'un objets
Un objets est une structure de donnée complexe qui représente un modèle réel (voiture, étudiant) ou imaginaire(monstre, hitbox) de manière informatique.
Pour modéliser cela, on utilises des **attribut** et des **méthodes**:
- Un __attribut__ c'est un paramètres/valeurs, pouvant être modéliser par une variable. Par exemple la vitesse d'une voiture ou les PV d'un monstre
- Une __méthode__ est peut être deux choses différentes:
    - Une **action** que notre modèle vas **appliquer à un autre modèle**
    - Une **action** que notre modèle vas **subir par rapport à un autre modèle**
    Dans notre code, nous avons une classe **Player** et une classe **Potion**
    Le player va appliquer une action vers une potion: la boire *Player.drinkPotion(PotionSoin potion)*
    Mais ce même player, en buvant la potion va "subir" un effet de cette potion. En effet notre potion appel un méthode du Player: *Player.addPv(int pv)*

Un autre éléments important dans une classe c'est le **constructeur** qui permet de créer et d'initialiser des variables internes à notre classe

## Pourquoi tout mettre en privé?
Une question qu''on peut se poser en voyant le code: Pourquoi tout mettre en privé??

En effet d'un point de vue pratique, mettre les PV de Player en public par exemple aurait permis de simplifier le code en codant moins de fonction.

Cependant en faisant ça on permet à tout programme de modifier les valeur internes d'un modèle sans aucune conditions.
On pourait par exemple imaginé une potion qui rends 2 000 000 000 de PV et dans ce cas là le joueur serait invinsible!!!

Oui mais c'est bien le codeur qui choisis quoi mettre comme valeur??

Par forcement, par exemple si je trouves que mes classes Player et Potion sont vraiment super je peux les donnés à d'autres programmeurs qui pourront faire n'importe quoi!!

Enfin ça permet d'ajouter des conditions de modification de la valeur en question.
On peut par exemple décider de ne pas dépasser les 100 PV pour un joueurs. En mettant les PV du player en privé et en modifiant sa valeur par un accesseur, on s'assure que les PV ne pourront pas être modifier n'importe comment.

Mettre des attributs en privé permet à notre modèle de respecter des contraintes et ainsi de ne pas pouvoir créer des modèles impossibles.