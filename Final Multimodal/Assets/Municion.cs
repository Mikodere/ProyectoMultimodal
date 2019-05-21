using UnityEngine;
using System.Collections;

public class Municion : MonoBehaviour
{

    public float velocidad;
    public float ToLife = 2;
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

}
    
