using UnityEngine;
using System.Collections;

public class characterControllerScriptPlayer2 : MonoBehaviour {
	
	public float maxSpeed = 10f;
	public Transform groundCheck;
	public LayerMask whatIsGround;
	public float jumpForce = 700f;
	
	private bool facingRight = true;
	private bool grounded = false;
	private float groundRadius = 0.2f;
	
	private Animator anim;
	
	
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);
		anim.SetBool ("ground", grounded);
		
		anim.SetFloat ("vSpeed", rigidbody2D.velocity.y);
		
		// if not grounded, player can't be controlled
		// if(!grounded) return;
		
		float move = Input.GetAxis ("Horizontal2");
		anim.SetFloat("speed", Mathf.Abs(move));
		rigidbody2D.velocity = new Vector2 (move * maxSpeed, rigidbody2D.velocity.y);
		
		if (move > 0 && !facingRight)
			Flip ();
		else if (move < 0 && facingRight)
			Flip ();
	}
	
	void Update()
	{
		if((grounded) && Input.GetKeyDown(KeyCode.Space))
		{
			anim.SetBool("ground", false);
			rigidbody2D.AddForce(new Vector2(0, jumpForce));
		}
	}
	
	void Flip()
	{
		facingRight = !facingRight;
		Vector3 scale = transform.localScale;
		scale.x *= -1;
		transform.localScale = scale;
	}
}
