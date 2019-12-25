using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class clicktochangetext : MonoBehaviour {

	public Text textshowed=null;
	public void changeWord (string word)
	{
		textshowed.text = word;
	}
}
