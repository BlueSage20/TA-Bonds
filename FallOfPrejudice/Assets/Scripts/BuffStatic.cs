using UnityEngine;
using System.Collections;

public class BuffStatic : MonoBehaviour {

	public float spawnTime;
	public float despawnTime;
	public float healthGain;

	void Start()
	{
		transform.renderer.enabled = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(Time.realtimeSinceStartup >= spawnTime)
		{
			transform.renderer.enabled = true;
			if(Time.realtimeSinceStartup >= despawnTime)
			{
				transform.renderer.enabled = false;
			}
		}
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Player") {
			Destroy (gameObject);
			col.gameObject.GetComponentInChildren<Bubble>().health += healthGain;
		} else if (col.gameObject.tag == "Ground") {
			Destroy (gameObject);
		}
	}
}
