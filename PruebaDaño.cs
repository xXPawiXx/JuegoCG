using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaDaño : MonoBehaviour
{
    public LogicaBarraVida HPJugador;
    
    public LogicaBarraVida HPEnemigo;

    public float daño = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.B)){
            HPJugador.vidaActual -= daño;

            HPEnemigo.vidaActual -= daño;
        }
    }
}
