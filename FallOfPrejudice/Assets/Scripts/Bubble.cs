using UnityEngine;
using System.Collections;

public class Bubble : MonoBehaviour {

	public float health = 100f;
	public GameObject player;
	public GameObject target;

	public float drain = -0.05f;
	public float recover = 0.05f;
	
	public float distanceBetweenPlayers;

	public GameController gameController;

	
	// Update is called once per frame
	void Update () {
				if (player && target != null) {
						distanceBetweenPlayers = Vector3.Distance (player.transform.position, target.transform.position);
						if (distanceBetweenPlayers >= 5) {
								health -= drain;
						}
						if (distanceBetweenPlayers <= 5) {
								health += recover;	
						}
						if (health <= 0 && gameObject != null) {
								Destroy (player);
								gameController.GameOver ();
						}
						light.spotAngle = health / 2 + 50f;
				}
		}
}
