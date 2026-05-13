using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaColisiones : MonoBehaviour
{
    public float resetHeight = 5f;
    public float speedIncrement = 0.5f;
    private Rigidbody rb;
    private CajaMovimientos cajaMovimientos;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cajaMovimientos = GetComponent<CajaMovimientos>();
    }

    void OnCollisionEnter(Collision col)
    {
       if (col.gameObject.CompareTag("Player"))
{
    FindObjectOfType<UiManager>().DetenerTiempo();
    cajaMovimientos.enabled = false;
    rb.velocity = Vector3.zero;
    rb.isKinematic = true;
    Destroy(col.gameObject);
}
        else if (col.gameObject.CompareTag("Piso"))
        {
            cajaMovimientos.speed += speedIncrement;
            Reposicionar();
        }
    }

    void Reposicionar()
    {
        float[] posicionesX = { -2f, 0f, 2f };
        int index = Random.Range(0, posicionesX.Length);
        float nuevaX = posicionesX[index];

        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        transform.position = new Vector3(nuevaX, resetHeight, transform.position.z);
    }
}