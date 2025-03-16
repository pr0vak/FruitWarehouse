using System.Collections.Generic;

namespace FruitWarehouse.Models
{
    public class Inventory
    {
        public Dictionary<(int, int), Item> Items { get; set; }



        private Inventory() { }



        public void AddItem(int x, int y, Item item)
        {
            Items[(x, y)] = item;
        }

        public void RemoveItem(int x, int y)
        {
            Items.Remove((x, y));
        }



        public static Inventory Create()
        {
            return new Inventory
            {
                Items = new Dictionary<(int, int), Item>()
            };
        }
    }
}
