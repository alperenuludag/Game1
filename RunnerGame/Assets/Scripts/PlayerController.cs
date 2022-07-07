using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool jump = false;
    public bool slide = false;
    bool oyunsonu_Geldimi;
    public GameManager gamemanager;

   Animator anim;
    void Start()
    {
        oyunsonu_Geldimi = false;
           anim = GetComponent<Animator>();
    }
    private void FixedUpdate()
    {
        if(!oyunsonu_Geldimi)
        transform.Translate(Vector3.forward * 8f * Time.deltaTime);
    }
    void Update()
    {
        if (!oyunsonu_Geldimi)
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                if (Input.GetAxis("Mouse X") < 0)
                {
                    transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x - .1f, transform.position.y,
                        transform.position.z), .3f);
                }
                if (Input.GetAxis("Mouse X") > 0)
                {
                    transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x + .1f, transform.position.y,
                        transform.position.z), .3f);
                }
            }


            if (Input.GetKeyDown(KeyCode.Space))
            {
                jump = true;
            }
            if (Input.GetKeyUp(KeyCode.Space))
            {
                jump = false;
            }


            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                slide = true;
            }
            else
            {
                slide = false;
            }


            if (jump == true)
            {

                if (anim.GetBool("isJump") == false)
                {
                    anim.SetBool("isJump", jump);
                    //transform.Translate(Vector3.up * 25f * Time.deltaTime);

                }



            }
            else if (jump == false)
            {
                anim.SetBool("isJump", jump);

            }



            if (slide == true)
            {
                if (anim.GetBool("isSlide") == false)
                {
                    anim.SetBool("isSlide", slide);
                    transform.Translate(Vector3.forward * 8f * Time.deltaTime);
                }
            }
            else if (slide == false)
            {
                anim.SetBool("isSlide", slide);

            }
        }

    }


    



    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "engel")
        {
            Debug.Log("carpti");
            other.gameObject.SetActive(false);
            gamemanager.rate_down(0.1f);
        }

        if (other.gameObject.tag == "Coin")
        {
            Destroy(other.gameObject, 0.2f);
        }
        if (other.CompareTag("reward"))
        {
            Debug.Log("odul kazandik");
            other.gameObject.SetActive(false);
            gamemanager.rate_up(0.1f);
        }
        if (other.CompareTag("bolum_sonu"))
        {
            anim.SetBool("oyunsonu", true);// eklenecek
            oyunsonu_Geldimi = true;
        }


    }
}
