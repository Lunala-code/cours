# A faire pour la prochaine fois: Les monstres arrivent!!

## Objectif: créer deux monstres qui peuvent attaquer le joueur

### Composition de la classe monstre
- Un monstre à des PV et de la force. Un monstre à 100 PV de base, la force dépends de chaque monstre.
- Un monstre à également une méthode qui lui permet d'attaquer un Player. Cependant, **chaque monstre attaque de manière différente**
- Tous les monstres ont une description qui présente leur type (Orc/gobelin), leur PV et leur force.
Il existe deux type de monstres:

#### Les orcs
Un orc est le monstre le plus fort, il à une force de base de 30.
Cependant, l'orc tape tellement fort qu'il se fais mal et perds 10PV à chaque fois qu'il attaque!!

#### Les gobelin
Un gobelin est moins puissant qu'un orc. Sa force de base est de 10.
Cependant, le gobelin, à chaque fois qu'il attaque, connais mieux son ennemis et sa force augmente de 1 à chaque fois.
Par contre sa force ne peut pas dépasser 20!! Ses connaissances sur l'ennemis ne sont pas inifine!!

### Attaque

Attaquer une joueur, c'est enlever des PV à ce joueur d'une certaines quantité. 
Pour simplifier les choses, les PV que le joueurs perds sont égale à la force du monstre qui l'attaque.
PV -= degat

On aura donc deux méthodes:
Monstre.attack(Player) qui dépends de chaque monstre.
Player.IsAttack(int) qui vas enlever la vie d'une certainer quantité passé en paramètre.