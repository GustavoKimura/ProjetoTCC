using UnityEngine;
using UnityEngine.UI;

public class Panel_GameInformations: MonoBehaviour {
    // Inspector fields
    [SerializeField]
    private Text currentMoneyText, nextMoneyText;

    [SerializeField]
    private Slider nextMoneySlider;

    void Update() {
        this.currentMoneyText.text = System.Math.Round(Player.getMoney(), 2) + " EUR"; // 0 EUR

        string connective = "in";

        switch(Configurations.Options.language) {
            case Configurations.Options.languages.ENGLISH:
                connective = "in";
                break;
            case Configurations.Options.languages.PORTUGUESE:
                connective = "em";
                break;
            case Configurations.Options.languages.SPANISH:
                connective = "en";
                break;
            default:
                connective = "in";
                break;
        }

        this.nextMoneyText.text =
            "+" + WalkingOptions.getGains() + " EUR " + connective + "\n" + Mathf.Round(WalkingOptions.getMustWalk() - Player.getCurrentWalking()) + "m"; // Next money in 0m

        this.nextMoneySlider.value = Player.getCurrentWalking() / WalkingOptions.getMustWalk(); // Change slider value.
    }
}