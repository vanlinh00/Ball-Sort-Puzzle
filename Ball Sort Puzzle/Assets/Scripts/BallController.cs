﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    // Start is called before the first frame update
    public static BallController Instance;
    public GameObject[] AllBall;
   // public  List<GameObject> Myball = new List<GameObject>();
    public GameObject[,] Myball1;
    List<GameObject>[] test = new List<GameObject>[100];
 
    
    void Start()
    {
        Instance = this;
      

    
        
    }

    void Update()
    {
   
    }
   
    public void setupball()
    {
 
      
        Vector3 target;
        float y = 0;
        for (int i=0;i<5 ;i++ )
        {
            test[i] = new List<GameObject>();
            
            target = TubleGrayController.Instance.arrayList[i].transform.position;
            target.y = target.y - 1.65f;
            y = 0;
            for (int j = 0; j < 4; j++)
            {
                int b = Random.RandomRange(0, 5);

                Vector3 change = new Vector3();
                change.x = target.x;
                change.y = target.y + y;
                change.z = target.z;
                target = change;
                GameObject obj = Instantiate(AllBall[b], target, Quaternion.identity);
                test[i].Add(obj);
                y = 1.05f;
              
            }
          
        }
        test[5] = new List<GameObject>();
        test[6] = new List<GameObject>();

    }
    public void getball(int numberjar)
    {
        Vector3 change = new Vector3();
        change.x = test[numberjar][(test[numberjar].Count - 1)].transform.position.x;
        change.y = test[numberjar][(test[numberjar].Count - 1)].transform.position.y + 2f;
        change.z = test[numberjar][(test[numberjar].Count - 1)].transform.position.z;
        test[numberjar][(test[numberjar].Count - 1)].transform.position = change;
        Debug.LogError((test[numberjar][(test[numberjar].Count-1)]).transform.position.x);
       // Destroy(test[numberjar][(test[numberjar].Count - 1)], 1f);
        test[numberjar].Remove(test[numberjar][(test[numberjar].Count - 1)]);
    }
    public void setball(int tonumberjar)
    {

    }    
}
