using UnityEditor;
using UnityEngine;

namespace TownSurvival.Control.Waves.Editor {
    [CustomEditor(typeof(WaveSequence))]
    public class WaveSequenceEditor : UnityEditor.Editor {
        public override void OnInspectorGUI() {
            base.OnInspectorGUI();
            var seq = (WaveSequence) target;

            GUILayout.Label($"===== Wave duration: {seq.Seconds} seconds =====");
            
            if (GUILayout.Button("Add children")) {
                seq.waves.Clear();
                foreach (Transform t in seq.transform) {
                    var w = t.GetComponent<Wave>();
                    if ((object) w == null) continue;
                    w.gameObject.SetActive(false);
                    seq.waves.Add(w);
                }
            }
        }
    }
}