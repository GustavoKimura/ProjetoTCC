using UnityEngine;

public class Language: MonoBehaviour {
    [SerializeField]
    private Configurations.Options.languages language;

    public Configurations.Options.languages getLanguage() {
        return this.language;
    }
}
