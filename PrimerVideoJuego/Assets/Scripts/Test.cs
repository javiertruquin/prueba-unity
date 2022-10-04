// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    public float velocidad;

    //Variables direccion movimiento
    public Vector3 direccion;

    //Variables de escalado
    public Vector3 escala;
    
    //Variables de rotacion
    public Vector3 rotacion;

    void Start()
    {
        transform.localScale += escala;
    }

    void Update()
    {
        transform.position += direccion * velocidad;
        transform.Rotate(rotacion);
    }

}
