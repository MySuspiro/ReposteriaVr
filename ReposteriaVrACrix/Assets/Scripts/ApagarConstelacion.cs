using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApagarConstelacion : MonoBehaviour
{
	// OnTriggerEnter is called when the Collider other enters the trigger.
	protected void OnTriggerEnter(Collider other)
	{
		
	}
	
	// OnTriggerExit is called when the Collider other has stopped touching the trigger.
	protected void OnTriggerExit(Collider other)
	{
		Debug.Log("Salir");
	}
	
	// OnCollisionExit is called when this collider/rigidbody has stopped touching another rigidbody/collider.
	protected void OnCollisionExit(Collision collisionInfo)
	{
		Debug.Log("Salir");
	}
}
