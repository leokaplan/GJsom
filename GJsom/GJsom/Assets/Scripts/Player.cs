using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public AnimationCurve ComodosXInsanidade;
	public int insanidade;
	int comodosVisitados = 0;
	public List<int> InsanidadePTeleport;
	public List<GameObject> Casas;
	int TPi;
	private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag=="Comodo"){
			comodosVisitados++;
			UpdateInsanidade();
		}
        
    }
	IEnumerator teleport(){
		Casas[TPi].SetActive(true);
		Vector3 pos = transform.localPosition;
		transform.parent = Casas[TPi].transform;
		transform.localPosition = pos;
		Casas[TPi-1].SetActive(false);
		yield return new WaitForSeconds(0.001f);
	}
	void UpdateInsanidade(){
		insanidade = Mathf.FloorToInt(ComodosXInsanidade.Evaluate(Mathf.FloorToInt(comodosVisitados)));
		if(TPi!=InsanidadePTeleport.Count && insanidade==InsanidadePTeleport[TPi]){
			TPi++;
			StartCoroutine(teleport());
		}
	}
	void Start () {
		TPi = 0;
		UpdateInsanidade();
	}
	
	void Update () {
		
	}
}
