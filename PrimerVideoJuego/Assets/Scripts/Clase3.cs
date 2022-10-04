using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clase3 : MonoBehaviour
{

    // public Enemigo objeto;
    // public float vidaPersonaje=100;
    // int money=0;
    // public float vidaJugador=100;
    // Start is called before the first frame update
    void Start()
    {
        // int numeritoA = 30;
        // SumarCinco(ref numeritoA);
        // Debug.Log(numeritoA);
        // objeto = GameObject.Find("Pared");
        // objeto = FindObjectOfType<Enemigo>();
        // objeto.DestruirElMundo();
    }


    // Update is called once per frame
    void Update()
    {
        // Debug.DrawRay(transform.position,new Vector3(1,0,0)*5,Color.red);
        // JuntarDinero();
        // QuitarVidaJugador();
        // transform.position += new Vector3(0.1f,0,0) * Time.deltaTime;

    }

    public void SumarCinco(ref int numero)
    {
        // numero = numero + 5;
    }

    void JuntarDinero()
    {
        // money+=5;
        // money-=3;
        // Debug.Log(money);
    }

    void QuitarVidaJugador()
    {
        // vidaJugador -= Time.deltaTime;
        // Debug.Log(vidaJugador);
    }

    void MovmientoJugador()
    {
        // transform.position += new Vector3...
    }

    void Damage()
    {
        // vidaPersonaje--;
    }
}
