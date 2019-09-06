using UnityEngine;
using UnityEngine.UI;
using Mapbox.Unity.Map;
using System.Collections;

public class Attributes: MonoBehaviour {
    // Inspector fields
    [SerializeField]
    private AbstractMap map;

    [SerializeField]
    [Tooltip("Option for testing.")]
    private bool hackEnabled;

    // Class fields
    private Vector2 lastRealWorldPlayerPosisiton;

    private float lastTouchDelay;
    private int touchCount;

    private const int POSITION_DECIMAL_FOR_COMPARISON = 4;
    private const int MAXIMUM_MONEY = 999999;

    void Start() {
        this.lastRealWorldPlayerPosisiton = this.getCurrentPlayerPositionInRealWorld();

        this.lastTouchDelay = 0;
        this.touchCount = 1;

        if(this.hackEnabled) {
            StartCoroutine(this.startHackMode());
        }
    }

    void Update() {
        Vector2 updatedPosition = this.getCurrentPlayerPositionInRealWorld();

        this.verifyHackingActivation();

        if(
            this.lastRealWorldPlayerPosisiton.x != updatedPosition.x ||
            this.lastRealWorldPlayerPosisiton.y != updatedPosition.y
        ) {
            float positionDifferenceInMeters = this.positionDifferenceInMeters(
                updatedPosition.x,
                updatedPosition.y,
                this.lastRealWorldPlayerPosisiton.x,
                this.lastRealWorldPlayerPosisiton.y
            );

            if(!float.IsNaN(positionDifferenceInMeters)) {
                Player.setCurrentWalking(Player.getCurrentWalking() + positionDifferenceInMeters);
                Player.setTotalWalking(Player.getTotalWalking() + positionDifferenceInMeters);

                if(Player.getCurrentWalking() >= WalkingOptions.getMustWalk()) {
                    Player.setMoney(Mathf.Clamp(Player.getMoney() + WalkingOptions.getGains(), 0, MAXIMUM_MONEY));

                    Player.setCurrentWalking(0); // Restart current walking.
                }
            }

            this.lastRealWorldPlayerPosisiton = updatedPosition;
        }
    }

    private Vector2 getCurrentPlayerPositionInRealWorld() {
        Mapbox.Utils.Vector2d playerPositionInRealWorld = this.map.WorldToGeoPosition(this.transform.position);

        return new Vector2(
            (float) System.Math.Round(playerPositionInRealWorld.x, POSITION_DECIMAL_FOR_COMPARISON),
            (float) System.Math.Round(playerPositionInRealWorld.y, POSITION_DECIMAL_FOR_COMPARISON)
        );
    }

    private float positionDifferenceInMeters(float latitude1, float longitude1, float latitude2, float longitude2) {
        int radius = 6371;

        float latRad1 = Mathf.Deg2Rad * latitude1;
        float latRad2 = Mathf.Deg2Rad * latitude2;
        float degreeLatRad = Mathf.Deg2Rad * (latitude2 - latitude1);
        float degreeLongRad = Mathf.Deg2Rad * (longitude2 - longitude1);

        float area = Mathf.Pow(
            Mathf.Sin(degreeLatRad / 2), 2) + (Mathf.Pow(Mathf.Sin(degreeLongRad / 2), 2) * Mathf.Cos(latRad1) * Mathf.Cos(latRad2)
        );

        float circunference = 2 * Mathf.Atan2(Mathf.Sqrt(area), Mathf.Sqrt(1 - area));

        return radius * circunference * 1000;
    }

    private void verifyHackingActivation() {
        if(Input.GetMouseButtonDown(0)) {
            if(Time.time - this.lastTouchDelay < 0.3f) {
                this.touchCount++;

                if(this.touchCount >= 100) {
                    if(!this.hackEnabled) {
                        this.hackEnabled = true;

                        StartCoroutine(this.startHackMode());
                    }
                }
            } else {
                this.touchCount = 1;
            }

            this.lastTouchDelay = Time.time;
        }
    }

    IEnumerator startHackMode() {
        Player.setMoney(Mathf.Clamp(Player.getMoney() + 111111, 0, MAXIMUM_MONEY));

        if(Player.getMoney() >= MAXIMUM_MONEY) {
            this.hackEnabled = false;
        }

        yield return new WaitForSeconds(0.10f);

        if(this.hackEnabled) {
            StartCoroutine(this.startHackMode());
        }
    }
}
