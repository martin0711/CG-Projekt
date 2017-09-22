using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    public float health = 100f;

    private bool isShielded;

    private Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }
    public bool Shielded
    {
        get { return isShielded; }
        set { isShielded = value; }
    }


	
	public void TakeDamage(float amount)
    {
        if (!isShielded)
        {
            health -= amount;

            print(health);

            if(health <= 0f)
            {  
                anim.SetBool("Death",true);
                 
                if(!anim.IsInTransition(0) && anim.GetCurrentAnimatorStateInfo(0).IsName("Death")
                    && anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 0.95)
                {
                    // Before call Destroy() function have to change all 
                   // Classes ,which contains Player as properties
                   // Destroy(gameObject, 2f);
                }
            }
        }
    }




}
