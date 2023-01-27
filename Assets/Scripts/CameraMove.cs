using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject objectBall;
    private Vector3 inicialPosition;

    // Start is called before the first frame update
    void Start()
    {
      inicialPosition = transform.position - objectBall.transform.position ;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = objectBall.transform.position + inicialPosition;
    }
}
