using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] AllBall;
    

    void Start()
    {

    
    }

    // Update is called once per frame
    void Update()
    {
        ////int a = Random.RandomRange(0, 5);
        ////Debug.LogError(a);
        //Queue qt = new Queue();
        //qt.Enqueue(1);
        ////qt.Enqueue(1);
        ////qt.Enqueue(2);
        ////qt.Enqueue(3);
        //for(int i=0;i<qt.Count;i++)
        //{
        //    Debug.LogError(qt.Dequeue());
        //}    
        ////foreach (Object obj in qt)
        ////{
        ////    Debug.LogError(obj);
        ////}
        ///

    }
 public void setupball()
    {

        float y = 0;
        for (int i = 0; i < 4; i++)
        {
            int a = Random.RandomRange(0, 5);
            Stack stackball = new Stack();
            Vector3 change = new Vector3();
            change.x = transform.position.x;
            change.y = transform.position.y+y;
            change.z = transform.position.z;
            transform.position = change;
            GameObject obj = Instantiate(AllBall[a], transform.position, Quaternion.identity);
            y =1.05f;
            stackball.Push(obj);
        }
    }    
}
