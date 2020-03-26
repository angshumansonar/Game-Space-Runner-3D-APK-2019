using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmanu : MonoBehaviour {
   
 public void PlayGame()
    {
              SceneManager.LoadScene(1);
        admob.instance.Loadinterstitialad();
    }
    public void QuitGame()
    {
        
        Debug.Log("GAME..EXIT..!");
        Application.Quit();
    }
}
