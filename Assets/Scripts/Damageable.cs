using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Damageable : MonoBehaviour
{

	public float damageMultiply = 100f;
	float _damage = 1f;
	float force;
	
	Rigidbody rb;
	void Awake()
	{
		rb = GetComponent<Rigidbody>();
	}


	public void AddDamage(Vector3 dir, float damage)
	{
		_damage += damage;
		force = Mathf.Pow(_damage, (1.3f / _damage) + 1f);
		transform.localScale = new Vector3(1f,1f,1f) * _damage;
		rb.AddForce(_damage * force *damageMultiply * dir);
	}
}
