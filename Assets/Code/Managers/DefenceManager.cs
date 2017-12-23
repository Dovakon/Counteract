using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenceManager : MonoBehaviour {

    public AntiMisisle antiMisisle;
    public LayerMask layerMask;
    private bool targeting;

    void Start()
    {
        targeting = true;
        StartCoroutine(FindTargets());
    }


    IEnumerator FindTargets()
    {
        while(targeting)
        {
            RaycastHit2D closestTarget = Physics2D.BoxCast(transform.position, new Vector2(17, 1), 0, transform.up, 8, layerMask);
            if (closestTarget)
            {
                antiMisisle.AimTarget(closestTarget.transform.gameObject);
            }
            else
            {
                antiMisisle.AimTarget(null);
            }

            yield return new WaitForSeconds(.5f);

        }
        
    }
}
