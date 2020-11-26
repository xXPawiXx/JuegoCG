using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoPies : MonoBehaviour
{

    public AudioSource Pie;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Floor")
        {
            Pie.Play();
        }  
    }
}
