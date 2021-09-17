using System.Collections.Generic;
using UnityEngine;
public class Tube : MonoBehaviour
{
    public Stack<Ball> balls;

    public GameObject[] allBall;

    internal void Start()
    {
    }

    public void Create()
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
        int rando = 1;

        int b=0;
        for (int i = 0; i < 4; i++)
        {
            Ball a = new Ball();
            while (rando == 1)
            {
                b = Random.RandomRange(0, 5);  //0-4
                Debug.LogError("_______________random______" + b);
              
                Debug.LogError( Controller.Instance.random[b]);
                Controller.Instance.random[b]++;
                if (Controller.Instance.random[b] < 4)
                {
                    rando = 0;
                }
               
            }
            Vector3 change = new Vector3();

            change.x = tagert.x;
            change.y = tagert.y + y - z;
            change.z = tagert.z;
            tagert = change;

            GameObject objectball = Instantiate(allBall[b], tagert, Quaternion.identity);
            rando = 1;
          //  Debug.LogError("romdom mau bong" + b);
            a.color = objectball;

            balls.Push(a);
            y = 1.05f;
            z = 0;

        }
    }

    public void xoa()
    {
        Destroy(balls.Pop().color);
    }

    internal void Update()
    {
    }
}
