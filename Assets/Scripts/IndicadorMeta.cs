using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndicadorMeta : MonoBehaviour
{
    private Collider indicador;
    public GestorNiveles Gestor;

    private void Start() {
        indicador = GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other) {
        Gestor.CargarSiguienteNivel();
    }
}
