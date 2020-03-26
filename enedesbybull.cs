using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enedesbybull : MonoBehaviour {
    public GameObject objecttodestroy;
    public GameObject effect;
    //AudioSource sound;
    // Use this for initialization
    void Start()
    {
       //sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag == "bullet")
        {
            Instantiate(effect, objecttodestroy.transform.transform.position, objecttodestroy.transform.rotation);
            //sound.Play();
            Destroy(objecttodestroy);
        }


    }

}
