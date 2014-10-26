using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour
{
    public float timeBetweenAttacks = 0.5f;
    public int attackDamage = 10;


    Animator anim;
    GameObject player;
    PlayerHealth playerHealth;
    EnemyHealth enemyHealth;

	// True whenever player is close enough for the enemy to attack
    bool playerInRange;

	// Used to keep everything in sync
    float timer;


    void Awake ()
    {
		// Find and store locally so the call does not have to be done on each update
        player = GameObject.FindGameObjectWithTag ("Player");

		// Pull PlayerHealth script off player and store it locally
		// Now can call getDamage
        playerHealth = player.GetComponent <PlayerHealth> ();

        enemyHealth = GetComponent<EnemyHealth>();
        
		// Reference to animator component
		anim = GetComponent <Animator> ();
    }

	// Triggers are not used for in-scene effects
	// Triggers are used for detecting collisions behind the scenes
	// The following two triggers determine is the player and enemy are close enough to attack each other

	// Called whenever anything goes into a trigger
	// Other is whatever collided with this collider
    void OnTriggerEnter (Collider other)
    {
		// Ensure the player is what was run into
        if(other.gameObject == player)
        {
			// If so, the player is in range
            playerInRange = true;
        }
    }

	// Something was in the trigger, but now it has gone away
    void OnTriggerExit (Collider other)
    {
		// Is what has left the trigger the player?
        if(other.gameObject == player)
        {
			// If so, the player is no longer in range
            playerInRange = false;
        }
    }


    void Update ()
    {
		// Accumullate time on each update
        timer += Time.deltaTime;

		// If it has been long enough between attacks and the player is close enough, attack them
        if(timer >= timeBetweenAttacks && playerInRange && enemyHealth.currentHealth > 0)
        {
            Attack ();
        }

		// If the player died, animate the character to stop moving
        if(playerHealth.currentHealth <= 0)
        {
            anim.SetTrigger ("PlayerDead");
        }
    }


    void Attack ()
    {
		// Reset timer between attacks
        timer = 0f;

		// If player has health, take away
        if(playerHealth.currentHealth > 0)
        {
            playerHealth.TakeDamage (attackDamage);
        }
    }
}
