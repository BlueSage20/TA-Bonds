using UnityEngine;
using System.Collections;

public class Bubble : MonoBehaviour {

	public float health;
	public GameObject player;

	float distanceBetweenPlayers = 0;

	public GameController gameController;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		health = light.spotAngle;
		if (distanceBetweenPlayers == 0) {
						light.spotAngle -= 0.1f;
				}
		if (health <= 50) {
			Destroy (player);
			gameController.GameOver ();
		}
	}
}
