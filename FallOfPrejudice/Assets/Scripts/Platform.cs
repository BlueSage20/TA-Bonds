using UnityEngine;
using System.Collections;

public class Platform : MonoBehaviour {

	public float currentSpeed;
	
	// Update is called once per frame
	void FixedUpdate () {
		float amtToMove = currentSpeed * Time.deltaTime;
		transform.Translate (Vector3.down * amtToMove);
	}
}