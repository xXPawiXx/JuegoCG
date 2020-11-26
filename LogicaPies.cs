using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPies : MonoBehaviour
{
    public AnimacionPersonaje animacionpersonaje;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other){
        if(other.tag== "Floor")
        animacionpersonaje.PuedoSaltar = true;
    }

    private void OnTriggerExit(Collider other){
        animacionpersonaje.PuedoSaltar = false;
    }
}
