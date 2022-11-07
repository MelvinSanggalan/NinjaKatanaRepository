using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordDash : MonoBehaviour
{

    PlayerController moveScript;

    public float dashSpeed;
    public float dashTime;

    public bool dashCooldown;


    // Start is called before the first frame update
    void Start()
    {
        moveScript = GetComponent<PlayerController>();

        dashCooldown = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            if (!dashCooldown) StartCoroutine(Dash());
        }
    }

    IEnumerator Dash()
    {
        dashCooldown = true;
        float startTime = Time.time;
        
        while(Time.time < startTime + dashTime)
        {
            moveScript.controller.Move(moveScript.motionStep * dashSpeed * Time.deltaTime);
        }

        yield return new WaitForSeconds(5);

        dashCooldown = false;
    }
}
