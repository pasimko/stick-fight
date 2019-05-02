﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Parts of the prefab
    public Rigidbody2D head, body, leftLeg, rightLeg, leftArm, rightArm;
    public Transform rightToe, leftToe;

    // KeyCodes that when pressed will trigger this action
    public KeyCode right, left, jump, attack, block;

    public bool isGrounded = false;
    public bool isJumping = false;
    public LayerMask groundLayer; // The map - Layer for checking collisions with any of the map

    //Flip counting
    private float totalDegrees = 0;
    private Vector3 lastPoint;
    
    public bool hasGun = false;
    public gunScript currentGun;
    public Transform meleePrefab;

    //how many seconds we wait until raising the gun
    float standCount = 0.5f;
    //The rigidbody the gun is a child of
    public Rigidbody2D gunHand;

    void Start()
    {
        lastPoint = transform.TransformDirection(Vector3.right);
        lastPoint.y = 0;
        // Body can get stuck in itself without this
        Physics2D.IgnoreCollision(leftLeg.GetComponent<BoxCollider2D>(), leftArm.GetComponent<BoxCollider2D>());
        Physics2D.IgnoreCollision(head.GetComponent<BoxCollider2D>(), leftArm.GetComponent<BoxCollider2D>());
        Physics2D.IgnoreCollision(head.GetComponent<BoxCollider2D>(), rightArm.GetComponent<BoxCollider2D>());
        Physics2D.IgnoreCollision(rightLeg.GetComponent<BoxCollider2D>(), rightArm.GetComponent<BoxCollider2D>());
    }



    void Update()
    {
        isGrounded = (Physics2D.OverlapCircle(leftToe.position, 0.2f, groundLayer) || Physics2D.OverlapCircle(rightToe.position, 0.2f, groundLayer));
        standUp();
        HandleMovement();
        raiseArm();
        if (!isGrounded)
        {
            CountFlips();
            Debug.Log(numberFlips.ToString());
        }
        else
        {
            totalDegrees = 0;
        }     
    }

    void HandleMovement()
    {
        if (Input.GetKeyDown(jump) && isJumping == false)
        {
            head.AddForce(new Vector2(0, 2500));
            isJumping = true;
        }
        if (Input.GetKeyDown(left))
        {
            head.AddForce(new Vector2(-500, 0));
        }
        if (Input.GetKeyDown(right))
        {
            head.AddForce(new Vector2(500, 0));
        }
        if (Input.GetKeyDown(attack))
        {
            if (hasGun) {
                currentGun.fire();
            }
            else {
                Instantiate(meleePrefab);
            }
        }
    }

    public int numberFlips
    {
        get
        {
            return ((int)totalDegrees) / 360;
        }
    }

    void CountFlips()
    {
        Transform tempBody = body.GetComponent<Transform>();
        Vector3 facing = tempBody.TransformDirection(Vector3.right);
        facing.y = 0;

        float angle = Vector3.Angle(lastPoint, facing);
        if (Vector3.Cross(lastPoint, facing).y < 0)
            angle *= -1;

        totalDegrees += angle;
        lastPoint = facing;

    }
    void standUp()
    {
        if (isGrounded)
        {
            standCount -= Time.deltaTime;
            isJumping = false;
            head.AddForce(new Vector2(0, 90));
            rightLeg.AddForce(new Vector2(0, -40));
            leftLeg.AddForce(new Vector2(0, -40));
            body.AddTorque(-body.angularVelocity);
        }
        else {
            standCount = 0.5f;
        }
    }
    void raiseArm() 
    {
        if (isGrounded && hasGun && standCount <= 0) {
            float currentAngle = gunHand.transform.localEulerAngles.z;
            if (currentAngle < 120) {
                gunHand.AddTorque((90-currentAngle));
                gunHand.AddTorque(-gunHand.angularVelocity/10);
            }
        }
        else {

        }
    }
}