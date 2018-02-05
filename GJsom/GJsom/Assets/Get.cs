using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Get : MonoBehaviour {

    public GameObject foto;

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("tocou");
       // if (Input.GetKeyDown("e"))
       //     Destroy(foto);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
