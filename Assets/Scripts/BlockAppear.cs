using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockAppear : MonoBehaviour
{
    public GameObject bloque;
    public GameObject ItemD;
    
    
//Aqui van todos los elementos que aparecen cuando tome el item que hace aparecer un bloque
public void OnTriggerEnter(Collider other) {
    bloque.SetActive(true);
    Destroy(ItemD);


}
}
