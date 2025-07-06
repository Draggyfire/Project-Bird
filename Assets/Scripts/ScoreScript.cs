using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text textComponent;

    // Start is called before the first frame update
    void Start()
    {
        textComponent = GetComponent<Text>();
        textComponent.enabled = false;
    }

    public void MakeTextVisible()
    {
        textComponent.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
