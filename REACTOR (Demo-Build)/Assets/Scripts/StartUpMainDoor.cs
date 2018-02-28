using System.Collections;
using UnityEngine;

public class StartUpMainDoor : MonoBehaviour 
{
	public float Speed = 0.2f;

	void Start ()
	{
		StartCoroutine ("OpenMainDoor");

	}

	void Update ()
	{

	}

	IEnumerator OpenMainDoor()
	{
		Debug.Log ("Main Door Opening in a few seconds.");

		yield return new WaitForSeconds (4.9f);

		transform.position += Vector3.right * Speed;

		Debug.Log ("Main Door Open.");
	}
}
