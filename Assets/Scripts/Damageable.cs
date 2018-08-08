using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Damageable : MonoBehaviour
{

	public float damageMultiply = 10f;
	float _damage = 1f;
	
	Rigidbody rb;
	void Awake()
	{
		rb = GetComponent<Rigidbody>();
	}


	public void AddDamage(Vector3 dir, float damage)
	{
		_damage += damage;
		transform.localScale = new Vector3(1f,1f,1f) * _damage;
		rb.AddForce(_damage * damageMultiply * dir);
	}
}
