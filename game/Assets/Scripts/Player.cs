using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	[Header("Movement")]
	public ControllerType controllerType;
	public float walkSpeed;
	public float sprintSpeed;
	public float jumpForce;
	public float currentSpeed;


	[Header("Ground Checks")]
	public bool doGroundCheck;
	public bool isGrounded;
	public Transform feetPos;
	public float checkRadius;
	public LayerMask groundLayers;

	//[Header("Camera Follow")]
	//public Vector2 camOffset;

	private Rigidbody2D rb;


	public enum ControllerType {
		WASD,
		ARROW
	}



	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}


	void FixedUpdate () {

		#region oldJumpDet
		//isGrounded = Physics2D.OverlapArea(top_left.position, bottom_right.position, groundLayers);

		//RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up);

		/*
		RaycastHit2D h = Physics2D.Raycast(transform.FindChild("JumpDetection").position, Vector2.down, 0.05F);

			//Debug.Log(h.transform.name);
		
		
		if (h.transform != null)
		{
			isGrounded = true;
		}
		else
		{
			isGrounded = false;
		}
		*/
		#endregion



		float arrowX = Input.GetAxisRaw("ArrowX");
		float arrowY = Input.GetAxisRaw("ArrowY");
		float wasdX = Input.GetAxisRaw("WasdX");
		float wasdY = Input.GetAxisRaw("WasdY");

		if(controllerType == ControllerType.ARROW)
		{
			movementCheckY(arrowY);
			movementCheckX(arrowX);
		}
		else
		{
			movementCheckY(wasdY);
			movementCheckX(wasdX);
		}




	}

	void Update()
	{
		//cameraFollow();
		isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, groundLayers);
	}



	void movementCheckX(float x)
	{



		if(x > 0)
		{
			//gameObject.transform.Translate(currentSpeed, 0, 0);
			//rb.velocity = new Vector2(currentSpeed, rb.velocity.y);
			//addXVelocity(currentSpeed);
			rb.velocity = new Vector2(x * currentSpeed, rb.velocity.y);
			//rb.AddForce(new Vector2(currentSpeed, 0), ForceMode2D.Impulse);
		}


		if(x == 0)
		{
			rb.velocity = new Vector2(0, rb.velocity.y);
		}

		if (x < 0)
		{
			// gameObject.transform.Translate(-currentSpeed, 0, 0);
			//addXVelocity(-currentSpeed);
			rb.velocity = new Vector2(x * currentSpeed, rb.velocity.y);
			//rb.AddForce(new Vector2(currentSpeed, 0), ForceMode2D.Impulse);
		}


		}

	void movementCheckY(float x)
	{

		if(isGrounded == true)
		{
			if (x > 0)
			{
				rb.velocity = Vector2.up * jumpForce;
			}



		}
		else
		{
			if (x < 0)
			{
				rb.velocity = Vector2.up * -jumpForce;
			}

		}



	}

	/*
	void cameraFollow()
	{
		Camera.main.transform.position = new Vector2(transform.position.x + camOffset.x, transform.position.y + camOffset.y);
	}
	*/
}


