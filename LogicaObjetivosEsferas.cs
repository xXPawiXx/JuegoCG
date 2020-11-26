using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LogicaObjetivosEsferas : MonoBehaviour
{

    public int numeroObjetivos;

    public TextMeshProUGUI textoMision;

    public TextMeshProUGUI Puntaje;

    public GameObject botonDeMision;

    public int puntaje;

    // Start is called before the first frame update
    void Start()
    {
        
            numeroObjetivos = GameObject.FindGameObjectsWithTag("Objetivo").Length;
            textoMision.text = "Obten las esferas" + 
                                "\n Restantes:  " + numeroObjetivos;
            Puntaje.text = "Puntaje:  " + puntaje; 

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "Objetivo"){
            numeroObjetivos--;
            textoMision.text = "Obten las esferas" + 
                        "\n Restantes:  " + numeroObjetivos;
            puntaje += 100;
            Puntaje.text = "Puntaje:  " + puntaje;

            if(numeroObjetivos <= 0){
                textoMision.text = "Completaste la misión";
                botonDeMision.SetActive(true);
            }
        }                    
    } 
}
