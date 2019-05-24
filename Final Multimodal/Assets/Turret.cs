using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public float fireRate = 1f;
    private float fireCountdown = 0f;

    public GameObject municion;
    public Transform salida;


    // Update is called once per frame
    void Update()
    {
        if (fireCountdown <= 0f)
        {
            Disparar();
            fireCountdown = 1f / fireRate;
        }

        fireCountdown -= Time.deltaTime;

    }
    void Disparar()
    {
        GameObject Bala = (GameObject)Instantiate(municion, salida.position, salida.rotation);
        Bala.transform.forward = salida.forward;
        //Bala.transform.SetParent(salida);
    }
}
