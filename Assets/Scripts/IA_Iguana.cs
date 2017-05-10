using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using Pathfinding;


public class IA_Iguana : FisiquesGameObject
{
    public float maxSpeed = 7;

    public GameObject Projectile;
    public float ShootTime;
    public Transform shootFrom;
    public int chanceShoot;
    public float TDestroy;
    public GameObject ColliderRang;

    private SpriteRenderer spriteRenderer;
    private Animator animator;

    public Transform bulletPrefab;

    float nextShootT;

    // Use this for initialization
    void Awake()
    {
        Physics2D.IgnoreCollision(Projectile.GetComponent<Collider2D>(), GetComponent<Collider2D>());

        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();

        Transform bullet = Instantiate(bulletPrefab) as Transform;
        Physics2D.IgnoreCollision(bullet.GetComponent<Collider2D>(), GetComponent<Collider2D>());

        nextShootT = 0f;
    }

    protected override void ComputeVelocity()
    {
        Vector2 move = Vector2.zero;

        bool flipSprite = (spriteRenderer.flipX ? (move.x > 0.01f) : (move.x < 0.01f)); //Girar Sprite
        if (flipSprite)
        {
            spriteRenderer.flipX = !spriteRenderer.flipX;
        }
        //Animacions
        animator.SetBool("grounded", grounded);
        animator.SetFloat("velocityX", Mathf.Abs(velocitat.x) / maxSpeed);
        targetVelocity = move * maxSpeed;

    }
}