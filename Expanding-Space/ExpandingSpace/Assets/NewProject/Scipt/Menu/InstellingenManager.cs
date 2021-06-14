using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class InstellingenManager : MonoBehaviour
{
    public AudioMixer audiomixer;
    public void Volume(float volume)
    {
        audiomixer.SetFloat("Volume", volume);
    }
}
