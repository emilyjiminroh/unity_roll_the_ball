using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main_camera : MonoBehaviour
{
    Transform playerT;
    Vector3 Offset;

    void Awake()
    {
        playerT = GameObject.FindGameObjectWithTag("Player").transform;
        Offset = transform.position - playerT.position;
    }

    
    void LateUpdate()
    {
        transform.position = playerT.position + Offset + Offset;
    }
}
