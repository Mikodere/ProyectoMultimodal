using UnityEngine;
using System.Collections;

public class Municion : MonoBehaviour
{
    public float velocidad;
    public float ToLife = 2;

    public bool ifHit = false;

    void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * velocidad, ForceMode.Impulse);
    }
    // Update is called once per frame
    void Update()
    {
        GameObject.Destroy(gameObject, ToLife);
        // transform.position += transform.forward * velocidad * Time.deltaTime;
    }

    void Golpeado()
    {
        Debug.Log("Golpeado!");
        //ifHit = true;
    }

}
    
