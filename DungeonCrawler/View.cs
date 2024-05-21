using System;
using System.Collections.Generic;

namespace DungeonCrawler
{
    public class View : IView
    {
        public View()
        {
        }

        //Menus
        public int MainMenu()
        {
            Console.WriteLine("Which way you go?");
            Console.WriteLine("----\n");
            Console.WriteLine("1. North");
            Console.WriteLine("2. South");
            Console.WriteLine("3. West");
            Console.WriteLine("4. East");
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
            Console.WriteLine(
            @"                                                                                              ▄█     █▄     ▄████████  ▄█        ▄████████  ▄██████▄    ▄▄▄▄███▄▄▄▄      ▄████████          ███      ▄██████▄                                                                                           " + "\n" +
            @"                                                                                             ███     ███   ███    ███ ███       ███    ███ ███    ███ ▄██▀▀▀███▀▀▀██▄   ███    ███      ▀█████████▄ ███    ███                                                                                           " + "\n" +
            @"                                                                                             ███     ███   ███    █▀  ███       ███    █▀  ███    ███ ███   ███   ███   ███    █▀          ▀███▀▀██ ███    ███                                                                                           " + "\n" +
            @"                                                                                             ███     ███  ▄███▄▄▄     ███       ███        ███    ███ ███   ███   ███  ▄███▄▄▄              ███   ▀ ███    ███                                                                                           " + "\n" +
            @"                                                                                             ███     ███ ▀▀███▀▀▀     ███       ███        ███    ███ ███   ███   ███ ▀▀███▀▀▀              ███     ███    ███                                                                                           " + "\n" +
            @"                                                                                             ███     ███   ███    █▄  ███       ███    █▄  ███    ███ ███   ███   ███   ███    █▄           ███     ███    ███                                                                                           " + "\n" +
            @"                                                                                             ███ ▄█▄ ███   ███    ███ ███▌    ▄ ███    ███ ███    ███ ███   ███   ███   ███    ███          ███     ███    ███                                                                                           " + "\n" +
            @"                                                                                              ▀███▀███▀    ██████████ █████▄▄██ ████████▀   ▀██████▀   ▀█   ███   █▀    ██████████         ▄████▀    ▀██████▀                                                                                                " + "\n" +
            @"                                                                                                                      ▀                                                                                                                                                                            " + "\n" +
            @"▄██   ▄      ▄████████     ███             ▄████████ ███▄▄▄▄    ▄██████▄      ███        ▄█    █▄       ▄████████    ▄████████      ████████▄  ███    █▄  ███▄▄▄▄      ▄██████▄     ▄████████  ▄██████▄  ███▄▄▄▄         ▄████████    ▄████████    ▄████████  ▄█     █▄   ▄█          ▄████████    ▄████████" + "\n" +
            @"███   ██▄   ███    ███ ▀█████████▄        ███    ███ ███▀▀▀██▄ ███    ███ ▀█████████▄   ███    ███     ███    ███   ███    ███      ███   ▀███ ███    ███ ███▀▀▀██▄   ███    ███   ███    ███ ███    ███ ███▀▀▀██▄      ███    ███   ███    ███   ███    ███ ███     ███ ███         ███    ███   ███    ███" + "\n" +
            @"███▄▄▄███   ███    █▀     ▀███▀▀██        ███    ███ ███   ███ ███    ███    ▀███▀▀██   ███    ███     ███    █▀    ███    ███      ███    ███ ███    ███ ███   ███   ███    █▀    ███    █▀  ███    ███ ███   ███      ███    █▀    ███    ███   ███    ███ ███     ███ ███         ███    █▀    ███    ███" + "\n" +
            @"▀▀▀▀▀▀███  ▄███▄▄▄         ███   ▀        ███    ███ ███   ███ ███    ███     ███   ▀  ▄███▄▄▄▄███▄▄  ▄███▄▄▄      ▄███▄▄▄▄██▀      ███    ███ ███    ███ ███   ███  ▄███         ▄███▄▄▄     ███    ███ ███   ███      ███         ▄███▄▄▄▄██▀   ███    ███ ███     ███ ███        ▄███▄▄▄      ▄███▄▄▄▄██▀" + "\n" +
            @"▄██   ███ ▀▀███▀▀▀         ███          ▀███████████ ███   ███ ███    ███     ███     ▀▀███▀▀▀▀███▀  ▀▀███▀▀▀     ▀▀███▀▀▀▀▀        ███    ███ ███    ███ ███   ███ ▀▀███ ████▄  ▀▀███▀▀▀     ███    ███ ███   ███      ███        ▀▀███▀▀▀▀▀   ▀███████████ ███     ███ ███       ▀▀███▀▀▀     ▀▀███▀▀▀▀▀  " + "\n" +
            @"███   ███   ███    █▄      ███            ███    ███ ███   ███ ███    ███     ███       ███    ███     ███    █▄  ▀███████████      ███    ███ ███    ███ ███   ███   ███    ███   ███    █▄  ███    ███ ███   ███      ███    █▄  ▀███████████   ███    ███ ███     ███ ███         ███    █▄  ▀███████████" + "\n" +
            @"███   ███   ███    ███     ███            ███    ███ ███   ███ ███    ███     ███       ███    ███     ███    ███   ███    ███      ███   ▄███ ███    ███ ███   ███   ███    ███   ███    ███ ███    ███ ███   ███      ███    ███   ███    ███   ███    ███ ███ ▄█▄ ███ ███▌    ▄   ███    ███   ███    ███" + "\n" +
            @" ▀█████▀    ██████████    ▄████▀          ███    █▀   ▀█   █▀   ▀██████▀     ▄████▀     ███    █▀      ██████████   ███    ███      ████████▀  ████████▀   ▀█   █▀    ████████▀    ██████████  ▀██████▀   ▀█   █▀       ████████▀    ███    ███   ███    █▀   ▀███▀███▀  █████▄▄██   ██████████   ███    ███" + "\n" +
            @"                                                                                                                    ███    ███                                                                                                       ███    ███                          ▀                        ███    ███" + "\n\n\n");

            Console.WriteLine(
            "                                                                                                                 ██▓    ▓█████▄▄▄█████▓  ██████     ▄▄▄▄   ▓█████   ▄████  ██▓ ███▄    █  ▐██▌ "+"\n"+
            "                                                                                                                ▓██▒    ▓█   ▀▓  ██▒ ▓▒▒██    ▒    ▓█████▄ ▓█   ▀  ██▒ ▀█▒▓██▒ ██ ▀█   █  ▐██▌ "+"\n"+
            "                                                                                                                ▒██░    ▒███  ▒ ▓██░ ▒░░ ▓██▄      ▒██▒ ▄██▒███   ▒██░▄▄▄░▒██▒▓██  ▀█ ██▒ ▐██▌ "+"\n"+
            "                                                                                                                ▒██░    ▒▓█  ▄░ ▓██▓ ░   ▒   ██▒   ▒██░█▀  ▒▓█  ▄ ░▓█  ██▓░██░▓██▒  ▐▌██▒ ▓██▒ "+"\n"+
            "                                                                                                                ░██████▒░▒████▒ ▒██▒ ░ ▒██████▒▒   ░▓█  ▀█▓░▒████▒░▒▓███▀▒░██░▒██░   ▓██░ ▒▄▄  "+"\n"+
            "                                                                                                                ░ ▒░▓  ░░░ ▒░ ░ ▒ ░░   ▒ ▒▓▒ ▒ ░   ░▒▓███▀▒░░ ▒░ ░ ░▒   ▒ ░▓  ░ ▒░   ▒ ▒  ░▀▀▒ "+"\n"+
            "                                                                                                                ░ ░ ▒  ░ ░ ░  ░   ░    ░ ░▒  ░ ░   ▒░▒   ░  ░ ░  ░  ░   ░  ▒ ░░ ░░   ░ ▒░ ░  ░ "+"\n"+
            "                                                                                                                ░ ░      ░    ░      ░  ░  ░      ░    ░    ░   ░ ░   ░  ▒ ░   ░   ░ ░     ░   "+"\n"+
            "                                                                                                                    ░  ░   ░  ░              ░      ░         ░  ░      ░  ░           ░  ░    "+"\n"+
            "                                                                                                                                                       ░                                       "+"\n");
        }

