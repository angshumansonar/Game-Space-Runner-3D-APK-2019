using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

public class pausemanu : MonoBehaviour {
    public static bool gameispause = false;
    public GameObject pausemanuui;
    public GameObject score;
    public GameObject leftbt;
    public GameObject rightbt;
    public GameObject firebt;
    public GameObject pausebt;
    public GameObject capsulsound;

    // Update is called once per frame
    void Update () {
        if (CrossPlatformInputManager.GetButtonDown("Cancel"))
        {
            if (gameispause)
            {
                Resume();
            }
            pause();
        }
	}
    public void Resume()
    {
        //admob.instance.Loadinterstitialad();
        pausemanuui.SetActive(false);
        Time.timeScale = 1f;
        gameispause = false;
        score.SetActive(true);
        leftbt.SetActive(true);
        rightbt.SetActive(true);
        firebt.SetActive(true);
        pausebt.SetActive(true);
        capsulsound.SetActive(true);
       
    }
    public void pause()
    {
        //admob.instance.showinterstitialad();
        pausemanuui.SetActive(true);
        Time.timeScale = 0f;
        gameispause = true;
        score.SetActive(false);
        leftbt.SetActive(false);
        rightbt.SetActive(false);
        firebt.SetActive(false);
        pausebt.SetActive(false);
        capsulsound.SetActive(false);
        

    }
    public void Loadmanu()
    {
        SceneManager.LoadScene("gamemanu");
    }
    public void quit()
    {
        Debug.Log("quit.....");
        Application.Quit();
    }
}
