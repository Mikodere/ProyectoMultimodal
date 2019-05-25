using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contador : MonoBehaviour
{
    private int count;
    public Text countText;

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
        }
    }
}
