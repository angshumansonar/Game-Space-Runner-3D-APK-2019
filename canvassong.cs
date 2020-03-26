using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvassong : MonoBehaviour {
    public AudioSource manusong;
    // Use this for initialization
    void Start () {
        manusong = GetComponent<AudioSource>();
        manusong.Play();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
