using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    private float yaw = 0.0f;
    private float pith = 0.0f;

    private float spd = 0.02f;

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
        if(Input.GetKey("w"))
        {
            transform.position += (transform.forward * spd);
        }
        else if(Input.GetKey("s"))
        {
            transform.position -= (transform.forward * spd);
        }

        if(Input.GetKey("d"))
        {
            float dir = transform.eulerAngles.y - 90.0f;
            Vector3 spdTemp = new Vector3(Mathf.Sign(dir * Mathf.Deg2Rad),0,Mathf.Cos(dir * Mathf.Deg2Rad));
            transform.position = transform.position + (spdTemp * -spd);
        }
        else if(Input.GetKey("a"))
        {
            float dir = transform.eulerAngles.y + 90.0f;
            Vector3 spdTemp = new Vector3(Mathf.Sign(dir * Mathf.Deg2Rad), 0, Mathf.Cos(dir * Mathf.Deg2Rad));
            transform.position = transform.position + (spdTemp * -spd);
        }

        yaw += speedH * Input.GetAxis("Mouse X");
        pith += speedV * Input.GetAxis("Mouse Y");
        transform.eulerAngles = new Vector3(pith,yaw, 0.0f);

    }
}
