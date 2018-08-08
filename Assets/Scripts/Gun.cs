using UnityEngine;

public class Gun : MonoBehaviour
{

	public GameObject projectile;
	public Transform center;
	public Transform shootingPoint;
	public float power = 10f;
	public float reloadRate = 0.5f;

	float _nextTimeShot;
	
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
	}

	private void Release()
	{
		isCharging = false;
		_nextTimeShot = Time.time + reloadRate;
		pro.GetComponent<ShotController>()
			.Shoot((shootingPoint.position - center.position).normalized * power);
	}
}
