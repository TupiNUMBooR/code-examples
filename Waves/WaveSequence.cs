using System.Collections.Generic;
using System.Linq;

namespace TownSurvival.Control.Waves {
    public class WaveSequence : Wave {
        public List<Wave> waves;
        public bool loop;
        int _num;

        public float Seconds => waves == null
            ? 0
            : waves.OfType<WaitWave>().Sum(wave => wave.seconds) +
              waves.OfType<WaveSequence>().Sum(wave => wave.Seconds);

        void OnEnable() {
            _num = -1;
        }

        void Update() {
            if (_num >= 0 && waves[_num].isActiveAndEnabled) return;

            _num++;

            if (waves.Count < _num + 1) {
                if (!loop) {
                    gameObject.SetActive(false);
                    return;
                }

                _num = 0;
            }

            waves[_num].gameObject.SetActive(true);
        }
    }
}