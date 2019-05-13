using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golpe : MonoBehaviour
{
    private Vector3 dir;
    private bool is_triggered =false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector2 norm = Input.mousePosition.normalized;
            dir = new Vector3(norm.x, norm.y, 1);
            is_triggered = true;
        }
        else
        {
            is_triggered = false;
        }
    }

    void OnTriggerEnter(Collider c)
    {
        if (is_triggered)
        {
            
        }
    }
}
