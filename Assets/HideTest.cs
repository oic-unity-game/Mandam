using UnityEngine;
using System.Collections;

public class HideTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject.Find("SetOrTakeoff").GetComponent<Canvas>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
