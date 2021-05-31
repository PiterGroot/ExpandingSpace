using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBG : MonoBehaviour
{
    public float Scrollspeed = 2;
    public Renderer bgRend;

    // Update is called once per frame
    void Update()
    {
        bgRend.material.mainTextureOffset += new Vector2(Scrollspeed * Time.deltaTime, 0f);
    }
}
