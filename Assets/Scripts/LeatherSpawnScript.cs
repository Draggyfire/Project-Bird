using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeatherSpawnScript : MonoBehaviour
{
    public GameObject leather;
    public int maxNumberPerPoint=5;
    public int cpt;

    // Start is called before the first frame update
    void Start()
    {
        cpt = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void resetLeather()
    {
        cpt = 0;
    }

    public void spawnLeather()
    {
        if(cpt < maxNumberPerPoint)
        {
            Quaternion rotation = Quaternion.Euler(0, 0, -50F);
            Instantiate(leather, new Vector3(transform.position.x, transform.position.y, 0), rotation);
            cpt++;
        }
        
    }
}
