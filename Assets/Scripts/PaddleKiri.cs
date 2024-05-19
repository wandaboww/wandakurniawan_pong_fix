using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleKiri : MonoBehaviour
{
    public float speed1;
    public KeyCode upkey;
    public KeyCode downkey;
    private Rigidbody2D rig;


    // Start is called before the first frame update
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        //gerakan objek pake input
        MoveObject(GetInput());
    }

    public Vector2 GetInput()
    {
        if (Input.GetKey(upkey))
        {
            return Vector2.up * speed1;
        }
        else if (Input.GetKey(downkey))
        {
            return Vector2.down * speed1;
        }

        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement)
    {
        //gerakan objek pake input
        rig.velocity = movement;
    }

    public void ActivePUSpeedUp(float speed)
    {
        speed1 *= speed;
    }
}

