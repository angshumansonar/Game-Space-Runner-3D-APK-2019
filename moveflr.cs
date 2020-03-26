using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class moveflr : MonoBehaviour {
    public float speed = 10;
    public float movespeed = 10;
    public float speedmultimeter;
    public float speedincreasemilestone;
    private float speedmilestonecount;


   // AudioSource lrsound;
    void Start()
    {
        speedmilestonecount = speedincreasemilestone;
        //lrsound = GetComponent<AudioSource>();

    }

    void Update()
    {
        if(transform.position.z>speedmilestonecount)
        {
            speedmilestonecount += speedincreasemilestone;
            speedincreasemilestone = speedincreasemilestone * speedmultimeter;
            speed = speed * speedmultimeter;
            //movespeed = speed * speedmultimeter;
        }
        float LR = CrossPlatformInputManager.GetAxis("Horizontal") * Time.deltaTime * movespeed;
        Vector3 clampedPosition = transform.position;
        //lrsound.Play();
        clampedPosition.x=Mathf.Clamp(transform.position.x, -0.63f, 0.63f);
        transform.position = clampedPosition;
        transform.Translate(LR, 0, 1 * speed * Time.deltaTime);
       


    }
    /*void FixedUpdate()
    {
        float LR =CrossPlartformInputManager.GetAxis("Horizontal") * Time.deltaTime * movespeed;
    }*/

}
