using System;
using System.Net;

namespace DungeonCrawler
{
    public class Controller
    {
        private DungeonMap dungeon;
        private IView view;
        private Room currentRoom;
        private Room previousRoom;
        private Player player;
        private bool gameOver = false;

        public Controller(DungeonMap dungeon, IView view, Player player)
        {
            this.dungeon = dungeon;
            this.view = view;
            this.player = player;
            this.currentRoom = dungeon.GetRoom("room1");
            this.previousRoom = null;
        }

        public void Start(IView view)
        {
            this.view = view;
            int option;

            view.Welcome();
            view.AksForInstructions();

            bool response = view.BoolChoiceOutput();
            if (response) view.Instructions();

            while (!gameOver)
            {
                view.RoomDescription(currentRoom);
                HandleRoomEvents();

                if (gameOver) break;
                view.MainMenu();

                string input = view.ChoiceInput();
                if (int.TryParse(input, out option))
                {
                    switch (option)
                    {
                        case 1:
                            MoveToRoom(currentRoom.North);
                            break;
                        case 2:
                            MoveToRoom(currentRoom.South);
                            break;
                        case 3:
                            MoveToRoom(currentRoom.West);
                            break;
                        case 4:
                            MoveToRoom(currentRoom.East);
                            break;
                        case 0:
                            view.EndMessage();
                            gameOver = true;
                            break;
                        default:
                            view.InvalidOption();
                            break;
                    }
                    view.AfterMenu();
                }
                else view.InvalidOption();
            }
        }

        private void HandleRoomEvents()
        {
            if (!string.IsNullOrEmpty(currentRoom.Item) && currentRoom.Item != "-")
            {
                string[] itemData = currentRoom.Item.Split('/');
                Item item = new Item(itemData[0], itemData[1], int.Parse(itemData[2]), Enum.Parse<ItemType>(itemData[3]), itemData[4]);
                view.ItemFoundMessage(item);
                view.AskPickUpItem();
                bool response = view.BoolChoiceOutput();
                if (response)
                {
                    player.PickUpItem(item);
                    currentRoom.Item = "-";
                }
            }

            if (!string.IsNullOrEmpty(currentRoom.Enemy) && currentRoom.Enemy != "-")
            {
                string[] enemyData = currentRoom.Enemy.Split('/');
                ICharacter enemy = new Enemy(enemyData[0], int.Parse(enemyData[1]), int.Parse(enemyData[2]), int.Parse(enemyData[3]));

                StartCombat(enemy);
                if (enemy.Health <= 0)
                {
                    view.EnemyDefeated(enemy);
                    currentRoom.Enemy = "-";
                }
            }
        }

        private void StartCombat(ICharacter enemy)
        {
            view.FaceEnemy();
            bool fled = false;
            int action;

            while (enemy.Health > 0 && player.Health > 0 && !fled)
            {
                view.CombatMenu(enemy);

                string input = view.ChoiceInput();
                if (int.TryParse(input, out action))
                {
                    if (action == 1)
                    {
                        HandlePlayerTurn(enemy);
                        if (enemy.Health > 0)
                        {
                            HandleEnemyTurn(enemy);
                        }
                    }
                    else if (action == 2)
                    {
                        ManageInventory();
                    }
                    else if (action == 3)
                    {
                        Flee();
                        fled = true;
                    }
                    else
                    {
                        view.InvalidOption();
                    }
                    view.AfterMenu();
                }
                else view.InvalidOption();
            }
        }

        private void HandlePlayerTurn(ICharacter enemy)
        {
            int attkPower = CalculateAttackPower(player.AttackPower, enemy.Defense);
            if (attkPower == 0)
            {
                view.DamageBlocked(enemy);
            }
            player.Attack(enemy, attkPower);

            if (enemy.Health <= 0) return;
            view.ReceiveDamage(enemy, attkPower);
        }

        private void HandleEnemyTurn(ICharacter enemy)
        {
            int attkPower = CalculateAttackPower(enemy.AttackPower, player.Defense);
            if (attkPower == 0)
            {
                view.DamageBlocked(player);
            }
            enemy.Attack(player, attkPower);

            if (player.Health <= 0)
            {
                gameOver = true;
                view.GameOver();
                return;
            }
            view.ReceiveDamage(player, attkPower);
        }

        private int CalculateAttackPower(int attackPower, int defense)
        {
            return defense >= attackPower ? 0 : attackPower;
        }

        private void ManageInventory()
        {
            bool inInventory = true;
            int inventoryOption;
            while (inInventory)
            {
                view.ShowInventory(player.Inventory.GetItems());
                view.InventoryMenu();
                string input = view.ChoiceInput();
                if (int.TryParse(input, out inventoryOption))
                {
                    if (inventoryOption > 0 && inventoryOption <= player.Inventory.GetItems().Count)
                    {
                        Item selectedItem = player.Inventory.GetItems()[inventoryOption - 1];
                        view.AskUseItem(selectedItem);
                        bool response = view.BoolChoiceOutput();
                        if (response)
                        {
                            UseItem(selectedItem);
                            player.Inventory.RemoveItem(selectedItem);
                        }
                    }
                    else if (inventoryOption == 0)
                    {
                        inInventory = false;
                    }
                    else view.InvalidOption();
                }
                else view.InvalidOption();
            }
        }

        private void UseItem(Item item)
        {
            switch (item.Type)
            {
                case ItemType.Potion:
                    player.Heal(item.Value);
                    view.ItemUsed(item);
                    break;
                case ItemType.Weapon:
                    player.EquipWeapon(item.Value);
                    view.ItemEquipped(item);
                    break;
                case ItemType.Gear:
                    player.EquipGear(item.Value);
                    view.ItemEquipped(item);
                    break;
            }
        }

        private void Flee()
        {
            if (previousRoom != null)
            {
                currentRoom = previousRoom;
                previousRoom = null;
                view.Flee();
            }
        }

        private void MoveToRoom(string roomName)
        {
            if (roomName != "-")
            {
                previousRoom = currentRoom;
                if (roomName == "END")
                {
                    view.GameWon();
                    gameOver = true;
                }
                else
                {
                    currentRoom = player.Move(dungeon, roomName);
                }
            }
            else view.EmptyMessage();
        }
    }
}
