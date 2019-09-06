using System.Collections;
using UnityEngine;

public class TourSelection: MonoBehaviour {
    [SerializeField]
    private GameObject tutorial, panel;

    void Start() {
        StartCoroutine(this.verifyIfCanBeShowed());
    }

    public IEnumerator verifyIfCanBeShowed() {
        if(!this.tutorial.activeSelf && !Tour.getTourSelected()) {
            this.panel.SetActive(true);

            yield break;
        } else if(Tour.getTourSelected()) {
            this.gameObject.SetActive(false);
        }

        yield return new WaitForSeconds(0.5f);

        StartCoroutine(this.verifyIfCanBeShowed());
    }

    public void setTourSelected(bool state) {
        Tour.setTourSelected(state);
    }
}
