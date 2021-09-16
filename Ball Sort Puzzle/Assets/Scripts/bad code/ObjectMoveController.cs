
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjectMoveController : MonoBehaviour
{

    public float force = 5;
    bool[] checkmove= new bool[10];
    private void Update()
    { 

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null)
            {
                int checkfullmove=0;
                int po1=-1;
                int po2=-1;
                int x=  Int32.Parse(hit.collider.gameObject.tag);
                Debug.LogError(x);
                checkmove[x] = true;

                for (int i=0;i<7 ;i++ )
                {
                   if(checkmove[i]==true)
                    {
                        checkfullmove++;
                        if(checkfullmove==1)
                        {
                            po1 = i;
                            BallController.Instance.GetballMove(po1);

                        }
                        if(checkfullmove==2)
                        {
                            po2 = i;
                        }    
                     }
                }
                if(checkfullmove==2)
                {
                    Debug.Log("vi tri move cua vt1 va vt2: la "+po1+"va"+po2);
                    BallController.Instance.Moveball(po1, po2);
                    checkmove[po1] = false;
                    checkmove[po2] = false;
                    checkfullmove = 0;
                }
            }
        }
    }

    private void PrintName(GameObject go)
    {
        print(go.name);
    }

    private void LaunchIntoAir(Rigidbody rig)
    {
        rig.AddForce(rig.transform.up * force, ForceMode.Impulse);
    }

}
