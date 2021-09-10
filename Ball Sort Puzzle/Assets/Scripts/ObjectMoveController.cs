
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjectMoveController : MonoBehaviour
{

    public float force = 5;

    private void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        // //   Debug.LogError("da tim thay ");

        //    RaycastHit hit;
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //    if (Physics.Raycast(ray, out hit, 100.0f))
        //    {
        //        if (hit.transform != null)
        //        {
        //            Debug.LogError("da tim thay ");

        //            //Rigidbody rb;

        //            //if (rb = hit.transform.GetComponent<Rigidbody>())
        //            //{
        //            //    PrintName(hit.transform.gameObject);
        //            //    LaunchIntoAir(rb);
        //            //}
        ////        }
        ////    }
        //}

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null)
            {
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
