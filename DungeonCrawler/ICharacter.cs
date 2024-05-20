using System;

namespace DungeonCrawler
{
    public interface ICharacter
    {
        int Health { get; }
        int AttackPower { get; }
        void Attack( int attackPower );
    }
}
