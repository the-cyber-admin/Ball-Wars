using UnityEngine;

public class Gun : MonoBehaviour
{

	public GameObject projectile;
	public Transform center;
	public Transform shootingPoint;
	public float power = 10f;
	public float reloadTime = 0.5f;
	
	
	bool isCharging = false;
	float nextShootingTime = 0;

	void Start()
	{
		nextShootingTime = Time.time + reloadTime;
	}
	
	void Update ()
	{
		if (nextShootingTime < Time.time)
		{
			if (!isCharging && Input.GetButtonDown("Fire1"))
				Charge();
		}

		if (isCharging && Input.GetButtonUp("Fire1"))
			Release();
	}

	private GameObject pro;
	
	private void Charge()
	{
		isCharging = true;
		pro = Instantiate(projectile, shootingPoint.position, Quaternion.identity, shootingPoint);
	}

	private void Release()
	{
		nextShootingTime = Time.time + reloadTime;
		isCharging = false;
		pro.GetComponent<ShotController>()
			.Shoot((shootingPoint.position - center.position).normalized * power);
	}
	
	void Shoot()
	{
		
	}
	
}
