using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesSpawner : MonoBehaviour
{
    public GameObject obstacle;
    public float spawnRate = 0.5f;
    private float timer = 0.0f;
    public float rightOffset;
    public float leftOffset;

    // Start is called before the first frame update
    void Start()
    {
        spawnObstacle();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else {
            spawnObstacle();
            timer = 0;
        }
    }

    void spawnObstacle()
    {
        float rightMax = transform.position.x + rightOffset;
        float leftMax = transform.position.x - leftOffset;
        Instantiate(obstacle, new Vector3(Random.Range(leftMax, rightMax), 0, transform.position.z), transform.rotation);
    }
}
