using UnityEngine;

public class OpenDoor : MonoBehaviour 
{
	public float Speed;
		
	void OnTriggerStay (Collider other)
	{
		if (Input.GetKeyDown (KeyCode.O)) 
		{
			Vector3 position = this.transform.position;
			position.y++;
			this.transform.position = position;

			transform.position += Vector3.up * Speed;
		}
	}

	void OnTriggerExit (Collider other)
	{

	}

	void Update ()
	{
		
	}
}
