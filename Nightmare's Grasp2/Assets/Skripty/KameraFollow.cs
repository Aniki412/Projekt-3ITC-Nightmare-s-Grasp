using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraFollow : MonoBehaviour
{
    public Transform hrac;  
    public Vector3 offset;
    public float zpomaleni = 0.125f;  

    void LateUpdate()
    {
        if (hrac != null)
        {
            Vector3 pozice= hrac.position + offset;
            Vector3 prechod= Vector3.Lerp(transform.position, pozice, zpomaleni);
            transform.position = prechod;
        }
    }
}
