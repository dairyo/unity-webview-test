using UnityEngine;
using System.Collections;

public class WebViewScript : MonoBehaviour {

    private string url = "http://www.google.com/";
    WebViewObject webViewObject;

    void Start() {
        webViewObject =
            (new GameObject("WebViewObject")).AddComponent<WebViewObject>();
        webViewObject.Init((msg)=>{
            if (msg == "clicked") {
                Debug.Log("hogehogehogehoge");
            }
        });
        webViewObject.LoadURL(url);
        webViewObject.SetVisibility(true);
        webViewObject.EvaluateJS(
            "window.addEventListener('load', function() {" +
            "   window.addEventListener('click', function() {" +
            "       Unity.call('clicked');" +
            "   }, false);" +
            "}, false);");
        webViewObject.SetMargins(0, 0, 0, 100); //下に100pxマージンを取る
    }
}
