using System.Collections;
using UnityEngine;

namespace TownSurvival.Control.Waves {
    public class WaitWave : Wave {
        public float seconds;
        void OnEnable() {
            StartCoroutine(Wait());
        }

        IEnumerator Wait() {
            yield return new WaitForSeconds(seconds);
            gameObject.SetActive(false);
        }
    }
}