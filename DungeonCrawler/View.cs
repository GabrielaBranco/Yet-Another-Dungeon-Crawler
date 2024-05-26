using System;
using System.Collections.Generic;

namespace DungeonCrawler
{
    public class View : IView
    {
        public View(){}

        //Menus
        public void MainMenu()
        {
            Console.WriteLine("Which way you go?");
            Console.WriteLine("----\n");
            Console.WriteLine("1. North");
            Console.WriteLine("2. South");
            Console.WriteLine("3. West");
            Console.WriteLine("4. East");
            Console.WriteLine("0. Quit\n");
        }

        public void AfterMenu()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nPress any key to continue...");
            Console.ReadLine();
            Console.WriteLine("\n");
        }

        public void AksForInstructions()
        {
            Console.WriteLine("Do you wish to see the instructions? (y/n)\n");
        }

        public void Instructions()
        {
            Console.WriteLine("This is a text based dungeon crawler\n");
            
            Console.WriteLine(
            " ██▓    ▓█████▄▄▄█████▓  ██████     ▄▄▄▄   ▓█████   ▄████  ██▓ ███▄    █  ▐██▌ "+"\n"+
            "▓██▒    ▓█   ▀▓  ██▒ ▓▒▒██    ▒    ▓█████▄ ▓█   ▀  ██▒ ▀█▒▓██▒ ██ ▀█   █  ▐██▌ "+"\n"+
            "▒██░    ▒███  ▒ ▓██░ ▒░░ ▓██▄      ▒██▒ ▄██▒███   ▒██░▄▄▄░▒██▒▓██  ▀█ ██▒ ▐██▌ "+"\n"+
            "▒██░    ▒▓█  ▄░ ▓██▓ ░   ▒   ██▒   ▒██░█▀  ▒▓█  ▄ ░▓█  ██▓░██░▓██▒  ▐▌██▒ ▓██▒ "+"\n"+
            "░██████▒░▒████▒ ▒██▒ ░ ▒██████▒▒   ░▓█  ▀█▓░▒████▒░▒▓███▀▒░██░▒██░   ▓██░ ▒▄▄  "+"\n"+
            "░ ▒░▓  ░░░ ▒░ ░ ▒ ░░   ▒ ▒▓▒ ▒ ░   ░▒▓███▀▒░░ ▒░ ░ ░▒   ▒ ░▓  ░ ▒░   ▒ ▒  ░▀▀▒ "+"\n"+
            "░ ░ ▒  ░ ░ ░  ░   ░    ░ ░▒  ░ ░   ▒░▒   ░  ░ ░  ░  ░   ░  ▒ ░░ ░░   ░ ▒░ ░  ░ "+"\n"+
            "░ ░      ░    ░      ░  ░  ░      ░    ░    ░   ░ ░   ░  ▒ ░   ░   ░ ░     ░   "+"\n"+
            "    ░  ░   ░  ░              ░      ░         ░  ░      ░  ░           ░  ░    "+"\n"+
            "                                       ░                                       "+"\n");
        }

