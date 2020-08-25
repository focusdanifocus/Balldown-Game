using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDessapear : MonoBehaviour
{
    public GameObject bloque2;
    public GameObject This;
   
    public void OnTriggerEnter(Collider other) {
    bloque2.SetActive(false);
    Destroy(This);
    }
}
