using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockAppear : MonoBehaviour
{
    public GameObject bloque;
    
public void OnTriggerEnter(Collider other) {
    bloque.SetActive(true);

}
}
