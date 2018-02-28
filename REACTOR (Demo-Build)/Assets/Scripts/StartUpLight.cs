using System.Collections;
using UnityEngine;

public class StartUpMainLight : MonoBehaviour 
{
	Light testLight;

	void Start ()
	{
		StartCoroutine ("OpenMainDoor");

		testLight = GetComponent<Light> ();

		StartCoroutine (Flashing ());

	}

	void Update ()
	{

	}

	IEnumerator OpenMainDoor()
	{
		Debug.Log ("Main Door Opening in a few seconds.");

		yield return new WaitForSeconds (5.2f);

		Debug.Log ("Main Door Open.");
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
