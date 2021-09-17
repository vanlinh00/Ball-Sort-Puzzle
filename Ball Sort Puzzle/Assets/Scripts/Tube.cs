using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tube : MonoBehaviour
{

    public Stack<Ball> balls;
    public GameObject[] allBall;
    void Start()
    {
       
    }
    public void Create()
    {
        balls = new Stack<Ball>(4);
        for (int i = 0; i < 4; i++)
        {
            Ball a = new Ball();
            GameObject objectball = Instantiate(allBall[i], transform.position, Quaternion.identity);
            a.color = objectball;
            balls.Push(a);
        }
    
    }
    public void xoa()
    {
        Destroy(balls.Pop().color);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
