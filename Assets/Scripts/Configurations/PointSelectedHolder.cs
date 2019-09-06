using Mapbox.Examples;

public static class PointSelectedHolder {
    private static PoiLabelTextSetter point;

    public static PoiLabelTextSetter Point {
        get {
            return point;
        }

        set {
            point = value;
        }
    }
}
