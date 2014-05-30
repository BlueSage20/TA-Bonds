using UnityEngine;
using System.Collections;

public class DestroyByGround : MonoBehaviour {
	void OnTriggerExit(Collider other) {
		Destroy (this.gameObject);
	}	
}
