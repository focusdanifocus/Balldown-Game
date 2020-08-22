using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reset : MonoBehaviour
{   public controladorJugador jugador;

    
    public void OnTriggerEnter(Collider other) {
        jugador.Resetear();
    }  
    
}   

