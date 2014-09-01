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

    void OnGUI() {
        float top = Screen.height - 100;
        float width = Screen.width / 3;
        if (GUI.Button(new Rect(0, top, width, 100), "back"))
        {
            webViewObject.EvaluateJS("window.history.back();");
        }
        if (GUI.Button(new Rect(width, top, width, 100), "reload"))
        {
            webViewObject.EvaluateJS("window.location.reload();");
        }
        if (GUI.Button(new Rect(width * 2, top, width, 100), "forward"))
        {
            webViewObject.EvaluateJS("window.history.forward();");
        }
    }
}
