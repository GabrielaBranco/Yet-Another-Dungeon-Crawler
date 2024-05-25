using System.Collections.Generic;

namespace DungeonCrawler
{
    public class Player : ICharacter
    {
        public string Name { get; private set; }
        public int Health { get; set; }
        public int AttackPower { get; private set; }
        public int Defense { get; private set; }
        public Inventory Inventory { get; private set; }
        private int maxHealth;

        public Player(string name,int attackPower)
        {
            maxHealth = 100;
            Name = name;
            Health = maxHealth;
            AttackPower = attackPower;
            Defense = 0;
            Inventory = new Inventory();
        }

        public Room Move(DungeonMap map, string roomName)
        {
            return map.GetRoom(roomName);
        }

        public void PickUpItem(Item item)
        {
            Inventory.AddItem(item);
        }

        public void Attack(ICharacter enemy, int attackPower)
        {
            enemy.Health -= attackPower - enemy.Defense;
        }

        public void Heal(int value)
        {
            Health += value;
            if (Health > maxHealth)
            {
                Health = maxHealth;
            }
        }

        public void EquipWeapon(int value)
        {
            AttackPower += value;
        }

        public void EquipGear(int value)
        {
            Defense += value;
        }

    }
}