        public void EndMessage()
        {
            Console.WriteLine("Bye!");
        }

        public void InvalidOption()
        {
            Console.Error.WriteLine("\n>>> Invalid option! <<<\n");
        }

        public void GameOver()
        {
            Console.WriteLine(
            @"  ▄████  ▄▄▄       ███▄ ▄███▓▓█████     ▒█████   ██▒   █▓▓█████  ██▀███     " + "\n" +
            @" ██▒ ▀█▒▒████▄    ▓██▒▀█▀ ██▒▓█   ▀    ▒██▒  ██▒▓██░   █▒▓█   ▀ ▓██ ▒ ██▒   " + "\n" +
            @"▒██░▄▄▄░▒██  ▀█▄  ▓██    ▓██░▒███      ▒██░  ██▒ ▓██  █▒░▒███   ▓██ ░▄█ ▒   " + "\n" +
            @"░▓█  ██▓░██▄▄▄▄██ ▒██    ▒██ ▒▓█  ▄    ▒██   ██░  ▒██ █░░▒▓█  ▄ ▒██▀▀█▄     " + "\n" +
            @"░▒▓███▀▒ ▓█   ▓██▒▒██▒   ░██▒░▒████▒   ░ ████▓▒░   ▒▀█░  ░▒████▒░██▓ ▒██▒   " + "\n" +
            @" ░▒   ▒  ▒▒   ▓▒█░░ ▒░   ░  ░░░ ▒░ ░   ░ ▒░▒░▒░    ░ ▐░  ░░ ▒░ ░░ ▒▓ ░▒▓░   " + "\n" +
            @"  ░   ░   ▒   ▒▒ ░░  ░      ░ ░ ░  ░     ░ ▒ ▒░    ░ ░░   ░ ░  ░  ░▒ ░ ▒░   " + "\n" +
            @"░ ░   ░   ░   ▒   ░      ░      ░      ░ ░ ░ ▒       ░░     ░     ░░   ░    " + "\n" +
            @"      ░       ░  ░       ░      ░  ░       ░ ░        ░     ░  ░   ░        " + "\n" +
            @"                                                     ░                      ");
            Console.WriteLine(

            "             ██▓     ▒█████    ██████ ▓█████  ██▀███   ▐██▌ " + "\n" +
            "            ▓██▒    ▒██▒  ██▒▒██    ▒ ▓█   ▀ ▓██ ▒ ██▒ ▐██▌ " + "\n" +
            "            ▒██░    ▒██░  ██▒░ ▓██▄   ▒███   ▓██ ░▄█ ▒ ▐██▌ " + "\n" +
            "            ▒██░    ▒██   ██░  ▒   ██▒▒▓█  ▄ ▒██▀▀█▄   ▓██▒ " + "\n" +
            "            ░██████▒░ ████▓▒░▒██████▒▒░▒████▒░██▓ ▒██▒ ▒▄▄  " + "\n" +
            "            ░ ▒░▓  ░░ ▒░▒░▒░ ▒ ▒▓▒ ▒ ░░░ ▒░ ░░ ▒▓ ░▒▓░ ░▀▀▒ " + "\n" +
            "            ░ ░ ▒  ░  ░ ▒ ▒░ ░ ░▒  ░ ░ ░ ░  ░  ░▒ ░ ▒░ ░  ░ " + "\n" +
            "              ░ ░   ░ ░ ░ ▒  ░  ░  ░     ░     ░░   ░     ░ " + "\n" +
            "                ░  ░    ░ ░        ░     ░  ░   ░      ░    " + "\n");
        }


