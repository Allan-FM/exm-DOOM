using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public float speed;

    Rigidbody rb;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    public float moveCamera;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 Position = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        rb.velocity = Position * speed;

        yaw += moveCamera * Input.GetAxis("Mouse X");
        pitch -= moveCamera * Input.GetAxis("Mouse Y");
        transform.eulerAngles = new Vector3(pitch,yaw,0.0f);
    }
}
