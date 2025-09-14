# online-ajc-tp-csharp-game-rpg-consol-app

## Énoncé de l’exercice
Vous allez développer un petit jeu RPG au tour par tour en C#.

Le projet se compose de deux exécutables distincts :
- Un programme de jeu qui permet d’incarner un héros et d’affronter une série de
monstres.
- Un programme d’administration qui permet de gérer les monstres du jeu.

## Règles et contraintes
- Les monstres sont définis dans un fichier texte externe.
- Le programme d’administration doit permettre : d’ajouter de nouveaux monstres, de supprimer des monstres existants, de lister les monstres enregistrés.
- Le programme de jeu doit : charger les monstres depuis la base de données avec Entity Framework, lancer un combat au tour par tour entre le héros et les monstres, afficher les résultats des attaques et l’évolution des points de vie, s’arrêter si le héros meurt ou quand tous les monstres ont été vaincus.
- Vous devez utiliser l’héritage et les interfaces dans la conception.
- Le héros et les monstres possèdent : Un nom, Des points de vie, Des points d’attaque.

## Déroulement d’un combat (tour par tour)
1. Le héros attaque en premier et inflige ses points d’attaque au monstre.
2. Si le monstre est toujours vivant, il réplique et inflige ses points d’attaque au héros.
3. Le tour se répète tant que les deux combattants ont encore des points de vie.
4. Quand un combattant tombe à 0 points de vie ou moins :
	a. s’il s’agit du héros, la partie s’arrête immédiatement (« Game Over »),
	b. s’il s’agit du monstre, le combat s’arrête et le héros passe au monstre suivant.
5. Le héros peut choisir d’attaquer OU de se régénérer (ses points de vie reviennent
au max). Il ne possède qu’une seule potion de régénération par monstre.

## Travail demandé
1. Proposez une conception technique de votre solution (par exemple : architecture
de la solution, diagrammes, texte explicatif, schéma, etc.).
	- Le format est libre (UML ou autre représentation claire).
2. Implémentez le code C# correspondant.
3. Une présentation de 10 minutes du travail réalisé.