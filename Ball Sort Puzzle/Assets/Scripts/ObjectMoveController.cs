
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjectMoveController : MonoBehaviour
{

    public float force = 5;

    private void Update()
    { 

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null)
            {
                int x=  Int32.Parse(hit.collider.gameObject.tag);
                Debug.LogError(x);
             
                //BallController.Instance.getball(a);
                //Debug.Log(hit.collider.gameObject.name);
          
                //BallController.Instance.setball(a,b);
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
