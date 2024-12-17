using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SecondScript : MonoBehaviour
{
    public int a = 10;
    public Text Mytxt;
    public int z, y, c;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
    }
    public void OnCollisionEnter(Collision collision)
    {
        a--;
        Mytxt.text = a.ToString();
    }
}
    