using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float turnSpeed;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
            transform.Rotate(Vector3.forward, turnSpeed * Time.deltaTime * -1);
        }

    }
}
