
using UnityEngine;

public class HealthScript : MonoBehaviour 
{
	public float health;
	public static bool isPlayerAlive = true;

	void Start () 
	{
		
	}

	void Update () 
	{
		if(health < 0.0f)
		{
			EnemyAI.isPlayerAlive = false;
			Destroy (gameObject);
		}
	}
}
