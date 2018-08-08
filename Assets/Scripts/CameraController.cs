using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraController : MonoBehaviour
{

	public List<Transform> targets;
	public Vector3 offset;
	public float minZoom = 40f;
	public float maxZoom = 10f;
	public float smoothTime = 0.5f;
	public float zoomLimter = 50f;

	private float realSmoothTime;
	private Camera cam;
	private Vector3 velocity;

	void Awake()
	{
		cam = GetComponent<Camera>();
	}
	
	void LateUpdate ()
	{
		if(targets.Count == 0)
			return;
		Move();
		Zoom();
	}

	void Zoom()
	{
		float newZoom = Mathf.Lerp(maxZoom, minZoom,
			GetLongestDistance() / zoomLimter);
		cam.fieldOfView = Mathf.Lerp(cam.fieldOfView, newZoom, Time.deltaTime);

	}

	float GetLongestDistance()
	{
		var bounds = new Bounds(targets[0].position , Vector3.zero);

		foreach (var target in targets)
		{
			if(target != null)
			bounds.Encapsulate(target.position);
		}

		return bounds.size.x;
	}
	
	void Move()
	{
		Vector3 center = GetCenterPoint();
		Vector3 newPosition = center + offset;
		transform.position = Vector3.SmoothDamp(transform.position, newPosition, ref velocity, smoothTime);
	}

	Vector3 GetCenterPoint()
	{
		if (targets.Count == 0)
		{
			return targets[0].position;
		}
		
		var bounds = new Bounds(targets[0].position , Vector3.zero);
		
		foreach (var t in targets)
		{
			if(t != null)
			bounds.Encapsulate(t.position);
		}

		return bounds.center;
	}
}
