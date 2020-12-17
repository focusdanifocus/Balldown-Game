using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audiomanager : MonoBehaviour
{
    public static Audiomanager instance;
    // Start is called before the first frame update
    void Awake(){
        
         if (instance == null)
         
             instance = this;
         
         else
         {
             Destroy(gameObject);
         }
       
    
        
    }
}
