using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantSway : MonoBehaviour
{

	Animator anim;
	GameObject player;
	public GameObject grass;
	public AnimationClip left;
	public AnimationClip right;



	void Start()
	{
		player = GameObject.FindGameObjectWithTag("Player");
		anim = GetComponent<Animator>();

	}


	void OnTriggerEnter2D(Collider2D other)
	{
		if (player.transform.position.x > grass.transform.position.x)
            gameObject.GetComponent<Animator>().Play(left.name);
			//Debug.Log("true");
        else 
        {
            if (player.transform.position.x < grass.transform.position.x)
                gameObject.GetComponent<Animator>().Play(right.name);
			//Debug.Log("false");
        }

	}
}
