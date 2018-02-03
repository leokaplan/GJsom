using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public AnimationCurve ComodosXInsanidade;
	public int insanidade;
	int comodosVisitados = 0;
	private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag=="Portal"){
			comodosVisitados++;
			UpdateInsanidade();
		}
        
    }
	void UpdateInsanidade(){
		insanidade = Mathf.FloorToInt(ComodosXInsanidade.Evaluate(Mathf.FloorToInt(comodosVisitados)));
	}
	void Start () {
		UpdateInsanidade();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
