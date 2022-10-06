using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{

    public Rigidbody2D rig;

    public GameObject player;

    private void Awake()
    {
        rig = gameObject.GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            Debug.Log("HIT");
            if (player.GetComponent<PlayerMovement>().isIn == false)
            {
                Destroy(player);
            }
            
        }
    }

}
