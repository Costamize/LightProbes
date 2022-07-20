using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightLight : MonoBehaviour
{
    //[SerializeField]
    public Light lightbutton;
    AudioSource clickL;

    void Start(){
       clickL = GetComponent<AudioSource>();
    }

        void OnTriggerEnter(Collider other)  
    {    
            clickL.Play(0);
            //Debug.Log("yes");

                                         //array_to_search
        //foreach (GameObject light in GetComponent<Light>())  
        //Renderer lit = GetComponent<Renderer>();
        
        lightbutton.GetComponent<Light>().color = this.gameObject.GetComponent<Light>().color;
        lightbutton.GetComponent<Light>().intensity = this.gameObject.GetComponent<Light>().intensity;
        //Debug.Log(gameObject.tag);
            }
}