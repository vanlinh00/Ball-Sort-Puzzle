using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubleGrayController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject TubleGray;
    public Transform target;
    void Start()
    {
        int x = 0;
        for(int i=0;i<7 ;i++ )
        {
           Instantiate(TubleGray, target.position, Quaternion.identity);
            Vector3 test = new Vector3(1, 2, 3);
            target.position = test;
        }    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
