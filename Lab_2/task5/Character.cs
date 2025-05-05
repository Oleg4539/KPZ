using System.Collections.Generic;

namespace task5
{
    public class Character
    {
        public int Height { get; set; }
        public string HairColor { get; set; }
        public List<string> Clothes { get; set; }
        public List<string> Inventory { get; set; }
        public List<string> Deeds { get; set; }

        public Character()
        {
            Clothes = new List<string>();
            Inventory = new List<string>();
            Deeds = new List<string>();
        }

        public override string ToString()
        {
            return $"Height: {Height}, HairColor: {HairColor}, Clothes: {string.Join(", ", Clothes)}, Inventory: {string.Join(", ", Inventory)}, Deeds: {string.Join(", ", Deeds)}";
        }
    }
}
