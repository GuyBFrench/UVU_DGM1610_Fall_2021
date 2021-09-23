using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AxisRawExample : MonoBehaviour
{
    public float range;
    public Text textOutput;


    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float xPos = h * range;

        transform.position = new Vector3(xPos, 2f, 0);
        textOutput.text = "Value Returned: " + h.ToString("F2");
    }
}
