using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{

    public int a1;
    public int a2;
    public int a3;
    void Start()
    {
        a1 = 0;
        a2 = 0;
        a3 = 0;
    }

    // Start is called before the first frame update
    public void Option11()
    {
        a1 = 1;
    }
 

    public void Option12()
    {
        a1 = 2;
    }
    public void Option21()
    {
        a2 = 1;
    }
    public void Option22()
    {
        a2 = 2;
    }
    public void Option31()
    {
        a3 = 1;
    }
    public void Option32()
    {
        a3 = 2;
    }
    // Update is called once per frame
    void Update()
    {

       //Debug.Log(a1 + ": " + a2 + ": " + a3);
    }
}
