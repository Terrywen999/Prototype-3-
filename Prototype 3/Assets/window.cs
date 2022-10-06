using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class window : MonoBehaviour
{

    public GameObject player;
    
    
    
    private void Start()
    {
        
    }

    private void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Debug.Log("HIT");
            collision.gameObject.GetComponent<PlayerMovement>().isIn = true;



        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player") 
        { 
            Debug.Log("EXIT");

            collision.gameObject.GetComponent<PlayerMovement>().isIn = false;
        }
    }

    private void OnMouseDrag()
    {
        transform.position = GetMousePos();
    }

    Vector3 GetMousePos()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        mousePos.z = 0;

        return mousePos;
    }
   

}
