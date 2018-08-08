using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerCtrl : MonoBehaviour
{
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
		var velocity = (axis * speed * Time.fixedDeltaTime * Vector3.right);
		velocity.y = rb.velocity.y;
		rb.velocity = velocity;
	}
}
