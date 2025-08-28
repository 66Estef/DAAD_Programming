/*
DESARROLLADOR: Estefannia Lizzet Garcia Zepeda
ASIGNATURA: Estructura de Datos 
PROFESOR: Josue Israel Rivas Diaz
DESCRIPCIÓN: Este script tenia como objetivo mostrar las colisiones que tendria Pete con los alimentos del continente asiatico.
    La accion se cumple, pero faltaron muchos detalles.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Colision3 : MonoBehaviour
{
    //Inicio de cla clase
    public int Parroz;
    public int Ramen;
    public TextMeshProUGUI arroz;
    public TextMeshProUGUI ramens;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D other)
    {
        arroz.text = "Arroz:" + Parroz;
        ramens.text = "Ramen(s):" + Ramen;

        if(other.gameObject.tag == "arroz")
        {
            Parroz++;
            arroz.text = "Arroz:" + Parroz;
            Destroy(other.gameObject);
        }

        if(other.gameObject.tag == "ramen")
        {
            Ramen++;
            ramens.text = "Ramen(s):" + Ramen;
            Destroy(other.gameObject);
        }
    }
}
