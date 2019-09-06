using UnityEngine;
using UnityEngine.UI;

public class Panel_Menu: MonoBehaviour {
    [SerializeField]
    private Text totalMetersWalkedText;

    [SerializeField]
    private GameObject[] otherPanelsToHide;

    void OnEnable() {
        foreach(GameObject panel in this.otherPanelsToHide) {
            panel.SetActive(false);
        }
    }

    void Update() {
        string connective = "walked in total";

        switch(Configurations.Options.language) {
            case Configurations.Options.languages.ENGLISH:
                connective = "walked in total";
                break;
            case Configurations.Options.languages.PORTUGUESE:
                connective = "caminhados no total";
                break;
            case Configurations.Options.languages.SPANISH:
                connective = "caminó en total";
                break;
            default:
                connective = "walked in total";
                break;
        }

        this.totalMetersWalkedText.text = Mathf.Round(Player.getTotalWalking()) + "m " + connective;
    }
}
