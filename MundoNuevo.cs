using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MundoNuevo : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
            SceneManager.LoadScene("Pantalla2");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