        public string ChoiceInput()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Your choice > ");
            return Console.ReadLine().Trim().ToLower();
        }

        public bool BoolChoiceOutput()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Your choice > ");
            Console.ForegroundColor = ConsoleColor.White;
            string response = Console.ReadLine().Trim().ToLower();
            Console.WriteLine("\n");
            return response == "y";
        }

        public void Welcome()
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(
            @" ▄█     █▄     ▄████████  ▄█        ▄████████  ▄██████▄    ▄▄▄▄███▄▄▄▄      ▄████████          ███      ▄██████▄ " + "\n" +
            @"███     ███   ███    ███ ███       ███    ███ ███    ███ ▄██▀▀▀███▀▀▀██▄   ███    ███      ▀█████████▄ ███    ███" + "\n" +
            @"███     ███   ███    █▀  ███       ███    █▀  ███    ███ ███   ███   ███   ███    █▀          ▀███▀▀██ ███    ███" + "\n" +
            @"███     ███  ▄███▄▄▄     ███       ███        ███    ███ ███   ███   ███  ▄███▄▄▄              ███   ▀ ███    ███" + "\n" +
            @"███     ███ ▀▀███▀▀▀     ███       ███        ███    ███ ███   ███   ███ ▀▀███▀▀▀              ███     ███    ███" + "\n" +
            @"███     ███   ███    █▄  ███       ███    █▄  ███    ███ ███   ███   ███   ███    █▄           ███     ███    ███" + "\n" +
            @"███ ▄█▄ ███   ███    ███ ███▌    ▄ ███    ███ ███    ███ ███   ███   ███   ███    ███          ███     ███    ███" + "\n" +
            @" ▀███▀███▀    ██████████ █████▄▄██ ████████▀   ▀██████▀   ▀█   ███   █▀    ██████████         ▄████▀    ▀██████▀ " + "\n" +
            @"                         ▀                                                                                      " + "\n" +
            @"▄██   ▄      ▄████████     ███             ▄████████ ███▄▄▄▄    ▄██████▄      ███        ▄█    █▄       ▄████████    ▄████████" + "\n" +
            @"███   ██▄   ███    ███ ▀█████████▄        ███    ███ ███▀▀▀██▄ ███    ███ ▀█████████▄   ███    ███     ███    ███   ███    ███" + "\n" +
            @"███▄▄▄███   ███    █▀     ▀███▀▀██        ███    ███ ███   ███ ███    ███    ▀███▀▀██   ███    ███     ███    █▀    ███    ███" + "\n" +
            @"▀▀▀▀▀▀███  ▄███▄▄▄         ███   ▀        ███    ███ ███   ███ ███    ███     ███   ▀  ▄███▄▄▄▄███▄▄  ▄███▄▄▄      ▄███▄▄▄▄██▀" + "\n" +
            @"▄██   ███ ▀▀███▀▀▀         ███          ▀███████████ ███   ███ ███    ███     ███     ▀▀███▀▀▀▀███▀  ▀▀███▀▀▀     ▀▀███▀▀▀▀▀  " + "\n" +
            @"███   ███   ███    █▄      ███            ███    ███ ███   ███ ███    ███     ███       ███    ███     ███    █▄  ▀███████████" + "\n" +
            @"███   ███   ███    ███     ███            ███    ███ ███   ███ ███    ███     ███       ███    ███     ███    ███   ███    ███" + "\n" +
            @" ▀█████▀    ██████████    ▄████▀          ███    █▀   ▀█   █▀   ▀██████▀     ▄████▀     ███    █▀      ██████████   ███    ███" + "\n" +
            @"                                                                                                                    ███    ███" + "\n" +
            @"████████▄  ███    █▄  ███▄▄▄▄      ▄██████▄     ▄████████  ▄██████▄  ███▄▄▄▄         ▄████████    ▄████████    ▄████████  ▄█     █▄   ▄█          ▄████████    ▄████████" + "\n" +
            @"███   ▀███ ███    ███ ███▀▀▀██▄   ███    ███   ███    ███ ███    ███ ███▀▀▀██▄      ███    ███   ███    ███   ███    ███ ███     ███ ███         ███    ███   ███    ███" + "\n" + 
            @"███    ███ ███    ███ ███   ███   ███    █▀    ███    █▀  ███    ███ ███   ███      ███    █▀    ███    ███   ███    ███ ███     ███ ███         ███    █▀    ███    ███" + "\n" + 
            @"███    ███ ███    ███ ███   ███  ▄███         ▄███▄▄▄     ███    ███ ███   ███      ███         ▄███▄▄▄▄██▀   ███    ███ ███     ███ ███        ▄███▄▄▄      ▄███▄▄▄▄██▀" + "\n" + 
            @"███    ███ ███    ███ ███   ███ ▀▀███ ████▄  ▀▀███▀▀▀     ███    ███ ███   ███      ███        ▀▀███▀▀▀▀▀   ▀███████████ ███     ███ ███       ▀▀███▀▀▀     ▀▀███▀▀▀▀▀  " + "\n" +
            @"███    ███ ███    ███ ███   ███   ███    ███   ███    █▄  ███    ███ ███   ███      ███    █▄  ▀███████████   ███    ███ ███     ███ ███         ███    █▄  ▀███████████" + "\n" + 
            @"███   ▄███ ███    ███ ███   ███   ███    ███   ███    ███ ███    ███ ███   ███      ███    ███   ███    ███   ███    ███ ███ ▄█▄ ███ ███▌    ▄   ███    ███   ███    ███" + "\n" + 
            @"████████▀  ████████▀   ▀█   █▀    ████████▀    ██████████  ▀██████▀   ▀█   █▀       ████████▀    ███    ███   ███    █▀   ▀███▀███▀  █████▄▄██   ██████████   ███    ███" + "\n" + 
            @"                                                                                                 ███    ███                          ▀                        ███    ███" + "\n\n\n");
        }

        public void EndMessage()
        {
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(
            @"  ▄████  ▒█████   ▒█████  ▓█████▄  ▄▄▄▄ ▓██   ██▓▓█████     " + "\n" +
            @" ██▒ ▀█▒▒██▒  ██▒▒██▒  ██▒▒██▀ ██▌▓█████▄▒██  ██▒▓█   ▀     " + "\n" +
            @"▒██░▄▄▄░▒██░  ██▒▒██░  ██▒░██   █▌▒██▒ ▄██▒██ ██░▒███       " + "\n" +
            @"░▓█  ██▓▒██   ██░▒██   ██░░▓█▄   ▌▒██░█▀  ░ ▐██▓░▒▓█  ▄     " + "\n" +
            @"░▒▓███▀▒░ ████▓▒░░ ████▓▒░░▒████▓ ░▓█  ▀█▓░ ██▒▓░░▒████▒    " + "\n" +
            @" ░▒   ▒ ░ ▒░▒░▒░ ░ ▒░▒░▒░  ▒▒▓  ▒ ░▒▓███▀▒ ██▒▒▒ ░░ ▒░ ░    " + "\n" +
            @"  ░   ░   ░ ▒ ▒░   ░ ▒ ▒░  ░ ▒  ▒ ▒░▒   ░▓██ ░▒░  ░ ░  ░    " + "\n" +
            @"░ ░   ░ ░ ░ ░ ▒  ░ ░ ░ ▒   ░ ░  ░  ░    ░▒ ▒ ░░     ░       " + "\n" +
            @"      ░     ░ ░      ░ ░     ░     ░     ░ ░        ░  ░    " + "\n" +
            @"                           ░            ░░ ░                " + "\n" +
            @" ▄████▄   ▒█████   █     █░ ▄▄▄       ██▀███  ▓█████▄  ▐██▌ " + "\n" +
            @"▒██▀ ▀█  ▒██▒  ██▒▓█░ █ ░█░▒████▄    ▓██ ▒ ██▒▒██▀ ██▌ ▐██▌ " + "\n" +
            @"▒▓█    ▄ ▒██░  ██▒▒█░ █ ░█ ▒██  ▀█▄  ▓██ ░▄█ ▒░██   █▌ ▐██▌ " + "\n" +
            @"▒▓▓▄ ▄██▒▒██   ██░░█░ █ ░█ ░██▄▄▄▄██ ▒██▀▀█▄  ░▓█▄   ▌ ▓██▒ " + "\n" +
            @"▒ ▓███▀ ░░ ████▓▒░░░██▒██▓  ▓█   ▓██▒░██▓ ▒██▒░▒████▓  ▒▄▄  " + "\n" +
            @"░ ░▒ ▒  ░░ ▒░▒░▒░ ░ ▓░▒ ▒   ▒▒   ▓▒█░░ ▒▓ ░▒▓░ ▒▒▓  ▒  ░▀▀▒ " + "\n" +
            @"  ░  ▒     ░ ▒ ▒░   ▒ ░ ░    ▒   ▒▒ ░  ░▒ ░ ▒░ ░ ▒  ▒  ░  ░ " + "\n" +
            @"░        ░ ░ ░ ▒    ░   ░    ░   ▒     ░░   ░  ░ ░  ░     ░ " + "\n" +
            @"░ ░          ░ ░      ░          ░  ░   ░        ░     ░    " + "\n" +
            @"░                                              ░            ");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void InvalidOption()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Error.WriteLine("\n>>> Invalid option! <<<\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void GameOver()
        {
            Console.ForegroundColor = ConsoleColor.Red;
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
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void GameWon()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(
            @"   ▓██   ██▓ ▒█████   █    ██     █     █░ ▒█████   ███▄    █  ▐██▌ " + "\n" +
            @"    ▒██  ██▒▒██▒  ██▒ ██  ▓██▒   ▓█░ █ ░█░▒██▒  ██▒ ██ ▀█   █  ▐██▌ " + "\n" +
            @"     ▒██ ██░▒██░  ██▒▓██  ▒██░   ▒█░ █ ░█ ▒██░  ██▒▓██  ▀█ ██▒ ▐██▌ " + "\n" +
            @"     ░ ▐██▓░▒██   ██░▓▓█  ░██░   ░█░ █ ░█ ▒██   ██░▓██▒  ▐▌██▒ ▓██▒ " + "\n" +
            @"     ░ ██▒▓░░ ████▓▒░▒▒█████▓    ░░██▒██▓ ░ ████▓▒░▒██░   ▓██░ ▒▄▄  " + "\n" +
            @"      ██▒▒▒ ░ ▒░▒░▒░ ░▒▓▒ ▒ ▒    ░ ▓░▒ ▒  ░ ▒░▒░▒░ ░ ▒░   ▒ ▒  ░▀▀▒ " + "\n" +
            @"    ▓██ ░▒░   ░ ▒ ▒░ ░░▒░ ░ ░      ▒ ░ ░    ░ ▒ ▒░ ░ ░░   ░ ▒░ ░  ░ " + "\n" +
            @"    ▒ ▒ ░░  ░ ░ ░ ▒   ░░░ ░ ░      ░   ░  ░ ░ ░ ▒     ░   ░ ░     ░ " + "\n" +
            @"    ░ ░         ░ ░     ░            ░        ░ ░           ░  ░    " + "\n" +
            @"    ░ ░                                                             ");
            Console.ForegroundColor = ConsoleColor.White;
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

        public void AskPickUpItem()
        {
            Console.WriteLine("Do you want to pick up this item? (y/n)\n");
        }

        public void PickedItem(Item item)
        {
            Console.WriteLine($"You picked {item.Name}");
        }

        public void InventoryMenu()
        {
            Console.Write("Choose an item to use. ");
        }

        public void AskUseItem(Item item)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n");
            Console.WriteLine($"Do you want to use {item.Name}? (y/n)");
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
        public void FaceEnemy()
        {
            Console.WriteLine($"You face an enemy in your way");
        }
        public void CombatMenu(ICharacter enemy)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{enemy.Name} has {enemy.Health} HP.\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("What will you do?");
            Console.WriteLine("----\n");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Inventory");
            Console.WriteLine("3. Flee");
            Console.WriteLine("\n");
        }

        public void EnemyDefeated(ICharacter enemy)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine( $"You have defeated the {enemy.Name}\n");
            Console.ForegroundColor = ConsoleColor.White;
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
            Console.WriteLine("\n");
            Console.WriteLine("You fled from the battle and ran back through the way you came!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*You can't progress further without killing that enemy*");
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void ReceiveDamage(ICharacter entity, int damage)
        {
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{entity.Name} receives {damage} damage!");
            Console.WriteLine($"{entity.Name}'s health now is: {entity.Health}\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void DamageBlocked(ICharacter entity)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{entity.Name} blocked all damage!");
            Console.ForegroundColor = ConsoleColor.White;
        }

        //Map and Rooms
        public void RoomDescription(Room room)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{room.Description}\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void EmptyMessage()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Error.WriteLine("\n>>> There's nothing here! <<<\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}