using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    void Start()
    {
        Invoke("DestroyObject", 0.35f);
    }
     
    void DestroyObject()
    {
        Destroy(this.gameObject);
    }
}
