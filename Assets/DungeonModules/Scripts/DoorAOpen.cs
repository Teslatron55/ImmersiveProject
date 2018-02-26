using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAOpen : MonoBehaviour
{
    public Animator anim;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnTriggerEnter(Collider other)
    {
        // GetComponent<Animator>().SetTrigger("DoorATrigger");
        anim.SetTrigger("DoorATrigger");

    }

    void OnTriggerExit(Collider other)
    {
        // GetComponent<Animator>().SetTrigger("DoorATrigger");
        anim.speed = -1;
        anim.SetTrigger("DoorATrigger");

    }

}