using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiManager : MonoBehaviour
{
    public TextMeshProUGUI tiempoText;
    private float tiempo;
    private bool contando = true;

    void Update()
    {
        if (contando)
        {
            tiempo += Time.deltaTime;
            tiempoText.text = tiempo.ToString("F2");
        }
    }

    public void DetenerTiempo()
    {
        contando = false;
    }
}