using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batFollow : MonoBehaviour
{
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
    
    //code bellow is a visual to see the range in game
    
    /*
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, lineOfSite);
    }
    */
}
