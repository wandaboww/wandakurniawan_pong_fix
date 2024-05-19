using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector2 speed;
    public Vector2 resetPosition;
    public Rigidbody2D paddle1;
    public Rigidbody2D paddle;
    private Rigidbody2D rig;
    public bool lasthit;
    public bool lasthit1;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
    }

    public void ResetBall()
    {
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 2);
    }

    public void ActivePUSpeedUp(float magnitude)
    {
        rig.velocity *= magnitude;
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("paddle")){
            lasthit = true;
            lasthit1 = false;
            Debug.Log("kena kanan");
        } else if(collision.gameObject.CompareTag("paddle1")) {
            lasthit1 = true;
            lasthit = false;
            Debug.Log("kena kiri");
        }
    }
    
}
