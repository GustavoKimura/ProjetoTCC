using UnityEngine;

public class TransitionsManager: MonoBehaviour {
    public void loadScene(string scene) {
        UnityEngine.SceneManagement.SceneManager.LoadScene(scene);
    }

    public void exitGame() {
        Application.Quit();
    }
}