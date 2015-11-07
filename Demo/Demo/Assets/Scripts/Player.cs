using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
	public GameObject hazards;
	public GameObject items;
	public float speed = 5f;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		float new_x = 0f;
		Vector2 mouse = new Vector2(Input.mousePosition.x, Screen.height - Input.mousePosition.y);
		if (Input.GetKeyDown ("space")) 
		{
			print ("space key was pressed");
			Vector3 updatedPosition = new Vector3 (transform.position.x, transform.position.y + 10f, transform.position.z);
			Instantiate (hazards, updatedPosition, transform.rotation);
		}
		float z = Input.GetAxis("Vertical");
		//transform.Translate+= new Vector3(0,1,0);
		float h = Input.GetAxis("Horizontal");
		if (transform.position.x >= 10f && mouse.x > Screen.width / 2) 
		{
			new_x = 0f;

		} else if (transform.position.x <= -10f && mouse.x < Screen.width / 2)
		{
			new_x = 0f;
		} 
		else 
		{
			new_x = Input.GetAxis ("Mouse X");
		}

		transform.Translate(new_x * Time.deltaTime*speed,speed* Time.deltaTime,0);
	}
}
