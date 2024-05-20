namespace DungeonCrawler
{
    public class Controller
    {
        private DungeonMap dungeon;
        private IView view;
        private Room currentRoom;

        public Controller(DungeonMap dungeon, IView view)
        {
            this.dungeon = dungeon;
            this.view = view;
            this.currentRoom = dungeon.GetRoom("room1");
        }
        public void Start(IView view)
        {
            this.view = view;
            int option;

            view.Welcome();
            
            do
            {
                view.RoomDescription(currentRoom);
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
                        break;
                    default:
                        view.InvalidOption();
                        break;
                }
                view.AfterMenu();
            } while (option != 0);
        }

        private void MoveToRoom(string roomName)
        {
            if (roomName != "-")
            {
                currentRoom = dungeon.GetRoom(roomName);
            }
            else
            {
                view.InvalidOption();
            }
        }

    }
}
