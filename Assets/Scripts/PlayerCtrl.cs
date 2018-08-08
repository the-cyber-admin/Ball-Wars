using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerCtrl : MonoBehaviour
{
	public float speed = 10f;
	public float jumpPower = 400f;
	public int timesCanJump = 3;
	public float movementSmoothing = 0.05f;


	#region Info Varibles

	Vector3 velocity;
	int timesJumped = 0;
	float axis = 0f;
	bool jump = false;

	#endregion

	#region Rigidbody reference

	Rigidbody rb;
	void Awake()
	{
		rb = GetComponent<Rigidbody>();
	}

	#endregion
	
	void Update ()
	{
		axis = Input.GetAxis("Horizontal");
		jump = Input.GetButtonDown("Jump");
	}
	void FixedUpdate()
	{
		if(jump)
			Jump();
		Move();
	}
	private void Move()
	{
		Vector3 targetVelocity = new Vector3(axis * speed, rb.velocity.y , 0f);
		rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref velocity, movementSmoothing);
	}

	#region JumpController

	private void Jump()
	{
		if (timesJumped < timesCanJump)
		{
			jump = false;
			timesJumped++;

			rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.z);
			rb.AddForce(jumpPower * Vector3.up);
		}
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other.collider.CompareTag("Walkable"))
			timesJumped = 0;
	}

	#endregion
}
