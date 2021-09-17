using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public static Controller Instance;
    public GameObject Tuble;
    GameObject[] Allball=new GameObject[10];
    public int[] random = new int[5];
    void Start()
    {

    }
    public void taotube()
    {


        Instance = this;
        Vector3 Poschange;
        float x = 0;

        for (int i = 0; i < 7; i++)
        {
            GameObject NTuble = Instantiate(Tuble, transform.position, Quaternion.identity);
            NTuble.tag = i.ToString();
            NTuble.GetComponent<Tube>().Create();
            Allball[i] = NTuble;

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
    public void xoatube()
    {
        Allball[1].GetComponent<Tube>().xoa();
    }

    void Update()
    {
      
    }
}
