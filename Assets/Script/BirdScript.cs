using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float FlapStrength;
    public LogicScript logic;
    public bool BirdisAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space) == true && BirdisAlive)
        { 
            myRigidbody.velocity = Vector2.up * FlapStrength;
        }
        CheckHeight(transform.position.y);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        BirdisAlive = false;
    }

    private void CheckHeight(float BirdHeight)
    {
        if (-14.5 > BirdHeight || BirdHeight > 14.5)
        {
            logic.GameOver();
            BirdisAlive = false;
        }
    }

}

