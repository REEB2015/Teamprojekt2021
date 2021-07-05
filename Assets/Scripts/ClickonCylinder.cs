using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickonCylinder : MonoBehaviour
{

    void Update()
  {
         //Check for mouse click 
         if (Input.GetMouseButtonDown(0))
         {
             RaycastHit hit;
             Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
             if (Physics.Raycast(ray, out hit, 100.0f))
             {
                 if (hit.transform)
                 {
                     PrintName(hit.transform.gameObject);
                    //Our custom method. 
                     //CurrentClickedGameObject(hit.transform.gameObject);
                 }
             }
         }
         

  }

  private void PrintName(GameObject go)
  {
      print(go.name);
  }
  private void CurrentClickedGameObject(GameObject gameObject)
 {
     if(gameObject.tag== "SliderCylinder")
     {
         gameObject.GetComponent<MeshRenderer>().material.color = Color.cyan;
     }
 }

    // void Update()
    // {
    //     if(Input.GetMouseButtonDown(0))
    //     {
    //         Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    //         RaycastHit hit;
    //         if(Physics.Raycast(ray, out hit))
    //         {
    //             if(hit.transform.name == "Cylinder")
    //             {
    //                 this.GetComponent<MeshRenderer>().material.color = Color.cyan;
    //             }
    //         }
    //     }
    // }
}
