/*
DESARROLLADOR: Estefannia Lizzet Garcia Zepeda
ASIGNATURA: Estructura de Datos 
PROFESOR: Josue Israel Rivas Diaz
DESCRIPCIÓN: Este script tiene el objetivo de mostrar las colisiones que tendra Pete con los elementos Taco y Palomita,
    los cuales debe juntar para ganar la moneda del continente "AMERICANO". Cada vez que pase sobre ellos se iran sumando
    y posteriormente se destruiran en señal de que los a recogido.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Colision : MonoBehaviour
{
    //Inicio de la clase

    //Queremos un contador para la comida y asi saber cuántos llevamos y si completamos para ganar la moneda.
    //Creamos 2 variables int con su respectivo nombre para cada comida
    public int Tacos;
    public int Palomita;
    
    // Para que el usuario al jugar vea y sepa cuántos a recogido, creamos dos textos UI.
    public TextMeshProUGUI tacos;
    public TextMeshProUGUI palomitas;

    private void Start()
    {
       
    }
    
    //Esta sección nos indica qué sucedera cuando el personaje entre en colision con otros objetos
    private void OnCollisionEnter2D(Collision2D other)
    {
        //Aqui le indicamos que al iniciar el juego nos muestre el marcador de la comida, el cual estara en 0 ya que apenas empieza.
        tacos.text = "Taco(s):" + Tacos;
        palomitas.text = "Palomita(s):" + Palomita;

        /*
        Este primer IF es para indicarle que: cuando Pete colisione con un objeto que tenga la etiqueta Comida, que es el caso de los tacos, nos registre
        que agarramos un taco, se actualice el marcador UI y por ultimo destruya el objeto.
        */

        if(other.gameObject.tag == "comida")
        {
            Tacos++;
            tacos.text = "Taco(s):" + Tacos;
            Destroy(other.gameObject);
        }

        /*
        Este segundo IF es similar al anterior, solo que en este caso le indicamos que: cuando Pete colisione con un objeto con la etiqueta palomitas
        se registre que lo tomamos, actualice el marcador de dicha comida y lo destruya posteriormente.
        */
        if(other.gameObject.tag == "palomita")
        {
            Palomita++;
            palomitas.text = "Palomita(s):" + Palomita;
            Destroy(other.gameObject);
        }

        //En el 3er if quiero indicarle que cuando el marcador llegue a 12 alimentos, diga que gaanste la moneda del continente
        if(Tacos == 6)
        {
            if(Palomita == 6)
            {
                Debug.Log("Lo lograste, ganaste una MONEDA");
            }
        }

    } 
}
