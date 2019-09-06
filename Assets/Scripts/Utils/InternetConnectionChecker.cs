using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class InternetConnectionChecker: MonoBehaviour {
    // Inspector fields
    [SerializeField]
    private GameObject modal, panel, loading;

    private const string URL_TO_PING = "https://www.google.com";

    void Start() {
        StartCoroutine(this.checkInternetConnection());
    }

    public IEnumerator checkInternetConnection() {
        if(!this.modal.activeSelf || !this.panel.activeSelf) {
            StartCoroutine(this.tryToConnect());
        }

        yield return new WaitForSeconds(0.3f);

        StartCoroutine(this.checkInternetConnection()); // Recursive call
    }

    private IEnumerator tryToConnect() {
        using(UnityWebRequest request = UnityWebRequest.Get(URL_TO_PING)) {
            yield return request.SendWebRequest();

            if(request.isNetworkError || request.isHttpError) {
                this.panel.SetActive(true);
                this.loading.SetActive(false);

                this.modal.SetActive(true);
            } else {
                this.modal.SetActive(false);
            }
        }
    }
}
