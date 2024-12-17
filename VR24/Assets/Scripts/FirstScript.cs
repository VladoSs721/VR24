using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class FirstScript : MonoBehaviour
{
    public int x = 0;
    public Text Mytxt;
    public GameObject click;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUptade()
    {
        x++;
        Mytxt.text = x.ToString();
    }
    public void ClickBut()
    {
       click.SetActive(!(click.activeSelf));
    }
}