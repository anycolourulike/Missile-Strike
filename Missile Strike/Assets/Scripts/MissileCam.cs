using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileCam : MonoBehaviour
{
   [SerializeField] Camera cam; 
   [SerializeField] Transform target;   

   void Update()
   {
      cam.transform.LookAt(target);
   }    
}
