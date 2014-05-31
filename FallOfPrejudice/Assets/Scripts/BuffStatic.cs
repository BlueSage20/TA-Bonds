using UnityEngine;
using System.Collections;

public class BuffStatic : MonoBehaviour {

	public float spawnTime;
	public float despawnTime;
	public float healthGain;

	public AudioClip clip;

	void Start()
	{
		transform.renderer.enabled = false;
		transform.collider2D.enabled = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(Time.realtimeSinceStartup >= spawnTime)
		{
			transform.renderer.enabled = true;
			transform.collider2D.enabled = true;
			if(Time.realtimeSinceStartup >= despawnTime)
			{
				transform.renderer.enabled = false;
				transform.collider2D.enabled = false;
			}
		}
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Player") {
			AudioSource.PlayClipAtPoint (clip, transform.position);
			Destroy (gameObject);
			col.gameObject.GetComponentInChildren<Bubble>().health += healthGain;
		} else if (col.gameObject.tag == "Ground") {
			Destroy (gameObject);
		}
	}
}
