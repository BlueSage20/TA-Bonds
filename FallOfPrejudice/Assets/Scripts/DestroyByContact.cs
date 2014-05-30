using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour {
	void Update()
	{
		if (transform.position.y <= -3) {
			Destroy(gameObject);		
		}
	}
}
