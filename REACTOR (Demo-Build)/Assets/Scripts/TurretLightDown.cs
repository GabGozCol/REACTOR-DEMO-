
using UnityEngine;

public class TurretLightDown : MonoBehaviour 
{	
	public float speed = 340f;

	void Update() 
	{
			transform.Rotate (Vector3.up, speed * Time.deltaTime);
	}

}
