namespace FruitWarehouse.Models
{
    public class Item
    {
        public string Name { get; set; }
        public string ImagePath { get; set; }



        public Item(string name, string imagePath)
        {
            Name = name;
            ImagePath = imagePath;
        }
    }
}
