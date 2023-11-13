using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batFollow : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    private Transform player;
    public float lineOfSite;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;    
    }

    void Update()
    {
        float distanceFromPlayer = Vector2.Distance(player.position, transform.position);
        if(distanceFromPlayer <  lineOfSite)
        transform.position = Vector2.MoveTowards(this.transform.position,player.position,speed*Time.deltaTime);

    }

    public void OnHit(int damage, Vector2 knockback)
    {
        rb.velocity = new Vector2(knockback.x, rb.velocity.y + knockback.y);
    }
    
    //code bellow is a visual to see the range in game
    
    /*
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, lineOfSite);
    }
    */
}
