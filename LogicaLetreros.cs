using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LogicaLetreros : MonoBehaviour
{
    public GameObject simboloMision;
    
    public GameObject panleNPC;
    
    public GameObject panleNPC2;
    
    public GameObject botonMision;
    
    public AnimacionPersonaje jugador;
    
    public bool jugadorCerca;

    public bool letra;
    
    // Start is called before the first frame update
    void Start(){
        
        jugador = GameObject.FindGameObjectWithTag("Player").GetComponent<AnimacionPersonaje>();

        simboloMision.SetActive(true);

        panleNPC.SetActive(false);

        letra = false;
        
    }

    // Update is called once per frame
    public void Siguiente()
    {

        if(letra){
        if(jugador.PuedoSaltar == true){

            Vector3 posicionJugador = new Vector3(transform.position.x, jugador.gameObject.transform.position.y, transform.position.z);
            jugador.gameObject.transform.LookAt(posicionJugador); 

            jugador.animacion.SetFloat("VelocidadX",0);
            jugador.animacion.SetFloat("VelocidadY",0);
            jugador.enabled = false;
            panleNPC.SetActive(false);
            panleNPC2.SetActive(true);
        }

        }
    }

    private void OnTriggerExit(Collider other){
        if(other.tag == "Player")
        {
            jugadorCerca = false;
            panleNPC.SetActive(false);
            panleNPC2.SetActive(false);
            letra = false;
        }  
    }

    private void OnTriggerEnter(Collider other){
        if(other.tag == "Player")
        {
            jugadorCerca = true;
            panleNPC.SetActive(true);
            letra = true;
            
        }  
    }

    public void No(){
        
        jugador.enabled = true;

        panleNPC2.SetActive(false);

        panleNPC.SetActive(true);
    }
}
