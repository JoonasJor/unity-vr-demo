using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnItem : MonoBehaviour
{
    Transform startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = gameObject.transform;
        Debug.Log(startPos.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.y < -2)
        {
            transform.position = new Vector3(startPos.position.x, startPos.position.y, startPos.position.z);
            Debug.Log(gameObject.transform.position.y);
        }
        
    }
}
