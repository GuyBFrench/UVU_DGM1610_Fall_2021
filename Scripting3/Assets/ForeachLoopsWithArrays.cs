using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachLoopsWithArrays : MonoBehaviour
{

    string[] adventurerRanks = { "F", "E", "D", "C", "B", "A", "S", "SS", "SSS", "R" };

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("The possible ranks for adventurers include ");
        foreach (string i in adventurerRanks)
        {
            Debug.Log(i);
        }
    }
}
