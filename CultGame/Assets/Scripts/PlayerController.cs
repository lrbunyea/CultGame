using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    [SerializeField] float speed;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
            anim.SetBool("isMoving", true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetBool("isMoving", false);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            anim.SetBool("isMoving", true);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            anim.SetBool("isMoving", false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
            anim.SetBool("isMoving", true);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            anim.SetBool("isMoving", false);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            anim.SetBool("isMoving", true);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            anim.SetBool("isMoving", false);
        }
    }
}
