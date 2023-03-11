using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 6;
    private float horizontalInput;
    private float forwardInput;
    private float nextXPos;
    private float nextZPos;
    public LevelScript logic;
    public int lifes = 3;
    private bool gameOver;

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        logic = GameObject.FindGameObjectWithTag("LogicManager").GetComponent<LevelScript>();
        logic.setLifes(lifes);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (lifes < 1)
        {
            gameOver = true;
            logic.setGameOver();
        }
        else
        {
            lifes--;
            logic.setLifes(lifes);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            transform.Translate(Vector3.up * 50 * Time.deltaTime);
        }
        
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Forward");

        nextXPos = transform.position.x + horizontalInput * moveSpeed * Time.deltaTime;
        nextZPos = transform.position.z + forwardInput * moveSpeed * Time.deltaTime;

        if (nextXPos > -8.8 && nextXPos < 8.8)
        {
            transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * moveSpeed);
        }
        if (nextZPos < 12.0 && nextZPos > -4.0)
        {
            transform.Translate(Vector3.forward * forwardInput * moveSpeed * Time.deltaTime);
        }
    }
}
