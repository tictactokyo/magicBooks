using UnityEngine;
using System.Collections;

public class Done_Mover : MonoBehaviour
{
	public float speed;
	public Vector3 DIR;
	void Start ()
	{
		GetComponent<Rigidbody>().velocity = (DIR) * speed;
	}
}
