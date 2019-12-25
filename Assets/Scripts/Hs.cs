using UnityEngine;
using System.Collections;

public class Hs : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D other)
	{
		if (transform.position.x < 3) {
			if (other.gameObject.name=="Switch_ani" && (this.transform.position.y-other.transform.position.y)>=1){
				GameObject[] gameObjects = Resources.FindObjectsOfTypeAll<GameObject> ();
				for (int i = 0; i < gameObjects.Length; i++) {
					if (gameObjects [i].name == "Hs_ani")
						gameObjects [i].SetActive (true);
					else if (gameObjects [i].name == "Hs")
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
