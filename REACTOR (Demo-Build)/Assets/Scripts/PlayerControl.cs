using UnityEngine;

public class PlayerControl : MonoBehaviour
{
	void Update()
	{
		var x = Input.GetAxis("Horizontal") * Time.deltaTime * 55.0f;
		var z = Input.GetAxis("Vertical") * Time.deltaTime * 6.8f;

		transform.Rotate(0, x, 0);
		transform.Translate(0, 0, z);

		//Controls 1 – UP
		if (Input.GetKeyDown(KeyCode.Space))
		{
			transform.Translate(Vector3.up * Time.deltaTime * 4.4f);
		}

		//Controls 2 – DOWN
		if (Input.GetKeyDown(KeyCode.C))
		{
			transform.Translate(Vector3.down * Time.deltaTime * 4.4f);
		}
			
	}

}