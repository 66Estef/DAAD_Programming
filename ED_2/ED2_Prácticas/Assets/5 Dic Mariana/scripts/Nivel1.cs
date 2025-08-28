using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Nivel1 : MonoBehaviour
{
    public TextMeshProUGUI texto;
    // Start is called before the first frame update
    void Start()
    {
        texto.text= "Esrtas solo con zombies. Que haces?";
    }

    // Update is called once per frame
    public void CORRER()
    {
        SceneManager.LoadScene("EscenaCorrer");
    }

    public void MATAR()
    {
        SceneManager.LoadScene("Escena3");
    }
}
