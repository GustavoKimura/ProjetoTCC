using Mapbox.Examples;
using UnityEngine;

public class PointsTour: MonoBehaviour {
    [SerializeField]
    private GameObject tourSelection;

    void Update() {
        for(int i = 0; i <  DeustoTour.points.Length; i++) {
            if(!DeustoTour.openned[i] && !this.tourSelection.activeSelf) {
                this.transform.GetChild(i).gameObject.SetActive(true);

                break;
            } else {
                this.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
    }
    
    public void setOpenned() {
        for(int i = 0; i < DeustoTour.points.Length; i++) {
            if(DeustoTour.points[i].Equals(PointSelectedHolder.Point.getName())) {
                DeustoTour.openned[i] = true;

                break;
            }
        }
    }

    public void setDeustoTourToFinished() {
        DeustoTour.finished = true;
    }
}
