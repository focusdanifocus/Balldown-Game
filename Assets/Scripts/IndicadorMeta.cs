using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndicadorMeta : MonoBehaviour
{
    private Collider indicador;
    public GestorNiveles Gestor;
    public float waitTimeload;

    private void Start() {
        indicador = GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other) {
        StartCoroutine(waitforLoad());
    }

    IEnumerator waitforLoad()
    {

    
        yield return new WaitForSeconds(waitTimeload);
        Gestor.CargarSiguienteNivel();
    
        
    }
        
}
