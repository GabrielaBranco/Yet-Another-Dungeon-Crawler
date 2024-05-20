using System;

namespace DungeonCrawler
{
    class Enemy : ICharacter
    {
        public readonly string Name;
        public int Health { get; private set; }
        public int AttackPower { get; private set; }

        public Enemy(string name, int health, int attackPower)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
        }
        public void Attack(int attackPower)
        {
            Console.WriteLine("Attack");
        }

    }
}
