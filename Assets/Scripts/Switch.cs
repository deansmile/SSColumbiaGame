using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D other)
	{
		if (transform.position.x < 3) {
			if (other.gameObject.name=="Boiler_ani" && (this.transform.position.y-other.transform.position.y)>=1){
				GameObject[] gameObjects = Resources.FindObjectsOfTypeAll<GameObject> ();
				for (int i = 0; i < gameObjects.Length; i++) {
					if (gameObjects [i].name == "Switch_ani")
						gameObjects [i].SetActive (true);
					else if (gameObjects [i].name == "Switch")
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
