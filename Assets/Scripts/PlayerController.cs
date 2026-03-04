using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{

    public int jumpForce = 12;
    public int moveSpeed = 5;

    public InputAction move;
    public InputAction jump;

    private Rigidbody2D rbody;
    private SpriteRenderer marioSprite;
    //public vector2 playerVelocity;
    public bool spriteRenderer; //flipX

    private bool isMoving = false;
    private bool isJumpPressed = false;

    void Awake()
    {

    rbody = GetComponent<Rigidbody2D>();
    marioSprite = gameObject.AddComponent<SpriteRenderer>();

    move = InputSystem.actions.FindAction("Move");
    move = InputSystem.actions.FindAction("Jump");

   



    //rbody = gameObject.AddComponent<Rigidbody2D>();
    //marioSprite = gameObject.AddComponent<SpriteRenderer>();


    // X = gameObject.GetComponent<>();
     //X = gameObject.GetComponentUbChildren<>();

    //Vector2 input = moveAction.action.ReadValue<Vector2>();


    }

    void Update()
    {
      isJumpPressed = Input.GetButtonDown("Jump");

      if (isJumpPressed)
      {
        
        rbody.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
      
      }
    }
void FixedUpdate(){


Vector2 moveValue = move.ReadValue<Vector2>();

//if (isRightPressed)

rbody.linearVelocity = new Vector2(moveValue.x * moveSpeed, rbody.linearVelocity.y);

//}


     // isMoving = Input.GetButtonDown("Horizontal");
      
      // if (isMoving)
       // {
            //rbody.AddForce(transform.move * moveSpeed, ForceMode2D.Impulse);
     //  }
    
    //vector2.up  
    }}

