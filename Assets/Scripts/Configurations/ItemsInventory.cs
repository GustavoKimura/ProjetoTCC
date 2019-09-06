using System.Collections.Generic;

public static class ItemsInventory {
    private static List<Item> items = new List<Item>();

    public static void addItem(Item item) {
        items.Add(item);
    }

    public static List<Item> getItems() {
        return items;
    }
}