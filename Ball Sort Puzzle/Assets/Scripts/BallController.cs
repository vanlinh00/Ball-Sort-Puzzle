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
    List<GameObject> Myball = new List<GameObject>();
    public void setupball()
    {
        //    Stack stackball = new Stack();
        //  GameObject[] stackclone = new GameObject[4];
        Vector3 target = TubleGrayController.Intansce.arrayList[0].transform.position;

        float y = 0;
        for (int i = 0; i < 4; i++)
        {
            int a = Random.RandomRange(0, 5);
           
            Vector3 change = new Vector3();
            change.x = target.x;
            change.y = target.y + y;
            change.z = target.z;
            target = change;

            /*   GameObject obj = Instantiate(AllBall[a], transform.position, Quaternion.identity);        */      /// bug cái này sinh ra tại bên trong cái bình cơ
            GameObject obj = Instantiate(AllBall[a],target, Quaternion.identity);
            Myball.Add(obj);
         //   stackclone[i] = obj;
            y =1.05f;
          //  stackball.Push(obj);
        }
        /*     GameObject de =*/ //stackball.Pop();

        //   Destroy(stackclone[2]);
    //  Destroy(Myball[0]);
    }   
    //    public void setupball()
    //{
    ////    Stack stackball = new Stack();
    //  //  GameObject[] stackclone = new GameObject[4];
       
    //    float y = 0;
    //    for (int i = 0; i < 4; i++)
    //    {
    //        int a = Random.RandomRange(0, 5);
           
    //        Vector3 change = new Vector3();
    //        change.x = transform.position.x;
    //        change.y = transform.position.y+y;
    //        change.z = transform.position.z;
    //        transform.position = change;

    //        /*   GameObject obj = Instantiate(AllBall[a], transform.position, Quaternion.identity);        */      /// bug cái này sinh ra tại bên trong cái bình cơ
    //        GameObject obj = Instantiate(AllBall[a], TubleGrayController.Intansce.arrayList[0].transform.position, Quaternion.identity);
    //        Myball.Add(obj);
    //     //   stackclone[i] = obj;
    //        y =1.05f;
    //      //  stackball.Push(obj);
    //    }
    //    /*     GameObject de =*/ //stackball.Pop();

    //    //   Destroy(stackclone[2]);
    ////  Destroy(Myball[0]);
    //}
    public void getball()
    {

        Vector3 change = new Vector3();
        change.x = Myball[3].transform.position.x;
        change.y = Myball[3].transform.position.y + 2f;
        change.z = Myball[3].transform.position.z;
        Myball[3].transform.position = change;

        Destroy(Myball[3], 3f);
      //  Debug.LogError(Myball[3].transform.position.x);
    }    
}
