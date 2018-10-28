using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBG : MonoBehaviour {

	public float speed;
	public dir direction;
	public float endX;
	public float StartX;
	public GameObject player;
	//public RectTransform t;

	void Start()
	{
		player = gameObject.transform.parent.gameObject;
	//	t = gameObject.GetComponent<RectTransform>();

	}

	public enum dir
	{
		left,
		right
	}

	void Update () {

		
		if(direction == dir.left)
		{
		
			transform.Translate(Vector2.left * speed * Time.deltaTime);
		}
		else
		{
			transform.Translate(Vector2.right * speed * Time.deltaTime);
		}

		if(transform.position.x <= player.transform.position.x + endX)
		{
			Vector2 pos = new Vector2(player.transform.position.x + player.transform.position.x + StartX, transform.position.y);
			transform.position = pos;

		}

	}
}
