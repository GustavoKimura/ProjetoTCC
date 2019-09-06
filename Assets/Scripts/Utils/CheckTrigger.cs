using UnityEngine;

public class CheckTrigger: MonoBehaviour {
    // Inspector fields
    [SerializeField]
    private string lockTriggerCheckOn;

    // Class fields
    private string tagOfTrigger;

    void Start() {
        this.tagOfTrigger = "";
    }

    void OnTriggerEnter(Collider c) {
        this.tagOfTrigger = (
            (this.lockTriggerCheckOn.Length > 0 && c.tag != this.lockTriggerCheckOn) ? 
            this.tagOfTrigger : c.tag
        ); 
    }

    void OnTriggerExit(Collider c) {
        this.tagOfTrigger = (
            (this.lockTriggerCheckOn.Length > 0 && c.tag != this.lockTriggerCheckOn) ?
            this.tagOfTrigger : ""
        );
    }

    public string getTagOfTrigger() {
        return this.tagOfTrigger;
    }
}
