using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerCtrl : MonoBehaviour
{
	public float maxSpeed = 7f;
	public float speed = 5f;
	public float jumpPower = 400f;

	float axis = 0f;
	bool jump = false;
	
	Rigidbody rb;
	
	void Awake()
	{
		rb = GetComponent<Rigidbody>();
	}
	
	void Update ()
	{
		axis = Input.GetAxis("Horizontal");
		jump = Input.GetButtonDown("Jump");
	}

	void FixedUpdate()
	{
		if (jump)
		{
			Jump();
			jump = false;
		}

		Move();
	}

	private void Jump()
	{
		rb.velocity = new Vector3(rb.velocity.x , 0 , rb.velocity.z);
		rb.AddForce(jumpPower * Vector3.up);
	}

	private void Move()
	{
<<<<<<< HEAD

		var force = Vector3.zero;
		// change the force depending on the speed of the axis
		if (Math.Abs(rb.velocity.x) < 0.001f)
			goto move;
		force.x =  Mathf.Abs(maxSpeed / rb.velocity.x);
		goto continueMath;
		move:
		force.x = 1f;
		continueMath:
		force.x *= speed * Time.deltaTime * axis;
		
		rb.AddForce(force / 10f);
		rb.velocity = new Vector3(
			Mathf.Clamp(rb.velocity.x, -maxSpeed, maxSpeed),
			rb.velocity.y,
			rb.velocity.z);
=======
		var velocity = (axis * speed * Time.fixedDeltaTime * Vector3.right);
		velocity.y = rb.velocity.y;
		rb.velocity = velocity;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> parent of dc23c87... Add Jump Limter
=======
>>>>>>> parent of dc23c87... Add Jump Limter
=======
>>>>>>> parent of dc23c87... Add Jump Limter
=======
>>>>>>> parent of dc23c87... Add Jump Limter
	}
}
