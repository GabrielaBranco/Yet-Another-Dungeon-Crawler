using System;

namespace DungeonCrawler
{
    class Player : ICharacter
    {
        public int Health { get; private set; }
        public int AttackPower { get; private set; }

        public Player(int health, int attackPower)
        {
            Health = health;
            AttackPower = attackPower;
        }

        public void Move()
        {

        }

        public void PickUpItem()
        {
            
        }
        public void Attack(int attackPower)
        {
            Health -= attackPower;
        }

        public void Heal(int value)
        {
            Health += value;
        }

    }
}
