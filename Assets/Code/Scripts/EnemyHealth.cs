using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour


{

    public int maxHealth = 5;
    public int currentHealth;

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth); 
        
    }

    // Update is called once per frame
    void Update()
    {
        //timeSinceHit += Time.deltaTime;
        //if (timeSinceHit >= 1f)
        //{
        //    TakeDamage(1);
        //    timeSinceHit = 0f;
        //}
           
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Debug.Log("Enemy died");
            EnemySpawner.onEnemyDestroy.Invoke();
            Destroy(gameObject);
            healthBar.SetHealth(currentHealth);
        }
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            TakeDamage(1);
            healthBar.SetHealth(currentHealth);
        }

    }
}
