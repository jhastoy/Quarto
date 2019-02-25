using System;


namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            int cptVictoire = 0;
            int cptDefaite = 0;
            int cptEgal = 0;
            int issue;
            char replay = 'O';
            int difficulty = 3;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(@"         _______                   _____                    _____                    _____                _____                   _______         ");
                Console.WriteLine(@"        /::\    \                 /\    \                  /\    \                  /\    \              /\    \                 /::\    \        ");
                Console.WriteLine(@"       /::::\    \               /::\____\                /::\    \                /::\    \            /::\    \               /::::\    \       ");
                Console.WriteLine(@"      /::::::\    \             /:::/    /               /::::\    \              /::::\    \           \:::\    \             /::::::\    \      ");
                Console.WriteLine(@"     /::::::::\    \           /:::/    /               /::::::\    \            /::::::\    \           \:::\    \           /::::::::\    \     ");
                Console.WriteLine(@"    /:::/~~\:::\    \         /:::/    /               /:::/\:::\    \          /:::/\:::\    \           \:::\    \         /:::/~~\:::\    \    ");
                Console.WriteLine(@"   /:::/    \:::\    \       /:::/    /               /:::/__\:::\    \        /:::/__\:::\    \           \:::\    \       /:::/    \:::\    \   ");
                Console.WriteLine(@"  /:::/    / \:::\    \     /:::/    /               /::::\   \:::\    \      /::::\   \:::\    \          /::::\    \     /:::/    / \:::\    \  ");
                Console.WriteLine(@" /:::/____/   \:::\____\   /:::/    /      _____    /::::::\   \:::\    \    /::::::\   \:::\    \        /::::::\    \   /:::/____/   \:::\____\ ");
                Console.WriteLine(@"|:::|    |     |:::|    | /:::/____/      /\    \  /:::/\:::\   \:::\    \  /:::/\:::\   \:::\____\      /:::/\:::\    \ |:::|    |     |:::|    |");
                Console.WriteLine(@"|:::|____|     |:::|____||:::|    /      /::\____\/:::/  \:::\   \:::\____\/:::/  \:::\   \:::|    |    /:::/  \:::\____\|:::|____|     |:::|    |");
                Console.WriteLine(@" \:::\   _\___/:::/    / |:::|____\     /:::/    /\::/    \:::\  /:::/    /\::/   |::::\  /:::|____|   /:::/    \::/    / \:::\    \   /:::/    / ");
                Console.WriteLine(@"  \:::\ |::| /:::/    /   \:::\    \   /:::/    /  \/____/ \:::\/:::/    /  \/____|:::::\/:::/    /   /:::/    / \/____/   \:::\    \ /:::/    /  ");
                Console.WriteLine(@"   \:::\|::|/:::/    /     \:::\    \ /:::/    /            \::::::/    /         |:::::::::/    /   /:::/    /             \:::\    /:::/    /   ");
                Console.WriteLine(@"    \::::::::::/    /       \:::\    /:::/    /              \::::/    /          |::|\::::/    /   /:::/    /               \:::\__/:::/    /    ");
                Console.WriteLine(@"     \::::::::/    /         \:::\__/:::/    /               /:::/    /           |::| \::/____/    \::/    /                 \::::::::/    /   ");
                Console.WriteLine(@"      \::::::/    /           \::::::::/    /               /:::/    /            |::|  ~|           \/____/                   \::::::/    /     ");
                Console.WriteLine(@"       \::::/____/             \::::::/    /               /:::/    /             |::|   |                                      \::::/    /      ");
                Console.WriteLine(@"        |::|    |               \::::/    /               /:::/    /              \::|   |                                       \::/____/       ");
                Console.WriteLine(@"        |::|____|                \::/____/                \::/    /                \:|   |                                        ~~              ");
                Console.WriteLine(@"         ~~                       ~~                       \/____/                  \|___|                                                        ");

                Console.WriteLine(@"                                           _____  _           __     __   _____          __  __ ______ ");
                Console.WriteLine(@"                                          |  __ \| |        /\\ \   / /  / ____|   /\   |  \/  |  ____|");
                Console.WriteLine(@"                                          | |__) | |       /  \\ \_/ /  | |  __   /  \  | \  / | |__   ");
                Console.WriteLine(@"                                          |  ___/| |      / /\ \\   /   | | |_ | / /\ \ | |\/| |  __|  ");
                Console.WriteLine(@"                                          | |    | |____ / ____ \| |    | |__| |/ ____ \| |  | | |____ ");
                Console.WriteLine(@"                                          |_|    |______/_/    \_\_|     \_____/_/    \_\_|  |_|______| ");

                System.Threading.Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine(@"         _______                   _____                    _____                    _____                _____                   _______         ");
                Console.WriteLine(@"        /::\    \                 /\    \                  /\    \                  /\    \              /\    \                 /::\    \        ");
                Console.WriteLine(@"       /::::\    \               /::\____\                /::\    \                /::\    \            /::\    \               /::::\    \       ");
                Console.WriteLine(@"      /::::::\    \             /:::/    /               /::::\    \              /::::\    \           \:::\    \             /::::::\    \      ");
                Console.WriteLine(@"     /::::::::\    \           /:::/    /               /::::::\    \            /::::::\    \           \:::\    \           /::::::::\    \     ");
                Console.WriteLine(@"    /:::/~~\:::\    \         /:::/    /               /:::/\:::\    \          /:::/\:::\    \           \:::\    \         /:::/~~\:::\    \    ");
                Console.WriteLine(@"   /:::/    \:::\    \       /:::/    /               /:::/__\:::\    \        /:::/__\:::\    \           \:::\    \       /:::/    \:::\    \   ");
                Console.WriteLine(@"  /:::/    / \:::\    \     /:::/    /               /::::\   \:::\    \      /::::\   \:::\    \          /::::\    \     /:::/    / \:::\    \  ");
                Console.WriteLine(@" /:::/____/   \:::\____\   /:::/    /      _____    /::::::\   \:::\    \    /::::::\   \:::\    \        /::::::\    \   /:::/____/   \:::\____\ ");
                Console.WriteLine(@"|:::|    |     |:::|    | /:::/____/      /\    \  /:::/\:::\   \:::\    \  /:::/\:::\   \:::\____\      /:::/\:::\    \ |:::|    |     |:::|    |");
                Console.WriteLine(@"|:::|____|     |:::|____||:::|    /      /::\____\/:::/  \:::\   \:::\____\/:::/  \:::\   \:::|    |    /:::/  \:::\____\|:::|____|     |:::|    |");
                Console.WriteLine(@" \:::\   _\___/:::/    / |:::|____\     /:::/    /\::/    \:::\  /:::/    /\::/   |::::\  /:::|____|   /:::/    \::/    / \:::\    \   /:::/    / ");
                Console.WriteLine(@"  \:::\ |::| /:::/    /   \:::\    \   /:::/    /  \/____/ \:::\/:::/    /  \/____|:::::\/:::/    /   /:::/    / \/____/   \:::\    \ /:::/    /  ");
                Console.WriteLine(@"   \:::\|::|/:::/    /     \:::\    \ /:::/    /            \::::::/    /         |:::::::::/    /   /:::/    /             \:::\    /:::/    /   ");
                Console.WriteLine(@"    \::::::::::/    /       \:::\    /:::/    /              \::::/    /          |::|\::::/    /   /:::/    /               \:::\__/:::/    /    ");
                Console.WriteLine(@"     \::::::::/    /         \:::\__/:::/    /               /:::/    /           |::| \::/____/    \::/    /                 \::::::::/    /   ");
                Console.WriteLine(@"      \::::::/    /           \::::::::/    /               /:::/    /            |::|  ~|           \/____/                   \::::::/    /     ");
                Console.WriteLine(@"       \::::/____/             \::::::/    /               /:::/    /             |::|   |                                      \::::/    /      ");
                Console.WriteLine(@"        |::|    |               \::::/    /               /:::/    /              \::|   |                                       \::/____/       ");
                Console.WriteLine(@"        |::|____|                \::/____/                \::/    /                \:|   |                                        ~~              ");
                Console.WriteLine(@"         ~~                       ~~                       \/____/                  \|___|                                                        ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(@"                                           _____  _           __     __   _____          __  __ ______ ");
                Console.WriteLine(@"                                          |  __ \| |        /\\ \   / /  / ____|   /\   |  \/  |  ____|");
                Console.WriteLine(@"                                          | |__) | |       /  \\ \_/ /  | |  __   /  \  | \  / | |__   ");
                Console.WriteLine(@"                                          |  ___/| |      / /\ \\   /   | | |_ | / /\ \ | |\/| |  __|  ");
                Console.WriteLine(@"                                          | |    | |____ / ____ \| |    | |__| |/ ____ \| |  | | |____ ");
                Console.WriteLine(@"                                          |_|    |______/_/    \_\_|     \_____/_/    \_\_|  |_|______| ");
                System.Threading.Thread.Sleep(500);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
            }
            while (replay == 'O')
            {
                difficulty = 5;
                while (difficulty != 1 && difficulty != 2 && difficulty != 3)
                {
                    Console.Clear();
                    Console.WriteLine(@"   _____ _           _     _                    _             _ _  __  __ _            _ _    __      ");
                    Console.WriteLine(@"  / ____| |         (_)   (_)                  | |           | (_)/ _|/ _(_)          | | |  /_/   _  ");
                    Console.WriteLine(@" | |    | |__   ___  _ ___ _ ___ ___  ___ ____ | | __ _    __| |_| |_| |_ _  ___ _   _| | |_ ___  (_) ");
                    Console.WriteLine(@" | |    | '_ \ / _ \| / __| / __/ __|/ _ \_  / | |/ _` |  / _` | |  _|  _| |/ __| | | | | __/ _ \     ");
                    Console.WriteLine(@" | |____| | | | (_) | \__ \ \__ \__ \  __// /  | | (_| | | (_| | | | | | | | (__| |_| | | ||  __/  _  ");
                    Console.WriteLine(@"  \_____|_| |_|\___/|_|___/_|___/___/\___/___| |_|\__,_|  \__,_|_|_| |_| |_|\___|\__,_|_|\__\___| (_) ");
                    Console.WriteLine(@"");
                    Console.WriteLine(@"");
                    Console.WriteLine(@"  __       ______         _ _          __        _   __       _        _           __  ");
                    Console.WriteLine(@" /_ |  _  |  ____|       (_) |        / /       | | /_/      | |      (_)          \ \ ");
                    Console.WriteLine(@"  | | (_) | |__ __ _  ___ _| | ___   | |    __ _| | ___  __ _| |_ ___  _ _ __ ___   | |");
                    Console.WriteLine(@"  | |     |  __/ _` |/ __| | |/ _ \  | |   / _` | |/ _ \/ _` | __/ _ \| | '__/ _ \  | |");
                    Console.WriteLine(@"  | |  _  | | | (_| | (__| | |  __/  | |  | (_| | |  __/ (_| | || (_) | | | |  __/  | |");
                    Console.WriteLine(@"  |_| (_) |_|  \__,_|\___|_|_|\___|  | |   \__,_|_|\___|\__,_|\__\___/|_|_|  \___|  | |");
                    Console.WriteLine(@"                                      \_\                                          /_/ ");
                    Console.WriteLine(@"");
                    Console.WriteLine(@"");
                    Console.WriteLine(@"  ___        __  __                        ");
                    Console.WriteLine(@" |__ \   _  |  \/  |                       ");
                    Console.WriteLine(@"    ) | (_) | \  / | ___  _   _  ___ _ __  ");
                    Console.WriteLine(@"   / /      | |\/| |/ _ \| | | |/ _ \ '_ \ ");
                    Console.WriteLine(@"  / /_   _  | |  | | (_) | |_| |  __/ | | |");
                    Console.WriteLine(@" |____| (_) |_|  |_|\___/ \__, |\___|_| |_|");
                    Console.WriteLine(@"                           __/ |           ");
                    Console.WriteLine(@"                          |___/           ");
                    Console.WriteLine(@"");
                    Console.WriteLine(@"");
                    Console.WriteLine(@"  ____        _____  _  __  __ _      _ _    ");
                    Console.WriteLine(@" |___ \   _  |  __ \(_)/ _|/ _(_)    (_) |     ");
                    Console.WriteLine(@"   __) | (_) | |  | |_| |_| |_ _  ___ _| | ___ ");
                    Console.WriteLine(@"  |__ <      | |  | | |  _|  _| |/ __| | |/ _ \");
                    Console.WriteLine(@"  ___) |  _  | |__| | | | | | | | (__| | |  __/");
                    Console.WriteLine(@" |____/  (_) |_____/|_|_| |_| |_|\___|_|_|\___|");
                    difficulty = int.Parse(Console.ReadLine());
                }
                Console.Clear();
                bool[,] infos = new bool[4, 20];
                string[,] grille = new string[36, 14];
                bool[] pionJoue = new bool[5];// on crée la grille qui représentera le jeu                              // infoHasard(infos);
                bool[,] pions = initPions();
                ActuGrille(grille, infos, pions);
                actuAffichage(grille, 0, 0, false);
                issue = partie(pions, infos, grille, difficulty);
                if (issue == 1)
                    cptVictoire++;
                else
                {
                    if (issue == -1)
                        cptDefaite++;
                    else
                        cptEgal++;
                }
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("                           |  V  |  E  |  D  |");
                Console.WriteLine("                           |-----|-----|-----|");
                Console.WriteLine("                           |     |     |     |");
                Console.WriteLine("                           |  {0}  |  {1}  |  {2}  |", cptVictoire, cptEgal, cptDefaite);
                Console.WriteLine("                           |     |     |     |");
                Console.WriteLine("                           |-----|-----|-----|");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine(@"  _____            _               ___     __   ____        __  _   _  __  ");
                Console.WriteLine(@" |  __ \          | |             |__ \   / /  / __ \      / / | \ | | \ \ ");
                Console.WriteLine(@" | |__) |___ _ __ | | __ _ _   _     ) | | |  | |  | |    / /  |  \| |  | |");
                Console.WriteLine(@" |  _  // _ \ '_ \| |/ _` | | | |   / /  | |  | |  | |   / /   | . ` |  | |");
                Console.WriteLine(@" | | \ \  __/ |_) | | (_| | |_| |  |_|   | |  | |__| |  / /    | |\  |  | |");
                Console.WriteLine(@" |_|  \_\___| .__/|_|\__,_|\__, |  (_)   | |   \____/  /_/     |_| \_|  | |");
                Console.WriteLine(@"            | |             __/ |         \_\                          /_/ ");
                Console.WriteLine(@"            |_|            |___/                                           ");
                replay = char.Parse(Console.ReadLine());
            }
        }
        /// <summary>
        /// Gère le déroulement de la partie.
        /// </summary>
        /// <param name="pions"></param>
        /// <param name="infos"></param>
        /// <param name="grille"></param>
        /// <param name="difficulty"></param>
        /// <returns></returns>
        static public int partie(bool[,] pions, bool[,] infos, string[,] grille, int difficulty)
        {
            Random alea = new Random();
            bool[] pionJoue = new bool[5];
            int placementX = 1;
            int placementY = 1;
            int choixPionsX = 0;
            int choixPionsY = 0;
            int cpt = alea.Next(0, 2); // tirage au sort du joueur débutant la partie
            if (cpt == 1)
                Console.WriteLine("L'adversaire commence !");
            else
                Console.WriteLine("Vous commencez !");
            System.Threading.Thread.Sleep(1000);
            int[] pionDonne = new int[2];
            while (verifVictoire(placementX, placementY, infos) == false && verifEgalite(infos) == false) //verification à chaque tour si la partie n'est pas terminée
            {
                if (cpt % 2 == 0)
                {
                    joueurDonnePion(pions, ref pionJoue);
                    if (difficulty == 2 || difficulty ==3)
                        adversaireNiv2(pions, infos, grille, out placementX, out placementY, pionJoue);
                    else
                        adversaireNiv1(pions, infos, grille, out placementX, out placementY, pionJoue);
                    cpt++;
                }
                else
                {
                    if (difficulty == 3)
                        adversaireDonnePionNiv2(ref pionJoue, ref infos, pions, grille);
                    else
                        adversaireDonnePionNiv1(pions, ref pionJoue, grille);
                    joueur(pions, infos, pionJoue, grille, out placementX, out placementY);
                    cpt++;
                }
            }
            actuAffichage(grille, choixPionsX, choixPionsY, false);
            if (verifEgalite(infos) == true)
            {
                Console.WriteLine("Il y a égalité");
                return 0;
            }
            else
            {
                if (cpt % 2 == 1)
                {
                    Console.WriteLine("L'adversaire a gagné en {0} coups !", cpt);
                    return -1;
                }
                else
                {
                    Console.WriteLine("Vous avez gagné en {0} coups !", cpt);
                    return 1;
                }
               
            }
            

        }
        /// <summary>
        /// Verifie l'égalité
        /// </summary>
        /// <param name="infos"></param>
        /// <returns></returns>
        public static bool verifEgalite(bool[,] infos)
        {
            int cpt = 0;
            for(int i = 0; i<4; i++)
            {
                for(int j = 4; j<20; j = j+5)
                {
                    if (infos[i, j] == true) // si tous les pions ont été joué sans victoire : c'est égalité
                        cpt = cpt + 1;
                }
            }
            if (cpt == 16)
                return true;
            else return false;
        }
        /// <summary>
        /// Permet de donner le pion à l'adversaire
        /// </summary>
        /// <param name="pions"></param>
        /// <param name="pionJoue"></param>
        public static void joueurDonnePion(bool[,] pions, ref bool[] pionJoue)
        {
            char[] carac = { 'A', 'B', 'C', 'D' };
            Console.WriteLine("Quel pions voulez-vous donner à l'adversaire ? (Exemple : B2)");
            string coord = Console.ReadLine();
            char pos = coord[0];
            int posy = (int)Char.GetNumericValue(coord[1]);
            bool test = pions[convertCoord(pos), posy * 5 - 1];
            while (test == false) // on vérifie si le joueur ne donne pas un pions déjà utilisé.
            {
                Console.WriteLine("Ce pions a déjà été utilisé.");
                Console.WriteLine("Quel pions voulez-vous donner à l'adversaire ? (Exemple : B2)");
                coord = Console.ReadLine();
                pos = coord[0];
                posy = (int)Char.GetNumericValue(coord[1]);
                test = pions[convertCoord(pos), posy * 5 - 1];
            }
            pionJoue = choixPions(convertCoord(pos), posy-1, pions);
        }

        public static bool[,] copieTableau(bool[,] tableauACopier)
        {
            int tailleX = tableauACopier.GetUpperBound(0);
            int tailleY = tableauACopier.GetUpperBound(1);
            bool[,] copieTableau = new bool[tailleX + 1, tailleY + 1];
            for (int i = 0; i <= tailleX; i++)
                for (int j = 0; j <= tailleY; j++)
                    copieTableau[i, j] = tableauACopier[i, j];
            return copieTableau;

        }
        /// <summary>
        /// Retourne, dans le cas où 3 pions sont alignés, posGagnante contenant les positions des emplacements dans lesquels un pion est manquant pour gagner la partie.
        /// </summary>
        /// <param name="pionJoue"></param>
        /// <param name="infos"></param>
        /// <param name="pions"></param>
        /// <param name="indice"></param>
        /// <returns></returns>
        public static int[,] adversaireDonnePionNiv2_verif(ref bool[] pionJoue,  bool[,] infos, bool[,] pions, out int indice)
        {
            indice = 0;
            int[,] posGagnante = new int[10, 2];
            int cpt = 0;
            int tempx = 0;
            int tempy = 0;
            for (int i = 0; i < 4; i++) 
            {
                for (int j = 4; j < 20; j = j + 5)
                {
                    if (infos[i, j] == true)
                    {
                        cpt++; // vérification de 3 pions alignés sur chaque ligne
                    }
                    else
                        tempy = j / 5;
                }
                if (cpt == 3)
                {
                    posGagnante[indice, 0] = i;
                    posGagnante[indice, 1] = tempy; // à chaque fois qu'on trouve une ligne avec 3 pions alignés, on stocke la position x et y du pion manquant dans le tableau posGagnante
                    indice++;
                }
                cpt = 0;
            }
            for (int i = 4; i < 20; i = i + 5) // on fait la même chose pour les colonnes
            {
                for (int j = 0; j < 4; j++)
                {
                    if (infos[j, i] == true)
                        cpt++;
                    else
                        tempx = j;
                }
                if (cpt == 3)
                {
                    posGagnante[indice, 0] = tempx; 
                    posGagnante[indice, 1] = i / 5;
                    indice++;
                }
                cpt = 0;
            }
            for (int i = 0; i < 4; i++) // on fait la même chose pour la diagonale gauche
            {
                if (infos[i, i * 5 + 4] == true)
                    cpt++;
                else
                {
                    tempx = i;                }
            }
            if(cpt==3)
            {
                posGagnante[indice, 0] = tempx;
                posGagnante[indice, 1] = tempx;
                indice++;
            }
            cpt = 0;
            for (int i = 0; i < 4; i++) // on fait la même chose pour la diagonale droite
            {
                if (infos[3 - i, i * 5 + 4] == true)
                    cpt++;
                else
                {
                    tempx = 3 - i;
                    tempy = i;
                }
            }
            if (cpt == 3)
            {
                posGagnante[indice, 0] = tempx;
                posGagnante[indice, 1] = tempy;
                indice++;
            }
            return posGagnante; // on revoit donc le tableau, mais aussi l'indice en out.
        }
        /// <summary>
        /// Choisi un pion qui ne permettra pas au joueur de gagner
        /// </summary>
        /// <param name="pionJoue"></param>
        /// <param name="infos"></param>
        /// <param name="pions"></param>
        /// <param name="grille"></param>
        /// <returns></returns>
        public static bool adversaireDonnePionNiv2(ref bool[] pionJoue, ref bool[,] infos, bool[,] pions, string[,] grille)
        {
            char[] carac = { 'A', 'B', 'C', 'D' };
            bool[,] copieInfos;
            copieInfos = copieTableau(infos);
            int[,] posGagnante;
            int indice;
            posGagnante = adversaireDonnePionNiv2_verif(ref pionJoue, infos, pions, out indice);
            int cpt = 0;
            if (indice > 0) // si l'indice est supérieur à zéro c'est qu'il y a au moins 1 fois 3 pions alignés.
            {
            for(int test = indice; test>=1; test-- ) // on teste autant de fois qu'il a 3 pions alignés
                for (int x = 0; x < 4; x++) // on parcourt tous les pions restants
                    for (int y = 0; y < 4; y++)
                    {
                            if (pions[x, y*5 + 4] == true) // on vérifie que cette position correspond bien à un pion restant
                            {
                                for (int i = 0; i < indice; i++) // on parcourt maintenant le tableau des positions
                                {
                                    for (int j = 0; j < 5; j++)
                                        infos[posGagnante[i, 0], posGagnante[i, 1] * 5 + j] = pions[x, y * 5 + j]; // on place temporairement le pion testé à l'emplacement testé
                                    if (verifVictoire(posGagnante[i, 0], posGagnante[i, 1], infos) == false) // et on vérifie si il y a une victoire pour chaque position, si ce n'est pas le cas, c'est que le pion testé ne fera pas gagné le joueur !
                                        cpt++;
                                    infos = copieTableau(copieInfos);
                                }
                                if (cpt == test) // si toutes les positions testées ne donne pas de victoire, on peut donné ce pion si au joueur, sinon on retest avec un alignement en moins
                                {
                                    
                                    pionJoue = choixPions(x, y, pions);
                                    Console.Clear();
                                    actuAffichage(grille, x, y, true);            
                                    Console.WriteLine("L'adversaire vous donne le pion {0}{1}.", carac[x], y + 1);
                                    return true;
                                }
                                cpt = 0;
                            }
                    }
            }
            else
                adversaireDonnePionNiv1(pions, ref pionJoue, grille); // si il n'y a pas 3 poins alignés, joue au hasard
            return false;
        }

      

        /// <summary>
        /// L'IA donne un pion au hasard au joueur.
        /// </summary>
        /// <param name="pions"></param>
        /// <param name="pionJoue"></param>
        /// <param name="grille"></param>
        public static void adversaireDonnePionNiv1(bool[,] pions, ref bool[] pionJoue, string[,] grille)
        {
            char[] carac = { 'A', 'B', 'C', 'D' };
            int choixPionsX = 0;
            int choixPionsY = 0;
            bool test = false;
            while (test == false) // on teste qu'on ne donne pas un pion déja utilisé !
            {
                Random alea2 = new Random();
                choixPionsX = alea2.Next(0, 4);
                choixPionsY = alea2.Next(0, 4);
                test = pions[choixPionsX, choixPionsY * 5 + 4];
            }
            pionJoue = choixPions(choixPionsX, choixPionsY, pions);
            Console.Clear();
            actuAffichage(grille, choixPionsX, choixPionsY, true);
            Console.WriteLine("L'adversaire vous donne le pion {0}{1}.", carac[choixPionsX], choixPionsY + 1);
        }
        /// <summary>
        /// Permet à l'IA de placer le pion de mankère à gagner
        /// </summary>
        /// <param name="pions"></param>
        /// <param name="infos"></param>
        /// <param name="grille"></param>
        /// <param name="placementX"></param>
        /// <param name="placementY"></param>
        /// <param name="pionJoue"></param>
        /// <returns></returns>
        public static int adversaireNiv2(bool[,] pions, bool[,] infos, string[,] grille, out int placementX, out int placementY, bool[] pionJoue)
        {
            int alea = 0;
            Random hasard = new Random();
            char[] carac = { 'A', 'B', 'C', 'D' };
            for(int nbPions = 3; nbPions >= 1; nbPions--) // permet de tester d'abord si 3 pions sont alignés, puis 2, puis 1; ainsi, l'IA jouera de manière intelligente pour chaque configuration !
            {
                alea = hasard.Next(0, 4); // l'aléa permet ici à l'IA de ne pas être prévisible nottament quand il n'y a qu'un pion aligné ! au lieu de commencer par jouer sur la colonne, elle pourra commencer aléatoire par colonne, ligne, ou diag!
                if(alea == 0) // on alterne donc les conditions if pour chaque tirage aléatoire
                    if (adversaireNiv2_verifLigne(pions, infos, grille, out placementX, out placementY, pionJoue, nbPions) == true)
                    {
                        placePion(placementX, placementY, infos, pionJoue);
                        ActuGrille(grille, infos, pions);
                        return 1;
                    }
                    else
                    {
                        if (adversaireNiv2_verifColonne(pions, infos, grille, out placementX, out placementY, pionJoue, nbPions) == true)
                        {
                            placePion(placementX, placementY, infos, pionJoue);
                            ActuGrille(grille, infos, pions);
                            return 1;
                        }

                        else
                        {
                            if (adversaireNiv2_verifDiagG(pions, infos, grille, out placementX, out placementY, pionJoue, nbPions) == true)
                            {
                                placePion(placementX, placementY, infos, pionJoue);
                                ActuGrille(grille, infos, pions);
                                return 1;
                            }

                            else
                            {
                                if (adversaireNiv2_verifDiagD(pions, infos, grille, out placementX, out placementY, pionJoue, nbPions) == true)
                                {
                                    placePion(placementX, placementY, infos, pionJoue);
                                    ActuGrille(grille, infos, pions);
                                    return 1;
                                }
                            }
                        }
                    }
                if(alea == 1)
                    if (adversaireNiv2_verifColonne(pions, infos, grille, out placementX, out placementY, pionJoue, nbPions) == true)
                    {
                        placePion(placementX, placementY, infos, pionJoue);
                        ActuGrille(grille, infos, pions);
                        return 1;
                    }
                    else
                    {
                        if (adversaireNiv2_verifLigne(pions, infos, grille, out placementX, out placementY, pionJoue, nbPions) == true)
                        {
                            placePion(placementX, placementY, infos, pionJoue);
                            ActuGrille(grille, infos, pions);
                            return 1;
                        }

                        else
                        {
                            if (adversaireNiv2_verifDiagG(pions, infos, grille, out placementX, out placementY, pionJoue, nbPions) == true)
                            {
                                placePion(placementX, placementY, infos, pionJoue);
                                ActuGrille(grille, infos, pions);
                                return 1;
                            }

                            else
                            {
                                if (adversaireNiv2_verifDiagD(pions, infos, grille, out placementX, out placementY, pionJoue, nbPions) == true)
                                {
                                    placePion(placementX, placementY, infos, pionJoue);
                                    ActuGrille(grille, infos, pions);
                                    return 1;
                                }
                            }
                        }
                    }
                if (alea == 2)
                    if (adversaireNiv2_verifDiagG(pions, infos, grille, out placementX, out placementY, pionJoue, nbPions) == true)
                    {
                        placePion(placementX, placementY, infos, pionJoue);
                        ActuGrille(grille, infos, pions);
                        return 1;
                    }
                    else
                    {
                        if (adversaireNiv2_verifColonne(pions, infos, grille, out placementX, out placementY, pionJoue, nbPions) == true)
                        {
                            placePion(placementX, placementY, infos, pionJoue);
                            ActuGrille(grille, infos, pions);
                            return 1;
                        }

                        else
                        {
                            if (adversaireNiv2_verifLigne(pions, infos, grille, out placementX, out placementY, pionJoue, nbPions) == true)
                            {
                                placePion(placementX, placementY, infos, pionJoue);
                                ActuGrille(grille, infos, pions);
                                return 1;
                            }

                            else
                            {
                                if (adversaireNiv2_verifDiagD(pions, infos, grille, out placementX, out placementY, pionJoue, nbPions) == true)
                                {
                                    placePion(placementX, placementY, infos, pionJoue);
                                    ActuGrille(grille, infos, pions);
                                    return 1;
                                }
                            }
                        }
                    }
                if (alea == 3)
                    if (adversaireNiv2_verifDiagD(pions, infos, grille, out placementX, out placementY, pionJoue, nbPions) == true)
                    {
                        placePion(placementX, placementY, infos, pionJoue);
                        ActuGrille(grille, infos, pions);
                        return 1;
                    }
                    else
                    {
                        if (adversaireNiv2_verifDiagG(pions, infos, grille, out placementX, out placementY, pionJoue, nbPions) == true)
                        {
                            placePion(placementX, placementY, infos, pionJoue);
                            ActuGrille(grille, infos, pions);
                            return 1;
                        }

                        else
                        {
                            if (adversaireNiv2_verifColonne(pions, infos, grille, out placementX, out placementY, pionJoue, nbPions) == true)
                            {
                                placePion(placementX, placementY, infos, pionJoue);
                                ActuGrille(grille, infos, pions);
                                return 1;
                            }

                            else
                            {
                                if (adversaireNiv2_verifLigne(pions, infos, grille, out placementX, out placementY, pionJoue, nbPions) == true)
                                {
                                    placePion(placementX, placementY, infos, pionJoue);
                                    ActuGrille(grille, infos, pions);
                                    return 1;
                                }
                            }
                        }
                    }
            }
            
            adversaireNiv1(pions, infos, grille, out placementX, out placementY, pionJoue);
            return 1;
            
        }
        /// <summary>
        /// Permet de placer le pion en argument aux coordonnées en argument dans le tableau infos !
        /// </summary>
        /// <param name="placementX"></param>
        /// <param name="placementY"></param>
        /// <param name="infos"></param>
        /// <param name="pionJoue"></param>
        public static void placePion(int placementX, int placementY, bool[,] infos, bool[] pionJoue)
        {
            for (int i = 0; i < 5; i++)
            {
                infos[placementX, placementY * 5 + i] = pionJoue[i];
            }
        }
        /// <summary>
        /// Verifie que 3, 2, ou 1 pions avec au moins une caractérisitque commune sont alignés sur la diagonale gauche et de jouer de manière à completer l'alignement
        /// </summary>
        /// <param name="pions"></param>
        /// <param name="infos"></param>
        /// <param name="grille"></param>
        /// <param name="placementX"></param>
        /// <param name="placementY"></param>
        /// <param name="pionJoue"></param>
        /// <param name="nbPions"></param>
        /// <returns></returns>
        public static bool adversaireNiv2_verifDiagG(bool[,] pions, bool[,] infos, string[,] grille, out int placementX, out int placementY, bool[] pionJoue, int nbPions)
        {
            int temp = 0;
            int temp2 = 0;
            int temp3 = 0;
            int cpt = 0;
            int cpt2 = 0;
            placementX = 0;
            placementY = 0;
            for(int i =1; i<5; i++)
            {
                if (infos[i - 1, i * 5 - 1] == true) // on vérifie si il y a bien nbPions alignés sur une ligne !
                    cpt++;
            }
            if(cpt== nbPions)
            {
                for (int i = 0; i < 4; i++) // on parcourt les caractéristiques du pions joué
                {
                    for (int j = 0; j < 16; j = j + 5)
                    {
                        if (pionJoue[i] == infos[j / 5, j + i] && infos[j/5, j +4] == true) // = si le ième caractérique du pion joué égale la ième caractéristique du premier pions, deuxiemex, etc...
                        {
                            cpt2++;
                        }
                        else // on récupère la position du pion manquant pour completer l'alignement
                        {
                            temp = j / 5;
                            temp2 = j/5;
                            temp3 = j + 4;
                        }
                    }
                    if (cpt2 == nbPions && infos[temp, temp3] == false) 
                    {
                        placementX = temp; //si on a trouvé un alignement de 3 pions ayant une carac en commun avec le pion joué, on récupère la position à laquelle placer le pion pour gagner
                        placementY = temp2;
                        return true;
                    }
                    else
                    {
                        cpt2 = 0;
                    }
                }

            }
            return false;

        }
        /// <summary>
        /// Verifie que 3, 2, ou 1 pions avec au moins une caractérisitque commune sont alignés sur la diagonale droite et de jouer de manière à completer l'alignement
        /// </summary>
        /// <param name="pions"></param>
        /// <param name="infos"></param>
        /// <param name="grille"></param>
        /// <param name="placementX"></param>
        /// <param name="placementY"></param>
        /// <param name="pionJoue"></param>
        /// <param name="nbPions"></param>
        /// <returns></returns>
        public static bool adversaireNiv2_verifDiagD(bool[,] pions, bool[,] infos, string[,] grille, out int placementX, out int placementY, bool[] pionJoue, int nbPions)
        {
            int temp = 0;
            int temp2 = 0;
            int temp3 = 0;
            int cpt = 0;
            int cpt2 = 0;
            placementX = 0;
            placementY = 0;
            for (int i = 1; i<5; i++)
            {
                if (infos[4-i, i * 5 - 1] == true)
                    cpt++;
            }
            if (cpt == nbPions)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j <16; j = j + 5)
                    {
                        if (pionJoue[i] == infos[3-(j / 5), j + i] && infos[3-(j/5), j+4] == true)
                        {
                            cpt2++;
                        }
                        else
                        {
                            temp = 3-(j / 5);
                            temp2 = j/ 5;
                            temp3 = j + 4;
                        }
                    }
                    if (cpt2 == nbPions && infos[temp, temp3] == false)
                    {
                        placementX = temp;
                        placementY = temp2;
                        return true;
                    }
                    else
                    {
                        cpt2 = 0;
                    }
                }

            }
            return false;

        }
        /// <summary>
        /// Verifie que 3, 2, ou 1 pions avec au moins une caractérisitque commune sont alignés sur les colonnes et de jouer de manière à completer l'alignement
        /// </summary>
        /// <param name="pions"></param>
        /// <param name="infos"></param>
        /// <param name="grille"></param>
        /// <param name="placementX"></param>
        /// <param name="placementY"></param>
        /// <param name="pionJoue"></param>
        /// <param name="nbPions"></param>
        /// <returns></returns>
        public static bool adversaireNiv2_verifColonne(bool[,] pions, bool[,] infos, string[,] grille, out int placementX, out int placementY, bool[] pionJoue, int nbPions)
        {
            placementX = 0;
            placementY = 0;
            int cpt = 0;
            int cpt2 = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (infos[j, i * 5 + 4] == true)
                        cpt++;
                }
                if (cpt == nbPions)
                {
                    for (int n = 0; n < 4; n++)
                    {
                        for (int m = 0; m < 4; m++)
                        {

                            if (pionJoue[n] == infos[m, i * 5 + n] && infos[m, i * 5 + 4] == true)
                            {
                                cpt2++;
                            }
                        }
                        if (cpt2 == nbPions)
                        {
                            for (int o = 0; o < 4; o++)
                            {
                                if (infos[o, i * 5 + 4] == false)
                                {
                                    placementX = o;
                                    placementY = i;
                                    return true;
                                }
                            }
                        }
                        cpt2 = 0;
                    }
                }
                cpt = 0;
            }
            return false;
        }
        /// <summary>
        /// Verifie que 3, 2, ou 1 pions avec au moins une caractérisitque commune sont alignés sur les lignes et de jouer de manière à completer l'alignement
        /// </summary>
        /// <param name="pions"></param>
        /// <param name="infos"></param>
        /// <param name="grille"></param>
        /// <param name="placementX"></param>
        /// <param name="placementY"></param>
        /// <param name="pionJoue"></param>
        /// <param name="nbPions"></param>
        /// <returns></returns>
        public static bool adversaireNiv2_verifLigne(bool[,] pions, bool[,] infos, string[,] grille, out int placementX, out int placementY, bool[] pionJoue, int nbPions)
        {
            int cpt = 0;
            int cpt2 = 0;
            placementX = 0;
            placementY = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 4; j < 20; j = j + 5)
                    if (infos[i, j] == true)
                        cpt++;
                if (cpt == nbPions)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        for (int l = 0; l < 16; l = l + 5)
                        {
                            if (pionJoue[k] == infos[i, l + k] && infos[i, l + 4] == true)
                            {
                                cpt2++;
                            }
                        }
                        if (cpt2 == nbPions)
                        {
                            for (int m = 0; m < 4; m++)
                                if (infos[i, m * 5 + 4] == false)
                                {
                                    placementX = i;
                                    placementY = m;
                                    return true;
                                }
                        }
                        cpt2 = 0;
                    }
                }
                cpt = 0;
            }
            return false;
        }
        /// <summary>
        /// Permet à l'IA de placer le pion de manière aléatoire
        /// </summary>
        /// <param name="pions"></param>
        /// <param name="infos"></param>
        /// <param name="grille"></param>
        /// <param name="placementX"></param>
        /// <param name="placementY"></param>
        /// <param name="pionJoue"></param>
        public static void adversaireNiv1(bool[,] pions, bool[,] infos, string[,] grille, out int placementX, out int placementY, bool[] pionJoue)
        {
            char[] carac = { 'A', 'B', 'C', 'D' };
            Random alea = new Random();
            placementX = 0;
            placementY = 0;
            bool test = true;

            while (test == true) // on verifie que l'IA ne joue pas à un emplacement déjà pris !
            {
                placementX = alea.Next(0, 4);
                placementY = alea.Next(0, 4);
                test = infos[placementX, placementY*5 + 4];
            }
            placePion(placementX, placementY, infos, pionJoue);
            ActuGrille(grille, infos, pions);
        }
        /// <summary>
        /// Permet au joueur de placer un pion
        /// </summary>
        /// <param name="pions"></param>
        /// <param name="infos"></param>
        /// <param name="pionJoue"></param>
        /// <param name="grille"></param>
        /// <param name="placementX"></param>
        /// <param name="placementY"></param>
        public static void joueur(bool[,] pions, bool[,] infos, bool[] pionJoue, string[,] grille, out int placementX, out int placementY)
        {
            char[] carac = { 'A', 'B', 'C', 'D' };
            Console.WriteLine("Où placez-vous le pions ? (Ex : A2)");
            string coord = Console.ReadLine();
            char placement = coord[0];
            placementY = (int)Char.GetNumericValue(coord[1]);

            
            placementX = convertCoord(placement);
            bool test = infos[placementX, (placementY) * 5 - 1];
            while (test == true)// on vérifie que l'emplacement n'est pas déjà pris !
            {
                Console.WriteLine("Il y a déjà un pions à cet endroit !");
                Console.Write("Où placez-vous le pions ? (Ex : A2)");
                coord = Console.ReadLine();
                placement = coord[0];
                placementY = (int)Char.GetNumericValue(coord[1]);
                placementX = convertCoord(placement);
                test = infos[placementX, (placementY) * 5 -1];
            }
            placementY--;
            for (int i = 0; i < 5; i++)
            {
                infos[placementX, (placementY) * 5 + i] = pionJoue[i];
            }
            Console.Clear();
            ActuGrille(grille, infos, pions);
            actuAffichage(grille, 0,0, false);
            
        }
        /// <summary>
        /// Permet de virifier s'il y a victoire
        /// </summary>
        /// <param name="pos"></param>
        /// <param name="posy"></param>
        /// <param name="infos"></param>
        /// <returns></returns>
        public static bool verifVictoire(int posx, int posy, bool[,] infos)
        {
            bool[] arg = new bool[16];

            if (verifPions(posx, posy, infos, out arg))
            {
                for (int i = 0; i < 4; i++)
                {
                    if (arg[i] == arg[i + 4] && arg[i + 4] == arg[i + 8] &&  arg[i + 8] == arg[i + 12]) // on regarde si les 4 pions alignés ont au moins une caractéristique en commun
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// revoit les caractéristiques des 4 pions alignés
        /// </summary>
        /// <param name="posx"></param>
        /// <param name="posy"></param>
        /// <param name="infos"></param>
        /// <param name="arg"></param>
        /// <returns></returns>
        public static bool verifPions(int posx, int posy, bool[,] infos, out  bool[] arg) 
        {
            char[] carac = { 'A', 'B', 'C', 'D' };
            arg = new bool[16];
            int cpt = 0;
            int cpt2 = 0;
            for(int i =4; i<20; i = i + 5)
            {
                if (infos[posx, i] == true)
                {
                    cpt++;
                }
            }
            for(int i = 0; i<4; i++)
            {
                if (infos[i, posy*5 +4] == true)
                {
                    cpt2++;
                }
            }
            if (cpt == 4) // on test si 4 pions sont alignés sur une ligne
            {
                int indice = 0;
                for (int i = 0; i < 20; i++)
                {
                    if (i % 5 != 4)
                    {
                        arg[indice] = infos[posx, i]; // on récupère les caractéristiques des 4 pions dans le tableau arg
                        indice++;
                    }
                }
                return true;

            }
            if (cpt2 == 4) //// on test si 4 pions sont alignés sur une colonne
            {
                int indice = 0;
                for (int i = 0; i<4; i++)
                    for (int j = 0; j<4; j++)
                    {
                        arg[indice] = infos[i, posy * 5 + j];
                        indice++;
                    }
                return true;
            }
            
            
                
            int cpt3 = 4;
            int cpt4 = 0;
            for(int i = 0   ; i<4; i++)
            {
                if (infos[i, cpt3] == true)
                {
                    cpt4++;
                }
                cpt3 = cpt3 + 5;
            }
            int cpt5 = 4;
            int cpt6 = 0;
            for (int i = 0; i <4; i++)
            {
                if (infos[3-i, cpt5] == true)
                {
                    cpt6++;
                }
                cpt5 = cpt5 + 5;
            }
            if(cpt4 == 4) //// on test si 4 pions sont alignés sur la diag gauche
            {
                int indice = 0;
                int reste = 0;
                for(int i =0; i<4; i++)
                {
                    for (int j = reste; j < reste + 4; j++)
                    {

                        arg[indice] = infos[i, j]; 
                        indice++;
                    }
                    reste = reste + 5;
                }
                return true;
            }
            if (cpt6 == 4)// on test si 4 pions sont alignés sur la diag droite
            {
                int indice = 0;
                int reste = 0;
                for (int i = 0; i < 4; i++)
                {
                    for (int j = reste; j < reste + 4; j++)
                    {
                        arg[indice] = infos[3-i, j];
                        indice++;
                    }
                    reste = reste + 5;
                }
                return true;
            }
            
        return false;
        }
        /// <summary>
        /// Converti les coordonnée A,B,C,D en 0,1,2,3
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        public static int convertCoord(char pos)
        {
            int posx = 0;
            if (pos == 'A')
                posx = 0;
            if (pos == 'B')
                posx = 1;
            if (pos == 'C')
                posx = 2;
            if (pos == 'D')
                posx = 3;
            return posx;
        }
        /// <summary>
        /// Permet de choisir un pion dans les pions restants
        /// </summary>
        /// <param name="posx"></param>
        /// <param name="posy"></param>
        /// <param name="pions"></param>
        /// <returns></returns>
        public static bool[] choixPions(int posx, int posy, bool[,] pions)
        {
            bool[] pionJoue = new bool[5];
            for (int i = 0; i < 5; i++)
                pionJoue[i] = pions[posx, posy * 5 + i];
            pions[posx, (posy) * 5 + 4] = false;
            return pionJoue;
        }
        

        


        

        /// <summary>
        /// Initialise le tableau des pions.
        /// </summary>
        /// <returns></returns>
        public static bool[,] initPions()
        {
            int k, l, m;
            k = 0;
            l = 0;
            m = 0;
            bool[,] pions = new bool[4, 20];
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 20; j++)
                    pions[i, j] = true;
            for (int j = 0; j<4; j++)
                for (int i = 1; i < 21; i++)
                {
                    if (i % 5 == 1)
                        if (i % 10 == 1)
                            pions[j, i-1] = false;
                    if (i % 5 == 2)
                    {
                        if (k % 4 < 2)
                        {
                            pions[j, i - 1] = false;
                        }
                        k++;
                    }
                    if (i % 5 == 3)
                    {
                        if (l % 8 < 4)
                        {
                            pions[j, i - 1] = false;
                        }
                        l++;
                    }
                    if (i % 5 == 4)
                    {
                        if (m % 16 < 8)
                        {
                            pions[j, i - 1] = false;
                        }
                        m++;
                    }
                }
            return pions;
        }
        /// <summary>
        /// Actualise la grille de jeu en fonction de ce qu'il se passe
        /// </summary>
        /// <param name="grille"></param>
        /// <param name="infos"></param>
        /// <param name="pions"></param>
        public static void ActuGrille(string[,] grille, bool[,] infos, bool[,] pions)                            //Cette fonction va refaire la grille entièrement à chaque fois qu'une pièce est rajoutée     
        {
            int cpt3;
            int cpt2 = 0;
            int cpt;
            string[] tabEphemere = new string[9];
            for (int k = 0; k < 4; k = k + 1)  // la variable k va représenter la ligne en terme de figure : en effet k va occuper les lignes 0 à 8 puis 10 à 19...
            {

                cpt = 0;
                cpt3 = 0;
                for (int j = 0; j < 14; j++) // j représente les colonnes
                {
                    for (int i = cpt2; i < cpt2 + 9; i++) // i représente les lignes de k à k + 9
                    {
                        if (j < 7)
                        {
                            if (j % 2 == 1)
                            {
                                grille[i, j] = " | ";
                            }
                            else
                            {
                                if (infos[k, cpt + 4] == false)
                                {
                                    grille[i, j] = "                    ";
                                }
                                else
                                {
                                    tabEphemere = figure(infos[k, cpt], infos[k, cpt + 1], infos[k, cpt + 2], infos[k, cpt + 3]);  //on crée un tableau qui prend pour info les caractéristiques d'une figure située à la jème colonne et à la (k+9) ème ligne
                                    grille[i, j] = tabEphemere[i % 9];
                                }
                            }
                        }
                        else
                        {
                            if (j % 2 == 0)
                            {
                                grille[i, j] = " | ";
                            }
                            else
                            {
                                if (pions[k, cpt3 + 4] == false)
                                {
                                    grille[i, j] = "                    ";
                                }
                                else
                                {
                                    tabEphemere = figure(pions[k, cpt3], pions[k, cpt3 + 1], pions[k, cpt3 + 2], pions[k, cpt3 + 3]);  //on crée un tableau qui prend pour info les caractéristiques d'une figure située à la jème colonne et à la (k+9) ème ligne
                                    grille[i, j] = tabEphemere[i % 9];
                                }
                            }
                        }
                    }

                    if (j < 7 && j % 2 == 0)
                        cpt = cpt + 5;
                    if (j >= 7 && j % 2 == 1)
                    {
                        cpt3 = cpt3 + 5;
                    }
                }
            
                cpt2 = cpt2 + 9;
            }

            // -----------------------------------------------------------------------------------------------


        }
        /// <summary>
        /// Affiche la grille dans la console
        /// </summary>
        /// <param name="grille"></param>
        /// <param name="choixPionsX"></param>
        /// <param name="choixPionsY"></param>
        /// <param name="color"></param>
        public static void actuAffichage(string[,] grille, int choixPionsX, int choixPionsY, bool color)   // actualise l'affichage de la grille une fois celle-ci changée
        {
            int[] placement = { 7, 9, 11, 13 };
            char[] lettre = { 'A', 'B', 'C', 'D' };
            Console.WriteLine("                                               PLATEAU                                                                                    PIONS DISPONIBLES");
            Console.WriteLine("               1                       2                      3                       4                        1                       2                      3                       4");
            Console.WriteLine("     ---------------------------------------------------------------------------------------------     ---------------------------------------------------------------------------------------------");
            for (int i = 0; i < 36; i++)
            {
                if (i %9 == 4)
                    Console.Write(" {0}  | ", lettre[i/9]);
                for (int j = 0; j < 14; j++)
                {

                    {
                        if (j == 0 && i % 9 != 4)
                            Console.Write("    | ");
                        if (i >= choixPionsX * 9 && i < choixPionsX * 9 + 9 && j == placement[choixPionsY] && color == true)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            Console.Write(grille[i, j]);
                            Console.BackgroundColor = ConsoleColor.White;
         
                        }
                        else
                        
                            Console.Write(grille[i, j]);

                        if (j == 6)
                            Console.Write("    || ");
                        if (j == 13)
                            Console.Write(" | ");


                    }
                }
                Console.WriteLine();
                if (i % 9 == 8)
                {
                    Console.WriteLine("     -------------------------------------------------------------------------------------------     ---------------------------------------------------------------------------------------------"); // double retour à la ligne lorsque l'on change de figure)
                }
            }
        }
        /// <summary>
        /// Permet de choisir une figure
        /// </summary>
        /// <param name="taille"></param>
        /// <param name="interieur"></param>
        /// <param name="forme"></param>
        /// <param name="couleur"></param>
        /// <returns></returns>
        static string[] figure(bool taille, bool interieur, bool forme, bool couleur)
        {
            string[] oui = new string[1];

            if (taille == true && interieur == true && forme ==true && couleur== true)
                return carreGrandPleinFonce();
            if (!taille && interieur && forme && couleur)
                return carrePetitPleinFonce();
            if (taille && !interieur && forme && couleur)
                return carreGrandVideFonce();
            if (taille && interieur && !forme && couleur)
                return cercleGrandPleinFonce();
            if (taille && interieur && forme && !couleur)
                return carreGrandPleinClair();
            if (!taille && !interieur && forme && couleur)
                return carrePetitVideFonce();
            if (!taille && interieur && !forme && couleur)
                return cerclePetitPleinFonce();
            if (!taille && interieur && forme && !couleur)
                return carrePetitPleinClair();
            if (taille && !interieur && forme && !couleur)
                return carreGrandVideClair();
            if (taille && !interieur && !forme && couleur)
                return cercleGrandVideFonce();
            if (taille && interieur && !forme && !couleur)
                return cercleGrandPleinClair();
            if (!taille && !interieur && !forme && couleur)
                return cerclePetitVideFonce();
            if (!taille && interieur && !forme && !couleur)
                return cerclePetitPleinClair();
            if (!taille && !interieur && forme && !couleur)
                return carrePetitVideClair();
            if (taille && !interieur && !forme && !couleur)
                return cercleGrandVideClair();
            if (!taille && !interieur && !forme && !couleur)
                return cerclePetitVideClair();
            return oui;
                                                                

        }
        /// <summary>
        /// Initialise la grille de jeu
        /// </summary>
        static void initGrille()
        {
            for (int j = 0; j < 4; j++)
            {
                Console.WriteLine("+---+---+---+---+");
                for (int i = 0; i < 4; i++)
                {
                    Console.Write("|   ");
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine("+---+---+---+---+");
        }
        static string[] carreGrandPleinFonce()
        {
            string[] affichagePion = new string[9];
            for (int i = 0; i < 9; i++)
            {
                affichagePion[i] = "@@@@@@@@@@@@@@@@@@@@";
            }
            return affichagePion;
        }
        static string[] carreGrandVideFonce()
        {
            string[] affichagePion = new string[9];

            affichagePion[0] = "@@@@@@@@@@@@@@@@@@@@";

            for (int i = 1; i < 8; i++)
                affichagePion[i] = "@                  @";
            affichagePion[8] = "@@@@@@@@@@@@@@@@@@@@";
            return affichagePion;
        }
        static string[] carrePetitPleinFonce()
        {
            string[] affichagePion = new string[9];
            affichagePion[0] = "                    ";
            for (int i = 1; i < 8; i++)
                affichagePion[i] = "   @@@@@@@@@@@@@@   ";

            affichagePion[8] = "                    ";
            return affichagePion;
        }
        static string[] carrePetitVideFonce()
        {
            string[] affichagePion = new string[9];
            affichagePion[0] = "                    ";
            affichagePion[1] = "   @@@@@@@@@@@@@@   ";
            for (int i = 2; i < 7; i++)
                affichagePion[i] = "   @            @   ";
            affichagePion[7] = "   @@@@@@@@@@@@@@   ";
            affichagePion[8] = "                    ";
            return affichagePion;
        }
        static string[] cercleGrandPleinFonce()
        {
            string[] affichagePion = new string[9];
            int j = 0;
            for (j = 0; j <= 8; j = j + 1)
            {
                if (j == 0 || j == 8)
                {
                    affichagePion[j] = "         @@         ";
                }
                if (j == 1 || j == 7)
                {
                    affichagePion[j] = "      @@@@@@@@      ";
                }
                if (j == 2 || j == 6)
                {
                    affichagePion[j] = "   @@@@@@@@@@@@@@   ";
                }
                if (j == 3 || j == 5)
                {
                    affichagePion[j] = " @@@@@@@@@@@@@@@@@@ ";
                }
                if (j == 4)
                {
                    affichagePion[j] = "@@@@@@@@@@@@@@@@@@@@";
                }
            }
            return affichagePion;
        }


        // petit cercle plein 
        static string[] cerclePetitPleinFonce()
        {
            string[] affichagePion = new string[9];
            int j = 0;
            for (j = 0; j <= 8; j = j + 1)
            {
                if (j == 0 || j == 8)
                {
                    affichagePion[j] = "                    ";
                }
                if (j == 1 || j == 7)
                {
                    affichagePion[j] = "         @@         ";
                }
                if (j == 2 || j == 6)
                {
                    affichagePion[j] = "      @@@@@@@@      ";
                }
                if (j == 3 || j == 5)
                {
                    affichagePion[j] = "    @@@@@@@@@@@@    ";
                }
                if (j == 4)
                {
                    affichagePion[j] = "   @@@@@@@@@@@@@@   ";
                }
            }
            return affichagePion;
        }

        // Grand cercle vide
        static string[] cercleGrandVideFonce()
        {
            string[] affichagePion = new string[9];
            int j = 0;
            for (j = 0; j <= 8; j = j + 1)
            {
                if (j == 0 || j == 8)
                {
                    affichagePion[j] = "         @@         ";
                }
                if (j == 1 || j == 7)
                {
                    affichagePion[j] = "      @      @      ";
                }
                if (j == 2 || j == 6)
                {
                    affichagePion[j] = "   @            @   ";
                }
                if (j == 3 || j == 5)
                {
                    affichagePion[j] = " @                @ ";
                }
                if (j == 4)
                {
                    affichagePion[j] = "@                  @";
                }
            }
            return affichagePion;
        }
        //petit cercle vide

        public static string[] cerclePetitVideFonce()
        {

            string[] affichagePion = new string[9];
            int j = 0;
            for (j = 0; j <= 8; j = j + 1)
            {
                if (j == 0 || j == 8)
                {
                    affichagePion[j] = "                    ";
                }
                if (j == 1 || j == 7)
                {
                    affichagePion[j] = "         @@         ";
                }
                if (j == 2 || j == 6)
                {
                    affichagePion[j] = "      @      @      ";
                }
                if (j == 3 || j == 5)
                {
                    affichagePion[j] = "    @          @    ";
                }
                if (j == 4)
                {
                    affichagePion[j] = "   @            @   ";
                }
            }
            return affichagePion;
        }
        //--------------------------------
        static string[] carreGrandPleinClair()
        {
            string[] affichagePion = new string[9];
            for (int i = 0; i < 9; i++)
            {
                affichagePion[i] = "oooooooooooooooooooo";
            }
            return affichagePion;
        }
        static string[] carreGrandVideClair()
        {
            string[] affichagePion = new string[9];

            affichagePion[0] = "oooooooooooooooooooo";

            for (int i = 1; i < 8; i++)
                affichagePion[i] = "o                  o";
            affichagePion[8] = "oooooooooooooooooooo";
            return affichagePion;
        }
        static string[] carrePetitPleinClair()
        {
            string[] affichagePion = new string[9];
            affichagePion[0] = "                    ";
            for (int i = 1; i < 8; i++)
                affichagePion[i] = "   oooooooooooooo   ";

            affichagePion[8] = "                    ";
            return affichagePion;
        }
        static string[] carrePetitVideClair()
        {
            string[] affichagePion = new string[9];
            affichagePion[0] = "                    ";
            affichagePion[1] = "   oooooooooooooo   ";
            for (int i = 2; i < 7; i++)
                affichagePion[i] = "   o            o   ";
            affichagePion[7] = "   oooooooooooooo   ";
            affichagePion[8] = "                    ";
            return affichagePion;
        }
        static string[] cercleGrandPleinClair()
        {
            string[] affichagePion = new string[9];
            int j = 0;
            for (j = 0; j <= 8; j = j + 1)
            {
                if (j == 0 || j == 8)
                {
                    affichagePion[j] = "         oo         ";
                }
                if (j == 1 || j == 7)
                {
                    affichagePion[j] = "      oooooooo      ";
                }
                if (j == 2 || j == 6)
                {
                    affichagePion[j] = "   oooooooooooooo   ";
                }
                if (j == 3 || j == 5)
                {
                    affichagePion[j] = " oooooooooooooooooo ";
                }
                if (j == 4)
                {
                    affichagePion[j] = "oooooooooooooooooooo";
                }
            }
            return affichagePion;
        }


        // petit cercle plein 
        static string[] cerclePetitPleinClair()
        {
            string[] affichagePion = new string[9];
            int j = 0;
            for (j = 0; j <= 8; j = j + 1)
            {
                if (j == 0 || j == 8)
                {
                    affichagePion[j] = "                    ";
                }
                if (j == 1 || j == 7)
                {
                    affichagePion[j] = "         oo         ";
                }
                if (j == 2 || j == 6)
                {
                    affichagePion[j] = "      oooooooo      ";
                }
                if (j == 3 || j == 5 )
                {
                    affichagePion[j] = "    oooooooooooo    ";
                }
                if (j == 4)
                {
                    affichagePion[j] = "   oooooooooooooo   ";
                }

            }
            return affichagePion;
        }

        // Grand cercle vide
        static string[] cercleGrandVideClair()
        {
            string[] affichagePion = new string[9];
            int j = 0;
            for (j = 0; j <= 8; j = j + 1)
            {
                if (j == 0 || j == 8)
                {
                    affichagePion[j] = "         oo         ";
                }
                if (j == 1 || j == 7)
                {
                    affichagePion[j] = "      o      o      ";
                }
                if (j == 2 || j == 6)
                {
                    affichagePion[j] = "   o            o   ";
                }
                if (j == 3 || j == 5)
                {
                    affichagePion[j] = " o                o ";
                }
                if (j == 4)
                {
                    affichagePion[j] = "o                  o";
                }
            }
            return affichagePion;
        }
        //petit cercle vide

        public static string[] cerclePetitVideClair()
        {

            string[] affichagePion = new string[9];
            int j = 0;
            for (j = 0; j <= 8; j = j + 1)
            {
                if (j == 0 || j == 8)
                {
                    affichagePion[j] = "                    ";
                }
                if (j == 1 || j == 7)
                {
                    affichagePion[j] = "         oo         ";
                }
                if (j == 2 || j == 6)
                {
                    affichagePion[j] = "      o      o      ";
                }
                if (j == 3 || j == 5)
                {
                    affichagePion[j] = "    o          o    ";
                }
                if (j == 4)
                {
                    affichagePion[j] = "   o            o   ";
                }
            }
            return affichagePion;
        }
    }
}
