using System.Collections;
using UnityEngine;

public class PermissionAsker: MonoBehaviour {
    // Inspector fields
    [SerializeField]
    private bool askForLocationPermission, askForCameraPermission;

    [SerializeField]
    private GameObject modal;

    // Class fields
    private const string ANDROID_PERMISSION_PREFIX = "android.permission.";

    void Start() {
        this.checkPermissions();
    }

    public void checkPermissions() {
        this.modal.SetActive(
            (this.askForLocationPermission && !(this.requestPermissions()[0] == AndroidRuntimePermissions.Permission.Granted)) ||
            (this.askForCameraPermission && !(this.requestPermissions()[1] == AndroidRuntimePermissions.Permission.Granted))
        );
    }

    private AndroidRuntimePermissions.Permission[] requestPermissions() {
        return AndroidRuntimePermissions.RequestPermissions(new string[] {
            ANDROID_PERMISSION_PREFIX + AndroidPermission.ACCESS_FINE_LOCATION,
            ANDROID_PERMISSION_PREFIX + AndroidPermission.CAMERA
        });
    }
}
