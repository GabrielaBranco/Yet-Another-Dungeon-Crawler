using System;

namespace DungeonCrawler
{
    public class View : IView
    {
        public View()
        {
        }
        public int MainMenu()
        {
            Console.WriteLine("Which way you go?");
            Console.WriteLine("----\n");
            Console.WriteLine("1. North\n");
            Console.WriteLine("2. South\n");
            Console.WriteLine("3. West\n");
            Console.WriteLine("4. East\n");
            Console.WriteLine("0. Quit\n");
            Console.Write("Your choice > ");
            return int.Parse(Console.ReadLine());
        }
        public void AfterMenu()
        {
            Console.Write("\nPress any key to continue...");
            Console.ReadKey(true);
            Console.WriteLine("\n");
        }

        public void Welcome()
        {
            Console.WriteLine("Welcome to Yet Another Dungeon Crawler!");
            Console.WriteLine("Lets Begin!\n");
        }
        public void EndMessage()
        {
            Console.WriteLine("Bye!");
        }

        public void InvalidOption()
        {
            Console.Error.WriteLine("\n>>> Unknown option! <<<\n");
        }

        public void PickedItem(Item item)
        {
            Console.WriteLine($"You picked {item.Name}");
        }

        public void ItemInformation(Item item)
        {
            Console.WriteLine($"{item.Name} - {item.Description} (Value: {item.Value}, Type: {item.Type}");
        }

        public void RoomDescription(Room room)
        {
            Console.WriteLine(room.Description);
        }
    }
}