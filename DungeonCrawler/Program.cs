using System;

namespace DungeonCrawler
{
    class Program
    {
        static void Main(string[] args)
        {
            DungeonMap map= new DungeonMap();
            map.LoadRooms("Rooms.txt");

            IView view= new View();
            Controller controller= new Controller(map, view);

            controller.Start(view);
        }
    }
}
