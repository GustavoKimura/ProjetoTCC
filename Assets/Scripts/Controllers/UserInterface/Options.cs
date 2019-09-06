using UnityEngine;
using UnityEngine.UI;

public class Options: MonoBehaviour {
    [SerializeField]
    private Button[] languageButtons;

    [SerializeField]
    private GameObject[] textsToChangeTheLanguage;

    void Start() {
        foreach(Button button in this.languageButtons) {
            button.GetComponent<Image>().enabled = button.GetComponent<Language>().getLanguage() == Configurations.Options.language;
        }
    }

    public void changeOptionsLanguage(Button button) {
        foreach(Button b in this.languageButtons) {
            b.GetComponent<Image>().enabled = b == button;
        }

        Configurations.Options.language = button.GetComponent<Language>().getLanguage();

        foreach(GameObject t in this.textsToChangeTheLanguage) {
            t.GetComponent<LanguageUpdater>().updateLanguage();
        }
    }
}