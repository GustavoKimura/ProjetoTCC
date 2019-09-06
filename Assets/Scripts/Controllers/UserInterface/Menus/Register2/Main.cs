using UnityEngine;

namespace UserInterface.Game.Menus.Register2 {
    public class Main: MonoBehaviour {
        // Inspector fields
        [SerializeField]
        private new Camera camera;

        [SerializeField]
        private GameObject styles;

        // Class fields
        private const string WALK_VALUE = "isWalking";

        void Update() {
            if(Input.GetMouseButtonDown(0)) {
                Ray ray = this.camera.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if(Physics.Raycast(ray, out hit)) {
                    if(hit.transform.tag == Tags.CHARACTER) {
                        for(int i = 0; i < this.styles.transform.childCount; i++) {
                            this.styles.transform.GetChild(i).GetComponent<Animator>().SetBool(WALK_VALUE, false);
                        }

                        hit.transform.GetComponent<Animator>().SetBool(WALK_VALUE, true);
                    }
                }
            }
        }
    }
}