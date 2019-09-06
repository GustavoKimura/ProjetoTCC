using UnityEngine;
using UnityEngine.UI;

public class Panel_PointInformations: MonoBehaviour {
    // Inspector fields
    [SerializeField]
    private Text aboutPointText, tooFarText;

    [SerializeField]
    private CheckTrigger playerTriggerChecker;

    [SerializeField]
    [Tooltip("Option for testing.")]
    private bool dontVerifyIfPlayerIsNearToPoint;

    [SerializeField]
    private Button openARCameraButton;

    [SerializeField]
    private GameObject[] otherPanelsToHide;

    void OnEnable() {
        foreach(GameObject panel in this.otherPanelsToHide) {
            panel.SetActive(false);
        }
    }

    void Update() {
        bool playerIsNearToPoint =
            this.playerTriggerChecker.getTagOfTrigger() == Tags.POINT_COLLIDER ||
            this.dontVerifyIfPlayerIsNearToPoint
        ;

        this.openARCameraButton.GetComponent<Button>().interactable = playerIsNearToPoint;
        this.tooFarText.gameObject.SetActive(!playerIsNearToPoint);

        this.aboutPointText.text = PointSelectedHolder.Point.getName() + " - " + PointSelectedHolder.Point.getType(); // Name - TYPE
    }

    public void setDontVerifyIfPlayerIsNearToPoint() {
        this.dontVerifyIfPlayerIsNearToPoint = !dontVerifyIfPlayerIsNearToPoint;
    }
}
