using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoops : MonoBehaviour
{
    int damage = 0;
    int enemies = 0;




    // Start is called before the first frame update
    void Start()
    {
         while (damage < 12)
        {
            Debug.Log("Slime is hurt!");
            damage++;
        }

        do
        {
            Debug.Log("Enemy has spawned!");
            enemies++;
        }
        while (enemies < 3);
    }
}
