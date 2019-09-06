using UnityEngine;

public class Pivot: MonoBehaviour {
    // Inspector fields
    [SerializeField]
    private new GameObject camera;

    [SerializeField]
    private float rotationSpeed, zoomSpeed, zoomLimit; // 1.5, 0.1, 12

    [SerializeField]
    [Tooltip("Option for testing.")]
    private bool infiniteZoomInAndRotate;

    // Class fields
    private float initialYPosition;
    private float initialXRotation;

    void Start() {
        this.initialYPosition = this.camera.transform.position.y;
        this.initialXRotation = this.camera.transform.rotation.eulerAngles.x;
    }

    void Update() {
        if(Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Moved) {
            this.cameraRotate(this.getNormalizedDragMovement());
        } else if(Input.touchCount == 2) {
            Touch touch0 = Input.GetTouch(0);
            Touch touch1 = Input.GetTouch(1);

            if(touch0.phase == TouchPhase.Moved || touch1.phase == TouchPhase.Moved) {
                this.cameraZoom(this.getNormalizedPinchMovementBetween(touch0, touch1));
            }
        }

        if(this.infiniteZoomInAndRotate) {
            this.cameraRotate(0.5f);

            this.cameraZoom(-0.5f);
        }
    }

    // 

    private float getXAxisByCurrentTouchPosition() {
        return Input.GetAxis("Mouse X") * ((
            Input.mousePosition.y < (Screen.height / 2)
        ) ? 1 : -1);
    }

    private float getYAxisByCurrentTouchPosition() {
        return Input.GetAxis("Mouse Y") * ((
            Input.mousePosition.x < (Screen.width / 2)
        ) ? 1 : -1);
    }

    private float getNormalizedDragMovement() {
        return this.getXAxisByCurrentTouchPosition() - this.getYAxisByCurrentTouchPosition();
    }

    private void cameraRotate(float strength) {
        transform.RotateAround(
            transform.position,
            Vector3.up,
            strength * rotationSpeed
        );
    }

    //

    private float getLastTouchMagnitude(Touch touch0, Touch touch1) {
        return (
            (touch0.position - touch0.deltaPosition) -
            (touch1.position - touch1.deltaPosition)
        ).magnitude;
    }

    private float getCurrentTouchMagnitude(Touch touch0, Touch touch1) {
        return (
            touch0.position - 
            touch1.position
        ).magnitude;
    }

    private float getNormalizedPinchMovementBetween(Touch touch0, Touch touch1) {
        float lastTouchMagnitude = this.getLastTouchMagnitude(touch0, touch1);
        float currentTouchMagnitude = this.getCurrentTouchMagnitude(touch0, touch1);

        return lastTouchMagnitude - currentTouchMagnitude;
    }

    private void cameraZoom(float strength) {
        this.camera.transform.position = new Vector3(
            this.camera.transform.position.x,
            Mathf.Clamp((this.camera.transform.position.y + (strength * this.zoomSpeed)), this.initialYPosition - this.zoomLimit,  this.initialYPosition),
            this.camera.transform.position.z
        );

        this.camera.transform.rotation = Quaternion.Euler(
            Mathf.Clamp((this.camera.transform.rotation.eulerAngles.x + (strength * this.zoomSpeed)), this.initialXRotation - this.zoomLimit, this.initialXRotation),
            this.camera.transform.rotation.eulerAngles.y,
            this.camera.transform.rotation.eulerAngles.z
        );
    }
}
