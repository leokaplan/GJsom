using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjChange : MonoBehaviour {

	// Use this for initialization
	Player Player;
	void Start () {
		Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
