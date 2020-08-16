using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NuevoControladorCamara : MonoBehaviour
{
    public Transform jugador;
    public float suavizado = 0.125f;

    public Vector3 offset = new Vector3(0,5,0);

   
    void LateUpdate() {
        transform.position = jugador.position + offset;
        
    }
}
