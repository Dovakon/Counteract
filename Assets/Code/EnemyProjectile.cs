using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour {

    public int Speed;
    bool canMove = false;
    private Vector2 startPos;

	void Start () {

        startPos = transform.position;
        Execute();
	}
	
	
	void Update () {
		
        if(canMove)
        {
            transform.Translate(Vector3.down * Speed * Time.deltaTime);
        }

	}


    public void Execute()
    {
        int randomPos = Random.Range(-8, 9);
        transform.position = new Vector2(randomPos, transform.position.y);
        canMove = true;
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        canMove = false;
        transform.position = startPos;
    }

}
