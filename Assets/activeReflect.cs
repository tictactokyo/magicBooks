using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activeReflect : MonoBehaviour
{

	public GameObject explosion;




	public int dur;
    // Start is called before the first frame update
    void Start()
    {
        
    }

	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Boundary" || other.tag == "Player")
		{
			return;
		}
		Instantiate(explosion, transform.position, transform.rotation);

		//Instantiate(other.gameObject, transform.position, transform.rotation);


		Destroy (other.gameObject);

	}
    // Update is called once per frame
    void Update()
    {
		dur--;

		if(dur<0){

			Destroy (gameObject);
		}
    }
}
