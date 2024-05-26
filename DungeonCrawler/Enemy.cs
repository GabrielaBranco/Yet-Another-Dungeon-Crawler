namespace DungeonCrawler
{
    public class Enemy : ICharacter
    {
        public string Name { get; private set; }
        public int Health { get; set; }
        public int AttackPower { get; private set; }
        public int Defense { get; private set; }

        public Enemy(string name, int health, int attackPower, int defense)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
            Defense = defense;
        }
        public void Attack(ICharacter player, int attackPower)
        {
            player.Health -= AttackPower;
        }
    }
}
