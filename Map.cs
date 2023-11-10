using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Heaj
{
    public class Map
    {
        Inventory inventory = new Inventory();

        private Dictionary<string, int> itemsInRoom = new Dictionary<string, int>();
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
            Console.WriteLine("vos directions possible sont : Est, Nord");
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

        }
        public void Salle2()
        {

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
