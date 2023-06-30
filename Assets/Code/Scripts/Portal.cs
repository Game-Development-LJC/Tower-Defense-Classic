using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
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
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            TakeDamage();
            Destroy(other.gameObject);
        }
    }

    void TakeDamage()
    {
        currentHealth--;
        healthBar.SetHealth(currentHealth);

        /*if(currentHealth == 0)
        {
            die;
        }*/
    }
}
