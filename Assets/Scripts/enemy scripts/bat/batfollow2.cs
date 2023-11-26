using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batfollow : MonoBehaviour
{
    public int damage = 10;
    public int health = 50;
    public float speed = 5f;
    public float lineOfSite;
    public Transform player;
    public float attackRange = 1.5f;

    void Update()
    {
        if (player != null)
        {
            // Move towards the player
             float distanceFromPlayer = Vector2.Distance(player.position, transform.position);
            if(distanceFromPlayer <  lineOfSite)
                transform.position = Vector2.MoveTowards(this.transform.position,player.position,speed*Time.deltaTime);

            // Check if the player is within attack range
            if (Vector2.Distance(transform.position, player.position) < attackRange)
            {
                // Attack the player
                AttackPlayer();
            }
        }
    }

    void AttackPlayer()
    {
        // Get the Damageable component from the player
        Damageable playerDamageable = player.GetComponent<Damageable>();

        // Check if the player has a Damageable component
        if (playerDamageable != null)
        {
            // Inflict damage to the player
            playerDamageable.Hit(damage, Vector2.zero);

            // Take damage from the player
            //TakeDamage(playerDamageable.GetDamage());
        }
    }

    public void TakeDamage(int damageAmount)
    {
        // Reduce health when the enemy takes damage
        health -= damageAmount;

        // Check if the enemy's health is zero or below
        if (health <= 0)
        {
            // Destroy the enemy or add your own logic for handling enemy death
            Destroy(gameObject);
        }

        
        

    }

    private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(transform.position, lineOfSite);
        }
}
