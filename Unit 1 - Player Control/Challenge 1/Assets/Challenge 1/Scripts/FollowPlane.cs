using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlane : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(0, 5, -10);
    public float turnSpeed;
    public float fire1Input;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        fire1Input = Input.GetAxis("Fire1");

        transform.Rotate(Vector3.up, turnSpeed * fire1Input * Time.deltaTime);
        transform.position = plane.transform.position + offset;
    }
}
