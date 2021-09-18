using System.Collections.Generic;
using UnityEngine;
public class Tube : MonoBehaviour
{
    public Stack<Ball> balls;

    public GameObject[] allBall;

    internal void Start()
    {
    }

    public void Create(int deball, int nextdeball)
    {
        //balls = new Stack<Ball>(4);
        //for (int i = 0; i < 4; i++)
        //{

        //    Ball a = new Ball();
        //    GameObject objectball = Instantiate(allBall[i], transform.position, Quaternion.identity);
        //    a.color = objectball;
        //    balls.Push(a);
        //}
      
        float z = 1.37f;
        balls = new Stack<Ball>(4);
        float y = 0;
        Vector3 tagert = transform.position;


        if (deball!=5&& nextdeball!=6&&nextdeball!=7)
        {
            for (int i = 0; i < 4; i++)
            {
                Ball a = new Ball();
                int b = random();
                Vector3 change = new Vector3();

                change.x = tagert.x;
                change.y = tagert.y + y - z;
                change.z = tagert.z;
                tagert = change;

                GameObject objectball = Instantiate(allBall[b], tagert, Quaternion.identity);

                //  Debug.LogError("romdom mau bong" + b);
                a.color = objectball;

                balls.Push(a);
                y = 1.05f;
                z = 0;

            }
        }
    }
    int random()
    {
        int b=-1;
        int run = 1;
        while (run==1)
        {
            b = Random.Range(0, 5);
            Controller.Instance.random[b]++;
            if(Controller.Instance.random[b]<=4)
            {
                run = 0;
            }
        }
        return b;
    }
    public void xoa()
    {
        // Destroy(balls.Pop().color);
      
    }
    public Ball getBall()
    {
        Vector3 change = new Vector3();
        change.x = balls.Pop().color.transform.position.x;
        change.y = balls.Pop().color.transform.position.y + 2f;
        change.z = balls.Pop().color.transform.position.z;
        balls.Pop().color.transform.position = change;
        return balls.Pop();
    }
    public void setBall(Ball newball)
    {
        balls.Push(newball);
    }

    public void DeleteAllBall()
    {
       while(balls.Count!=0)
        {
            Destroy(balls.Pop().color);
        }
    }
    internal void Update()
    {
       
    }
}
