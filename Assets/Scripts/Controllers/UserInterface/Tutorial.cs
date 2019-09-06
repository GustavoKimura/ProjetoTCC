using System.IO;
using UnityEngine;

public class Tutorial: MonoBehaviour {
    // Inspector fields
    [SerializeField]
    private GameObject firstTutorialPanel;

    // Class fields
    private bool preferencesExists;

    void Start() {
        this.preferencesExists = File.Exists(Application.persistentDataPath + "/preferences.dat");

        if(!this.preferencesExists) {
            this.firstTutorialPanel.SetActive(true);
        } else {
            this.gameObject.SetActive(false);
        }
    }

    void OnDisable() {
        if(!this.gameObject.activeSelf && !this.preferencesExists) {
            this.createPreferences();
        }
    }

    public void createPreferences() {
        File.Create(Application.persistentDataPath + "/preferences.dat");
    }
}
