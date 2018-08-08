using UnityEngine;

public class Gun : MonoBehaviour
{

	public GameObject projectile;
	public Transform center;
	public Transform shootingPoint;
	public float power = 10f;
	
	void Update () {
		if (Input.GetButtonDown("Fire1"))
		{
			Shoot();
		}
	}

	void Shoot()
	{
		var pro = Instantiate(projectile, shootingPoint.position, Quaternion.identity, shootingPoint);
		pro.GetComponent<ShotController>()
			.Shoot((shootingPoint.position - center.position).normalized * power);
	}
	
}
