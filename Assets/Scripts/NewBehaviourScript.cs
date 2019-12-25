using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour {

	public void MENU_ACTION_GotoPage(string sceneName) {
		SceneManager.LoadScene(sceneName);
	}
}
