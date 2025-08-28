using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class botones : MonoBehaviour
{
    public void Menu()
    {
        SceneManager.LoadScene("Menú");
    }

    public void Nuno()
    {
        SceneManager.LoadScene("Nivel1");
    }

    public void Nudos()
    {
        SceneManager.LoadScene("Nivel2");
    }
    public void creditos()
    {
        SceneManager.LoadScene("Creditos");
    }
}
