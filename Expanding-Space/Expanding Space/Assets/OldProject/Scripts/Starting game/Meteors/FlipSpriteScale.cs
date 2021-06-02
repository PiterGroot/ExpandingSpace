using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipSpriteScale : MonoBehaviour
{
    private float xWitdh;
    private float xScale;

    private void Start() {
        xWitdh = gameObject.transform.localScale.x;
        xScale = xWitdh;
    }
    public void FlipRight(){
      xWitdh = -xScale;  
    }
    public void FlipLeft(){
      xWitdh = xScale;
    }
    private void Update() {
       transform.localScale = new Vector3(xWitdh, transform.localScale.y, transform.localScale.z);
    }
}
