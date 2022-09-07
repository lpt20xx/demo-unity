using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public float maxHealth;
    float currentHealth;

    public GameObject bloodEffect;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addDamage(float damage){
        if (damage <=0)
            return;
        currentHealth -= damage;

        if(currentHealth <= 0)
            makeDead();
    }

    void makeDead(){
        Instantiate(bloodEffect, transform.position, transform.rotation);
        Destroy (gameObject);
    }
}
