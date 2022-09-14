using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp_MP : MonoBehaviour
{
    public PowerupManager manager;
    public Collider2D ball;
    public GameObject paddel;
    public float panjangpaddel;
    private void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            paddel.transform.localScale = new Vector3(1, 5, 1);
           
            Destroy(gameObject);
            

        }
    }
}
