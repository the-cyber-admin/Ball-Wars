using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Damageable : MonoBehaviour
{

	public float damageMultiply = 100f;
	public float maxDamage = 3f;
	float _damage = 1f;
	float force;
	
	Rigidbody rb;
	void Awake()
	{
		rb = GetComponent<Rigidbody>();
	}


	public void AddDamage(Vector3 dir, float damage)
	{
		//TODO Decrease Sizing value every time he get hit
		_damage += damage;
		var TweakDamage = Mathf.Clamp(_damage , 1f ,maxDamage);
		force = TweakDamage;
		transform.localScale = new Vector3(1f,1f,1f) * TweakDamage;
		rb.AddForce(_damage * force * damageMultiply * dir);
	}
}
