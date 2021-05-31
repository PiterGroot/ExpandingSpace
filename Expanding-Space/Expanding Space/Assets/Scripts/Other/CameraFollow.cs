using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject ObjToFollow;
    public int Zscale;
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(ObjToFollow.transform.position.x, ObjToFollow.transform.position.y, Zscale);
    }
}
