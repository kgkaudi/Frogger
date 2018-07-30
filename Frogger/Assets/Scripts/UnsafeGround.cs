using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnsafeGround : MonoBehaviour {

	public GameManager manager;

	void OnTriggerEnter(Collider other){
		if (other.tag == "Safe") {
			Collider col = gameObject.GetComponent<CapsuleCollider> ();
			col.isTrigger = false;
			Invoke ("ActivateColliders", 3f);
		}

		if (other.tag == "Player") {
			Debug.Log ("Unsafe!!!!");
			manager.life--;
			other.transform.position = new Vector3 (0f, other.transform.position.y, 0f);
		}
	}
		
	void ActivateColliders(){
		Collider col = gameObject.GetComponent<CapsuleCollider> ();
		col.isTrigger = true;
	}
}
