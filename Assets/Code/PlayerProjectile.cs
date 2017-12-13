using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour {

    [Header("Projectile Parameters")]
    public int Speed;
    public int rotatingSpeed;

    private Rigidbody2D rb;
    private GameObject target;
    public bool canMove;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        if (canMove)
        {
            //Follow Target 
            Vector2 point2Target = (Vector2)transform.position - (Vector2)target.transform.position;

            point2Target.Normalize();

            float value = Vector3.Cross(point2Target, transform.up).z;

            rb.angularVelocity = rotatingSpeed * value;

            rb.velocity = transform.up * Speed;
        }
    }
    

    public void Launch(GameObject enemyTarget)
    {
        canMove = true;
        target = enemyTarget;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.SetActive(false);
    }
}
