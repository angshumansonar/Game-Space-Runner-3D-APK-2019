using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class score : MonoBehaviour {
    public Transform player;
    public Text scoretext;
    public GameObject deatmn;
    public GameObject leftbt;
    public GameObject rightbt;
    public GameObject firebt;
    public GameObject pausebt;
    
    // Use this for initialization
    void Start () {
        deatmn.SetActive(false);
	}

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            scoretext.text = player.position.z.ToString("0");
        }
        else
        {
            admob.instance.showinterstitialad();
            deatmn.SetActive(true);
            leftbt.SetActive(false);
            rightbt.SetActive(false);
            firebt.SetActive(false);
            pausebt.SetActive(false);

        }

    }
    
}
