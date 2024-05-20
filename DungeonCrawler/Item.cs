namespace DungeonCrawler
{
    public class Item
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public int Value { get; private set; }
        public ItemType Type { get; private set; }

        public Item(string name, string description, int value, ItemType type)
        {
            Name = name;
            Description = description;
            Value = value;
            Type = type;
        }
    }
}