using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LogicaEsferas : MonoBehaviour
{
    public LogicaNPC logicanpc;

    public AnimacionPersonaje personaje;

    // Start is called before the first frame update
    void Start()
    {
        personaje = GameObject.FindGameObjectWithTag("Player").GetComponent<AnimacionPersonaje>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col){

        if(col.tag == "Player"){
            
            logicanpc.numeroObjetivos--;            
            logicanpc.textoMision.text = "Obten las esferas" + 
                                    "\n Restantes:  " + logicanpc.numeroObjetivos;              
            personaje.puntaje += 100;    
            personaje.Puntaje.text = "Puntaje:  " + personaje.puntaje;

                if(logicanpc.numeroObjetivos <= 0){
                    logicanpc.textoMision.text = "Mision Completada"+
                    "\n Dirigete a la salida";
                    logicanpc.botonMision.SetActive(true);
                }
                transform.parent.gameObject.SetActive(false);      
        }

    }
}
