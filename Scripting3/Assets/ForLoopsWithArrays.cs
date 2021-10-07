using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoopsWithArrays : MonoBehaviour
{
    string[] localMonsters = { "Slimes", "Goblins", "Sprites", "Wolves", "Skeletons" };

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < localMonsters.Length; i++)
        {
            Debug.Log(localMonsters[i]);
        }        
    }
}
