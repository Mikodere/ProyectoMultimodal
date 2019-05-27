using UnityEngine;
using System.Collections;

public class Municion : MonoBehaviour
{
    public float velocidad;
    public bool ifHit = false;
    public bool dest = false;

    void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * velocidad, ForceMode.Impulse);
    }
    // Update is called once per frame
    void Update()
    {
        if (dest)
        {
            GameObject.Destroy(gameObject, 0);

        }
        // transform.position += transform.forward * velocidad * Time.deltaTime;
    }

    void Golpeado()
    {
        Debug.Log("Golpeado!");
        //ifHit = true;
    }

}
    
