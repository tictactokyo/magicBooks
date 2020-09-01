using UnityEngine;
using System.Collections;

//using UnityEngine.UI;

[System.Serializable]
public class Done_Boundary 
{
	public float xMin, xMax, zMin, zMax;
}

public class PlayerController : AnimatedObject
{
    
	//public Image pImage;

 

	
	public float tilt;
	public Done_Boundary boundary;
    public bool crouching;
	public GameObject[] shots;
	public Transform shotSpawn;
	public float fireRate;

	private float nextFire;

	void Update ()
	{

       

        if (Input.GetButton("Fire1") && Time.time > nextFire) 
		{

           // pImage.tintColor = new Color(1f, 1f, 1f, 1f);
            //gameObject. SetEnabled( false);

            nextFire = Time.time + fireRate;
			Instantiate(shots[0], shotSpawn.position, shotSpawn.rotation);
			GetComponent<AudioSource>().Play ();
		}
		if (Input.GetButton("Fire2") && Time.time > nextFire) 
		{
            

            nextFire = Time.time + fireRate;
			Instantiate(shots[3], shotSpawn.position, shotSpawn.rotation);
			GetComponent<AudioSource>().Play ();
		}


		if (Input.GetKeyDown("space") && Time.time > nextFire) 
		{
			nextFire = Time.time + fireRate;
			Instantiate(shots[1], shotSpawn.position, shotSpawn.rotation);
			GetComponent<AudioSource>().Play ();
		}
        if (Input.GetKeyDown("q") && Time.time > nextFire)
        {
            crouching = true;
        }

    }

  public void onLanded()
    {

        animator.SetBool("IsJumping", false);
    }

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal") * max_speed;

        animator.SetFloat("Speed", Mathf.Abs(moveHorizontal));

        float moveVertical   = Input.GetAxis ("Vertical") * max_speed;

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		GetComponent<Rigidbody>().velocity = movement ;

		//GetComponent<Rigidbody>().position = new Vector3
		//	(
		//		Mathf.Clamp (GetComponent<Rigidbody>().position.x, boundary.xMin, boundary.xMax), 
		//		0.0f, 
		//		Mathf.Clamp (GetComponent<Rigidbody>().position.z, boundary.zMin, boundary.zMax)
		//	);

	//	GetComponent<Rigidbody>().rotation = Quaternion.Euler (0.0f, 0.0f, GetComponent<Rigidbody>().velocity.x * -tilt);
	}
}
