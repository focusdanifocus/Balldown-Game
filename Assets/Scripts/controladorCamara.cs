using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorCamara : MonoBehaviour
{
    public GameObject jugador;
    Vector3 posicionRelativa;
   
    void Start()
    {
        posicionRelativa = transform.position - jugador.transform.position;
       
    }

  
    void LateUpdate()
    {
         transform.position = jugador.transform.position + posicionRelativa;
         
    }
}
