using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Connect : MonoBehaviour {

    public string location;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(location);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
