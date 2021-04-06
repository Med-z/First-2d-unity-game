using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public Rigidbody2D rigidbody; 
    private Vector3 velocity = Vector3.zero;
    public float move_speed;
    public Animator animator;
    public SpriteRenderer sprite; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        float horizontal_move = Input.GetAxis("Horizontal") * move_speed * Time.deltaTime;
        movePlayer(horizontal_move);
        flipAnimRun(rigidbody.velocity.x); 

        animator.SetFloat("Speed", Mathf.Abs(rigidbody.velocity.x));

    }
    

    void movePlayer(float horizontal_move)
    {
        Vector3 targetVelocity = new Vector2(horizontal_move, rigidbody.velocity.y);
        rigidbody.velocity = Vector3.SmoothDamp(rigidbody.velocity, targetVelocity, ref velocity, .05f);
    }

    void flipAnimRun(float velocity)
    {
        if (velocity > 0.1)
            sprite.flipX = false;
        else if (velocity < -0.1)
            sprite.flipX = true; 

    }
}
