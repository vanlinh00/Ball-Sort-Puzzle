using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
  public  GameObject Tuble;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i=0;i<7;i++ )
        {
             Instantiate(Tuble, transform.transform.position, Quaternion.identity);
           
        }    
    }
}
