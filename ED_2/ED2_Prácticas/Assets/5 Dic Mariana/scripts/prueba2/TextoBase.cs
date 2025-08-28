using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Narracion")]
public class TextoBase : ScriptableObject
{
    [SerializeField]
    private string información;
    
    // Start is called before the first frame update
    public string GetInformacion()
    {
        return información;
    }
    
}
