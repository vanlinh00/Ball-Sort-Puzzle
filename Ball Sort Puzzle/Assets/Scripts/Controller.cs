using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Tuble;
    GameObject[] Allball=new GameObject[10];
    void Start()
    {
    }
    public void taotube()
    {
        GameObject NTuble = Instantiate(Tuble, transform.position, Quaternion.identity);
        NTuble.GetComponent<Tube>().Create();
        Allball[1] = NTuble;
    }
    public void xoatube()
    {
        Allball[1].GetComponent<Tube>().xoa();
    }

    void Update()
    {
      
    }
}
