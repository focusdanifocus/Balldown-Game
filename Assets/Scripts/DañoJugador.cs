using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoJugador : MonoBehaviour
{
    public controladorJugador jugador;

    public void OnCollisionEnter(Collision other) {
        
    
        Debug.Log("Colision");
        jugador.Resetear();
    } 
}
