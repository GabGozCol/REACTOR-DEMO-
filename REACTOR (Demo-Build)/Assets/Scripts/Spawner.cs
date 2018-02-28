using UnityEngine;

public class Spawner : MonoBehaviour 
{
	public GameObject spawnee;
	public bool stopSpawning = false;
	public float spawnTime;
	public float spawnDelay;

	public float playerDistance;
	public Transform player;
	public static bool isPlayerAlive = true;

	void Start () 
	{
		InvokeRepeating ("SpawnObject", spawnTime, spawnDelay);

		if (playerDistance < 100.0f)
		{
			playerDistance = Vector3.Distance (player.position, transform.position);

			InvokeRepeating ("SpawnObject", spawnTime, spawnDelay);

			if (playerDistance < 80.0f) 
			{

				Instantiate (spawnee, transform.position, transform.rotation);

				if (stopSpawning) 
				{
					CancelInvoke ("SpawnObject");
				}

			} 
		}
	}

}
