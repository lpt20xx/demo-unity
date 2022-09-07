using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //khai bao thu vien UI

public class enemyHealth : MonoBehaviour
{
    public float maxHealth;
    float currentHealth;

    //Bien tao hieu ung khi enemy chet
    public GameObject enemyHealthEF;
    //Khai bao bien de tao thanh mau cho enemy
    public Slider enemyHealthSlider;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        enemyHealthSlider.maxValue = maxHealth;
        enemyHealthSlider.value = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addDamage(float damage){
        enemyHealthSlider.gameObject.SetActive(true);
        currentHealth -= damage;
        enemyHealthSlider.value = currentHealth;
        if(currentHealth <= 0) makeDead();
    }

    void makeDead(){
        Destroy(gameObject);
        Instantiate(enemyHealthEF, transform.position, transform.rotation);
    }
}
