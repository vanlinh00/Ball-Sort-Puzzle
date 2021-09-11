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

 

 ///   List<int> aa = new List<int>[100];

    List<List<GameObject>> Listjar = new List<List<GameObject>>();
    
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
      //  Myball1 = new GameObject[5, 4];
      
        Vector3 target;
        float y = 0;
        for (int i=0;i<5 ;i++ )
        {
            Listjar[i] = new List<GameObject>();

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

                //Myball1[i,j] = obj;

                Listjar[i].Add(obj);

                y = 1.05f;
              
            }
          
        }

    }
    public void getball(int numberjar)
    {

        //Vector3 change = new Vector3();
        //change.x = Myball1[TubleGaray, 3].transform.position.x;
        //change.y = Myball1[TubleGaray, 3].transform.position.y + 2f;
        //change.z = Myball1[TubleGaray, 3].transform.position.z;
        //Myball1[TubleGaray, 3].transform.position = change;

        //Destroy(Myball1[TubleGaray, 3], 3f);

        GameObject a1;
        Vector3 change = new Vector3();
        change.x = Listjar[numberjar][Listjar[numberjar].Count].transform.position.x;
        change.y = Listjar[numberjar][Listjar[numberjar].Count].transform.position.y + 2f;
        change.z = Listjar[numberjar][Listjar[numberjar].Count].transform.position.z;
        Listjar[numberjar][Listjar[numberjar].Count].transform.position = change;


        //  Debug.LogError(Myball[3].transform.position.x);

    }
}
