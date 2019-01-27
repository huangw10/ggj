using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseover : MonoBehaviour
{
    // Start is called before the first frame update

    public bool is_over = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseOver()
    {
        is_over = true;
    }

    private void OnMouseExit()
    {
        is_over = false;
    }
}
