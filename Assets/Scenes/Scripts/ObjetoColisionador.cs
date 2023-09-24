using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoColisionador : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Obtener una referencia al UIManager
            UIManager uiManager = GameObject.FindObjectOfType<UIManager>();
            // Incrementar el contador
            uiManager.IncrementarContador();
        }
    }
}
