using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {
	public GameObject player;
	// Use this for initialization
	void Awake()
	{
		player = GameObject.Find("player");
	}
	void Start () {

	}
	
	// Update is called once per frame
	void Update () 
	{	
		if (GameObject.Find ("player") != null) 
		{
			if (player.transform.position.y-2 > transform.position.y ) 
			{
				
				Destroy(gameObject);
			}
		}

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "player")
			Destroy (player);
	}
}
