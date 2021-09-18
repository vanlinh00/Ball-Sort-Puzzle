using UnityEngine;
using System;
public class Controller : MonoBehaviour
{
    public static Controller Instance;

    public GameObject Tuble;

    internal GameObject[] Allball = new GameObject[10];

    public int[] random = new int[5];

    internal void Start()
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
            NTuble.GetComponent<Tube>().Create(i, i + 1);
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

    public void testrandom()
    {
        for (int i = 0; i < random.Length; i++)
        {
            Debug.LogError("ball thu" + i + "da xuat hieen" + random[i] + "lan");
        }
    }

    public void xoatube()
    {
        Allball[1].GetComponent<Tube>().xoa();
    }

    internal void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null)
            {
                int tubeselect = Int32.Parse(hit.collider.gameObject.tag);
                Debug.LogError("tubleselect is" + tubeselect);
                MoveBall(tubeselect, 2);  
              
            }

        }
    }
    void MoveBall(int ps1,int ps2)
    {
        Allball[ps1].GetComponent<Tube>().balls.Peek().color.transform.position = Allball[ps2].GetComponent<Tube>().balls.Peek().color.transform.position;


        Allball[ps2].GetComponent<Tube>().setBall(Allball[ps1].GetComponent<Tube>().getBall());
    }
    
}



