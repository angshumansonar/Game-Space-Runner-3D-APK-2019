using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour {
    private GameObject Player;
    private GameObject cold;

    AudioSource AudioClip;
	// Use this for initialization
	void Start () {
        Player = GameObject.FindWithTag("Player");
        cold =Resources.Load("cold")as GameObject;
        AudioClip = GetComponent<AudioSource>();
	}
	
    void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag == "Player")
        {
            if (cold != null)
            {
                Instantiate(cold, Player.transform.position, Player.transform.rotation);
            }
            
            AudioClip.Play();
            Destroy(Player);         
        }
         

    }
}
