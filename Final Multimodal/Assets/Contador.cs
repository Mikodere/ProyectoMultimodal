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

            //La pared devuelve la bola al centro para que el jugador pueda volver a golpear sin moverse
            Vector3 pos = new Vector3(target.position.x, target.position.y + 2.0f, target.position.z - 1f);
            dir = pos - other.transform.position;
            other.rigidbody.velocity = new Vector3(0, 0, 0);
            other.rigidbody.AddForceAtPosition(dir.normalized * Random.Range(5.5f, 6.5f) , other.transform.position, ForceMode.Impulse);
        }
    }
}
