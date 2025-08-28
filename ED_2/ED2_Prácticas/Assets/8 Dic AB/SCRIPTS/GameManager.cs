using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameObject[]PCjuego;
    public GameObject[] Juego;
    // Start is called before the first frame update
    void Start()
    {
        Juego[0].SetActive(false);
        Juego[1].SetActive(false);
        Juego[2].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
