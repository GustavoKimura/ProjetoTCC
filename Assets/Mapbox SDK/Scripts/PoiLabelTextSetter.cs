namespace Mapbox.Examples {
    using Mapbox.Unity.MeshGeneration.Interfaces;
    using System.Collections.Generic;
    using UnityEngine;

    public class PoiLabelTextSetter: MonoBehaviour, IFeaturePropertySettable {
        // Inspector fields
        [SerializeField]
        private new string name;

        [SerializeField]
        private string type;

        // Class fields
        [SerializeField]
        private bool openned;

        void Start() {
            this.openned = false;
        }

		public void Set(Dictionary<string, object> props) {
            if(props.ContainsKey("name")) {
				this.name = props["name"].ToString();
			}

            if(props.ContainsKey("type")) {
				this.type = props["type"].ToString().ToUpper();
			}

            if(!Points.isAllowed(this.type)) {
                this.gameObject.SetActive(false);
            }
        }

        public string getName() {
            return this.name;
        }

        public string getType() {
            return this.type;
        }

        public bool getOpenned() {
            return this.openned;
        }

        public void setOpenned(bool openned) {
            this.openned = openned;
        }
    }
}