using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RPG_Heaj
{
    public class Map
    {
        Inventory inventory = new Inventory();

        public Dictionary<string, int> itemsInRoom = new Dictionary<string, int>();

        public bool mapspawn = false;
        public bool salle1 = false;
        public bool salle1gauche = false;
        public bool salle1droite = false;
        public bool salle2 = false;
        public void mapSpawn()
        {
            Console.WriteLine("Vous etes dans la zone de Spawn");
            Console.WriteLine("Vos directions possibles sont : Nord ");
            Console.WriteLine("Vous y trouvez : ");
            itemsInRoom["sword"] = 1;
            itemsInRoom["shield"] = 1;
            itemsInRoom["potion"] = 3;

            foreach (var item in itemsInRoom)
            {
                Console.WriteLine(item.Value + " " + item.Key);
            }
        }
        public void Salle1()
        {
            Console.WriteLine("Vous arrivez dans une salle sombre");
            Console.WriteLine("la seul source de lumiere est un petit interstice dans la roche");
            Console.WriteLine("vos directions possible sont : Nord , Est , West , Sud");
            Console.WriteLine("vous y trouvez : ");

            itemsInRoom = new Dictionary<string, int>();

            itemsInRoom["torche"] = 1;
            itemsInRoom["casque"] = 1;

            foreach (var item in itemsInRoom)
            {
                Console.WriteLine(item.Value + " " + item.Key);
            }
        }
        public void Salle1Gauche()
        {
            Console.WriteLine("Vous arrivez dans une salle contenant des tentes et un feu de camp ");
            Console.WriteLine("vos directions possible sont : West");
            Console.WriteLine("Vous y trouvez : ");

            itemsInRoom = new Dictionary<string, int>();

            itemsInRoom["note"] = 1;

            foreach (var item in itemsInRoom)
            {
                Console.WriteLine(item.Value + " " + item.Key);
            }
        }
        public void Salle1Droite()
        {
            Console.WriteLine("Vous arrivez dans une salle avec ce qui semble etre les restes d'un magicien ");
            Console.WriteLine("vos directions possible sont : est");
            Console.WriteLine("Vous y trouvez : ");

            itemsInRoom = new Dictionary<string, int>();

            itemsInRoom["Staff"] = 1;
            itemsInRoom["FireSpell"] = 1;

            foreach (var item in itemsInRoom)
            {
                Console.WriteLine(item.Value + " " + item.Key);
            }
        }
        public void Salle2()
        {
            Console.WriteLine("Vous arrivez dans une immense grotte ou repose un dragon");
            Thread.Sleep(1000);
            Console.WriteLine("Vos bruit de pas reveille la creature");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Le combat de boss commence !!!");
            Console.ForegroundColor = ConsoleColor.White;

        }

        //Fonction pour l'inventaire


        public int GetQuantityOfItem(string item)
        {
            if (itemsInRoom.ContainsKey(item))
            {
                return itemsInRoom[item];
            }
            else
            {
                return 0;
            }
        }
    }
}
