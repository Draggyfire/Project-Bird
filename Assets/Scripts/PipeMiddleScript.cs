using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{

    public LogicScript logic;
    public LeatherSpawnScript leatherSpawn;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        leatherSpawn = GameObject.FindGameObjectWithTag("Leather").GetComponent<LeatherSpawnScript>();
        Debug.Log("Logic !");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logic.addScore(1);
            leatherSpawn.resetLeather();
        }
    }
}
