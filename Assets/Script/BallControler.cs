using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControler : MonoBehaviour
{
    public Vector2 speed;
    public Vector2 resetposition;

    private Rigidbody2D rig;
    
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
    }

    public void Resetball()
    {
        transform.position = resetposition;    
    }
   
}
