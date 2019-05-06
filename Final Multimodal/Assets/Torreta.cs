using UnityEngine;
using System.Collections;

public class Torreta : MonoBehaviour
{

    [Header("Unity Setup Fields")]

    public float fireRate = 1f;
    private float fireCountdown = 0f;
    public GameObject municion;
    public Transform salida_municion;

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
        //Rellena el código necesario
        GameObject bala = (GameObject)Instantiate(municion, salida_municion.transform.position, salida_municion.transform.rotation);
        Municion bullet = bala.GetComponent<Municion>();

        if (bullet != null)
        {
            bullet.Lanzar(salida_municion);
        }
    }
}
