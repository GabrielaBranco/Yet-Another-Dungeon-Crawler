using System.Collections.Generic;

namespace DungeonCrawler
{
    public interface IView
    {
        //Menus
        int MainMenu();
        void AfterMenu();

        //Start & Ending messages
        void Welcome();
        void EndMessage();
        void InvalidOption();
        void GameOver();
        void GameWon();
        
        //Items
        void ItemFoundMessage(Item item);
        string ItemInformation(Item item);
        public bool AskPickUpItem();
        void PickedItem(Item item);
        int InventoryMenu();
        bool AskUseItem(Item item);
        void ItemUsed(Item item);
        void ItemEquipped(Item item);

        //Combat
        void FaceEnemy();
        void CombatMenu(ICharacter enemy);
        void EnemyDefeated(ICharacter enemy);
        int GetAction();
        void ShowInventory(List<Item> items);
        void Flee();
        void ReceiveDamage(ICharacter entity, int damage);
        void DamageBlocked(ICharacter entity);

        //Rooms and Map
        void RoomDescription(Room room);
        void EmptyMessage();
    }
}