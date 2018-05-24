using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour {

    public GameObject panel;
	// Use this for initialization
	
    public void Destoy()
    {
        Destroy(panel);
    }
}
