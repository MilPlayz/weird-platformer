using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthHeart : MonoBehaviour {

	public Transform heartInside;
	public float timeLeft;
	//public Animation flashAnim;
	public Animator anim;

	[Header("Dont Edit")]
	public float nextSub;
	public float healthLeft;
	public float valToSubFromHealth;
	public float valToSubFromY;
	//public bool animPlaying = false;


	void Start () {
		valToSubFromY = heartInside.localPosition.y / timeLeft;
		valToSubFromHealth = 100 / timeLeft;
		nextSub = 1;
		healthLeft = 100;
	}
	

	void Update () {

		anim.SetFloat("Health", healthLeft);

		/*
		if(healthLeft <= 30)
		{
			if (!flashAnim.isPlaying)
			{
				flashAnim.Play();
			}
			
		}
		*/

		if(nextSub <= 0)
		{
			healthLeft -= valToSubFromHealth;
			timeLeft--;
			nextSub = 1;
			heartInside.localPosition -= new Vector3(0, valToSubFromY, 0);
		}

		if(timeLeft <= 0)
		{
			Debug.Log("Stopped!");
			Destroy(gameObject);
		}

		nextSub -= Time.deltaTime;

	}
}
