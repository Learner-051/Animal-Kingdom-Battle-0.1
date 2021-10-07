using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	[SerializeField] private float moveSpeed;
	[SerializeField] private float walkSpeed;
	[SerializeField] private float runSpeed;
	private Vector3 moveDirection;
	/*private Vector3 velocity;
	[SerializeField] private bool isGrounded;
	[SerializeField] private float groundCheckDistance;
	[SerializeField] private float gravity;
	[SerializeField] private LayerMask groundMask;*/

	//Refrences
	private CharacterController controller;
	private Animator anim;
	private Rigidbody rb;
	public void Start()
	{
		controller = GetComponent<CharacterController>();
		anim = GetComponentInChildren<Animator>();
		rb = GetComponentInChildren<Rigidbody>();
	}
	public void Update()
	{
		Move();
	}
	private void Move()
	{
		/*IisGrounded = Physics.CheckSphere(transform.position, groundCheckDistance, groundMask);
		if (isGrounded && velocity.y <0)
        {
			velocity.y = -2f;
        }*/
		float moveZ = Input.GetAxis("Vertical");
		moveDirection = new Vector3(0, 0, moveZ);
		moveDirection = transform.TransformDirection(moveDirection);
		if (moveDirection != Vector3.zero && !Input.GetKeyDown(KeyCode.LeftShift))
		{
			Walk();
			anim.SetFloat("speed", 0.5f, 0.1f, Time.deltaTime);
			rb.AddForce(moveDirection);
		}
		else if (moveDirection != Vector3.zero && Input.GetKeyDown(KeyCode.LeftShift))
		{
			Run();
			anim.SetFloat("speed", 1f, 0.1f, Time.deltaTime);
			rb.AddForce(moveDirection);
		}
		else if (moveDirection == Vector3.zero)
		{
			anim.SetFloat("speed", 0, 0.1f, Time.deltaTime);
			rb.AddForce(moveDirection);
		}
		moveDirection *= moveSpeed;
		controller.Move(moveDirection * Time.deltaTime);
		/*velocity.y += gravity * Time.deltaTime;
		controller.Move(velocity * Time.deltaTime);*/
	}
	private void Walk()
	{
		moveSpeed = walkSpeed;
	}
	private void Run()
	{
		moveSpeed = runSpeed;
	}
	private void Idle()
	{

	}
}