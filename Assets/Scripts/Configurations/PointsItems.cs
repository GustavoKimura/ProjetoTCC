public static class PointsItems {
    public static string[] getItemsByType(string type) {
        switch(type) {
            case "RESTAURANT":
                return new string[] {
                    "Chicken",
                    "Chili",
                    "Egg"
                };
            case "PUB":
                return new string[] {
                    "Blue Drink",
                    "Green Drink",
                    "Red Drink"
                };
            case "CAFE":
                return new string[] {
                    "Bread",
                    "Croissant",
                    "Donut"
                };
            case "SUPERMARKET":
                return new string[] {
                    "Chips Bag",
                    "Pineapple",
                    "Shrimp"
                };
            case "FAST FOOD":
                return new string[] {
                    "Burger",
                    "Hot Dog",
                    "French Fries"
                };
            case "BAR":
                return new string[] {
                    "Wine Bottle",
                    "Tacos"
                };
            case "TOUR":
                return new string[] {
                    "Blue Drink",
                    "Green Drink",
                    "Red Drink"
                };
            default:
                return new string[] { };
        }
    }
}
