using Units;
using UnityEngine;

namespace Tiles {
    public class BarrackTile : BuildingTile {
        private const string BarrackTileName = "Barrack";

        public BarrackTile(Vector2Int position) : base(position, BarrackTileName) {
            AddAction(new TileAction("new military", NewMilitary, IsNewMilitaryActive));
        }

        public void NewMilitary() {
            UnitManager.Instance.SpawnUnit(new Military(Position));
        }

        public bool IsNewMilitaryActive() {
            var unitOrNull = UnitManager.Instance.GetUnit(Position);
            return unitOrNull == null;
        }
    }
}