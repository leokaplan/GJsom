using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroSequence : MonoBehaviour {

    public GameObject ui;


	void Start () {
        StartCoroutine(start());
	}

    IEnumerator start()
    {
        yield return new WaitForSecondsRealtime(3.0f);
        ui.SetActive(true);
    }
}
