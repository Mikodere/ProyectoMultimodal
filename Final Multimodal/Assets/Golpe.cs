using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golpe : MonoBehaviour
{
    private Camera cam;
    private Vector3 dir;
    private bool is_triggered = false;
    private float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //pos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, this.transform.position.z);
            Ray rayo = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit; 
            Debug.DrawRay(rayo.origin, rayo.direction * 10, Color.yellow);

            dir = new Vector3(-rayo.direction.x, rayo.direction.y, rayo.direction.z);
            velocidad = Input.acceleration.z;

            if (Physics.Raycast(rayo, out hit))
            {
                if(hit.rigidbody != null && is_triggered == true)
                {
                    Debug.Log("Hit!" + velocidad);
                    hit.rigidbody.AddForceAtPosition(dir.normalized*25f, hit.point, ForceMode.Impulse);
                }
            }
        }
    }

    void OnTriggerEnter (Collider c)
    {
        if(c.tag == "pelota")
        {
            is_triggered = true;
        }
    }

    void OnTriggerExit (Collider c)
    {
        is_triggered = false;
    }

}
