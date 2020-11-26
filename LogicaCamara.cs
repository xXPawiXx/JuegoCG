using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaCamara : MonoBehaviour
{
    public Transform objetivo;

    public Vector3 desenfoque;

    public float velocidadzoom;

    public float zoommax;

    public float zoommin;

    private float zoomact = 10f ;

    public float incl;

    public float velocidadang;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        zoomact -= Input.GetAxis("Mouse ScrollWheel") * velocidadzoom;

        zoomact = Mathf.Clamp(zoomact,zoommin,zoommax);
    }

    void LateUpdate(){
        transform.position = objetivo.position - desenfoque * zoomact;
        transform.LookAt(objetivo.position + Vector3.up * incl);
    }
}
