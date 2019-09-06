using System.IO;
using UnityEngine;

public class LanguageSelection: MonoBehaviour {
    // Inspector field
    [SerializeField]
    private GameObject modal;

    void Start() {
        if(!File.Exists(Application.persistentDataPath + "/preferences.dat")) {
            this.modal.SetActive(true);
        }
    }
}
