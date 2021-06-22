using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    float _velocidadeFrente;
    float _velocidadeTras;
    float _velocidadeGirar;

    float _velocidade;
    float _girar;


    private float yaw = 0.0f;
    private float pitch = 0.0f;

    private float speedH = 2.0f;
    private float speedV = 2.0f;
    void Start()
    {

        _velocidade = 20.0F;
        _girar = 60.0F;
        _velocidadeFrente = 10;
        _velocidadeTras = 5;
        _velocidadeGirar = 60;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.Translate(0, 0, (_velocidadeFrente * Time.deltaTime));
        }

        if (Input.GetKey("s"))
        {
            transform.Translate(0, 0, (-_velocidadeTras * Time.deltaTime));
        }

        if (Input.GetKey("a"))
        {
            transform.Rotate(0, (-_velocidadeGirar * Time.deltaTime), 0);
        }

        if (Input.GetKey("d"))
        {
            transform.Rotate(0, (_velocidadeGirar * Time.deltaTime), 0);
        }
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");
        transform.eulerAngles = new Vector3(pitch,yaw,0.0f);
    }
}
