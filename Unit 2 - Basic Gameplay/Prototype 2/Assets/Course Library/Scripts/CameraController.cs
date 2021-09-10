using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 positionFirst = new Vector3(0, 3, 1f);
    private Vector3 positionThird = new Vector3(0, 17.5f, -10);
    private Vector3 rotateFirst = new Vector3(10, 0, 0);
    private Vector3 rotateThird = new Vector3(45, 0, 0);
    private Vector3 rotateLeft = new Vector3(10, 20, 0);
    private Vector3 rotateRight = new Vector3(10, -20, 0);

    private int pov = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {

        if (Input.GetKeyDown(KeyCode.P))
        {
            if (pov == 0)
            {
                pov++;
                transform.eulerAngles = rotateFirst;
                GetComponent<Camera>().fieldOfView = 100;
            } else
            {
                pov--;
                transform.position = positionThird;
                transform.eulerAngles = rotateThird;
                GetComponent<Camera>().fieldOfView = 47;
            }
        }

        if (pov == 1)
        {
            transform.position = player.transform.position + positionFirst;

            if (Input.GetKeyDown(KeyCode.E))
            {
                transform.eulerAngles = rotateLeft;
            } else if (Input.GetKeyDown(KeyCode.Q))
            {
                transform.eulerAngles = rotateRight;
            }
        } else
        {
            if (player.transform.position.x > -4.5f && player.transform.position.x < 4.5f) 
            {
                transform.position = player.transform.position + positionThird;
            }
        }

    }
}
