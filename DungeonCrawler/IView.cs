using System.Collections.Generic;

namespace DungeonCrawler
{
    public interface IView
    {
        int MainMenu();
        void AfterMenu();

        void Welcome();
        void EndMessage();
        void InvalidOption();
        void GameOver();

        void ItemFoundMessage(Item item);
        string ItemInformation(Item item);
        public bool AskPickUpItem();
        void PickedItem(Item item);
        int InventoryMenu();
        bool AskUseItem(Item item);
        void ItemUsed(Item item);
        void ItemEquipped(Item item);

        void CombatMessage(ICharacter enemy);
        void EnemyDefeated(ICharacter enemy);
        int GetAction();
        void ShowInventory(List<Item> items);
        void Flee();
        void ReceiveDamage(ICharacter creature, int damage);

        void RoomDescription(Room room);
        void EmptyMessage();
    }
}