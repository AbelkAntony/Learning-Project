using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour
{

	private void OnCollisionEnter(Collision collision)
	{
		Debug.Log("collided");
		Destroy(collision.gameObject);
	}

	
}
