﻿using UnityEngine;

public class Gun : MonoBehaviour
{

	public GameObject projectile;
	public Transform center;
	public Transform shootingPoint;
	public float power = 10f;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
	public float reloadRate = 0.5f;

	float _nextTimeShot;
=======
	
>>>>>>> parent of 7ead4d7... Firerate
=======
	
>>>>>>> parent of 7ead4d7... Firerate
=======
	public float reloadRate = 0.5f;

	float _nextTimeShot;
>>>>>>> parent of 2688703... Fail
	
	bool isCharging = false;
	void Update ()
	{
		if (!isCharging && Input.GetButtonDown("Fire1"))
			Charge();
		if (isCharging && Input.GetButtonUp("Fire1"))
			Release();
	}

	private GameObject pro;
	
	private void Charge()
	{
		if(_nextTimeShot > Time.time)
			return;
		isCharging = true;
		pro = Instantiate(projectile, shootingPoint.position, Quaternion.identity, shootingPoint);
=======
=======
>>>>>>> parent of dc23c87... Add Jump Limter
=======
>>>>>>> parent of dc23c87... Add Jump Limter
=======
>>>>>>> parent of dc23c87... Add Jump Limter
=======
>>>>>>> parent of dc23c87... Add Jump Limter
	
	void Update () {
		if (Input.GetButtonDown("Fire1"))
		{
			Shoot();
		}
<<<<<<< HEAD
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
=======
>>>>>>> parent of dc23c87... Add Jump Limter
	}

	void Shoot()
	{
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
		isCharging = false;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> parent of 2688703... Fail
		_nextTimeShot = Time.time + reloadRate;
=======
		var pro = Instantiate(projectile, shootingPoint.position, Quaternion.identity, shootingPoint);
>>>>>>> parent of dc23c87... Add Jump Limter
		pro.GetComponent<ShotController>()
			.Shoot((shootingPoint.position - center.position).normalized * power , transform);
	}
<<<<<<< HEAD
=======
=======
>>>>>>> parent of dc23c87... Add Jump Limter
=======
>>>>>>> parent of dc23c87... Add Jump Limter
=======
>>>>>>> parent of dc23c87... Add Jump Limter
		var pro = Instantiate(projectile, shootingPoint.position, Quaternion.identity, shootingPoint);
<<<<<<< HEAD
=======
>>>>>>> parent of 7ead4d7... Firerate
=======
>>>>>>> parent of 7ead4d7... Firerate
=======
>>>>>>> parent of 2688703... Fail
		pro.GetComponent<ShotController>()
			.Shoot((shootingPoint.position - center.position).normalized * power);
	}
	
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> parent of 2688703... Fail
>>>>>>> parent of dc23c87... Add Jump Limter
=======
	
>>>>>>> parent of dc23c87... Add Jump Limter
=======
>>>>>>> parent of dc23c87... Add Jump Limter
=======
>>>>>>> parent of dc23c87... Add Jump Limter
=======
>>>>>>> parent of dc23c87... Add Jump Limter
<<<<<<< HEAD
=======
=======
>>>>>>> parent of 7ead4d7... Firerate
	void Shoot()
	{
		
	}
	
<<<<<<< HEAD
>>>>>>> parent of 7ead4d7... Firerate
=======
>>>>>>> parent of 7ead4d7... Firerate
=======
>>>>>>> parent of 2688703... Fail
}
