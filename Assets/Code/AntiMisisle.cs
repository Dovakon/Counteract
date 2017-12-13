using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiMisisle : MonoBehaviour {

    public bool canShoot;

    [Header("Gun Parameters")]
    public float rotatingSpeed;
    public float FireRate;
    

    public ObjectPooling Pool;
    public GameObject target;
    private Rigidbody2D rb;
    private float NextFire;

    void Awake()
    {
        
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    void Update()
    {

       
        //Follow Target 
        Vector2 point2Target = (Vector2)transform.position - (Vector2)target.transform.position;

        point2Target.Normalize();

        float value = Vector3.Cross(point2Target, transform.up).z;
        print(value);
        rb.angularVelocity = rotatingSpeed * value;
        
        if (rb.angularVelocity < 2f & rb.angularVelocity > -2f & canShoot & Time.time > NextFire)
        {
                NextFire = Time.time + FireRate;
                Shoot();
        }
            
    }

   public void Shoot()
    {
        
        GameObject projectile = Pool.GetPooledObject();
        projectile.SetActive(true);
        projectile.GetComponent<PlayerProjectile>().Launch(target);
    }
}
