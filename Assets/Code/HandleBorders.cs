﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleBorders : MonoBehaviour {


    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<Projectile>().DestroyProjectile();
    }
}
