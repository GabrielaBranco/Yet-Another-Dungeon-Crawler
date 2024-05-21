namespace DungeonCrawler
{
    public class Room
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string North { get; set; }
        public string South { get; set; }
        public string West { get; set; }
        public string East { get; set; }
        public string Item { get; set; }
        public string Enemy { get; set; }

        public Room(string name)
        {
            Name = name;
        }
    }
}