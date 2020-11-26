using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaCabeza : MonoBehaviour
{
    public int contadorDeCabeza = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        contadorDeCabeza++;
    }

    void OnTriggerExit(Collider other){
        contadorDeCabeza--;
    }
}
