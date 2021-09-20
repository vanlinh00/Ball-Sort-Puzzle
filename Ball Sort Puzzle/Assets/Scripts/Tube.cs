using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Tube : MonoBehaviour
{
    public Stack<Ball> balls;

    public GameObject[] allBall;
  
    internal void Start()
    {
    }

    public void Create(int deball, int nextdeball)
    { 
        float y2 = 1.75f;
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
                change.y = tagert.y + y - y2;
                change.z = tagert.z;
                tagert = change;

                GameObject objectball = Instantiate(allBall[b], tagert, Quaternion.identity);

                //  Debug.LogError("romdom mau bong" + b);
                a.color = objectball;

                balls.Push(a);
                y = 1.05f;
                y2 = 0;

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
        change.x = balls.Peek().color.transform.position.x;
        change.y = balls.Peek().color.transform.position.y + 2f;
        change.z = balls.Peek().color.transform.position.z;
        balls.Peek().color.transform.position = change;
        return balls.Peek();
    }
    public void GetBall()
    {
        Vector3 change = new Vector3();
        change.x = balls.Peek().color.transform.position.x;
       // change.y = 2.68f;
        change.y = 3.23f;
        change.z = balls.Peek().color.transform.position.z;
        balls.Peek().color.transform.DOMove(change, 0.3f);
    }    

    public void UngetBall()
    {
        Vector3 change = new Vector3();
        if (balls.Count == 1)
        {
            change.x = balls.Peek().color.transform.position.x;
            change.y = balls.Peek().color.transform.position.y - 1.05f * 5;
            change.z = balls.Peek().color.transform.position.z;
        }
        if (balls.Count == 2)
        {
            change.x = balls.Peek().color.transform.position.x;
            change.y = balls.Peek().color.transform.position.y - 1.05f * 4;
            change.z = balls.Peek().color.transform.position.z;
        }
        if (balls.Count == 3)
        {
            change.x = balls.Peek().color.transform.position.x;
            change.y = balls.Peek().color.transform.position.y - 1.05f * 3;
            change.z = balls.Peek().color.transform.position.z;
        }
        if (balls.Count == 4)
        {
            change.x = balls.Peek().color.transform.position.x;
            change.y = balls.Peek().color.transform.position.y - 1.05f * 2;
            change.z = balls.Peek().color.transform.position.z;
        }
        balls.Peek().color.transform.DOMove(change, 0.3f);

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
