using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private GameObject player;


    private void FixedUpdate()
    {

        if(player == null)
        {
            transform.position = transform.position;
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, target.position.z - 7);
        }

    }


}
