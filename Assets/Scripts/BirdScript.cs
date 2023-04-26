using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BirdScript : MonoBehaviour
{
    [SerializeField] InputAction flapButton = new InputAction(type: InputActionType.Button);
    [SerializeField] string colliderTag;
    [SerializeField] float flapStrength;
    [SerializeField] bool isAlive = true;
    [SerializeField] InputAction horizontalMovment = new InputAction(type: InputActionType.Button);
    [SerializeField] float movmentSpeed = 5f;

    private Rigidbody2D rb;
    private LogicScript logic;

    private void OnEnable()
    {
        horizontalMovment.Enable();
        flapButton.Enable();
    }

    private void OnDisable()
    {
        horizontalMovment.Disable();
        flapButton.Disable();
    }


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 v = new Vector2();
        if (flapButton.WasPerformedThisFrame() && isAlive)
        {
            rb.velocity = new Vector2(rb.velocity.x, flapStrength);
        }
        float m = horizontalMovment.ReadValue<float>();
        rb.velocity = new Vector2(m * movmentSpeed, rb.velocity.y);
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == colliderTag)
        {
            isAlive = false;
            logic.gameOver();
        }
    }
}
