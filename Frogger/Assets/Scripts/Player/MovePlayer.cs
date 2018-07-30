using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary {
	public float xMin, xMax, zMin, zMax;
}

public class MovePlayer : MonoBehaviour {

	public Boundary boundary;

	void Start(){
		//gameObject.tag == "Safe";
	}

	// Update is called once per frame
	void Update () {
		 
		if (Input.GetKeyDown(KeyCode.A))
        {
			transform.position += Vector3.left*10;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
			transform.position += Vector3.right*10;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
			transform.position += Vector3.forward*5;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
			transform.position += Vector3.back*5;
        }

		GetComponent<Transform> ().position = new Vector3 (
			Mathf.Clamp(GetComponent<Transform> ().position.x, boundary.xMin, boundary.xMax),
			5.0f, 
			Mathf.Clamp(GetComponent<Transform> ().position.z, boundary.zMin, boundary.zMax));
		
    }
}
