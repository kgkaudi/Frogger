using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {

	public GameManager manager;

	void OnTriggerEnter(Collider other){
		manager.goals--;
		Destroy (gameObject);
		other.transform.position = new Vector3 (0f, 5f, 0f);
		Debug.Log ("Touchdown!");
	}
}
