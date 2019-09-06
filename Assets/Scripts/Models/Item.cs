using UnityEngine;

public class Item: MonoBehaviour {
    // Inspector fields
    [SerializeField]
    private string englishName, portugueseName, spanishName, frenchName, germanName, italianName;

    [SerializeField]
    private float price;

    public string getName() {
        string name = this.englishName;

        switch(Configurations.Options.language) {
            case Configurations.Options.languages.ENGLISH:
                name = this.englishName;
                break;
            case Configurations.Options.languages.PORTUGUESE:
                name = this.portugueseName;
                break;
            case Configurations.Options.languages.SPANISH:
                name = this.spanishName;
                break;
            default:
                name = this.englishName;
                break;
        }

        return name;
    }

    public string getEnglishName() {
        return this.englishName;
    }

    public float getPrice() {
        return this.price;
    }

    public void setName(string name) {
        this.name = name;
    }

    public void setPrice(float price) {
        this.price = price;
    }
}