using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestorNiveles : MonoBehaviour
{   
    
    public void Start()
    {
        

    }
    public void CargarSiguienteNivel()
     {
        //int escenaActual = SceneManager.GetActiveScene().buildIndex; 
        //int siguienteEscenaIndice = escenaActual++;
        //Debug.Log(escenaActual);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
