using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOver : MonoBehaviour
{
    public UIManager manager;
    public Turret lanzar;

    public int intentos = 3;

    public void OnTriggerExit(Collider other)
    {
        Debug.Log("Se ha salido: " + other.ToString());
        Municion bola = other.GetComponent<Municion>();
        if(other.tag == "pelota") //&& bola.ifHit == false)
        {
            intentos--;

            bola.dest = true;

            if (intentos > 0)
            {
                lanzar.activate = true;
            }
            else
            {
                Time.timeScale = 0;
                manager.ShowFinished();

            }
        }
    }
}
