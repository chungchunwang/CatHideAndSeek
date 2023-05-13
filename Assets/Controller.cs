using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] public CharacterController2D controller;
    [SerializeField] public float runSpeed = 50f;
    [SerializeField]float horizontalMove = 0f;
    bool jump = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }
    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, false);
        if (jump)
        {
            controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
            jump = false;
        }
    }
}
