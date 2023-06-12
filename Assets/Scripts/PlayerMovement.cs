using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rgb;
    Vector3 velocity;

    public Animator animator;
    public Vector3 respawnPoint;

    float MoveInput;
    public bool isMove = true;
     
    float speedAmount = 7f;
    float jumpAmount = 7f;

    PlayerControls controls;

    public int questionAnswers = 0;
    public bool takenChest = false;
    // Start is called before the first frame update
    void Start()
    {
        respawnPoint = new Vector3(-6.62f, 0.45f,0f);
        rgb = GetComponent<Rigidbody2D>();
    }

    void Awake()
    {
        controls = new PlayerControls();
        controls.Enable();

        controls.Land.Move.performed += ctx => MoveInput = ctx.ReadValue<float>();
        controls.Land.Jump.performed += ctx => {
            if (Mathf.Approximately(rgb.velocity.y, 0))
            {
                rgb.AddForce(Vector3.up * jumpAmount, ForceMode2D.Impulse);
                animator.SetBool("isJumping", true);
            }
            if (Mathf.Approximately(rgb.velocity.y, 0))
            {
                animator.SetBool("isJumping", false);
            }
        };
    }

    // Update is called once per frame
    void Update()
    {
        if (isMove)
        {
            velocity = new Vector3(MoveInput, 0);

            transform.position += velocity * speedAmount * Time.deltaTime;
            animator.SetFloat("speed", Mathf.Abs(MoveInput));
            PlayerDeathCheck();


            if (Input.GetButtonDown("Jump") && Mathf.Approximately(rgb.velocity.y, 0))
            {
                rgb.AddForce(Vector3.up * jumpAmount, ForceMode2D.Impulse);
                animator.SetBool("isJumping", true);
            }
            if (animator.GetBool("isJumping") && Mathf.Approximately(rgb.velocity.y, 0))
            {
                animator.SetBool("isJumping", false);
            }

            if (MoveInput == -1)
            {
                transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            }
            else if (MoveInput == 1)
            {
                transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            }
            
        }
        
    }
    private void PlayerDeathCheck()
    {
        if(transform.position.y <= -10)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            transform.position = respawnPoint;
        }
    }
    
}
