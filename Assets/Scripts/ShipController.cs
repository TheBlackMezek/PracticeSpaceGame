using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{

    public Rigidbody playerRigidBody;
    public float speed = 50;
    Vector3 rotationUp = new Vector3(0, 50, 0);
    Vector3 rotationDown = new Vector3(0, -50, 0);
    Vector3 rollRight = new Vector3(-50, 0, 0);
    Vector3 rollLeft = new Vector3(50, 0, 0);
    Vector3 rudderRight = new Vector3(0, 0, 50);
    Vector3 rudderLeft = new Vector3(0, 0, -50);
    Vector3 forward = new Vector3(1, 0, 0);

    void Start()
    {
        
    }

    private Quaternion RotationDelta(Vector3 vector) {
        return Quaternion.Euler(vector * Time.deltaTime);
    }

    private void RotateRigidBody(Vector3 vector) {
        playerRigidBody.MoveRotation(playerRigidBody.rotation * RotationDelta(vector));
    }

    void FixedUpdate()
    {
        // float x = Input.GetAxis("Horizontal");
        // float z = Input.GetAxis("Vertical");
        // Vector3 move = transform.right * x + transform.forward * z;
        // player.Move(move * speed * Time.deltaTime);
        if(Input.GetKey("w")) {
            transform.Translate(forward * speed * Time.deltaTime);
        }
        if(Input.GetKey("s")) {
            transform.Translate(-forward * speed * Time.deltaTime);
        }
        if(Input.GetKey("d")) {
            RotateRigidBody(rudderRight);
        }
        if(Input.GetKey("a")) {
            RotateRigidBody(rudderLeft);
        }
        if(Input.GetKey("q")) {
            RotateRigidBody(rollLeft);
        }
        if(Input.GetKey("e")) {
            RotateRigidBody(rollRight);
        }
    }
}
