using UnityEngine;

public class Gun : MonoBehaviour 
{
	public float damage = 12.0f;
	public float range = 250.0f;

	public float Bullet_Forward_Force;

	public GameObject BulletEmitter;
	public GameObject Bullet;

	public Gun fpsGun;

	void Start () 
	{
		
	}

	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Mouse0)) 
		{
			Shoot ();

			GameObject Temporary_Bullet_Handler;
			Temporary_Bullet_Handler = Instantiate (Bullet, BulletEmitter.transform.position, BulletEmitter.transform.rotation) as GameObject;

			//Temporary_Bullet_Handler.transform.Rotate(Vector3.left * 90);

			Rigidbody Temporary_RigidBody;
			Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody> ();

			Temporary_RigidBody.AddForce (transform.forward * Bullet_Forward_Force);

			Destroy (Temporary_Bullet_Handler, 0.8f);

		}

		if (Input.GetKeyDown (KeyCode.Mouse0)) 
		{
			AudioSource audio = GetComponent <AudioSource> ();
			audio.Play();
		}

	}

	void Shoot ()
	{

		RaycastHit hit;
		if (Physics.Raycast (fpsGun.transform.position, fpsGun.transform.forward, out hit, range)) 
		{
			Debug.Log (hit.transform.name);

			Target target = hit.transform.GetComponent<Target> ();
			if (target != null) 
			{
				target.TakeDamage (damage);
			}
		}
	}
}
