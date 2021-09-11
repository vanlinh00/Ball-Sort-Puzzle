using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    // Start is called before the first frame update
    public static BallController Instance;
    public GameObject[] AllBall;
   // public  List<GameObject> Myball = new List<GameObject>();
    public GameObject[,] Myball1;
  
    void Start()
    {
        Instance = this;
       
    }

    // Update is called once per frame
    void Update()
    { 

    }
   
    public void setupball()
    {
        Myball1 = new GameObject[5, 4];
      
        Vector3 target;
        float y = 0;
        for (int i=0;i<5 ;i++ )
        {
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
                Myball1[i,j] = obj;
                y = 1.05f;
              
            }
          
        }

    }
    public void getball()
    {

        Vector3 change = new Vector3();
        change.x = Myball1[2, 3].transform.position.x;
        change.y = Myball1[2, 3].transform.position.y + 2f;
        change.z = Myball1[2, 3].transform.position.z;
        Myball1[2,3].transform.position = change;

        Destroy(Myball1[2, 3], 3f);
      //  Debug.LogError(Myball[3].transform.position.x);
    }    
}
