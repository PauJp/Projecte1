using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootControl : MonoBehaviour {

    public float shootSpeedH;
    public float shootSpeedL;
    public float shootAngle;
    public float shootTorqueAngle;
    public GameObject Iguana;

    private SpriteRenderer spriteRenderer;

    Rigidbody2D shootRB;

    // Use this for initialization
    void Start()
    {
        shootRB = GetComponent<Rigidbody2D>();
        shootRB.AddForce(new Vector2(Random.Range(-shootAngle, shootAngle), Random.Range(shootSpeedL, shootSpeedH)), ForceMode2D.Impulse);
        shootRB.AddTorque(Random.Range(-shootTorqueAngle, shootTorqueAngle));
    }

	
	// Update is called once per frame
	void Update () {
		
	}
}
