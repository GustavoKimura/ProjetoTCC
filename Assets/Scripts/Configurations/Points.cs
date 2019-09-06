public static class Points {
    private static string[] typesOfPointsAllowed = new string[] {
        "RESTAURANT",
        "PUB",
        "CAFE",
        "SUPERMARKET",
        "FAST FOOD",
        "BAR",
        "TOUR"
    };

    public static bool isAllowed(string type) {
        bool allowed = false;

        foreach(string t in typesOfPointsAllowed) {
            if(t.Equals(type)) {
                allowed = true;

                break;
            }
        }

        return allowed;
    }
}