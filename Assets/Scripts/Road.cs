using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    public float speed = 10;
    public float deadZone = -30;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.back * speed) * Time.deltaTime;
        if (transform.position.z < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
