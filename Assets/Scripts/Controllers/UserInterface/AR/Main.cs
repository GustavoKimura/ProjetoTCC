using UnityEngine;

namespace UserInterface.AR {
    public class Main: MonoBehaviour {
        // Inspector fields
        [SerializeField]
        private new Camera camera;

        [SerializeField]
        private GameObject buyItemPanel, tipPanel;

        // Class fields
        private GameObject itemToBuy;

        void Start() {
            this.itemToBuy = null;
        }

        void Update() {
            if(Input.GetMouseButtonDown(0)) {
                Ray ray = this.camera.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if(Physics.Raycast(ray, out hit)) {
                    if(hit.transform.tag == Tags.ITEM) {
                        this.itemToBuy = hit.transform.gameObject;

                        if(this.tipPanel.activeSelf) {
                            this.tipPanel.SetActive(false);
                        }

                        this.buyItemPanel.SetActive(true);
                    }
                }
            }
        }

        public GameObject getItemToBuy() {
            return this.itemToBuy;
        }
    }
}