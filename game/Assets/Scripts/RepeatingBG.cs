using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBG : MonoBehaviour {

	public float speed;
	public dir direction;
	public float endX;
	public float StartX;
	//public RectTransform t;

	void Start()
	{
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

		if(transform.position.x <= endX)
		{
			Vector2 pos = new Vector2(StartX, transform.position.y);
			transform.position = pos;

		}

	}
}
