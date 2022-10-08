using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class window : MonoBehaviour
{

    public GameObject player;
    Vector2 startPos;
    [SerializeField] private Transform correctTrans;
    [SerializeField] private bool isFinished;
    
    
    private void Start()
    {
        startPos = transform.position;
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
       

        if (!isFinished)
        {
            transform.position = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x,
                                             Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
        }
    }



    private void OnMouseUp()
    {
        if(Mathf.Abs(transform.position.x - correctTrans.position.x) <= 0.5f && 
                Mathf.Abs (transform.position.y - correctTrans.position.y) <= 0.5f)
        {
            transform.position = new Vector2(correctTrans.position.x, correctTrans.position.y);
            isFinished = true; 
        }
        else
        {
            transform.position = new Vector2(startPos.x, startPos.y);
            
        }
    }


    private void OnMouseEnter()
    {
        if(isFinished == false)
        {
        transform.localScale += Vector3.one * 2.5f;
        }
       
    }
    private void OnMouseExit()
    {
        if (isFinished == false)
        { 
            transform.localScale -= Vector3.one * 2.5f;
        }
    }




}
