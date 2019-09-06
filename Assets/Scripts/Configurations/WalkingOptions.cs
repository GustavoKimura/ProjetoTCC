public static class WalkingOptions {
    private static float mustWalk = 30;
    private static float gains = 1;

    public static float getMustWalk() {
        return mustWalk;
    }

    public static float getGains() {
        return gains;
    }

    public static float setMustWalk(float mustWalk) {
        return WalkingOptions.mustWalk = mustWalk;
    }

    public static float setGains(float gains) {
        return WalkingOptions.gains = gains;
    }
}
