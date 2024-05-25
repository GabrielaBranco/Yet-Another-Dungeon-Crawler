using System;

namespace DungeonCrawler
{
    public class Controller
    {
        private DungeonMap dungeon;
        private IView view;
        private Room currentRoom;
        private Player player;
        private bool gameOver = false;

        public Controller(DungeonMap dungeon, IView view, Player player)
        {
            this.dungeon = dungeon;
            this.view = view;
            this.player = player;
            this.currentRoom = dungeon.GetRoom("room1");
        }
        public void Start(IView view)
        {
            this.view = view;
            int option;

            view.Welcome();
            while (!gameOver)
            {
                view.RoomDescription(currentRoom);
                HandleRoomEvents();

                if (gameOver) break;
                
                option = view.MainMenu();
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
        }

        private void HandleRoomEvents()
        {
            if (!string.IsNullOrEmpty(currentRoom.Item) && currentRoom.Item != "-")
            {
                string[] itemData = currentRoom.Item.Split('/');
                Item item = new Item(itemData[0], itemData[1], int.Parse(itemData[2]), Enum.Parse<ItemType>(itemData[3]), itemData[4]);
                view.ItemFoundMessage(item);

                if (view.AskPickUpItem())
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
            while (enemy.Health > 0 && player.Health > 0)
            {
                view.CombatMenu(enemy);
                int action = view.GetAction();
                int attkPower;
                
                if (action == 1)
                {
                    if (enemy.Health > 0 && player.Health > 0)
                    {
                        //Player's turn
                        attkPower = player.AttackPower;
                        if(enemy.Defense >= player.AttackPower)
                        {
                            attkPower = 0;
                            view.DamageBlocked(enemy);
                        }
                        player.Attack(enemy, attkPower);
                        view.ReceiveDamage(enemy, attkPower);

                        //Enemy's turn
                        attkPower = enemy.AttackPower;
                        if(player.Defense >= enemy.AttackPower)
                        {
                            attkPower = 0;
                            view.DamageBlocked(player);
                        }
                        enemy.Attack(player, attkPower);

                        if (player.Health <= 0)
                        {
                            gameOver = true;
                            view.GameOver();
                            break;
                        }
                        view.ReceiveDamage(player, attkPower);
                    }
                }
                else if (action == 2)
                {
                    ManageInventory();
                }
                else
                {
                    view.InvalidOption();
                }
            }
        }

        private void ManageInventory()
        {
            bool inInventory = true;
            while (inInventory)
            {
                view.ShowInventory(player.Inventory.GetItems());
                int inventoryOption = view.InventoryMenu();
                
                if (inventoryOption > 0 && inventoryOption <= player.Inventory.GetItems().Count)
                {
                    Item selectedItem = player.Inventory.GetItems()[inventoryOption - 1];
                    if (view.AskUseItem(selectedItem))
                    {
                        UseItem(selectedItem);
                        player.Inventory.RemoveItem(selectedItem);
                    }
                }
                else if (inventoryOption == 0)
                {
                    inInventory = false;
                }
                else
                {
                    view.InvalidOption();
                }
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

        private void MoveToRoom(string roomName)
        {
            if (roomName != "-")
            {
                if(roomName == "END")
                {
                    view.GameWon();
                    gameOver = true;
                }
                else
                {
                    currentRoom = player.Move(dungeon, roomName);
                }
            }
            else
            {
                view.EmptyMessage();
            }
        }
    }
}
