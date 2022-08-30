using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreControl : MonoBehaviour
{
    // Start is called before the first frame update
    public Text scoreRight;
    public Text scoreLeft;
    public ScoreManager manager;
    // Update is called once per frame
    private void Update()
    {
        scoreRight.text = manager.rightScore.ToString();
        scoreLeft.text = manager.leftScore.ToString();
    }
}
