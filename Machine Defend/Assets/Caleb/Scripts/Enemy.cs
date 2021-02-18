using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public Player player;

    // Start is called before the first frame update
    void Start()
    {
        health = 10;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * 0.05f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Finish")
        {
            player.health = player.health - 10;
        }
    }
}
