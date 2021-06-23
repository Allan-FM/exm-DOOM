using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerMove : MonoBehaviour
{
    private float yaw = 0.0f;
    private float pitch = 0.0f;

    public float spd = 0.007f;

    private float speedH = 2.0f;
    private float speedV = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.position += (transform.forward * spd);
        }

        if (Input.GetKey("s"))
        {
            transform.position += (transform.forward * -spd);
        }

        if (Input.GetKey("d"))
        {
            float dir = transform.eulerAngles.y - 90.0f;
            Vector3 spdTemp = new Vector3(Mathf.Sin(dir * Mathf.Deg2Rad), 0, Mathf.Cos(dir * Mathf.Deg2Rad));
            transform.position = transform.position + (spdTemp * -spd);
        }
        if (Input.GetKey("a"))
        {
            float dir = transform.eulerAngles.y + 90.0f;
            Vector3 spdTemp = new Vector3(Mathf.Sin(dir * Mathf.Deg2Rad), 0, Mathf.Cos(dir * Mathf.Deg2Rad));
            transform.position = transform.position + (spdTemp * -spd);
        }

        /*
        if (Input.GetKey (KeyCode.LeftArrow))
        {
            transform.Rotate(0,-2f,0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 2f, 0);

        }
        */

        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");
        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }
}
