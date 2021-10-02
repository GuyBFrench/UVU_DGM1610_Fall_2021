using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    int myAge = 25;
    string myName = ("Guy French");
    string myHometown = ("Justin, Texas");
    double moneyPaid = 22.50;

    void Start()
    {
         Debug.Log("Hello, my name is " + myName + " I am " + myAge + " years old," + " my hometown is " + myHometown + ".");
         Debug.Log("For some reason yesterday I spent " + moneyPaid + " on one meal..." + "it was pretty good though.");
    }
       

}
