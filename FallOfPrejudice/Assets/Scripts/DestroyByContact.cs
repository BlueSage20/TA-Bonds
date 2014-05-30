using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour 
{
	void Start ()
	{
	}
	
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Player") {
			Destroy (gameObject);
			col.gameObject.GetComponentInChildren<Bubble>().health -= 20;
		} else if (col.gameObject.tag == "Ground") {
			Destroy (gameObject);
		}
	}
}
