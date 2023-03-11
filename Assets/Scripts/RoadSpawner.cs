using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSpawner : MonoBehaviour
{
    public GameObject roadObject;
    public float timeBetween = 2;
    private float timer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        float roadSpeed = roadObject.GetComponent<Road>().speed;
        Debug.Log(roadSpeed);
        spawnRoad();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < timeBetween)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnRoad();
            timer = 0;
        }
    }

    private void spawnRoad()
    {
        Instantiate(roadObject, transform.position, transform.rotation);
    }
}
