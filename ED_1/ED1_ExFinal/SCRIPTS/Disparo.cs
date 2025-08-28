/*
DESARROLLADOR: Estefannia Lizzet Garcia Zepeda
ASIGNATURA: Estructura de Datos
PROFESOR: Josue Israel Rivas Diaz
DESCRIPCIÓN: Este script determina desde donde saldra la bala disparada para provocarle
    un daño al personaje si es que se atraviesa, a que velocidad y cada cuanto se repetira
    y saldra otra bala.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    //Necesitamos indicarle que objeto sera el que saldra disparado y desde que lugar.
    //Para la salida utilizamos un Empty object
    public GameObject Bala;
    public Transform salidacañon;
    // Start is called before the first frame update
    void Start()
    {
        //Invoca a la repeticion cada 4 f/s
        InvokeRepeating("Spawn",0,4);
    }

    void Spawn()
    {
        //La bala saldra desde la ubicacion donde se encuentre el empty object
        Instantiate(Bala,salidacañon.position,Quaternion.identity);
    }
}
