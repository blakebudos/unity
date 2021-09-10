using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 20.0f;
    public float turnSpeed;
    public float jumpStrength = 10;

    public float horizontalInput;
    public float forwardInput;
    public float jumpInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        jumpInput = Input.GetAxis("Jump");

        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.right, turnSpeed * horizontalInput * Time.deltaTime);
        transform.Translate(Vector3.up * Time.deltaTime * jumpStrength * jumpInput);
    }
}
