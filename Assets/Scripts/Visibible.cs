using UnityEngine;
using System.Collections;

public class Visibible : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		if (gameObject.transform.position.x > -60 && gameObject.transform.position.y > 220)
			gameObject.GetComponent<Renderer>().enabled = false;
		else
			gameObject.GetComponent<Renderer>().enabled = true;
	}
}
