using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controladorJugador : MonoBehaviour
{
    //Llamar el componente Rigidbody del jugador
    public Rigidbody rbJugador;
    public float velocidad;


    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            Application.Quit();
        }
    }
  
    
    public void FixedUpdate()
    {
        //CONTROLADOR del jugador
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");
        Vector3 movimiento = new Vector3(movimientoHorizontal,0,movimientoVertical);
        //FISICAS
        rbJugador.AddForce(movimiento * velocidad * Time.deltaTime);
         
    }

    public void Resetear() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex) 
    }
    
}
