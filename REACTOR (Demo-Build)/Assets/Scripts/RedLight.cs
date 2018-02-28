using UnityEngine;
using System.Collections;

public class RedLight : MonoBehaviour 
{
	Light testLight;

	void Start()
	{

			testLight = GetComponent<Light> ();
			StartCoroutine (Flashing ());

			//testLight = GetComponent<Light> ();
			//StartCoroutine (Flashing ());
	}

	IEnumerator Flashing ()
	{

		while (true) 
		{
			yield return new WaitForSeconds (1.0f);
			testLight.enabled = !testLight.enabled;
		}

	}
}
