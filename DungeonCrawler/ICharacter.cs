namespace DungeonCrawler
{
    public interface ICharacter
    {
        string Name { get; }
        int Health { get; set; }
        int AttackPower { get; }
        int Defense { get; }
        void Attack( ICharacter creature, int attackPower );
    }
}
