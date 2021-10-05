using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Conditionals : MonoBehaviour
{
    int z = 29;
    int i = 16;

    void Start()
    {
        if (z > i)
        {
            Debug.Log("You have bested me this time!");
        }
        else if (z < i)
        {
            Debug.Log("I have prevailed again!");
        }
        else
        {
            Debug.Log("Tis a draw!");
        }
    
    }

}
