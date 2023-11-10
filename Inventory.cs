using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Heaj
{
    public class Inventory
    {
        Dictionary<string, int> internalInventory = new Dictionary<string, int>();
        public void AddToInventory(string item, int quantity)
        {
            if (internalInventory.ContainsKey(item))
            {
                internalInventory[item] += quantity;
            }
            else
            {
                internalInventory.Add(item, quantity);
            }
        }

        public void RemoveFromInventory(string item, int quantity)
        {
            if (internalInventory.ContainsKey(item))
            {
                internalInventory[item] = internalInventory[item] - quantity;

                if (internalInventory[item] <= 0)
                {
                    internalInventory.Remove(item);
                }
            }
        }

        public int GetQuantity(string item)
        {
            if (internalInventory.ContainsKey(item))
            {
                return internalInventory[item];
            }
            else
            {
                return 0;
            }
        }
        public bool HasItem(string item)
        {
            return internalInventory.ContainsKey(item);
        }
        public bool HasNotItem(string item)
        {
            return !internalInventory.ContainsKey(item);
        }
        public void DisplayInventory()
        {
            foreach (var items in internalInventory)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($"You have {items.Value} {items.Key} in your inventory");
                Console.WriteLine("---------------------------------------");
            }
            if (internalInventory.Count == 0 )
            {
                Console.WriteLine("Your inventory is empty");
            }
        }
    }
}
