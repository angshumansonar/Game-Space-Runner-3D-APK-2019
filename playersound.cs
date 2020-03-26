using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playersound : MonoBehaviour {

    
    public AudioSource sound;
	
	void Start () {
        if (pausemanu.gameispause== false)
        {
            sound = GetComponent<AudioSource>();
            sound.Play();
        }
	
	
    }
}
