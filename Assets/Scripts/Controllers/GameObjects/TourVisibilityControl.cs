using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TourVisibilityControl: MonoBehaviour {
    [SerializeField]
    private bool alreadyAlerted;

    void Start() {
        this.alreadyAlerted = false;
    }

    public bool getAlreadyAlerted() {
        return this.alreadyAlerted;
    }

    public void setAlreadyAlerted(bool state) {
        this.alreadyAlerted = state;
    }
}
