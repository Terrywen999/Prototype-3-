using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class icon : MonoBehaviour
{
    private Vector3 startPos;
    public GameObject dottedLine;
    public bool isDrag;
    public bool isIn;

    public UnityEvent screenShot;
    private void Start()
    {
        if(screenShot == null)
        {
            screenShot = new UnityEvent();
        }
        startPos = transform.position;
        dottedLine.SetActive(false);
    }

    public void MouseDrag()
    {
        transform.position = Input.mousePosition;
        dottedLine.SetActive(true);
        isDrag = true;
    }

    public void EndDrag()
    {
        //GameObject target = GameObject.Find("target");
        //dottedLine.SetActive(false);
        //float dist = Vector3.Distance(transform.position, target.transform.position);
        //if (dist < 100)
        //{
         //   transform.position = target.transform.position;
        //}
        //else
        //{
        //    transform.position = startPos;
        //}
        
        if(isIn == true)
        {
            screenShot.Invoke();
        }
        isDrag = false;
        transform.position = startPos;
        dottedLine.SetActive(false); 


    }



}
