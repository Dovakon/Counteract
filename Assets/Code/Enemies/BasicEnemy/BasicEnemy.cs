using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : Enemy {

    public GameObject Missile1;
    public GameObject Missile2;

    
	void Update ()
    {
        if (Input.GetMouseButton(0))
        {
            Fire();
            Debug.Log("Fired");
        }

    }



    public void Fire()
    {
        
        int X = Random.Range(-8, 9);
        Vector2 destination = new Vector2(X, -4);
        
        
        Missile1.transform.position = new Vector2(transform.position.x - .3f, transform.position.y);
        Missile1.transform.localEulerAngles = new Vector3(0, 0, 70);
        Missile1.SetActive(true);
        Missile1.GetComponent<EnemyMissile>().StartMoving(destination);



        //GameObject RightRocket = MissilePool.GetPooledObject();
        //RightRocket.transform.position = new Vector2(transform.position.x + .3f, transform.position.y);
        //RightRocket.transform.localEulerAngles = new Vector3(0, 0, -70);
        //RightRocket.SetActive(true);


    }

}
