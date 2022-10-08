using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class icon : MonoBehaviour
{
    private Vector3 startPos;
    public GameObject dottedLine;
    private void Start()
    {
        startPos = transform.position;
        dottedLine.SetActive(false);
    }

    public void MouseDrag()
    {
        transform.position = Input.mousePosition;
        dottedLine.SetActive(true);
    }

    public void EndDrag()
    {
        GameObject target = GameObject.Find("target");
        dottedLine.SetActive(false);
        float dist = Vector3.Distance(transform.position, target.transform.position);
        if (dist < 100)
        {
            transform.position = target.transform.position;
        }
        else
        {
            transform.position = startPos;
        }
    }

}
