using System.Collections;
using UnityEngine;

public class PositionWithLatLon: MonoBehaviour {
    [SerializeField]
    private Mapbox.Unity.Map.AbstractMap map;

    [SerializeField]
    private float latitude, longitude;

    void Start() {
        StartCoroutine(this.verifyIfMapIsLoaded());
    }

    private IEnumerator verifyIfMapIsLoaded() {
        if(this.map != null) {
            Mapbox.Utils.Vector2d centerMarcator = this.map.CenterMercator;
            float worldRelativeScale = this.map.WorldRelativeScale;

            if(centerMarcator.x != 0 && centerMarcator.y != 0 && worldRelativeScale != 0) {
                Vector3 vector = Mapbox.Unity.Utilities.VectorExtensions.AsUnityPosition(
                    new Vector2(
                        this.latitude,
                        this.longitude
                    ),

                    centerMarcator,

                    worldRelativeScale
                );

                this.transform.position = new Vector3(vector.x, 0, vector.z);
            }

            yield return new WaitForSeconds(0.5f);

            StartCoroutine(this.verifyIfMapIsLoaded());
        }
    }
}
