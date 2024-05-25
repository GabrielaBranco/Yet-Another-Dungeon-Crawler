using System;
using System.Collections.Generic;
using System.IO;

namespace DungeonCrawler
{
    public class DungeonMap
    {
        public Dictionary<string, Room> Rooms { get; private set; } = new Dictionary<string, Room>();

        public void LoadRooms(string filePath)
        {
            //Opens a text file, reads all lines of the file, and then closes the file.
            //Returns:A string array containing all lines of the file.
            string[] lines = File.ReadAllLines(filePath);
            Room currentRoom = null;

            foreach (string line in lines)
            {
                if (line.StartsWith("room"))
                {
                    string roomName = line.Split(':')[0].Trim();
                    currentRoom = new Room(roomName);
                    Rooms[roomName] = currentRoom;
                }
                else if (currentRoom != null)
                {
                    string[] parts = line.Split(':');
                    if (parts.Length == 2)
                    {
                        string key = parts[0].Trim();
                        string value = parts[1].Trim();

                        switch (key)
                        {
                            case "description":
                                currentRoom.Description = value;
                                break;
                            case "north":
                                currentRoom.North = value;
                                break;
                            case "south":
                                currentRoom.South = value;
                                break;
                            case "west":
                                currentRoom.West = value;
                                break;
                            case "east":
                                currentRoom.East = value;
                                break;
                            case "item":
                                currentRoom.Item = value;
                                break;
                            case "enemy":
                                currentRoom.Enemy = value;
                                break;
                        }
                    }
                }
            }
        }

        public Room GetRoom(string roomName)
        {
            Rooms.TryGetValue(roomName, out Room room);
            return room;
        }
    }
}