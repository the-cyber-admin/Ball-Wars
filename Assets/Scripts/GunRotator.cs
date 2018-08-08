using UnityEngine;

public class GunRotator : MonoBehaviour
{

	public Transform center;
	public int invert = 1;
	
	Camera cam;
	void Awake()
	{
		cam = Camera.main;
	}
	
	void Update () 
	{
		//Get the Screen positions of the object
		Vector2 positionOnScreen = cam.WorldToViewportPoint (center.position);
         
		//Get the Screen position of the mouse
		Vector2 mouseOnScreen = cam.ScreenToViewportPoint(Input.mousePosition);
         
		//Get the angle between the points
		float angle = AngleBetweenTwoPoints(positionOnScreen, mouseOnScreen);
 
		//Assign the new Rotation
		center.rotation =  Quaternion.Euler (new Vector3(0f,0f,angle));
	}
 
	float AngleBetweenTwoPoints(Vector3 a, Vector3 b)
	{
		a *= invert;
		b *= invert;
		
		return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
	}
}
