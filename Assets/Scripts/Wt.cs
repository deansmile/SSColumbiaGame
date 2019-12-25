using UnityEngine;
using System.Collections;

public class Wt : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D other)
	{
		if (transform.position.x < 3) {
			if (other.gameObject.name=="SwitchH_ani" && (this.transform.position.x-other.transform.position.x)>0){
				GameObject[] gameObjects = Resources.FindObjectsOfTypeAll<GameObject> ();
				for (int i = 0; i < gameObjects.Length; i++) {
					if (gameObjects [i].name == "Wt_ani")
						gameObjects [i].SetActive (true);
					else if (gameObjects [i].name == "Wt")
						gameObjects [i].SetActive (false);
					else if (gameObjects [i].tag == "Ani" && gameObjects [i].activeSelf == true) {
						gameObjects [i].SetActive (false);
						gameObjects [i].SetActive (true);
					}
				}
				int flag = 0;
				for (int i = 0; i < gameObjects.Length; i++) {
					if (gameObjects [i].tag == "Ani")
					if (gameObjects [i].activeSelf == false) {
						flag = 1;	
						break;
					}
				}
				if (flag==0)
					for (int i=0;i<gameObjects.Length;i++)
						if (gameObjects [i].name == "Ending")
							gameObjects [i].SetActive (true);
			}
		}
	}
}
