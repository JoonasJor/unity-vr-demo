using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatThing : MonoBehaviour
{
    [SerializeField] private Transform targetA, targetB;
    [SerializeField] private Transform ball;
    private Vector3 ballStartPos;
    [SerializeField] private Rigidbody ballRb;
    [SerializeField] private float ballForce;
    [SerializeField] private float speed = 0.05f; //Change this to suit your game.
    private bool switching = false;
    private bool hit = false;

    private void Start()
    {
        ballStartPos = ball.position;
    }
    void Update()
    {
        if (!switching && hit)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetA.position, speed * Time.deltaTime * 50f);
        }
        else if (switching)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetB.position, speed * Time.deltaTime);
        }
        if (transform.position == targetA.position)
        {
            switching = true;
        }
        else if (transform.position == targetB.position)
        {
            switching = false;
            hit = false;
        }

        if(Vector3.Distance(ball.position, ballStartPos) > 50f)
        {
            ballRb.velocity = Vector3.zero;
            ball.position = ballStartPos;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("bat") && !hit)
        {
            hit = true;
            ballRb.AddForce(new Vector3(0, ballForce, 0), ForceMode.Impulse);
        }
    }
}
