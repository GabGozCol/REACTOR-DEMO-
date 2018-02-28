
using UnityEngine;

public class TurretLight : MonoBehaviour 
{	
	public float speed = 130f;

	void Update() 
	{
			transform.Rotate (Vector3.right, speed * Time.deltaTime);
	}

}
