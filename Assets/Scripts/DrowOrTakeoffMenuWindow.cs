using UnityEngine;
using System.Collections;

public class DrowOrTakeoffMenuWindow : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGui() {
        GUI.Label(new Rect(0,0,10,10),"MenuWindow");
    }
}
