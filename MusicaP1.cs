using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicaP1 : MonoBehaviour
{
    public AudioSource sonido;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M)){
            sonido.Stop();    
        } 
        if(Input.GetKeyDown(KeyCode.N)){
            sonido.Play();    
        }  
    }
}