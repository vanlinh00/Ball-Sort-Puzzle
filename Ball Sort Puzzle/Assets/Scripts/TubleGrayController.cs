using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubleGrayController : MonoBehaviour
{
    public static TubleGrayController Intansce;
    public GameObject TubleGray;
    // GameObject[] AllTubleGray = new GameObject[10];

    //  List<GameObject[]> arrayList = new List<GameObject[]>();
 public   List<GameObject> arrayList = new List<GameObject>();
    // int[] a;
    void Start()
       // 3.35
    {
        Intansce = this;
        Vector3 Poschange;
        float x = 0;
       
        for (int i=0;i<7 ;i++ )
        {


//           AllTubleGray[i]= Instantiate(TubleGray, transform.position, Quaternion.identity);

         

            GameObject obj=Instantiate(TubleGray, transform.position, Quaternion.identity);
            arrayList.Add(obj);

        x = 3.35f;

            Poschange.x = transform.position.x + x;
            Poschange.y = transform.position.y;
            Poschange.z = 0;
            transform.position = Poschange;

            if (i == 4)
            {
                Poschange.x = -7.3f;
                Poschange.y = -5.65f;
                Poschange.z = 0f;
                transform.position = Poschange;
            }
           

        }
    }
    public List<GameObject> getArraylist()
    {
        return arrayList;
    }    

    // Update is called once per frame
    void Update()
    {
        
    }
}
