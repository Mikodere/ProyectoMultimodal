using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public bool activate = true;
    private Vector3  Rand;

    public GameObject municion;
    public Transform salida;


    // Update is called once per frame
    void Update()
    {
        if (activate == true)
        {
            Disparar();
            activate = false;
        }

        
    }
    void Disparar()
    {
        Rand = new Vector3(Random.Range(-0.5f, 0.5f), 0.0f, 0.0f);
        GameObject Bala = (GameObject)Instantiate(municion, salida.position + Rand, salida.rotation);
        Bala.transform.forward = salida.forward;
        Bala.transform.parent = transform;
    }
}
