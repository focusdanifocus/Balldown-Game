using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDessapear : MonoBehaviour
{
    public GameObject bloque2;
   
    public void OnTriggerEnter(Collider other) {
    bloque2.SetActive(false);
    }
}
