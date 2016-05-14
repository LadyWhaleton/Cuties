﻿using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour
{

    private float speed = 2.0f;
    private float zoomSpeed = 2.0f;

    public float minX = -360.0f;
    public float maxX = 360.0f;

    public float minY = -45.0f;
    public float maxY = 45.0f;

    public float sensX = 100.0f;
    public float sensY = 100.0f;

    float rotationY = 0.0f;
    float rotationX = 0.0f;

    void Update()
    {

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        transform.Translate(0, scroll * zoomSpeed, scroll * zoomSpeed, Space.World);

        if (Input.GetKey("d"))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey("w"))
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            transform.position += Vector3.back * speed * Time.deltaTime;
        }

        if (Input.GetMouseButton(0))
        {
            rotationX += Input.GetAxis("Mouse X") * sensX * Time.deltaTime;
            rotationY += Input.GetAxis("Mouse Y") * sensY * Time.deltaTime;
            rotationY = Mathf.Clamp(rotationY, minY, maxY);
            transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
        }
    }
}
