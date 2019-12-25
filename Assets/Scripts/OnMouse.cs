using UnityEngine;
using System.Collections;

public class OnMouse : MonoBehaviour {


	void OnMouseOver() {
		GameObject[] gameObjects = Resources.FindObjectsOfTypeAll<GameObject> ();
		for (int i = 0; i < gameObjects.Length; i++)
			if (gameObjects [i].name == "Coal_explanation")
				gameObjects [i].SetActive (true);
	}

	void OnMouseExit()
	{
		GameObject[] gameObjects = Resources.FindObjectsOfTypeAll<GameObject> ();
		for (int i = 0; i < gameObjects.Length; i++)
			if (gameObjects [i].name == "Coal_explanation")
				gameObjects [i].SetActive (false);
	}
}
