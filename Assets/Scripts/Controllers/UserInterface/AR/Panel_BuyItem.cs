using UnityEngine;
using UnityEngine.UI;

public class Panel_BuyItem: MonoBehaviour {
    // Inspector fields
    [SerializeField]
    private Text itemInformationsText;

    [SerializeField]
    private Button buyItemButton;

    [SerializeField]
    private UserInterface.AR.Main main;

    // Class fields
    private GameObject itemToBuy;

    void Update() {
        this.itemToBuy = this.main.getItemToBuy();

        if(this.itemToBuy) {
            Item item = this.itemToBuy.GetComponent<Item>();

            this.itemInformationsText.GetComponent<Text>().text = item.getName() + " - " + item.getPrice() + " EUR";

            this.buyItemButton.interactable = Player.getMoney() >= item.getPrice();
        }
    }

    public void buyItem() {
        Item item = this.itemToBuy.GetComponent<Item>();

        Destroy(this.itemToBuy);

        Player.setMoney(Player.getMoney() - item.getPrice());

        gameObject.SetActive(false);

        ItemsInventory.addItem(item);
    }
}
