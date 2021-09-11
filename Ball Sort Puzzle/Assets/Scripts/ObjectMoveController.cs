﻿
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
                //if (hit.collider.gameObject.tag.Equals("0"))
                //{
                //    BallController.Instance.getball(0);

                //}
                //BallController.Instance.getball(hit.collider.gameObject.tag);

              int x=  Int32.Parse(hit.collider.gameObject.tag);
                BallController.Instance.getball(x);
                Debug.Log(hit.collider.gameObject.name);
            //    hit.collider.attachedRigidbody.AddForce(Vector2.up);
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
