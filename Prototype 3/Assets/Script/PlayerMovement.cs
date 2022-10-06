using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public Vector3 playerInput;
    public bool isIn;

    // Start is called before the first frame update
    void Start()
    {
        isIn = false; 
    }

    // Update is called once per frame
    void Update()
    {
        playerInput = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        transform.position = playerInput * speed * Time.deltaTime + transform.position;
        
    }
}
