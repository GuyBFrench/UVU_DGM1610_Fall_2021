using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Rigidbody bulletPrefab;
    public Transform firePosition;
    public float bulltSpeed;

    private Inventory inventory;

    void Awake()
    {
        inventory = GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();   
    }

    void Shoot()
    {
        if(Input.GetButtonDown("Fire1") && inventory.myStuff.bullets > 0)
        {
            Rigidbody bulletInstance = Instantiate(bulletPrefab, firePosition.position,
                firePosition.rotation) as Rigidbody;
            bulletInstance.AddForce(firePosition.forward * bulltSpeed);
            inventory.myStuff.bullets--;
        }
    }
}
