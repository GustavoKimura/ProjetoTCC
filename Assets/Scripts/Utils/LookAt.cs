using UnityEngine;

public class LookAt: MonoBehaviour {
    // Inspector fields
    [SerializeField]
    private string objectToLook;

    [SerializeField]
    private bool lockX, lockY, lockZ;

    void Update() {
        GameObject obj = GameObject.Find(this.objectToLook);

        if(obj != null) {
            transform.LookAt(new Vector3(
                this.lockX ? this.transform.position.x : obj.transform.position.x,
                this.lockY ? this.transform.position.y : obj.transform.position.y,
                this.lockZ ? this.transform.position.z : obj.transform.position.z
            ));
        }
    }
}
