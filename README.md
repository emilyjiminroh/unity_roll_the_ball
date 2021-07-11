# unity_roll_the_ball_item

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_r : MonoBehaviour
{

    public float rotateSpeed;
    
    void Update()
    {
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime, Space.World);
    }

   
}
