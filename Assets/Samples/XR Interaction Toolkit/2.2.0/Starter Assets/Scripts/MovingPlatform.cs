using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Transform targetA, targetB;
    [SerializeField] private float speed = 0.05f; //Change this to suit your game.
    private bool switching = false;
    void Update()
    {
        if (!switching)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetA.position, speed * Time.deltaTime);
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
        }
    }
}
