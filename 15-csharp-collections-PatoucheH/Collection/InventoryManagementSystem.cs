using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class InventoryManagementSystem
    {
        private Dictionary<string, int> Inventory = [];

        public void AddItems(string itemName, int itemQuantity)
        {
            if (Inventory.ContainsKey(itemName))
            {
                Inventory.TryGetValue(itemName, out int quantity);
                Inventory[itemName] = itemQuantity + quantity;
            }
            else
            {
                {
                    Inventory.Add(itemName, itemQuantity);
                }
            }
        }

        public void RemoveItems(string itemName) 
        {
                Inventory.Remove(itemName);

        }

        public void CheckLowStock(int minStock)
        {
            Dictionary<string, int> lowStock = Inventory.Where(i => i.Value > minStock).ToDictionary(i => i.Key, i => i.Value);
            foreach(var item in lowStock)
            {
                Console.WriteLine($"Item : {item.Key}\t Quantity : {item.Value}");
            }
        }

        public void DisplayAllItems()
        {
            var SortInventory = Inventory.OrderBy(pair => pair.Key);

            foreach (var item in SortInventory)
            {
                Console.WriteLine($"Item : {item.Key}\t Quantity : {item.Value}");
            }
        }
    }
}
