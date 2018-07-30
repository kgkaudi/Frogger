using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetLogRight : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		other.transform.position = new Vector3 (-45f, other.transform.position.y, other.transform.position.z);
	}
}
