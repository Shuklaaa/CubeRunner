using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Transform Osbtacle;
	public Text scoreText;
 
	
	// Update is called once per frame
	void Update () {
		 
			scoreText.text = Time.time.ToString("0");
			 
		
		
	}
}