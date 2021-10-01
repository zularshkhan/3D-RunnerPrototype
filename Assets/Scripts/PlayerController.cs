using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float movespeed=10f;
    private float speed = 10f;


    private void FixedUpdate()
    {

        float dir = Input.GetAxisRaw("Horizontal");

        transform.Translate(transform.right * dir * movespeed * Time.fixedDeltaTime);

        transform.Translate(transform.forward * speed * Time.fixedDeltaTime);
    }
}
