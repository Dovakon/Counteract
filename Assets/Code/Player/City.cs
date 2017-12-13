using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class City : MonoBehaviour {


    public int Health;

    public Text healthText; 
	
	void Start ()
    {
        healthText.text = Health.ToString();
		
	}


    private void OnTriggerEnter2D(Collider2D col)
    {
        Health -= col.GetComponent<Missile>().Damage;

        col.gameObject.SetActive(false);
        healthText.text = Health.ToString();
    }


}
