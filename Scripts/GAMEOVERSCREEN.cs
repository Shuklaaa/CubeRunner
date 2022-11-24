using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GAMEOVERSCREEN : MonoBehaviour
{
    public Text pointsText;
    // public void Setup(int score)
    // {
    //     gameObject.SetActive(true);
    //     points.text = score.ToString()+ "POINTS";
    // } 
    public void RestartButton()
    {
         if (Input.GetKey(KeyCode.Escape))	// If the player is pressing the "d" key
		{
			// Add a force to the right
			Application.Quit();
      SceneManager.LoadScene("Level1");
		}
        Application.Quit();
      SceneManager.LoadScene("Level1");

    }
    public void ExitButton()
    {
       SceneManager.LoadScene("startscreen");
    }
}
