using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contador : MonoBehaviour
{
    private int count;
    public Text countText;

    private Vector3 dir;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collide!");
        if(other.collider.tag == "pelota")
        {
            count++;
            countText.text = "Puntos: " + count.ToString();

            //devolver la bola al punto central
            dir = target.position - other.transform.position;
            other.rigidbody.AddForceAtPosition(dir.normalized , other.transform.position, ForceMode.Impulse);
        }
    }
}
