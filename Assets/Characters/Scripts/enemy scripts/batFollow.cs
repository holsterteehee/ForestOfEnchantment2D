using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batFollow : MonoBehaviour
{
    public float speed;
    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;    
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(this.transform.position,player.position,speed*Time.deltaTime);
    }
}
