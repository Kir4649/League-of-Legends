using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float speed = 6f;

    Rigidbody rb;
    Camera viewCamera;
    Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        viewCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = viewCamera.ScreenToWorldPoint(
            new Vector3(Input.mousePosition.x, Input.mousePosition.y, viewCamera.transform.position.y)
            );
        transform.LookAt(mousePos + Vector3.up * transform.position.y);
        velocity = new Vector3(
            Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized * speed;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + velocity * Time.deltaTime);
    }
}
