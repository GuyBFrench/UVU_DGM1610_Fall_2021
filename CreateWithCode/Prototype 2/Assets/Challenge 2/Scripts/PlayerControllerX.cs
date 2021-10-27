using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float dogMaxFrequency = 2.0f;
    private float dogTimer = 0.0f;
    // Update is called once per frame
    void Update()
    {
        dogTimer += Time.deltaTime;

        // On spacebar press, send dog if enough time has passed
        if (Input.GetKeyDown(KeyCode.Space) && dogTimer > dogMaxFrequency)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            dogTimer = 0;
        }
    }
}
