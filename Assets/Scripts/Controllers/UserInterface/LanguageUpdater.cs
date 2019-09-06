using UnityEngine;
using UnityEngine.UI;

public class LanguageUpdater: MonoBehaviour {
    [SerializeField]
    private LanguageStrings.stringNames stringName;

    void Start() {
        this.updateLanguage();
    }

    void OnEnable() {
        this.updateLanguage();
    }

    public void updateLanguage() {
        this.GetComponent<Text>().text = LanguageStrings.strings[(int) this.stringName]();
    }
}