        //Items
        public void ItemFoundMessage(Item item)
        {
            Console.WriteLine($"You found an item: {item.Name} - {item.Description}");
        }

        public string ItemInformation(Item item)
        {
            return $"{item.Name} - {item.Description} (Value: {item.Value}, Type: {item.Type})";
        }

        public bool AskPickUpItem()
        {
            Console.WriteLine("Do you want to pick up this item? (y/n)\n");
            Console.Write("Your choice > ");
            string response = Console.ReadLine().Trim().ToLower();
            Console.WriteLine("\n");
            return response == "y";
        }

        public void PickedItem(Item item)
        {
            Console.WriteLine($"You picked {item.Name}");
        }

        public int InventoryMenu()
        {
            Console.Write("Choose an item to use > ");
            return int.Parse(Console.ReadLine());
        }

        public bool AskUseItem(Item item)
        {
            Console.WriteLine($"Do you want to use {item.Name}? (y/n)");
            string response = Console.ReadLine().Trim().ToLower();
            return response == "y";
        }

        public void ItemUsed(Item item)
        {
            Console.WriteLine($"You used {item.Name}.");
            Console.WriteLine($"{item.Effect} {item.Value} HP!");
        }
        public void ItemEquipped(Item item)
        {
            Console.WriteLine($"You equipped {item.Name}.");
            Console.WriteLine($"{item.Effect} in {item.Value}!");
        }

        //Enemy and Combat
        public void CombatMessage(ICharacter enemy)
        {
            Console.WriteLine($"You face an enemy in your way");
            Console.WriteLine($"{enemy.Name} has {enemy.Health} HP.\n");
            Console.WriteLine("What will you do?");
            Console.WriteLine("----\n");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Inventory");
            Console.WriteLine("3. Flee");
            Console.Write("Your choice > ");
        }

        public void EnemyDefeated(ICharacter enemy)
        {
            Console.WriteLine( $"You have defeated the {enemy.Name}\n");
        }

        public int GetAction()
        {
            return int.Parse(Console.ReadLine().Trim().ToLower());
        }

        public void ShowInventory(List<Item> items)
        {
            Console.WriteLine("\n>>> Inventory <<<\n");
            Console.WriteLine("----\n");
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {ItemInformation(items[i])}");
            }
            Console.WriteLine("0. Quit");
            Console.WriteLine("\n");
        }

        public void Flee()
        {
            Console.WriteLine("You fled from the battle!");
        }

        public void ReceiveDamage(ICharacter creature, int damage)
        {
            Console.WriteLine($"{creature.Name} receives {damage} damage! Health now: {creature.Health}\n");
        }


        //Map and Rooms
        public void RoomDescription(Room room)
        {
            Console.WriteLine($"{room.Description}\n");
        }
        public void EmptyMessage()
        {
            Console.Error.WriteLine("\n>>> There's nothing here! <<<\n");
        }
    }
}