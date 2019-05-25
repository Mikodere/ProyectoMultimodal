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
    void onTriggerEnter(Collider other)
    {
        count++;
        countText.text = count.ToString()
    }
    void SetCountText()
    {
        if (countText.text != null)
        {
            countText.text = "Count: " + count.ToString();
        }
        if (count >= 12)
        {
            winText.text = "You Win!";
        }
    }
}
