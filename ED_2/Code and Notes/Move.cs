using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float velocidad = 0.5F; //representa la velocidad de mi objeto

    // Start is called before the first frame update
    void Start()
    {
        //punto de partida
        transform.position = new Vector3(-7.94f, 4.14f, 0f); 
    }

    // Update is called once per frame
    void Update()
    {
        //IA 
        // transform.position = transform.position + new Vector3(0, -0.5f, 0); //60 imagenes por segundos velocidad de tu
        //procesador
        if (Input.GetKey(KeyCode.S))
        {
            //Vecto3 mas direccion siempre devuelve 1 multiplicado por un valor de velocidad, los estabilizas a que lea son el ultimo
            // frame mulriplicado el Time.deltaTime
            transform.position += Vector3.down * velocidad * Time.deltaTime; //0.5 unidades hacia la direccion down
        }

        if (Input.GetKey(KeyCode.W))
        {
            //Vecto3 mas direccion siempre devuelve 1 multiplicado por un valor de velocidad, los estabilizas a que lea son el ultimo
            // frame mulriplicado el Time.deltaTime
            transform.position += Vector3.up * velocidad * Time.deltaTime; //0.5 unidades hacia la direccion down
        }

        if (Input.GetKey(KeyCode.A))
        {
            //Vecto3 mas direccion siempre devuelve 1 multiplicado por un valor de velocidad, los estabilizas a que lea son el ultimo
            // frame mulriplicado el Time.deltaTime
            transform.position += Vector3.left * velocidad * Time.deltaTime; //0.5 unidades hacia la direccion down
        }

        if (Input.GetKey(KeyCode.D))
        {
            //Vecto3 mas direccion siempre devuelve 1 multiplicado por un valor de velocidad, los estabilizas a que lea son el ultimo
            // frame mulriplicado el Time.deltaTime
            transform.position += Vector3.right * velocidad * Time.deltaTime; //0.5 unidades hacia la direccion down
        }
    }
}
