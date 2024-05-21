namespace DungeonCrawler
{
    class Program
    {
        static void Main(string[] args)
        {
            DungeonMap map= new DungeonMap();
            map.LoadRooms("Rooms.txt");

            Player player = new Player("Alan", 100, 10);

            IView view= new View();
            Controller controller= new Controller(map, view, player);

            controller.Start(view);
        }
    }
}
