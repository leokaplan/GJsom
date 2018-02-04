using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeOnInsanity : MonoBehaviour {

	public Component component;

	[System.Serializable]
	public struct effect {
		public string name;
		public AnimationCurve curve;
	}
	public effect[] effects;
	Player Player;

	void Start () {
		Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
		StartCoroutine(update());
	}
	
	// Update is called once per frame
	IEnumerator update () {
		while(true){
			foreach(effect e in effects){
				float value = e.curve.Evaluate(Player.insanidade);
				System.Reflection.FieldInfo field = component.GetType().GetField(e.name);
				Debug.Log(field.Attributes);
				field.SetValue(component,value);
			}
			
			yield return new WaitForSeconds(0.01f);
		}
	}
}
