using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Tour {
    public static bool tourSelected = false;

    public static bool getTourSelected() {
        return tourSelected;
    }

    public static void setTourSelected(bool state) {
        tourSelected = state;
    }
}
