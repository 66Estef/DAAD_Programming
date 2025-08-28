using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraMov : MonoBehaviour
{
    //Variables
    public float velocidadx;
    public float velocidady;
    float mousex;
    float mousey;
    float rotacionx;
    float rotaciony;
    public Transform orientacion;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        //funcion GetAxisRaw recibe los inputs del mouse, que tanto se movio del centro de la pantalla
        mousex = Input.GetAxisRaw("Mouse X") * Time.deltaTime * velocidadx;
        mousey = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * velocidady;

        rotaciony += mousex;
        // signo menos para invertirla
        rotacionx -= mousey;
        //limite de rotacion
        rotacionx = Mathf.Clamp(rotacionx, -90f, 90f);

        //Quaternios - angulos.Modificar la rotacion del objeto que tenga el script
        transform.rotation = Quaternion.Euler(rotacionx,rotaciony,0);
        //Saber en que direccion voltea el modelo respecto a su rotacion
        orientacion.rotation = Quaternion.Euler(0,rotaciony,0);
    }

}
