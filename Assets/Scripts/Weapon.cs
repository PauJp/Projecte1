/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public float fireRate = 0;
    public float damage = 10;
    public LayerMask notToHit;

    float TimeToFire = 0;
    Transform firePoint;

	// Use this for initialization
	void Awake ()
    {
        firePoint = transform.FindChild("FirePoint");
        if (firePoint == null) // No troba Fire Point
        {
            Debug.LogError("No firepoint? WHAT?!");
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (fireRate == 0)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Shoot();
            }
            else
            {
                if (Input.GetButton("Fire1") && Time.time > TimeToFire)
                {
                    TimeToFire = Time.time + 1 / fireRate;
                    Shoot();
                }

        }

	}
}*/
