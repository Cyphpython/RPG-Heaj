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
 
        Stats stats = new Stats();

        static string input;

        public void Run()
        {
            Console.Clear();
            Console.WriteLine("Bienvenue sur RPG Heaj");
            Console.WriteLine("Entrez commencer pour debutez le jeux");
            Console.WriteLine("Ou entrez Help pour affichez les commandes disponibles");
            Console.WriteLine(" ");
            Console.WriteLine("Entrez votre choix : ");
            input = Console.ReadLine();
            if (input.ToLower() == "commencer" || input.ToLower() == "go")
            {
                Console.Clear();
                map.mapSpawn();
                Console.WriteLine(" ");
                Console.WriteLine("Entrez votre choix : ");
                while (true)
                {
                    input = Console.ReadLine();
                    if (input.ToLower() == "go north")
                    {
                        Console.WriteLine("Vous vous dirigez vers la prochaine salle ");
                        Thread.Sleep(1000);
                        Console.Clear();
                        string input;
                        map.Salle1();
                        Console.WriteLine(" ");
                        Console.WriteLine("Entrez votre choix : ");
                        input = Console.ReadLine();
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
        }
    }
}
