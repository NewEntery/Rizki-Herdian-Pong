using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxController : MonoBehaviour
{
    //speed
    public float speed;
    //input
    public KeyCode Upkey;
    public KeyCode downkey;
    public Transform tranform;
    public Transform transform1;

    private float timer;

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
    
    public void activePowerUp_SP(float kecepatanpadel)
    {
        StartCoroutine(Start1(kecepatanpadel));
    }

    public void activePowerup_MP(float panjangpaddel)
    {
        StartCoroutine(start2(panjangpaddel));
    }
    IEnumerator Start1(float kecepatanpadel)
    {
        speed *= kecepatanpadel;
        yield return new WaitForSeconds(5f);
        speed /= kecepatanpadel;
    }
    IEnumerator start2(float panjangpaddel)
    {
        tranform.localScale *= panjangpaddel;
        yield return new WaitForSeconds(5f);
        tranform.localScale /= panjangpaddel;
    }
}
