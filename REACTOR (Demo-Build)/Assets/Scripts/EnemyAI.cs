using UnityEngine;

public class EnemyAI : MonoBehaviour 
{
	public Transform player;
	public float playerDistance;
	public float rotationDamping;
	public float moveSpeed;
	public static bool isPlayerAlive = true;

	void Start () 
	{
		
	}

	void Update () 
	{
		if (isPlayerAlive) 
		{
			playerDistance = Vector3.Distance (player.position, transform.position);

			if (playerDistance < 60.0f) 
			{
				lookAtPlayer();
			}

			if (playerDistance < 15.0f) 
			{
				if (playerDistance > 5.0f) 
				{
					chase ();
				} 
				else if (playerDistance < 6.5f) 
				{
					attack ();
				}
			}
		}
	}

	void lookAtPlayer()
	{
		Quaternion rotation = Quaternion.LookRotation (player.position - transform.position);
		transform.rotation = Quaternion.Slerp (transform.rotation, rotation, Time.deltaTime * rotationDamping);
	}

	void chase()
	{
		transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
	}

	void attack()
	{
		
		RaycastHit hit;
		if (Physics.Raycast (transform.position, transform.forward, out hit)) 
		{
			if (hit.collider.gameObject.tag == "Player") 
			{
				hit.collider.gameObject.GetComponent<HealthScript> ().health -= 0.5f;
			}
		}
	}
		

	public float health = 40.0f;

	public void TakeDamage (float amount)
	{
		health -= amount;
		if (health <= 0) 
		{
			Die ();
		}
	}

	void Die ()
	{
		Destroy (gameObject);
	}

}

//check. 14/FEB/2018
//check.— components. 14/FEB/2018

// *NO USAR CON PLAYER*