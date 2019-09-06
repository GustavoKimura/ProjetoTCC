using Mapbox.Examples;
using UnityEngine;

namespace UserInterface.Game {
    public class Main: MonoBehaviour {
        // Inspector fields
        [SerializeField]
        private new Camera camera;

        [SerializeField]
        private GameObject pointInformationsPanel;

        void Update() {
            if(Input.GetMouseButtonDown(0)) {
                Ray ray = this.camera.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if(Physics.Raycast(ray, out hit)) {
                    if(hit.transform.tag == Tags.POINT) {
                        GameObject pointSelected = hit.transform.parent.gameObject; // Father Point GameObject.
                        PoiLabelTextSetter pointProperties = pointSelected.GetComponent<PoiLabelTextSetter>();
                        PointSelectedHolder.Point = pointProperties;

                        this.pointInformationsPanel.SetActive(true);
                    }
                }
            }
        }
    }
}