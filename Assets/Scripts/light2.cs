using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light2 : MonoBehaviour
{
    // Start is called before the first frame update
    // Start is called before the first frame update
    public GameObject mainplot;
    public GameObject userinterface;
    UI useri;
    Plot smallplot;
    void Start()
    {
        useri = userinterface.GetComponent<UI>();
        smallplot = mainplot.GetComponent<Plot>();
    }

    // Update is called once per frame

    void Update()
    {
        if (smallplot.is_turn && useri.a1 == 2)
        {
            GameObject.Find("red1").transform.localScale = new Vector3(1, 1, 1);
        }
        else
            GameObject.Find("red1").transform.localScale = new Vector3(0, 0, 0);
    }
}
