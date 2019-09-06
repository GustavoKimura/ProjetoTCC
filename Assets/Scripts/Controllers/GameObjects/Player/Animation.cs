using UnityEngine;
using System.Collections;

public class Animation: MonoBehaviour {
    // Inspector fields
    [SerializeField]
    private Animator animator;

    [SerializeField]
    private float threshold;

    // Class fields
    private Vector2 lastPlayerPosition;

    // Animations variables
    private const string IS_WALKING = "isWalking";

    void Start() {
        StartCoroutine(this.updateLastPositionVariables());
    }

    void Update() {
        float xDiffAbs = this.getXDiffAbs();
        float zDiffAbs = this.getZDiffAbs();

        this.animator.SetBool(IS_WALKING,
            xDiffAbs > threshold ||
            zDiffAbs > threshold
        );
    }

    public float getXDiffAbs() {
        return Mathf.Abs(
            this.transform.position.x -
            this.lastPlayerPosition.x
        );
    }

    public float getZDiffAbs() {
        return Mathf.Abs(
            this.transform.position.z -
            this.lastPlayerPosition.y
        );
    }

    IEnumerator updateLastPositionVariables() {
        this.lastPlayerPosition.x = this.transform.position.x;
        this.lastPlayerPosition.y = this.transform.position.z;

        yield return new WaitForSeconds(1);

        StartCoroutine(this.updateLastPositionVariables());
    }
}
