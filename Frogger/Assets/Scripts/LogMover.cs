using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogMover : MonoBehaviour {

	public int speed;

	// Update is called once per frame
	void Update () {
		transform.position += Vector3.left * Time.deltaTime * speed;	
	}
}
