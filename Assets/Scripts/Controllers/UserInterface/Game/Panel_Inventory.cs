using UnityEngine;
using UnityEngine.UI;

public class Panel_Inventory: MonoBehaviour {
    // Inspector fields
    [SerializeField]
    private Text itemNameAndQuantityText;
        
    [SerializeField]
    private Items itemsHolder;

    [SerializeField]
    private GameObject[] otherPanelsToHide;

    // Class fields
    private int actualItemIndex;
    private int lastItemIndex;

    void OnEnable() {
        this.actualItemIndex = 0;
        this.lastItemIndex = 0;

        this.inventoryUpdater();

        foreach(GameObject panel in this.otherPanelsToHide) {
            panel.SetActive(false);
        }
    }

    private void inventoryUpdater() {
        if(ItemsInventory.getItems().Count > 0) {
            string englishtemName = ItemsInventory.getItems()[this.actualItemIndex].getEnglishName();
            string actualItemName = ItemsInventory.getItems()[this.actualItemIndex].getName();
            int actualItemQuantity = 0;

            // Item game object
            for(int i = 0; i < this.itemsHolder.transform.childCount; i++) {
                Destroy(this.itemsHolder.transform.GetChild(i).gameObject);
            }

            this.itemsHolder.GetComponent<InventoryItems>().instantiate(englishtemName);

            // Item description
            foreach(Item item in ItemsInventory.getItems()) {
                if(item.getName().Equals(actualItemName)) {
                    actualItemQuantity++;
                }
            }

            this.itemNameAndQuantityText.text = actualItemName + " - x" + actualItemQuantity;
        } else {
            string emptyString = "Empty";

            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    emptyString = "Empty";
                    break;
                case Configurations.Options.languages.PORTUGUESE:
                    emptyString = "Vazia";
                    break;
                case Configurations.Options.languages.SPANISH:
                    emptyString = "Vacía";
                    break;
                default:
                    emptyString = "Empty";
                    break;
            }

            this.itemNameAndQuantityText.text = emptyString;
        }
    }

    public void addActualItemIndex() {
        if(ItemsInventory.getItems().Count > 0) {
            this.lastItemIndex = this.actualItemIndex;

            this.actualItemIndex++;

            if(this.actualItemIndex > ItemsInventory.getItems().Count - 1) {
                this.actualItemIndex = 0;
            }

            Item actualItem = ItemsInventory.getItems()[this.actualItemIndex];
            Item lastItem = ItemsInventory.getItems()[this.lastItemIndex];

            if(actualItem.getName().Equals(lastItem.getName())) {
                bool goToFirst = true;

                for(int i = this.actualItemIndex; i < ItemsInventory.getItems().Count; i++) {
                    Item item = ItemsInventory.getItems()[i];

                    if(!actualItem.getName().Equals(item.getName())) {
                        this.actualItemIndex = i;

                        goToFirst = false;

                        break;
                    }
                }

                if(goToFirst) {
                    this.actualItemIndex = 0;
                }
            }

            this.inventoryUpdater();
        }
    }

    public void decActualItemIndex() {
        if(ItemsInventory.getItems().Count > 0) {
            this.lastItemIndex = this.actualItemIndex;

            this.actualItemIndex--;

            if(this.actualItemIndex < 0) {
                this.actualItemIndex = ItemsInventory.getItems().Count - 1;
            }

            Item actualItem = ItemsInventory.getItems()[this.actualItemIndex];
            Item lastItem = ItemsInventory.getItems()[this.lastItemIndex];

            if(actualItem.getName().Equals(lastItem.getName())) {
                bool goToLast = true;

                for(int i = this.actualItemIndex; i > 0; i--) {
                    Item item = ItemsInventory.getItems()[i];

                    if(!actualItem.getName().Equals(item.getName())) {
                        this.actualItemIndex = i;

                        goToLast = false;

                        break;
                    }
                }

                if(goToLast) {
                    this.actualItemIndex = ItemsInventory.getItems().Count - 1;
                }
            }

            this.inventoryUpdater();
        }
    }
}
