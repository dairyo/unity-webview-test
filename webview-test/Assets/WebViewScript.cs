using UnityEngine;
using System.Collections;

public class WebViewScript : MonoBehaviour {

    public string Url;
    WebViewObject webViewObject;
    void Start() {
        webViewObject =
            (new GameObject("WebViewObject")).AddComponent<WebViewObject>();
        webViewObject.Init ();
        webViewObject.LoadURL(Url);
        webViewObject.SetVisibility(true);
    }
}
