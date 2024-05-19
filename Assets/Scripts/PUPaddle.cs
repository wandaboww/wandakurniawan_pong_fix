using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUPaddle : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    public Collider2D paddle;
    public Collider2D paddle1;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            paddle.GetComponent<PaddleController>().ActivePUSpeedUp(speed);
            manager.RemovePowerUp(gameObject);
        }
        if(collision.gameObject.CompareTag("paddle") && collision == ball){
            
            Debug.Log("kena kanan");
            paddle.GetComponent<PaddleController>().ActivePUSpeedUp(speed);
            manager.RemovePowerUp(gameObject);
        } else if(collision.gameObject.CompareTag("paddle1")  && collision == ball) {
            
            Debug.Log("kena kiri");
            paddle1.GetComponent<PaddleKiri>().ActivePUSpeedUp(speed);
            manager.RemovePowerUp(gameObject);
        }
    }
}
