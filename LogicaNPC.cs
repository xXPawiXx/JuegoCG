using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LogicaNPC : MonoBehaviour
{
    public GameObject simboloMision;
    
    public GameObject panleNPC;
    
    public GameObject panleNPC2;
    
    public GameObject panleNPCMision;
    
    public GameObject[] Objetivos;
    
    public GameObject botonMision;
    
    public AnimacionPersonaje jugador;
    
    public TextMeshProUGUI textoMision;
    
    public bool jugadorCerca;
    
    public bool aceptarMision;
    
    public int numeroObjetivos;

    public bool letra;
    
    // Start is called before the first frame update
    void Start()
    {
        numeroObjetivos = Objetivos.Length;        

        textoMision.text = "Obten las esferas" + 
                "\n Restantes:  " + numeroObjetivos;
        
        jugador = GameObject.FindGameObjectWithTag("Player").GetComponent<AnimacionPersonaje>();

        simboloMision.SetActive(true);

        panleNPC.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {

        if(letra){

        if(Input.GetKeyDown(KeyCode.X) && aceptarMision == false && jugador.PuedoSaltar == true){

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
            letra = true;
            jugadorCerca = true;
            if(aceptarMision == false){
                panleNPC.SetActive(true);
            }
        }  
    }

    public void No(){
        jugador.enabled = true;

        panleNPC2.SetActive(false);

        panleNPC.SetActive(true);
    }

    public void Si(){
        jugador.enabled = true;
        
        aceptarMision = true;

        for (int i = 0; i < Objetivos.Length; i++){
            Objetivos[i].SetActive(true);
        }
        jugadorCerca = false;
        simboloMision.SetActive(false);
        panleNPC.SetActive(false);
        panleNPC2.SetActive(false);
        panleNPCMision.SetActive(true); 
    }
}
