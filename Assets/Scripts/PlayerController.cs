using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    public float speed = 5f;
    private float rightLeftBound = 4.13f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -rightLeftBound)
        {
            transform.position = new Vector3(-rightLeftBound, transform.position.y, transform.position.z);
        }
        if(transform.position.x > rightLeftBound)
        {
            transform.position = new Vector3(rightLeftBound, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }
}
