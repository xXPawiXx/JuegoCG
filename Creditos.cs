using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Creditos : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
            SceneManager.LoadScene("Creditos");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
