using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlatform : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "platform")
        {
            transform.parent = other.transform;

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("platform"))
        {
            transform.parent = null;

        }
    }
}
