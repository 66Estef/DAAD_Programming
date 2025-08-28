/*
DESARROLLADOR: Estefannia Lizzet Garcia Zepeda
ASIGNATURA: Estructura de Datos
PROFESOR: Josue Israel Rivas Diaz
DESCRIPCIÓN: Este script quiero que active un pequeño panel donde saldra el texto de victoria y la moneda del continente
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject panel;
    public GameObject moneda;
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
        moneda.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        panel.SetActive(true);
        moneda.SetActive(true);
    }
}
