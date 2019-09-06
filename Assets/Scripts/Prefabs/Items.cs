using UnityEngine;

public class Items: MonoBehaviour {
    // Inspector fields
    [SerializeField]
    public GameObject[] items;

    public GameObject findItem(string name) {
        GameObject item = null;

        foreach(GameObject i in this.items) {
            if(i.GetComponent<Item>().getEnglishName().Equals(name)) {
                item = i;
            }
        }

        return item;
    }
}
