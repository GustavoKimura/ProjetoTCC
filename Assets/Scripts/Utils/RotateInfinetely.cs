using UnityEngine;

public class RotateInfinitely: MonoBehaviour {
    // Inspector fields
    [SerializeField]
    private bool rotateXRight, rotateYRight, rotateZRight, rotateXLeft, rotateYLeft, rotateZLeft;

    [SerializeField]
    private float velocity;

    void Update() {
        this.transform.Rotate(new Vector3(
            0,
            rotateYLeft ? -velocity : velocity,
            0
        ));
    }

    public void setRotateXRight(bool value) {
        this.rotateXRight = value;
    }

    public void setRotateYRight(bool value) {
        this.rotateYRight = value;
    }

    public void setRotateZRight(bool value) {
        this.rotateZRight = value;
    }

    public void setRotateXLeft(bool value) {
        this.rotateXLeft = value;
    }

    public void setRotateYLeft(bool value) {
        this.rotateYLeft = value;
    }

    public void setRotateZLeft(bool value) {
        this.rotateZLeft = value;
    }

    public void setVelocity(float value) {
        this.velocity = value;
    }
}
