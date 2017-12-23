using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMissile : Missile {

	

	protected override void Start ()
    {

        base.Start();
		
	}


    private void OnTriggerEnter2D(Collider2D col)
    {
        /// Pithanon tha diagrafei

        //if (col.gameObject.GetComponent<Bullet>())
        //{
        //    Health -= col.gameObject.GetComponent<Bullet>().Damage;
        //    col.gameObject.SetActive(false);

        //    if (Health <= 0)
        //    {
        //        //this.gameObject.SetActive(false);
        //    }
        //}
    }
}
