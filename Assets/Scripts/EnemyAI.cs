using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyAI : MonoBehaviour {

    public bool touched;

    public Transform player;
    public GameObject enemy;
    public float smoothTime = 20.0f;

    //Vector3 used to store the velocity of the enemy
    private Vector3 smoothVelocity = Vector3.zero;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (touched) {
            if (transform.position.x - player.position.x < 0) {
                smoothVelocity = new Vector3(3, 0, 0);
            }
            if (transform.position.x - player.position.x > 0)
            {
                smoothVelocity = new Vector3(-3, 0, 0);
            }
            transform.position = Vector3.SmoothDamp(transform.position, player.position, ref smoothVelocity, smoothTime);
            
        }
	}

    void OnTriggerEnter2D(Collider2D col) {
        if (col.tag == "Player") {
            touched = true;
        }
    }


    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            touched = false;
        }
    }
    }
