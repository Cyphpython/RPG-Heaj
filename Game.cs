using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RPG_Heaj
{
    public class Game
    {
        Inventory inventory = new Inventory();
        Map map = new Map();
        Boss boss = new Boss();
 
        Stats stats = new Stats();

        static string input;
        public bool mapspawnupdated = false;
        public bool salle1updated = false;
        public bool salle1gaucheupdated = false;
        public bool salle1droiteupdated = false;

        public void Run()
        {
            Console.Clear();
            Console.WriteLine("Bienvenue sur RPG Heaj");
            Console.WriteLine("Entrez commencer pour debutez le jeux");
            Console.WriteLine("Ou entrez Help pour affichez les commandes disponibles");
            Console.WriteLine(" ");
            Console.WriteLine("Entrez votre choix : ");
            input = Console.ReadLine();
                                                    //DEBUG!!!
            if (input.ToLower() == "commencer" || input.ToLower() == "go")
            {
                map.mapspawn = true;
                Console.Clear();
                map.mapSpawn();
                Console.WriteLine(" ");
                Console.WriteLine("Entrez votre choix : ");
                while (true)
                {
                    //salle 1
                    input = Console.ReadLine();
                    if ( map.salle1 == false && input.ToLower() == "go north")
                    {
                        map.salle1 = true;
                        Console.WriteLine("Vous vous dirigez vers la prochaine salle ");
                        Thread.Sleep(1000);
                        Console.Clear();
                        map.Salle1();
                        Console.WriteLine(" ");
                        Console.WriteLine("Entrez votre choix : ");
                        input = Console.ReadLine();
                    }
                    //salle 1 gauche updated pour salle 1 normal
                    if (map.salle1 == true && input.ToLower() == "go east")
                    {
                        salle1gaucheupdated = true;
                        map.salle1 = false;
                        Console.WriteLine("Vous vous dirigez vers la prochaine salle ");
                        Thread.Sleep(1000);
                        Console.Clear();
                        SalleGaucheUpdated();
                        Console.WriteLine(" ");
                        Console.WriteLine("Entrez votre choix : ");
                        input = Console.ReadLine();
                    }
                    //salle 1 gauche updated pour salle 1 updated
                    else if (salle1updated == true && input.ToLower() == "go east")
                    {
                        salle1gaucheupdated = true;
                        salle1updated = false;
                        Console.WriteLine("Vous vous dirigez vers la prochaine salle ");
                        Thread.Sleep(1000);
                        Console.Clear();
                        SalleGaucheUpdated();
                        Console.WriteLine(" ");
                        Console.WriteLine("Entrez votre choix : ");
                        input = Console.ReadLine();
                    }
                    //salle 1 droite updated pour salle 1 normal
                    if (map.salle1 == true && input.ToLower() == "go west")
                    {
                        salle1droiteupdated = true;
                        map.salle1 = false;
                        Console.WriteLine("Vous vous dirigez vers la prochaine salle ");
                        Thread.Sleep(1000);
                        Console.Clear();
                        SalleDroiteUpdated();
                        Console.WriteLine(" ");
                        Console.WriteLine("Entrez votre choix : ");
                        input = Console.ReadLine();
                    }
                    //salle 1 droite updated pour salle 1 updated
                    else if (salle1updated == true && input.ToLower() == "go west")
                    {
                        salle1droiteupdated = true;
                        salle1updated = false;
                        Console.WriteLine("Vous vous dirigez vers la prochaine salle ");
                        Thread.Sleep(1000);
                        Console.Clear();
                        SalleDroiteUpdated();
                        Console.WriteLine(" ");
                        Console.WriteLine("Entrez votre choix : ");
                        input = Console.ReadLine();
                    }
                    //salle 1 gauche
                    else if (map.salle1 == true && input.ToLower() == "go east")
                    {
                        map.salle1gauche = true;
                        map.salle1 = false;
                        Console.WriteLine("Vous vous dirigez vers la prochaine salle ");
                        Thread.Sleep(1000);
                        Console.Clear();
                        map.Salle1Gauche();
                        Console.WriteLine(" ");
                        Console.WriteLine("Entrez votre choix : ");
                        input = Console.ReadLine();
                    }
                    else if (salle1updated == true && input.ToLower() == "go east")
                    {
                        map.salle1gauche = true;
                        map.salle1 = false;
                        salle1updated = false;
                        Console.WriteLine("Vous vous dirigez vers la prochaine salle ");
                        Thread.Sleep(1000);
                        Console.Clear();
                        map.Salle1Gauche();
                        Console.WriteLine(" ");
                        Console.WriteLine("Entrez votre choix : ");
                        input = Console.ReadLine();
                    }
                    //salle 1 updated si on est a gauche
                    else if (map.salle1gauche == true && input.ToLower() == "go west")
                    {
                        salle1updated = true;
                        map.salle1 = false;
                        map.salle1gauche = false;
                        Console.WriteLine("Vous vous dirigez vers la prochaine salle ");
                        Thread.Sleep(1000);
                        Console.Clear();
                        salle1Updated();
                        Console.WriteLine(" ");
                        Console.WriteLine("Entrez votre choix : ");
                        input = Console.ReadLine();
                    }
                    //salle 1 normal si on est a gauche
                    else if(map.salle1gauche == true && input.ToLower() == "go west")
                    {
                        salle1updated = false;
                        map.salle1 = true;
                        map.salle1gauche = false;
                        Console.WriteLine("Vous vous dirigez vers la prochaine salle ");
                        Thread.Sleep(1000);
                        Console.Clear();
                        map.Salle1();
                        Console.WriteLine(" ");
                        Console.WriteLine("Entrez votre choix : ");
                        input = Console.ReadLine();
                    }
                    //salle 1 droite
                    else if (map.salle1 == true && input.ToLower() == "go west")
                    {
                        map.salle1droite = true;
                        map.salle1 = false;
                        Console.WriteLine("vous vous dirigez vers la prochaine salle");
                        Thread.Sleep(1000);
                        Console.Clear();
                        map.Salle1Droite();
                        Console.WriteLine(" ");
                        Console.WriteLine("Entrez votre choix");
                        input = Console.ReadLine();
                    }
                    else if (salle1updated == true && input.ToLower() == "go west")
                    {
                        map.salle1droite = true;
                        salle1updated = false;
                        Console.WriteLine("vous vous dirigez vers la prochaine salle");
                        Thread.Sleep(1000);
                        Console.Clear();
                        map.Salle1Droite();
                        Console.WriteLine(" ");
                        Console.WriteLine("Entrez votre choix");
                        input = Console.ReadLine();
                    }
                    //salle 1 updated si on est a droite
                    else if (map.salle1droite == true && input.ToLower() == "go east")
                    {
                        salle1updated = true;
                        map.salle1 = false;
                        Console.WriteLine("Vous vous dirigez vers la prochaine salle ");
                        Thread.Sleep(1000);
                        Console.Clear();
                        salle1Updated();
                        Console.WriteLine(" ");
                        Console.WriteLine("Entrez votre choix : ");
                        input = Console.ReadLine();
                    }
                    //salle 2 (boss room)
                    else if (map.salle1 == true && input.ToLower() == "go north")
                    {
                        map.salle2 = true;
                        map.salle1 = false;
                        Console.WriteLine("vous vous dirigez vers la prochaine salle");
                        Thread.Sleep(1000);
                        Console.Clear();
                        map.Salle2();
                        boss.premierephase = true;
                        Console.WriteLine(" ");
                        Console.WriteLine("Entrez votre choix");
                        input = Console.ReadLine();
                        if (boss.premierephase == true && boss.HP == 25)
                        {
                            boss.premierephase = false;
                            boss.deuxiemephase = true;
                            boss.ATKPoint = 40;
                            if (boss.HP == 0)
                            {
                                boss.premierephase = false;
                                boss.deuxiemephase = false;
                                Console.WriteLine("Boss Vaincu");
                                Thread.Sleep(2000);
                                Console.Clear();
                                Thread.Sleep(1000);
                                Console.WriteLine("Félicitations vous avez vaincu le boss");
                                Thread.Sleep(1000);
                                Console.WriteLine("Vous pouvez maintenant vous enfuir du donjon");
                                Console.WriteLine(" ");
                                Console.WriteLine("Entrez Exit pour quitter le donjon");
                                string sortie = Console.ReadLine();
                                if(sortie.ToLower() == "exit")
                                {
                                    Exit();
                                }
                            }
                        }
                    }
                    else if (salle1updated == true && input.ToLower() == "go north")
                    {
                        map.salle2 = true;
                        salle1updated = false;
                        Console.WriteLine("vous vous dirigez vers la prochaine salle");
                        Thread.Sleep(1000);
                        Console.Clear();
                        map.Salle2();
                        boss.premierephase = true;
                        Console.WriteLine(" ");
                        Console.WriteLine("Entrez votre choix");
                        input = Console.ReadLine();
                        if (boss.premierephase == true && boss.HP == 25)
                        {
                            boss.premierephase = false;
                            boss.deuxiemephase = true;
                            boss.ATKPoint = 40;
                            if (boss.HP == 0)
                            {
                                boss.premierephase = false;
                                boss.deuxiemephase = false;
                                Console.WriteLine("Boss Vaincu");
                                Thread.Sleep(2000);
                                Console.Clear();
                                Thread.Sleep(1000);
                                Console.WriteLine("Félicitations vous avez vaincu le boss");
                                Thread.Sleep(1000);
                                Console.WriteLine("Vous pouvez maintenant vous enfuir du donjon");
                                Console.WriteLine(" ");
                                Console.WriteLine("Entrez Exit pour quitter le donjon");
                                string sortie = Console.ReadLine();
                                if (sortie.ToLower() == "exit")
                                {
                                    Exit();
                                }
                            }
                        }
                    }
                    else if (map.salle1 == true && input.ToLower() == "go south")
                    {
                        map.mapspawn = true;
                        map.salle1 = false;
                        mapspawnupdated = false;
                        Console.WriteLine("Vous vous dirigez vers la prochaine salle ");
                        Thread.Sleep(1000);
                        Console.Clear();
                        map.mapSpawn();
                        Console.WriteLine(" ");
                        Console.WriteLine("Entrez votre choix : ");
                        input = Console.ReadLine();

                    }
                    else if (salle1updated == true && input.ToLower() == "go south")
                    {
                        map.mapspawn = true;
                        salle1updated = false;
                        mapspawnupdated = false;
                        Console.WriteLine("Vous vous dirigez vers la prochaine salle ");
                        Thread.Sleep(1000);
                        Console.Clear();
                        map.mapSpawn();
                        Console.WriteLine(" ");
                        Console.WriteLine("Entrez votre choix : ");
                        input = Console.ReadLine();

                    }
                    else if (map.salle1 == true && input.ToLower() == "go south")
                    {
                        mapspawnupdated = true;
                        map.mapspawn = false;
                        map.salle1 = false;
                        Console.WriteLine("Vous vous dirigez vers la prochaine salle ");
                        Thread.Sleep(1000);
                        Console.Clear();
                        MapSpawnUpdated();
                        Console.WriteLine(" ");
                        Console.WriteLine("Entrez votre choix : ");
                        input = Console.ReadLine();
                    }
                    else if (salle1updated == true && input.ToLower() == "go south")
                    {
                        mapspawnupdated = true;
                        map.mapspawn = false;
                        salle1updated = false;
                        Console.WriteLine("Vous vous dirigez vers la prochaine salle ");
                        Thread.Sleep(1000);
                        Console.Clear();
                        MapSpawnUpdated();
                        Console.WriteLine(" ");
                        Console.WriteLine("Entrez votre choix : ");
                        input = Console.ReadLine();
                    }
                    //DEBUG !!!
                    else if ( map.salle2 = true && input.ToLower() == "kill")
                    {
                        Exit();
                    }
                    else if (input.ToLower().StartsWith("take"))
                    {
                        string[] objectsToTake = input.Split(' ');
                        if (objectsToTake.Length < 2)
                        {
                            Console.WriteLine("Veuillez spécifier un objet à prendre.");
                        }
                        else
                        {
                            string objectToTake = objectsToTake[1];
                            if (inventory.HasItem(objectToTake))
                            {
                                Console.WriteLine(objectToTake + " was already in the inventory");
                            }
                            else
                            {
                                int quantity = map.GetQuantityOfItem(objectToTake);
                                if (quantity > 0)
                                {
                                    Console.WriteLine(quantity + " " + objectToTake + " was added to inventory");
                                    inventory.AddToInventory(objectToTake, quantity);
                                }
                                else
                                {
                                    Console.WriteLine("There are no " + objectToTake + " here");
                                }
                            }
                        }
                    }

                    //Fonctions
                    else if (input.ToLower() == "open inventory")
                    {
                        inventory.DisplayInventory();
                    }
                    else if (input.ToLower() == "read note")
                    {
                        Note();
                    }
                    else
                    {
                        ConsoleColorRedText();
                        Console.WriteLine("Invalid Command");
                        Console.ResetColor();
                    }
                }
            }
            else if (input.ToLower() == "help")
            {
                DisplayHelp();
                Console.WriteLine(" ");
                Console.WriteLine("Appuyez sur Entrez pour revenir au menu");
                Console.ReadKey();
                Run();
            }
            else
            {
                ConsoleColorRedText();
                Console.WriteLine("Invalid Command");
                Thread.Sleep(2000);
                Console.ResetColor();
                Run();
            }
            void DisplayHelp()
            {
                Console.WriteLine("Les commandes disponibles sont : ");
                Console.WriteLine(" -----------------inventory Commands----------------------");
                Console.WriteLine(" - take 'ItemName' : Prendre l'item (exemple : take sword = prendre l'épée)");
                Console.WriteLine(" - read note : lire la note");
                Thread.Sleep(1000);
                Console.WriteLine(" - open inventory : Affichez votre inventaire");
                Thread.Sleep(1000);
                Console.WriteLine(" - equip 'ArmorParts': equipez l'armure (exemple : equip helmet = equipez le casque)");
                Console.WriteLine(" -----------------Go Commands----------------------");
                Console.WriteLine(" - go 'Direction' : Allez vers cette direction(exemple : go north = allez vers le nord)");
                Console.WriteLine(" -----------------Fight Commands----------------------");
                Console.WriteLine(" attack : attaquez l'ennemi");
                Thread.Sleep(1000);
                Console.WriteLine(" block : se proteger ");
                Thread.Sleep(1000);
                Console.WriteLine(" spell attack : attaquez l'ennemi avec un sort");
                Thread.Sleep(1000);
                Console.WriteLine(" heal : se soigner");
                Thread.Sleep(2000);
            }
            void ConsoleColorRedText()
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            void Note()
            {
                if (inventory.HasItem("note"))
                {
                    Console.WriteLine("Apres 3 jours d'exploration on enfin mit la main sur de l'equipement");
                    Console.WriteLine("je pense que on n'est fin pres à affronter cette monstruosité");
                    Console.WriteLine("à ce qu'il parait c'est la plus feroce des creatures qui n'ait jamais existé");
                    Console.WriteLine("mais le sorcier du village nous a revele son secret un moyen qui nous permettrait de battre cette créature");
                    Console.WriteLine("cette maudite créature est vulnerable à la magie, quel ironie.");    
                }
                else if (inventory.HasNotItem("note"))
                {
                    Console.WriteLine("Vous ne possédez pas la note");
                }
            }
            void Exit()
            {
                Console.Clear();
                Console.WriteLine("merci d'avoir jouer");
                Thread.Sleep(2000);
                Console.WriteLine("J'espere que cette experience vous aura plus");
                Thread.Sleep(2000);
                Console.WriteLine("Au revoir");
                Thread.Sleep(3000);
                Environment.Exit(0);
            }

            void salle1Updated()
            {
                if (inventory.HasItem("torche") && inventory.HasNotItem("casque"))
                {
                    Console.WriteLine("Vous arrivez dans une salle sombre");
                    Console.WriteLine("la seul source de lumiere est un petit interstice dans la roche");
                    Console.WriteLine("vos directions possible sont : Nord , Est , West , Sud");
                    Console.WriteLine("vous y trouvez : ");

                    map.itemsInRoom = new Dictionary<string, int>();

                    map.itemsInRoom["casque"] = 1;

                    foreach (var item in map.itemsInRoom)
                    {
                        Console.WriteLine(item.Value + " " + item.Key);
                    }
                }
                else if (inventory.HasItem("torche") && inventory.HasItem("casque"))
                {
                    Console.WriteLine("Vous arrivez dans une salle sombre");
                    Console.WriteLine("la seul source de lumiere est un petit interstice dans la roche");
                    Console.WriteLine("vos directions possible sont : Nord , Est , West , Sud");
                    Console.WriteLine("vous n'y trouvez rien : ");
                }
                else if (inventory.HasItem("casque") && inventory.HasNotItem("torche"))
                {
                    Console.WriteLine("Vous arrivez dans une salle sombre");
                    Console.WriteLine("la seul source de lumiere est un petit interstice dans la roche");
                    Console.WriteLine("vos directions possible sont : Nord , Est , West , Sud");
                    Console.WriteLine("vous y trouvez : ");

                    map.itemsInRoom = new Dictionary<string, int>();

                    map.itemsInRoom["torche"] = 1;

                    foreach (var item in map.itemsInRoom)
                    {
                        Console.WriteLine(item.Value + " " + item.Key);
                    }
                }
                else if (inventory.HasItem("casque") && inventory.HasItem("torche"))
                {
                    Console.WriteLine("Vous arrivez dans une salle sombre");
                    Console.WriteLine("la seul source de lumiere est un petit interstice dans la roche");
                    Console.WriteLine("vos directions possible sont : Nord , Est , West , Sud");
                    Console.WriteLine("vous n'y trouvez rien : ");
                }
                else
                {
                    map.Salle1();
                }
            }
            void SalleGaucheUpdated()
            {
                if (inventory.HasItem("note"))
                {
                    Console.WriteLine("Vous arrivez dans une salle contenant des tentes et un feu de camp ");
                    Console.WriteLine("vos directions possible sont : West");
                    Console.WriteLine("Vous n'y trouvez rien: ");
                }
                else
                {
                    map.Salle1Gauche();
                }
            }
            void SalleDroiteUpdated()
            {
                if (inventory.HasItem("Staff") && inventory.HasNotItem("FireSpell"))
                {
                    Console.WriteLine("Vous arrivez dans une salle avec ce qui semble etre les restes d'un magicien ");
                    Console.WriteLine("vos directions possible sont : est");
                    Console.WriteLine("Vous y trouvez : ");

                    map.itemsInRoom = new Dictionary<string, int>();

                    map.itemsInRoom["FireSpell"] = 1;

                    foreach (var item in map.itemsInRoom)
                    {
                        Console.WriteLine(item.Value + " " + item.Key);
                    }
                }
                else if (inventory.HasItem("Staff") && inventory.HasItem("FireSpell"))
                {
                    Console.WriteLine("Vous arrivez dans une salle avec ce qui semble etre les restes d'un magicien ");
                    Console.WriteLine("vos directions possible sont : est");
                    Console.WriteLine("Vous n'y trouvez rien : ");
                }
                else if (inventory.HasItem("FireSpell") && inventory.HasNotItem("Staff"))
                {
                    Console.WriteLine("Vous arrivez dans une salle avec ce qui semble etre les restes d'un magicien ");
                    Console.WriteLine("vos directions possible sont : est");
                    Console.WriteLine("Vous y trouvez : ");

                    map.itemsInRoom = new Dictionary<string, int>();

                    map.itemsInRoom["Staff"] = 1;

                    foreach (var item in map.itemsInRoom)
                    {
                        Console.WriteLine(item.Value + " " + item.Key);
                    }
                }
                else if (inventory.HasItem("FireSpell") && inventory.HasItem("Staff"))
                {
                    Console.WriteLine("Vous arrivez dans une salle avec ce qui semble etre les restes d'un magicien ");
                    Console.WriteLine("vos directions possible sont : est");
                    Console.WriteLine("Vous n'y trouvez rien : ");
                }
                else
                {
                    map.Salle1Droite();
                }
            }
            void MapSpawnUpdated()
            {
                if (inventory.HasItem("sword") && inventory.HasNotItem("shield") && inventory.HasNotItem("potion"))
                {
                    Console.WriteLine("Vous êtes de retour dans la zone de Spawn");
                    Console.WriteLine("Vos directions possibles sont : Nord ");
                    Console.WriteLine("Vous y trouvez : ");

                    map.itemsInRoom = new Dictionary<string, int>();

                    map.itemsInRoom["shield"] = 1;
                    map.itemsInRoom["potion"] = 3;

                    foreach (var item in map.itemsInRoom)
                    {
                        Console.WriteLine(item.Value + " " + item.Key);
                    }
                }
                else if (inventory.HasItem("sword") && inventory.HasItem("shield") && inventory.HasNotItem("potion"))
                {
                    Console.WriteLine("Vous êtes de retour dans la zone de Spawn");
                    Console.WriteLine("Vos directions possibles sont : Nord ");
                    Console.WriteLine("Vous n'y trouvez rien : ");
                }
                else if (inventory.HasItem("shield") && inventory.HasNotItem("sword") && inventory.HasNotItem("potion"))
                {
                    Console.WriteLine("Vous êtes de retour dans la zone de Spawn");
                    Console.WriteLine("Vos directions possibles sont : Nord ");
                    Console.WriteLine("Vous y trouvez : ");

                    map.itemsInRoom = new Dictionary<string, int>();

                    map.itemsInRoom["sword"] = 1;
                    map.itemsInRoom["potion"] = 3;

                    foreach (var item in map.itemsInRoom)
                    {
                        Console.WriteLine(item.Value + " " + item.Key);
                    }
                }
                else if (inventory.HasItem("shield") && inventory.HasItem("sword") && inventory.HasNotItem("potion"))
                {
                    Console.WriteLine("Vous êtes de retour dans la zone de Spawn");
                    Console.WriteLine("Vos directions possibles sont : Nord ");
                    Console.WriteLine("Vous n'y trouvez rien : ");
                }
                else if (inventory.HasNotItem("shield") && inventory.HasNotItem("sword") && inventory.HasItem("potion"))
                {
                    Console.WriteLine("Vous êtes de retour dans la zone de Spawn");
                    Console.WriteLine("Vos directions possibles sont : Nord ");
                    Console.WriteLine("Vous y trouvez : ");

                    map.itemsInRoom = new Dictionary<string, int>();

                    map.itemsInRoom["sword"] = 1;
                    map.itemsInRoom["shield"] = 1;

                    foreach (var item in map.itemsInRoom)
                    {
                        Console.WriteLine(item.Value + " " + item.Key);
                    }
                }
                else if (inventory.HasNotItem("shield") && inventory.HasItem("sword") && inventory.HasItem("potion"))
                {
                    Console.WriteLine("Vous êtes de retour dans la zone de Spawn");
                    Console.WriteLine("Vos directions possibles sont : Nord ");
                    Console.WriteLine("Vous n'y trouvez rien : ");
                }
                else if (inventory.HasItem("shield") && inventory.HasNotItem("sword") && inventory.HasItem("potion"))
                {
                    Console.WriteLine("Vous êtes de retour dans la zone de Spawn");
                    Console.WriteLine("Vos directions possibles sont : Nord ");
                    Console.WriteLine("Vous n'y trouvez rien : ");
                }
                else if (inventory.HasItem("shield") && inventory.HasItem("sword") && inventory.HasItem("potion"))
                {
                    Console.WriteLine("Vous êtes de retour dans la zone de Spawn");
                    Console.WriteLine("Vos directions possibles sont : Nord ");
                    Console.WriteLine("Vous n'y trouvez rien : ");
                }
                else
                {
                    map.mapSpawn();
                }
            }
        }
    }
}
