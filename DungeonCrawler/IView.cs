namespace DungeonCrawler
{
    public interface IView
    {
        int MainMenu();
        void AfterMenu();
        void Welcome();
        void EndMessage();
        void InvalidOption();
        void PickedItem(Item item);
        void ItemInformation(Item item);
        void RoomDescription(Room room);
    }
}