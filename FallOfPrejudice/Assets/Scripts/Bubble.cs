using UnityEngine;
using System.Collections;

public class Bubble : MonoBehaviour {

	public float health = 100f;
	public GameObject player;
	public GameObject target;
	
	public float distanceBetweenPlayers;

	public GameController gameController;

	
	// Update is called once per frame
	void Update () {
		distanceBetweenPlayers = Vector3.Distance(player.transform.position, target.transform.position);
		if (distanceBetweenPlayers >= 5) {
					health -= 0.05f;
				}
		if (distanceBetweenPlayers <= 5) {
			health += 0.05f;	
		}
		if (health <= 0 && gameObject != null) {
			Debug.Log (health);
			Destroy (player);
			gameController.GameOver ();
		}
		light.spotAngle = health / 2 + 50f;
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Obstacle") {
			health -= 20;		
		}
						
	}
}
