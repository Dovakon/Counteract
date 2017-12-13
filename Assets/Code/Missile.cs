using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour {

    public int Health;
    public int Damage;
    public int Speed;
    public int rotatingSpeed;

    private Vector2 Destination;

    private Rigidbody2D rb;
    private bool canMove;

    protected virtual void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
    }
	
	
	void Update () {

        if (canMove)
        {
            Vector2 point2Target = (Vector2)transform.position - Destination;

            point2Target.Normalize();

            float value = Vector3.Cross(point2Target, transform.up).z;

            rb.angularVelocity = rotatingSpeed * value;

            rb.velocity = transform.up * Speed;
        }
    }


    public void StartMoving(Vector2 dest)
    {
        Destination = dest;
        canMove = true;
    }
}
