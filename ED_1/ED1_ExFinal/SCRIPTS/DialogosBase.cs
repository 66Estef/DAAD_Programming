/*
DESARROLLADOR: Estefannia Lizzet Garcia Zepeda
ASIGNATURA: Estructura de Datos 
PROFESOR: Josue Israel Rivas Diaz
DESCRIPCIÓN: Este script tiene la función de crear la base para un item donde colocaremos los dialogos de Pete
    que mencionara en la Historia.
    Tema visto en clase
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Nuevo Dialogo")]
public class DialogosBase : ScriptableObject
{
    //Variable tipo string ya que usaremos letras y palabras para dichos dialogos.
    [SerializeField]
    private string nombrePersonaje;
    //Un contador para la cantidad de los dialogos
    [SerializeField]
    private int numDialogos;
    //Creamos un arreglo para los dialogos
    [SerializeField]
    private string[] dialogos;

    public string GetDialogos(int index)
    {
        return dialogos[index];
    }

    public int DialogosLenght()
    {
        return dialogos.Length;
    }
}
