using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task1 : MonoBehaviour
{
    public Animator anim;
    void OnMouseDown()
    {
        anim.SetTrigger("Start");
    }
}
