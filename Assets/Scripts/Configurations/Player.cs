public static class Player {
    private static float currentWalking = 0;
    private static float totalWalking = 0;
    private static float money = 0;

    public static float getCurrentWalking() {
        return currentWalking;
    }

    public static float getTotalWalking() {
        return totalWalking;
    }

    public static float getMoney() {
        return money;
    }

    public static void setCurrentWalking(float currentWalking) {
         Player.currentWalking = currentWalking;
    }

    public static void setTotalWalking(float totalWalking) {
         Player.totalWalking = totalWalking;
    }

    public static void setMoney(float money) {
        Player.money = money;
    }
}