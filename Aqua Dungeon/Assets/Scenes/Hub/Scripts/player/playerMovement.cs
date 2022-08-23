using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Animator anim;
    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    Vector2 movement; 
    Vector2 Dash; 


    public float facingHorizontal = 0;
    public float facingVertical = -1;

    public float DashSpeed;
    
    public float DashTime;
    public float DashTimeSet;
    public float DashChargeTime;
    public float dashChargeTimeSet;

    public bool isDashing;
    public bool canDash;

    // Update is called once per frame

    void Start()
    {
        DashTime = DashTimeSet;
        DashChargeTime = dashChargeTimeSet;
        canDash = true;

        rb = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        Dash.x =  facingHorizontal;
        Dash.y = facingVertical;


        FacingDirection();

        anim.SetFloat("Horizontal", movement.x);
        anim.SetFloat("Vertical", movement.y);
        anim.SetFloat("Speed", movement.sqrMagnitude);

        anim.SetFloat("facingHorizontal", facingHorizontal);
        anim.SetFloat("facingVertical", facingVertical);

        if(Input.GetButtonDown("Dash") && DashTime > 0)
        {
            Dashvoid();

        }

        
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    private void Dashvoid()
    {
        
        
        rb.MovePosition(rb.position + Dash * DashSpeed * Time.fixedDeltaTime);
        DashTime -= Time.deltaTime;
        
         if(DashTime > 0)
        {
            //DashCharge();
        }
    
        if (DashTime <= 0)
        {
            //DashChargeEmpty();
        }
        
    }

    private void DashCharge()
    {
        if(DashChargeTime != dashChargeTimeSet)
        {
            DashChargeTime -= Time.deltaTime;
        }
        else if(DashChargeTime >= dashChargeTimeSet )
        {
            DashChargeTime = dashChargeTimeSet;
            DashTime = DashTimeSet;
        }
    }

    private void DashChargeEmpty()
    {
        if(DashChargeTime != dashChargeTimeSet)
        {
            DashChargeTime -= Time.deltaTime;
        }
        else if(DashChargeTime >= dashChargeTimeSet)
        {
            DashChargeTime = dashChargeTimeSet;
            DashTime = DashTimeSet;
        }
    }

    private void FacingDirection()
    {
        if(movement.x > 0f)
        {
            facingHorizontal = 1f;
            facingVertical = 0f;
        }
        else if(movement.x < 0f)
        {
            facingHorizontal = -1f;
            facingVertical = 0f;
        }
        else if(movement.y > 0f)
        {
            facingHorizontal = 0f;
            facingVertical = 1f;
        }
        else if(movement.y < 0f)
        {
            facingHorizontal = 0f;
            facingVertical = -1f;
        }
    }

}
