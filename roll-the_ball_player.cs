using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_ball : MonoBehaviour
{
    public float jumpPower;
    public int itemCount;
    public manager Manager;
    public int total;
    bool isJump;
    Rigidbody rigid;
    AudioSource audio;

    void Awake()
    {
        isJump = false;
        rigid = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
      
    }
    void Update()
    {
        
        if (!isJump && Input.GetButtonDown("Jump"))
        {
            isJump = true;
            rigid.AddForce(new Vector3(0, jumpPower, 0), ForceMode.Impulse);
        }

    }
   
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        rigid.AddForce(new Vector3(h,0,v),ForceMode.Impulse);
    }

    
    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "floor")
            isJump = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other != null)
        {
            if (other.tag == "item")
            {
                itemCount++;
                audio.Play();
                other.gameObject.SetActive(false);
                Manager.GetItem(itemCount);

                if (itemCount == Manager.TotalItem)
                {
                    SceneManager.LoadScene("Example_1");
                }
            }
        }
      
    }
}
