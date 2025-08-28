using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamientoAnimal : MonoBehaviour
{
    public string animalSound;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(animalSound);

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.S))
        {
            Debug.Log(animalSound);
        }
    }
}
