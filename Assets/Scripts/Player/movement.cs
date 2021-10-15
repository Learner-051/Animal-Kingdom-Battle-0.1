using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    //public float speed;
    // public float rotateSpeed;
    private Animator anim;
    private Rigidbody rb;
    public FixedJoystick joystick;
    bool isIntialize = false;
    public static bool stop;
    [SerializeField] private float moveSpeed = 1f;
    [SerializeField] private float rotateSpeed = 10f;

    public void Initilize()
    {
        rb = GetComponent<Rigidbody>();
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

        /*float moveZ = joystick.Vertical;
        float moveX = joystick.Horizontal;
        anim.SetFloat("speed", moveZ);
        Vector3 movement = new Vector3(moveX, 0, moveZ);
        Vector3 localMovement = transform.TransformDirection(movement);
        rb.AddForce(localMovement * speed);
        if (localMovement != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(localMovement, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotateSpeed * Time.deltaTime);
        }*/



        rb.velocity = transform.TransformDirection(new Vector3(joystick.Horizontal * moveSpeed, rb.velocity.y, joystick.Vertical * moveSpeed));


        if (joystick.Horizontal >= 0.1f || joystick.Horizontal <= -0.1f)
        {
            //Debug.Log("joystick.Horizontal" + joystick.Horizontal);

            transform.Rotate(new Vector3(0, joystick.Horizontal * rotateSpeed, 0));
        }

        //var direction = new Vector3(joystick.Horizontal, 0f, joystick.Vertical);
        //Vector3 localDirection = transform.TransformDirection(direction);
        //transform.Translate(direction * moveSpeed * Time.deltaTime , Space.World);

        if (joystick.Horizontal != 0f || joystick.Vertical != 0f)
        {
            anim.SetBool("Walk", true);
            stop = false;
            rb.isKinematic = false;
            //transform.rotation = Quaternion.LookRotation(rb.velocity);
        }
        else
        {
            anim.SetBool("Walk", false);
            stop = true;
        }
    }
}
