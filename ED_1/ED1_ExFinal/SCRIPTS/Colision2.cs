/*
DESARROLLADOR: Estefannia Lizzet Garcia Zepeda
ASIGNATURA: Estructura de Datos
PROFESOR:Josue Israel Rivas Diaz
DESCRIPCIÓN: Este script nos mostraria las colisiones que tendria Pete con los alimentos Macaron, Croissant y Queso del continente Europeo,
    basicamente la acción es la misma que en el continente americano solo que los puse por separado ya que al tratar de juntarlos todos en un solo scrip de colision
    me marcaba un error de que no encontraba los objetos, seguramente por estar en diferentes escenas, asi que uno por continente me es más sencillo y cómodo.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Colision2 : MonoBehaviour
{
    //Inicio clase
    //Colocamos 3 marcadores int para cada comida
    public int Macaron;
    public int Croissant;
    public int Queso;
    //Tres textos UI para cada uno
    public TextMeshProUGUI macarons;
    public TextMeshProUGUI croissants;
    public TextMeshProUGUI quesos;
    
    //Sección "Cuando Pete entre en colision con.."
    private void OnCollisionEnter2D(Collision2D other)
    {
        //Aqui los marcadores iniciaran en 0
        macarons.text = "Macarons:" + Macaron;
        croissants.text = "Croissants:" + Croissant;
        quesos.text = "Quesos:" + Queso;
        
        //Si PETE colisiona con un objeto con la etiqueta macarons, el marcador aumentara 1, se reflejara en el texto y destruira el objeto como muestra de recogerlo.
        if(other.gameObject.tag == "macarons")
        {
            Macaron++;
            macarons.text = "Macarons:" + Macaron;
            Destroy(other.gameObject);
        }
        //Si PETE colisiona con un objeto de nombre croisant, el marcador aumentara 1, se reflejara en el texto y destruira el objeto.
        if(other.gameObject.name == "croisant")
        {
            Croissant++;
            croissants.text = "Croissants:" + Croissant;
            Destroy(other.gameObject);
        }
        //Si PETE colisiona con un objeto con la etiqueta cheese, el marcador aumentara 1, se reflejara en el texto y destruira el objeto.
        if(other.gameObject.tag == "cheese")
        {
            Queso++;
            quesos.text = "Quesos:" + Queso;
            Destroy(other.gameObject);
        }
    }
}
