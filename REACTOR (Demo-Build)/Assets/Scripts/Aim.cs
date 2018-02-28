using UnityEngine;






// *********  		T H I S  S C R I P T  O V E R I D E S  " P L A Y E R  C O N T R O L L E R ",  
//					D O  N O T  U S E  U N T I L  P R O P E R L Y  A T T A T C H E D. .– 	This script generates independant rotation 
// 	 																						added to the main player scontroller script 
// *********																				creating multiple t.



// SCRIPT IS NOT ASSIGNED. check 15/FEB/2018



public class Aim : MonoBehaviour 
{
	void Update () 
	{
		Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.z, 10);

		Vector3 lookPos = Camera.main.ScreenToWorldPoint(mousePos);

		lookPos = lookPos - transform.position;

		float angle = Mathf.Atan2(lookPos.z, lookPos.x) * Mathf.Rad2Deg;

		transform.rotation = Quaternion.AngleAxis(angle, Vector3.down); // Turns Right

		transform.rotation = Quaternion.AngleAxis(angle, Vector3.up); //Turns Left

	}
}
