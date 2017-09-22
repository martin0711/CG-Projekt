using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireShield : MonoBehaviour {

    private PlayerHealth playerHealth;

	// Use this for initialization
	void Awake () {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
	}
	
    void OnEnable()
    {
        playerHealth.Shielded = true;
    }

    void OnDisable()
    {
        playerHealth.Shielded = false;
    }
}
