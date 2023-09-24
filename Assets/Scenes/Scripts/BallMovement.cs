using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float MovementSpeed = 5f; // Velocidad de movimiento del personaje

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        // Obtener las entradas del teclado
        float HorizontalMove = Input.GetAxis("Horizontal");
        float VerticalMove = Input.GetAxis("Vertical");

        // Calcular el vector de movimiento
        Vector3 Movement = new Vector3(HorizontalMove, 0, VerticalMove);

        // Aplicar la fuerza al Rigidbody para mover el personaje
        rb.AddForce(Movement * MovementSpeed, ForceMode.Force);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            // Hacer que el objeto desaparezca.
            Destroy(other.gameObject);
        }
    }
}
