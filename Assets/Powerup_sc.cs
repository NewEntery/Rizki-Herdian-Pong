using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup_sc : MonoBehaviour
{
    public PowerupManager manager;
    public Collider2D ball;

    public GameObject paddel1;
    public float kecepatanpadel;

    private void Start()
    {

    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            paddel1.GetComponent<boxController>().activePowerUp_SP(kecepatanpadel);
            Destroy(gameObject);


        }
    }
}
