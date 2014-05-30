using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {
	
	public float currentSpeed;
	public float healthDrain;
	
	// Update is called once per frame
	void FixedUpdate () {
		float amtToMove = currentSpeed * Time.deltaTime;
		transform.Translate (Vector3.down * amtToMove);
	}
	
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Player") {
			Destroy (gameObject);
			col.gameObject.GetComponentInChildren<Bubble>().health -= healthDrain;
		} else if (col.gameObject.tag == "Ground") {
			Destroy (gameObject);
		}
	}
}