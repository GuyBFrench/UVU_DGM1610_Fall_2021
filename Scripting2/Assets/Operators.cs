using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operators : MonoBehaviour
{
    int w = 16;
    int x = 22;
    int y = 3;
    int z = 91;
    double a = 16.50;
    double b = 23.75;
    




    // Start is called before the first frame update
    void Start()
    {
        z &= 9;
        w += 18;
        a -= 13.50;
        b %= 3.19;
        x /= 2;
        y ^= 7; 
    }

}
