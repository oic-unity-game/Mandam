using UnityEngine;
using System.Collections;

public class ChangeModeManager : MonoBehaviour {
    private GameObject SetOrTakeoff;
    private GameObject DrowOrDrop;
    private GameObject SelectWepon;
    // Use this for initialization
    void Start () {
        SetOrTakeoff = GameObject.Find("SetOrTakeoff");
        DrowOrDrop = GameObject.Find("DrowOrDrop");
        SelectWepon = GameObject.Find("SelectWepon");
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void DrowPush()
    {
        DrowOrDrop.GetComponent<Canvas>().enabled = false;
        SetOrTakeoff.GetComponent<Canvas>().enabled = true;
        
    }

    public void TakeoffPush()
    {
        SetOrTakeoff.GetComponent<Canvas>().enabled = false;
        SelectWepon.GetComponent<Canvas>().enabled = true;
    }
}
