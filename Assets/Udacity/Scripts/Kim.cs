using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class Kim : MonoBehaviour
{

    public GameObject kkhair;
    public AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    public void speakKim()
    {
        audio.Play();
    }
}