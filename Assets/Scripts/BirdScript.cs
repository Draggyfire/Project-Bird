using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flyStrength;
    public LogicScript logic;
    public LeatherSpawnScript leatherSpawn;

    private bool birdisAlive = true;
    private bool gameIsStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        leatherSpawn = GameObject.FindGameObjectWithTag("Leather").GetComponent<LeatherSpawnScript>();
        myRigidbody.gravityScale = 0;
    }

    public void startGame()
    {
        gameIsStarted = true;
    }
    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.Space) && birdisAlive)
        {
            if (!gameIsStarted)
            {
                myRigidbody.gravityScale = 4.5F;
            }
            myRigidbody.linearVelocity = Vector2.up * flyStrength;
        }

        if (Input.GetKeyDown(KeyCode.Mouse0) && birdisAlive)
        {
            if (!gameIsStarted)
            {
                myRigidbody.gravityScale = 4.5F;
            }
            // lancer la plume
            leatherSpawn.spawnLeather();
        }
        */
    }

    public void Jump()
    {
        if (birdisAlive)
        {
            if (!gameIsStarted)
            {
                myRigidbody.gravityScale = 4.5F;
            }
            myRigidbody.linearVelocity = Vector2.up * flyStrength;
        }
    }

    public void Shot()
    {
        if (birdisAlive)
        {
            if (!gameIsStarted)
            {
                myRigidbody.gravityScale = 4.5F;
            }
            // lancer la plume
            leatherSpawn.spawnLeather();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdisAlive = false;
    }


}
