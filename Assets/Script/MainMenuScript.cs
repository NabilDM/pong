using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

    // Start is called before the first frame update
public class MainMenuScript : MonoBehaviour 
{
    
   public void PlayGame()
    {
        SceneManager.LoadScene("game");
    }

    public void OpenAuthor()
    {
        Debug.Log("Created by Panda");
    }
}
