using System.Linq;

namespace Tiles {
    public abstract class Tile {
        public int Level { get; }
        public int PositionX { get; }
        public int PositionY { get; }
        public string Name { get; }
        public Action[] Actions { get; }

        protected Tile(int positionX, int positionY, string name) {
            Level = 1;
            PositionX = positionX;
            PositionY = positionY;
            Name = name;
            Actions = new Action[] {};
        }
        
        protected void AddAction(Action action) {
            Actions.Append(action);
        }
    }
}