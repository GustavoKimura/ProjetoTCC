using Mapbox.Examples;
using System.Collections;
using UnityEngine;

public class TourInterface: MonoBehaviour {
    [SerializeField]
    private GameObject[] points, interfaces;

    void Start() {
        StartCoroutine(this.updateTourInterface());
    }

    private IEnumerator updateTourInterface() {
        for(int i = 0; i < this.points.Length; i++) {
            if(this.points[i].activeSelf && !this.interfaces[i].GetComponent<TourVisibilityControl>().getAlreadyAlerted() && Tour.getTourSelected()) {
                this.interfaces[i].SetActive(true);

                break;
            } else {
                this.interfaces[i].SetActive(false);
            }
        }

        if(DeustoTour.openned[DeustoTour.openned.Length - 1] && !DeustoTour.finished) {
            this.interfaces[this.interfaces.Length - 1].SetActive(true);

            yield break;
        }

        yield return new WaitForSeconds(0.5f);

        StartCoroutine(this.updateTourInterface());
    }
}