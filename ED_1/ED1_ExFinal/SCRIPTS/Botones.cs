/*
DESARROLLADOR: Estefannia Lizzet Garcia Zepeda
ASIGNATURA: Estructura de Datos
PROFESOR: Josue Israel Rivas Diaz
DESCRIPCIÓN: Este script tiene como objetivo dar las instrucciones de los botones del juego.
    Cada boton guiara a una escena diferente. En este caso el boton de SALIR esta inhabilitado para el usuario.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botones : MonoBehaviour
{
    //Serie de métodos para los botones.
    //Debemos colocar el nombre de la escena a la que queremos pasar.

    public void Jugar()
    {
        SceneManager.LoadScene("Historia");
    }
    
    //Este metodo solo sera visible para el desarrollador
    public void Salir()
    {
        Debug.Log("Saliste del juego");
    }

    public void Vamos()
    {
        SceneManager.LoadScene("Mapa");
    }

    public void Volver()
    {
        SceneManager.LoadScene("Historia");
    }

    public void Cam()
    {
        SceneManager.LoadScene("America");
    }

    public void CEu()
    {
        SceneManager.LoadScene("Europa");
    }

    public void Caf()
    {
        SceneManager.LoadScene("Africa");
    }

    public void Cas()
    {
        SceneManager.LoadScene("Asia");
    }

    public void Coc()
    {
        SceneManager.LoadScene("Oceania");
    }
}
