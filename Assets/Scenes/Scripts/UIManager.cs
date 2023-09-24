using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text text;
    private int contador = 0;

    void Start()
    {
        ActualizarTexto();
    }
    void ActualizarTexto()
    {
        text.text = "Monedas: " + contador + "/3";
    }

    // Método para incrementar el contador
    public void IncrementarContador()
    {
        contador++;
        ActualizarTexto();
    }

    private void Update()
    {
        if (contador == 3) 
        {
            SceneManager.LoadScene(1);
        }
    }
}
