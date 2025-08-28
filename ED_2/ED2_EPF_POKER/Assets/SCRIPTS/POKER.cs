using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POKER : MonoBehaviour
{
    //JUGADOR
    List<int> TuJuego = new List<int>();
    public int[] numCarta = {2,3,4,5,6,7,8,9,10};
    public string[] nombreCarta = {"Corazon", "Trebol", "Diamante", "Espada"};
    private int U,O;
    private int Suma;


    //CONSOLA
    List<int> JuegoPC = new List<int>();
    private int[] NC = {2,3,4,5,6,7,8,9,10};
    private string[] nc = {"Corazon", "Trebol", "Diamante", "Espada"};
    private int m,b;
    private int t;
    // Start is called before the first frame update

    
    public void CartasPartida()
    {
        Debug.Log("Este es tu juego:");
        for(int i = 0; i < 5; i++)
        {
            U = Random.Range(0,numCarta.Length);
            O = Random.Range(0,nombreCarta.Length);
            Debug.Log(numCarta[U] + " " + nombreCarta[O]);
            TuJuego.Add(numCarta[U]);
        }

    }

    private void GamePC()
    {
        Debug.Log("Juego del oponente");
        for(int i = 0; i < 5; i++)
        {
            m = Random.Range(0,NC.Length);
            b = Random.Range(0,nc.Length);
            JuegoPC.Add(NC[m]);
        }
    }

    public void MostrarCARTAS()
    {
        GamePC();
        //SUMA DEL JUGADOR
        foreach(var item in TuJuego)
        {
            Suma = item + U;
        }

        //SUMA DEL PC
        foreach (var ITEM in JuegoPC)
        {
            t = ITEM + m;
        }

        CompararCartas();
    }


        //COMPARACION
    public void CompararCartas()
    {
        if(Suma > t)
        {
            Debug.Log("Tus puntos son:" + Suma);
            Debug.Log("GANASTE EL JUEGO");
        }

        else
        {
            Debug.Log("Puntos del oponente:" + t);
            Debug.Log("GANO TU OPONENTE");
        }
    }
        
}
