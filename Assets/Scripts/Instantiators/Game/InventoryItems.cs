using UnityEngine;

public class InventoryItems: MonoBehaviour {
    public void instantiate(string itemName) {
        GameObject item = Instantiate(this.GetComponent<Items>().findItem(itemName), transform);

        float newScale = Screen.width + (Screen.width * 0.2f);

        item.transform.localScale = new Vector3(newScale, newScale, newScale);
        item.transform.localRotation = new Quaternion(0, 0, 0, 0);

        RotateInfinitely rotateInfinitely = item.AddComponent<RotateInfinitely>();

        rotateInfinitely.setRotateYRight(true);
        rotateInfinitely.setVelocity(0.5f);

        item.GetComponent<Rigidbody>().useGravity = false;
    }
}