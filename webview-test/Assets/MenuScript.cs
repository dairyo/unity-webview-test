using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

    void OnGUI() {

        //画面の左上にメニューを作る
        GUI.Box (new Rect(10,10,100,90),"MENU");

        if (GUI.Button(new Rect(30, 35, 60, 30), "Button"))
        {
            Debug.Log("Button pressed");
        }
    }

}
