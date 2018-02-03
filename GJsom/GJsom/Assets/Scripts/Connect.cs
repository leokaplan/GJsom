using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Connect : MonoBehaviour {

    public string location;
    static int i=0;

    private void OnTriggerEnter(Collider other)
    {
        i++;
        Debug.Log(location + " " + i);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
