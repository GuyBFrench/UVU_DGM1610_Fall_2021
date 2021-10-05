using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour
{
    int rank = 3;

    // Start is called before the first frame update
    void Start()
    {
        switch (rank)
        {
            case 1:
                Debug.Log("We have a slime hunting quest available for you.");
                break;
            case 2:
                Debug.Log("We have a small goblin outbreak you my be able to help with.");
                break;
            case 3:
                Debug.Log("There is a bandit duo causing trouble with a nearby village, you may be able to assist with that problem.");
                break;
            case 4:
                Debug.Log("There is a group effort being put together to deal with a cave troll, are you interested?");
                break;
            default:
                Debug.Log("We have no quests available to someone of your rank currently.");
                break;
        }
    }

}
