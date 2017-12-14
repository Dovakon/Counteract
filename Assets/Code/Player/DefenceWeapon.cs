using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenceWeapon : MonoBehaviour {

    [Header("Gun Parameters")]
    public float rotatingSpeed;
    public float FireRate;


    private Rigidbody2D rb;

    
    public bool canShoot;
    private float NextFire;

    public LayerMask layerMask;
    void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
        
        
	}
	
	void Update ()
    {
        if (Input.GetMouseButton(0))
        {
           FindTarget();
            Debug.Log("Fired");
        }

        ////Follow Target 
        //Vector2 point2Target = (Vector2)transform.position - (Vector2)target.transform.position;

        //point2Target.Normalize();

        //float value = Vector3.Cross(point2Target, transform.up).z;
        //print(value);
        //rb.angularVelocity = rotatingSpeed * value;

        //if (rb.angularVelocity < 2f & rb.angularVelocity > -2f & canShoot & Time.time > NextFire)
        //{
        //    NextFire = Time.time + FireRate;
        //    Shoot();
        //}


    }

    void FindTarget()
    {

       
        // Collider[] targetsInAttackRadius = Physics2D.OverlapBox(transform.position, new Vector2(17, 17));
        RaycastHit2D target = Physics2D.BoxCast(transform.position, new Vector2(30,1), 0, transform.up, 4, layerMask);

        Debug.Log(target.collider);
        
        
        //float closest_dst = attackRadius;
        //GameObject closest_go = null;
        //int count_ia = 0;
        //for (int i = 0; i < targetsInAttackRadius.Length; i++)
        //{
        //    GameObject target = targetsInAttackRadius[i].gameObject;
        //    if (target.tag != "Enemy") continue;
        //    Transform t_target = target.transform;
        //    Vector3 dirToTarget = (t_target.position - transform.position).normalized;
        //    if (Vector3.Angle(transform.forward, dirToTarget) < attackAngle / 2)
        //    {
        //        float dstToTarget = Vector3.Distance(transform.position, t_target.position);
        //        if (!Physics.Raycast(transform.position, dirToTarget, dstToTarget, obstacleMask))
        //        {
        //            count_ia++;
        //            visibleTargets.Add(t_target);
        //            if (dstToTarget < closest_dst)
        //            {
        //                doAttackAngle = dirToTarget;
        //                closest_dst = dstToTarget;
        //                closest_go = target;
        //            }
        //        }
        //    }
        //}
    }
    void Shoot()
    {

    }
}
