using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorUp : MonoBehaviour
{
    Rigidbody doorButton;
    private float doorForce = 2222f;
    AudioSource doorBell;

    void Start()
    {
        //Fetch the Rigidbody from the GameObject with this script attached
        doorButton = GetComponent<Rigidbody>();
        doorBell = GetComponent<AudioSource>(); 
    }

    void OnTriggerEnter(Collider other)
    {

            //Apply a force to this Rigidbody in direction of this GameObjects up axis
            doorButton.AddForce(transform.up * doorForce);
            doorBell.Play(0); //Door sound
             
    }
}
