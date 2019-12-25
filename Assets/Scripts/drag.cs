using UnityEngine;
using System.Collections;

public class drag : MonoBehaviour {
	float distance=10;
	int flag=0;
	void OnMouseDrag() {
		flag = 1;
		Vector3 mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, distance);
		Vector3 objPosition = Camera.main.ScreenToWorldPoint (mousePosition);
		GetComponent<Rigidbody2D> ().velocity = (objPosition - transform.position) * 10;
		transform.SetParent (null);
	}

	void OnMouseUp() {
		GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
		flag = 0;
	}

	void Update() {
		if (flag == 0)
			GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
	}
}
	