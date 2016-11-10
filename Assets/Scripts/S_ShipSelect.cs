using UnityEngine;
using System.Collections;

public class S_ShipSelect : MonoBehaviour {

    public GameObject UnitSelctionIcon;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        Debug.Log(this.name+" Selected");

        //spawn a selection cursor icon

    }
}
