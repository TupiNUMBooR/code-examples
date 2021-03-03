using TownSurvival.Objects;
using TownSurvival.Utils;

namespace TownSurvival.Control.Waves {
    public class DropWave : Wave {
        public ChanceItemPacks items;
        public TravellingItemDropper dropper;
        public int amount;

        void OnEnable() {
            for (var i = 0; i < amount; i++) {
                dropper.Drop(items.Random().TransferInfo());
                dropper.Travel(); // TODO up
            }

            gameObject.SetActive(false);
        }
    }
}