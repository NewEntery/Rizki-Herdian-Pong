using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxControllet : MonoBehaviour
{
    //speed
    public int speed;
    //input
    public KeyCode Upkey;
    public KeyCode downkey;

    //rigbody
    private Rigidbody2D rig;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = Vector2.zero;
        // getinput
        if (Input.GetKey(Upkey))
        {
            movement = Vector2.up * speed;
        }
        else if (Input.GetKey(downkey))
        {
            movement = Vector2.down * speed;
        }
        rig.velocity = movement;
    }
}