using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed;
    public float rotateSpeed;
    private Animator anim;
    private Rigidbody rb;
    public FixedJoystick joystick;
    bool isIntialize = false;
    
    public void Initilize()
    {
        rb=GetComponent<Rigidbody>();
        anim = GetComponentInChildren<Animator>();
        joystick = FindObjectOfType<FixedJoystick>();
        isIntialize = true;
    }
    void Update()
    {
        if (isIntialize)
        CharacterMove();
    }
    public void CharacterMove()
    {
        float moveZ = joystick.Vertical;
        float moveX = joystick.Horizontal;
        anim.SetFloat("speed", moveZ);
        Vector3 movement = new Vector3(moveX, 0, moveZ);
        Vector3 localMovement = transform.TransformDirection(movement);
        rb.AddForce(localMovement * speed);
        if (localMovement != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(localMovement, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotateSpeed * Time.deltaTime);
        }
    }
}
