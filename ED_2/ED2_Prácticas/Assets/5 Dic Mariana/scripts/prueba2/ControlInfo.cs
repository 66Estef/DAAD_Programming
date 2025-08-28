using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ControlInfo : MonoBehaviour
{
    public TextMeshProUGUI texto;
    public TextoBase texto1;
    // Start is called before the first frame update
    void Start()
    {
        texto.text = texto1.GetInformacion();
    }

    public void matarzombie()
    {
        SceneManager.LoadScene("Escena3");
    }
    
}
