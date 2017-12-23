using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiMisisle : DefenceWeapon {


    protected override void Shoot(GameObject target)
    {
        target.GetComponent<Projectile>().DestroyProjectile();
    }


}
