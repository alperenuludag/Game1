using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool jump = false;
    public bool slide = false;
    public GameObject trigger;

    public Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        transform.Translate(0, 0, 0.01f);



        if (Input.GetKey(KeyCode.Space))
        {
            jump = true;    
        }
        else
        {
            jump = false;
        }

       
        if (Input.GetKey(KeyCode.DownArrow))
        {
            slide = true;
        }
        else
        {
            slide = false;
        }


        if (jump == true)
        {
            anim.SetBool("isJump", jump);
            transform.Translate(0, 0, 0.01f);
        }
        else if(jump == false)
        {
            anim.SetBool("isJump", jump);
            
        }



        if (slide == true)
        {
            anim.SetBool("isSlide", slide);
            transform.Translate(0, 0, 0.01f);
        }
        else if (slide == false)
        {
            anim.SetBool("isSlide", slide);

        }


    }


    



    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "PlayerTrigger")
        {
            Destroy(trigger.gameObject);
        }

        if (other.gameObject.tag == "Coin")
        {
            Destroy(other.gameObject, 0.2f);
        }
    }
}
