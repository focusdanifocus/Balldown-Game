using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objetodestruible : MonoBehaviour
{
    public float deathtime;
    public GameObject bloque;
    
    
    public void  OnCollisionEnter() {
        Destroy(bloque,deathtime);
        
    }
}
