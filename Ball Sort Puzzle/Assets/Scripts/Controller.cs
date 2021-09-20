using System;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
public class Controller : MonoBehaviour
{
    public static Controller Instance;

    public GameObject Tuble;
    public GameObject Btnext;
    int checkbtnext = 0;

    internal GameObject[] AllTube = new GameObject[10];
    public AudioClip addballclip;
    public AudioClip donetubleclip;
    public AudioSource audiosoure;
    
    public int[] random = new int[5];
    int[] checkselect;
    int vt1=-1;
    int vt2 = -2;
    int check = 0;
    internal void Start()
    {
      audiosoure= audiosoure.GetComponent<AudioSource>();
        checkselect = new int[10];

        Instance = this;
        Vector3 Poschange;
        float x = 0;

        for (int i = 0; i < 7; i++)
        {
            GameObject NTuble = Instantiate(Tuble, transform.position, Quaternion.identity);
            NTuble.tag = i.ToString();
            NTuble.GetComponent<Tube>().Create(i, i + 1);
            AllTube[i] = NTuble;

            x = 2.35f;

            Poschange.x = transform.position.x + x;
            Poschange.y = transform.position.y;
            Poschange.z = 0;
            transform.position = Poschange;

            //if (i == 4)
            //{
            //    Poschange.x = -2.59f;
            //    Poschange.y = -2.6f;
            //    Poschange.z = 0f;
            //    transform.position = Poschange;
            //}
        }
    }

    public void taotube()
    {
        SceneManager.LoadScene(0);

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
        AllTube[1].GetComponent<Tube>().xoa();
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
                if (check == 0)
                {
                    Debug.LogError("get vitri 1 len");
                    check =1;
                    vt1 = tubeselect;
                    audiosoure.clip = addballclip;
                    audiosoure.Play();
                    Getball(vt1);
                  
                   // addball.
                }
                else if(check ==1)
                 {
                    if (tubeselect == vt1)
                    {
                        Debug.LogError("ungetball");
                        audiosoure.clip = addballclip;
                        audiosoure.Play();
                        Ungetball(vt1);

                        check = 0;
                    }
                    else
                    {
                        vt2 = tubeselect;
                        if(AllTube[vt2].GetComponent<Tube>().balls.Count ==0||checktrucolor(vt1,vt2))
                         {
                           
                            if (AllTube[vt2].GetComponent<Tube>().balls.Count >= 4)
                            {
                                Debug.LogError("beacouse tube is full ");
                            }
                            else
                            {
                                check = 0;
                                Debug.LogError("di chuyen tu" + vt1 + "sang" + vt2);
                                audiosoure.clip = addballclip;
                                audiosoure.Play();
                                MoveBall(vt1, vt2);

                            }
                          
                            
                        }
                        else
                        {
                            audiosoure.clip = addballclip;
                            audiosoure.Play();
                            Ungetball(vt1);
                            Getball(vt2);
                            //vt1 = tubeselect;
                            vt1 = vt2;
                            check = 1;
                        }

                    }
                 }

            }

        }
    }
   
    void DeSelectAll()
    {
        for(int i=0;i<checkselect.Length ;i++ )
        {
            checkselect[i] = 0;
        }    
    }   
    bool checktrucolor(int ps1, int  ps2)
    {
        if(AllTube[ps2].GetComponent<Tube>().balls.Peek().color.tag.Equals(AllTube[ps1].GetComponent<Tube>().balls.Peek().color.tag))
        {
            return true;
        }
        return false;
    }    
    void Getball(int ps)
    {
        AllTube[ps].GetComponent<Tube>().GetBall();
    }
    void Ungetball(int ps)
    {
       AllTube[ps].GetComponent<Tube>().UngetBall();

    }
    bool checkfullsamecolor(int ps)
    {
        string stag = null;
        foreach (var item in AllTube[ps].GetComponent<Tube>().balls)
        {
            stag = stag + item.color.tag;
            
        }
        
        Debug.LogError(stag);
        int count = 0;
        for (int i = 0; i < stag.Length; i++)
        {
            Debug.LogError("string tag" + stag[i]);

            if (i == 1 || i == 3 || i == 5 | i == 7)
            {
                if (stag[i].Equals(stag[i + 2]))
                {
                    count++;
                    if (count == 3)
                    {
                        return true;
                    }
                }
                else
                {
                    Debug.LogError("khong cung tag" + stag[i] + stag[i + 1]);
                    return false;
                }
            }
        }
        return false;
    }    
    internal void MoveBall(int ps1, int ps2)
    {
        Vector3 vitritube2 = AllTube[ps2].transform.position;
        Vector3 change1 = new Vector3();
        change1.x = vitritube2.x;
        change1.y = vitritube2.y - 1.75f;
        change1.z = vitritube2.z;
        vitritube2 = change1;

        //   1.75
        // y=-0.27
        //-2.02
        if (AllTube[ps2].GetComponent<Tube>().balls.Count == 0)
        {
            Debug.LogError(" da them phan tu dau tien vao tube" + ps2);
            AllTube[ps2].GetComponent<Tube>().setBall(AllTube[ps1].GetComponent<Tube>().getBall());
            AllTube[ps1].GetComponent<Tube>().balls.Pop().color.transform.DOMove(vitritube2, 0.3f);
        }
       
        else
        {

            if (AllTube[ps2].GetComponent<Tube>().balls.Peek().color.tag.Equals(AllTube[ps1].GetComponent<Tube>().balls.Peek().color.tag))
            {
                int count = AllTube[ps2].GetComponent<Tube>().balls.Count;
                Debug.LogError("cung mau da them" + "tube" + ps1 + "vao tube" + ps2);
                AllTube[ps2].GetComponent<Tube>().setBall(AllTube[ps1].GetComponent<Tube>().getBall());
                Vector3 change = new Vector3();
                for (int i = 1; i < 4; i++)
                {
                    if (count == i)
                    {
                       
                        change.x = vitritube2.x;
                        change.y = vitritube2.y + 1.05f * i;
                        change.z = vitritube2.z;
                    }
                }
                vitritube2 = change;
                AllTube[ps1].GetComponent<Tube>().balls.Pop().color.transform.DOMove(vitritube2, 0.3f);
                if(AllTube[ps2].GetComponent<Tube>().balls.Count==4)
                {
                    if (checkfullsamecolor(ps2))
                    {
                      
                        audiosoure.clip = donetubleclip;
                        audiosoure.Play();
                        checkbtnext++;
                        if (checkbtnext == 5)
                        {
                            Btnext.SetActive(true);
                        }


                    }

                }
            }
          
        }

        DeSelectAll();
    }
}
