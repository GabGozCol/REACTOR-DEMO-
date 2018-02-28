using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnomallyDOOR : MonoBehaviour 
{
	Light testLight;
	public float speed = 0.3f;
	private Vector3 Direction;
	private GameObject[] probeOne;

	void Start ()
	{
		Direction = Vector3.down;
	}

	void OnTriggerEnter (Collider Player)
	{
		AudioSource audio = GetComponent <AudioSource> ();
		audio.Play();

		testLight = GetComponent<Light> ();
		testLight.enabled = true;

		StartCoroutine ("Teleport");

	}

	IEnumerator Teleport()
	{
		yield return new WaitForSeconds (8.2f);

		probeOne = GameObject.FindGameObjectsWithTag ("Player");
		foreach (GameObject r in probeOne)
			r.transform.Translate (Direction * speed);

		Debug.Log ("Teleported to THE UNDERGROUND");
	}
		
}
