using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOver : MonoBehaviour
{
    public UIManager manager;

    public void OnTriggerExit(Collider other)
    {
        Debug.Log("Se ha salido: " + other.ToString());
        Municion bola = other.GetComponent<Municion>();
        if(other.tag == "pelota" && bola.ifHit == false)
        {
            Time.timeScale = 0;
            manager.ShowFinished();
        }
    }
}
