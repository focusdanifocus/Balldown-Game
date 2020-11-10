using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controladorJugador : MonoBehaviour
{
    //Llamar el componente Rigidbody del jugador
    public Rigidbody rbJugador;
    public float velocidad;
    public float velocidadCaida;


    public void Update()
    {
        //Sales del juego si apretas la tecla Escape
        if (Input.GetKeyDown(KeyCode.Escape)){
            Application.Quit();
        }
    }
  
    
    public void FixedUpdate()
    {
        //Almacenar el movimiento del analogo o las teclas de dirección
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");
        Vector3 movimiento = new Vector3(movimientoHorizontal,0,movimientoVertical);
        //Añado una fuerza al Rigidbody del jugador
        rbJugador.AddForce(movimiento * velocidad * Time.deltaTime);
        

        velocidadCaida = -(rbJugador.velocity.y);
        
        if(velocidadCaida > 20 ){
            Debug.Log("Vas Rapido!");
        }
        
         
    }

    public void Resetear() 
    {   // Resetea el nivel si mueres o pierdes
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }

    
  
    
}
