using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AnimacionPersonaje : MonoBehaviour
{

    public float velocidadM;

    public float velocidadR;

    public Animator animacion;

    public Rigidbody rb;

    public bool PuedoSaltar;

    float x, y ;

    public float VelocidadInicial;
    
    public float VelocidadAgachado;

    public int puntaje;   

    public TextMeshProUGUI Puntaje;

    public bool estoyAtacando;

    public bool avanzosolo;

    public float impulsogolpe = 10f;

    public CapsuleCollider colParado;
    
    public CapsuleCollider colAgachado;

    public GameObject  cabeza;

    public LogicaCabeza logicacabeza;

    public bool estoyAgachado;
    
    public AudioSource salto;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 

        velocidadM = 3.5f;

        velocidadR = 300f;

        PuedoSaltar = false; 

        animacion = GetComponent<Animator>();     

        VelocidadInicial = velocidadM;

        VelocidadAgachado = velocidadM * 0.5f;  

        puntaje = 0;

    }

    void FixedUpdate()
    {

        if(!estoyAtacando){        

        transform.Rotate(0,x * Time.deltaTime * velocidadR, 0);

        transform.Translate(0,0, y * Time.deltaTime * velocidadM);
        } 

        if(avanzosolo){
            rb.velocity = transform.forward * impulsogolpe;
        }
    }

    // Update is called once per frame
    void Update()
    {

        x = Input.GetAxis("Horizontal");

        y = Input.GetAxis("Vertical");       

        if(Input.GetMouseButton(0) && PuedoSaltar && !estoyAtacando) {

            animacion.SetTrigger("Golpeo");
            estoyAtacando = true;
        }     

        animacion.SetFloat("VelocidadX", x);

        animacion.SetFloat("VelocidadY", y);

        if(PuedoSaltar)
        {
            if(!estoyAtacando){
                if(Input.GetKeyDown(KeyCode.Space)){
                animacion.SetBool("Salte", true);
                rb.AddForce(new Vector3(0,4,0), ForceMode.Impulse);                 
                salto.Play();          
            }

                if(Input.GetKey(KeyCode.LeftControl)){
                animacion.SetBool("agachado",true);
                velocidadM = VelocidadAgachado;

                colAgachado.enabled = true;
                colParado.enabled = false;

                cabeza.SetActive(true);
                estoyAgachado = true;
            }
                else{

                    if(logicacabeza.contadorDeCabeza <= 0){
                
                animacion.SetBool("agachado",false);
                velocidadM = VelocidadInicial;

                cabeza.SetActive(false);
                colAgachado.enabled = false;
                colParado.enabled = true;
                estoyAgachado = false;  
                 }
            }
            }

            

            animacion.SetBool("Tocasuelo",true);
        }
        else{
            estoyCayendo();
        }

    }

    public void estoyCayendo()
    {    
        animacion.SetBool("Tocasuelo",false);
        animacion.SetBool("Salte",false);
    }

    public void DejeDeGolpear(){

        estoyAtacando = false;
    }

    public void Ananzosolo(){
        avanzosolo = true;
    }

    public void DejoDeAvanazar(){
        avanzosolo = false;
    }
}
