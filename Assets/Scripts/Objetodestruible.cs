using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objetodestruible : MonoBehaviour
{
    public GameObject bloque;
    
    public void  OnCollisionEnter() {
        Destroy(bloque,2f);
    }
}
