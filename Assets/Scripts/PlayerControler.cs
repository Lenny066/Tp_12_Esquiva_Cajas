using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private float[] posiciones = { -2f, 0f, 2f };
    private int indiceActual = 1; // Empieza en el centro (0f)

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (indiceActual < posiciones.Length - 1)
            {
                indiceActual++;
                transform.position = new Vector3(posiciones[indiceActual], transform.position.y, transform.position.z);
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (indiceActual > 0)
            {
                indiceActual--;
                transform.position = new Vector3(posiciones[indiceActual], transform.position.y, transform.position.z);
            }
        }
    }
}