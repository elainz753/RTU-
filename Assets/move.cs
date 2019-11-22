
using UnityEngine;

public class move : MonoBehaviour
{
    public int speed = 5;
    public GameObject player;
    public GameObject ball;

    void Start()
    {
    }
    
    void Update()
    {
      
        if (Input.GetKey(KeyCode.D))
        {
            ball.GetComponent<Rigidbody>().AddForce(player.transform.right * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            ball.GetComponent<Rigidbody>().AddForce(-player.transform.right * speed);
        }                                           
    }
}