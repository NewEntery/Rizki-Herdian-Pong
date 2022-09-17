using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp_Speed_Controler : MonoBehaviour
{
    public PowerupManager manager;
    public Collider2D ball;
    public float magnitude;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            ball.GetComponent<BallControler>().activePowerupSpeed(magnitude);
            manager.Removepowerup(gameObject);
        }
    }
    
}