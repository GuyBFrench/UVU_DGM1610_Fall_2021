using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AxisExample : MonoBehaviour
{
    public float range;
    public Text textOutput;

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float xpos = h * range;

        transform.position = new Vector3(xpos, 2f, 0);
        textOutput.text = "Value Returned: " + h.ToString("F2");
    }
}
