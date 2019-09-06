using UnityEngine;

public class TableItems: MonoBehaviour {
    void Start() {
        foreach(string item in PointsItems.getItemsByType(PointSelectedHolder.Point.getType())) {
            Instantiate(this.GetComponent<Items>().findItem(item), transform);
        }
    }
}
