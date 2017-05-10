using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iguana_Range : MonoBehaviour
{

    public Transform Iguana;

    private Collider2D colliderRB;


    public GameObject Projectile;
    public float ShootTime;
    public Transform shootFrom;
    public int chanceShoot;
    public float TDestroy;
    public GameObject ColliderRang;

    public GameObject iguana;

    private SpriteRenderer spriteRenderer;
    private Animator animator;

    public Transform bulletPrefab;

    float nextShootT;

    bool shoot;

    // Use this for initialization
    void Start()
    {
        colliderRB = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        colliderRB.transform.position = Iguana.position;

    }
    private void OnTriggerStay2D(Collider2D collision)   // Trigger Shoot
    {
        if (collision.tag == "Player" && nextShootT < Time.time)
        {
            nextShootT = Time.time * nextShootT;
            if (Random.Range(0, 10) >= chanceShoot)
            {
                var clonedProj = Instantiate(Projectile, shootFrom.position, Quaternion.identity);
                Destroy(clonedProj, TDestroy);
                Physics2D.IgnoreCollision(clonedProj.GetComponent<Collider2D>(), iguana.GetComponent<Collider2D>());

            }
        }
    }
}
