using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp_MPKanan : MonoBehaviour
{
    public PowerupManager manager;
    public Collider2D ball;
    
    public GameObject paddel1;
    public float panjangpaddel;

    private void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            paddel1.GetComponent<boxController>().activePowerup_MP(panjangpaddel);

            Destroy(gameObject);


        }
    }
}
