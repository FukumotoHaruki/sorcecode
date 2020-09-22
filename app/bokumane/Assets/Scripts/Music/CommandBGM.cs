using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandBGM : MonoBehaviour
{
    public AudioSource AS;
    public AudioClip A;
    public AudioClip B;
    public AudioClip C;
    public AudioClip D;

    public void OnClick1()
    {
        AS.PlayOneShot(A);
    }

    public void OnClick2()
    {
        AS.PlayOneShot(B);
    }

    public void OnClick3()
    {
        AS.PlayOneShot(C);
    }

    public void OnClick4()
    {
        AS.PlayOneShot(D);
    }

    void Start()
    {
        AS = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {

    }
}
