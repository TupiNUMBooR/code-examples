using TownSurvival.Control.Spawn;

namespace TownSurvival.Control.Waves {
    public class SpawnWave : Wave {
        public UnitSpawner spawner;
        public int amount;

        void OnEnable() {
            for (var i = 0; i < amount; i++)
                spawner.Spawn();
            gameObject.SetActive(false);
        }
    }
}