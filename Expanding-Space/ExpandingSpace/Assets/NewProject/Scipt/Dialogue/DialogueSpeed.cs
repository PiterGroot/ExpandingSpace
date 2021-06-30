using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueSpeed : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetFloat("DialogueSpeed", 0.05f);
    }
}
