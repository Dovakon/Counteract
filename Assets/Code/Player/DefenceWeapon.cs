using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// To Foward se UP
/// </summary>
public class DefenceWeapon : MonoBehaviour {

    [Header("Gun Parameters")]
    public int rotatingSpeed;
    public float FireRate;
    public int ProjectileSpeed;
    public ObjectPooling Pool;
    

    public bool canShoot;
    private float NextFire;
    private Rigidbody2D rb;
    private GameObject target;

    public float lerpTime;
    private float currentLerpTime;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start ()
    {
        
        //canShoot = true;

      
    }
	
	void Update ()
    {
       
        //Follow Target 
        if (target)
        {

            Vector2 point2Target = (Vector2)target.transform.position - (Vector2)transform.position;


            float angle = Mathf.Atan2(point2Target.x, point2Target.y) * Mathf.Rad2Deg;
            Quaternion rot = Quaternion.AngleAxis(angle, -Vector3.forward);

            transform.rotation = Quaternion.Lerp(transform.rotation, rot, rotatingSpeed * Time.deltaTime);
            


            point2Target.Normalize();
            float aim = Vector3.Dot(point2Target, transform.up);
            Debug.Log(aim);


            if (aim > .995f)
            {
                
                if (canShoot & Time.time > NextFire)
                { 
                    NextFire = Time.time + FireRate;
                    Shoot(target);


                }
            }

            
        }
        

    }

    public void AimTarget(GameObject trg)
    {
        target = trg;

        //canShoot = target ? true : false;
        
    }
    protected virtual void Shoot(GameObject target)
    {
        
        //GameObject projectile = Pool.GetPooledObject();
        //projectile.transform.position = new Vector2(this.transform.position.x, this.transform.position.y);
        //projectile.SetActive(true);
        //Rigidbody2D projectileRB = projectile.GetComponent<Rigidbody2D>();

        ////projectileRB.rotation = transform.eulerAngles.z;

        //projectileRB.velocity = transform.up * ProjectileSpeed;
    }
}
