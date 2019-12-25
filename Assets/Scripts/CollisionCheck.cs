using UnityEngine;
using System.Collections;

public class CollisionCheck : MonoBehaviour {
	void OnCollisionEnter2D(Collision2D other)
	{
		if (transform.position.x < 3) {
			if (other.gameObject.name=="Coal" && (this.transform.position.y-other.transform.position.y)>=1){
				GameObject[] gameObjects = Resources.FindObjectsOfTypeAll<GameObject> ();
				for (int i = 0; i < gameObjects.Length; i++) {
					if (gameObjects [i].name == "Boiler_ani")
						gameObjects [i].SetActive (true);
					else if (gameObjects [i].name == "Fire_ani")
						gameObjects [i].SetActive (true);
					else if (gameObjects [i].name == "Coal")
						gameObjects [i].SetActive (false);
					else if (gameObjects [i].name == "Boiler")
						gameObjects [i].SetActive (false);
					else if (gameObjects [i].tag == "Ani" && gameObjects [i].activeSelf == true) {
						gameObjects [i].SetActive (false);
						gameObjects [i].SetActive (true);
					}
				}
			}
		}
	}
}
